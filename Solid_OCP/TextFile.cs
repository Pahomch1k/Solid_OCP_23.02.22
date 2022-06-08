using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Solid_OCP
{
    class TextFile: IFile
    {
        public void Save(List<Person> a)
        {
            WriteLine("SaveInFile");
        }

        public void Load(List<Person> a)
        {
            WriteLine("LoadInFile");
        }
    }
}
