using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
// force github commit

namespace Pdb_Magician
{
    public partial class PdbMagician
    {
        private bool FetchSymbolFile()
        {
            string downloadURL = _symbolServer + "/" + _filename + "/" + _guidAge + "/" + _filename;
            bool bTargetIsCompressed = false;

            try
            {
                // test to see if the file is there
                HttpWebRequest webReq = (HttpWebRequest)WebRequest.Create(downloadURL);
                webReq.UserAgent = _userAgent;
                webReq.Method = "HEAD";
                HttpWebResponse webResp = (HttpWebResponse)webReq.GetResponseNoException();
                if (webResp.StatusCode == HttpStatusCode.NotFound)
                {
                    // wasn't there, so try the compressed version
                    downloadURL = ProbeWithUnderscore(downloadURL);
                    webReq = (HttpWebRequest)WebRequest.Create(downloadURL);
                    webReq.UserAgent = _userAgent;
                    webReq.Method = "HEAD";
                    webResp = (HttpWebResponse)webReq.GetResponseNoException();
                    if (webResp.StatusCode == HttpStatusCode.OK)
                    {
                        bTargetIsCompressed = true;
                    }
                    else if (webResp.StatusCode == HttpStatusCode.NotFound)
                    {
                        downloadURL = _symbolServer + "/" + _filename + "/" + _guidAge + "/" + _filename;
                        downloadURL = ProbeWithFilePointer(downloadURL);
                        webReq = (HttpWebRequest)System.Net.WebRequest.Create(downloadURL);
                        webReq.UserAgent = _userAgent;
                        webResp = (HttpWebResponse)webReq.GetResponseNoException();
                        if (webResp.StatusCode != HttpStatusCode.OK)
                        {
                            _errorList.Add("Couldn't Find Requested File on the Symbol Server");
                            webResp.Close();
                            return false;
                        }
                    }
                    else
                    {
                        _errorList.Add("Couldn't Find Requested File on the Symbol Server");
                        webResp.Close();
                        return false;
                    }
                }
                string realTargetName = _filename;
                if (bTargetIsCompressed)
                {
                    realTargetName = ProbeWithUnderscore(_filename);
                }
                string destinationFolder = Path.Combine(_cacheFolder, _guidAge);
                DirectoryInfo di = new DirectoryInfo(destinationFolder);
                if(!di.Exists)
                {
                    di.Create();
                    di = new DirectoryInfo(destinationFolder);
                    if (!di.Exists)
                    {
                        _errorList.Add("Failed to create destination folder: " + destinationFolder);
                        return false;
                    }
                }
                string filePath = Path.Combine(destinationFolder, realTargetName);
                FileStream writer = new FileStream(filePath, System.IO.FileMode.Create);
                webReq = (HttpWebRequest)WebRequest.Create(downloadURL);
                webReq.UserAgent = _userAgent;
                webReq.Method = "GET";
                webResp = (HttpWebResponse)webReq.GetResponseNoException();
                long contentSize = webResp.ContentLength;
                long blockSize = 0x1000;
                Stream dataStream = webResp.GetResponseStream();
                BinaryReader reader = new BinaryReader(dataStream);
                while (contentSize > 0)
                {
                    if (contentSize < blockSize)
                        blockSize = contentSize;
                    byte[] buffer = reader.ReadBytes((int)blockSize);
                    writer.Write(buffer, 0, (int)blockSize);
                    contentSize -= blockSize;
                }
                reader.Close();
                writer.Close();
                webResp.Close();
                if (bTargetIsCompressed)
                {
                    return DecompressArchive(filePath);
                }
            }
            catch (Exception ex)
            {
                _errorList.Add(ex.Message);
                return false;

            }
            return true;
        }
        private bool DecompressArchive(string filePath)
        {
            FileInfo fi = new FileInfo(filePath);
            string newFilePath = RemoveUnderscore(fi.FullName);
            string args = string.Format("expand {0} {1}", "\"" + filePath + "\"", "\"" + newFilePath + "\"");

            Match m = Regex.Match(args, "^\\s*\"(.*?)\"\\s*(.*)");
            if (!m.Success)
                m = Regex.Match(args, @"\s*(\S*)\s*(.*)");    // thing before first space is command

            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo(m.Groups[1].Value, m.Groups[2].Value);

            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;

            startInfo.UseShellExecute = false;
            startInfo.Verb = "runas";
            startInfo.CreateNoWindow = true;
            process.StartInfo = startInfo;

            try
            {
                var started = process.Start();
                if (started)
                {
                    process.WaitForExit(600000);
                    File.Delete(filePath);
                }
                return true;
            }
            catch (Exception ex)
            {
                _errorList.Add(ex.Message);
                return false;
            }
        }
        private string ProbeWithUnderscore(string path)
        {
            path = path.Remove(path.Length - 1);
            path = path.Insert(path.Length, "_");
            return path;
        }
        private string RemoveUnderscore(string path)
        {
            path = path.Remove(path.Length - 1);
            path = path.Insert(path.Length, "b");
            return path;
        }
        private string ProbeWithFilePointer(string path)
        {
            int position = path.LastIndexOf('/');
            path = path.Remove(position, (path.Length - position));
            path = path.Insert(path.Length, "/file.ptr");
            return path;
        }
    }
}
