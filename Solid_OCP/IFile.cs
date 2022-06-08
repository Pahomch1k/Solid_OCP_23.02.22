using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Solid_OCP
{
    interface IFile
    {
        void Save(List<Person> a);
        void Load(List<Person> a);

    }
}
