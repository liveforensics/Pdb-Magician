// force github commit
namespace Pdb_Magician
{
    public partial class PdbMagician
    {
        class Enumerator
        {
            public string name;
            public uint id;

            public SubEnumerator[] values;
        }

        class SubEnumerator
        {
            public string name;
            public dynamic value;
            public uint id;
        }
    }
}
