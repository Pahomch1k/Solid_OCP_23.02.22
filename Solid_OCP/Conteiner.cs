using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Solid_OCP
{
    
    class Conteiner
    {
        IFile f;
        List<Person> group;

        public List<Person> Group
        {
            get
            {
                return group;
            }
       
        }

        public Conteiner()
        { }

        public Conteiner(int a)
        {
            group = new List<Person>(a); 
        }

        public void SetFile(IFile b)
        {
            f = b;
        }

        public void SaveInFile()
        {
            f.Save(Group);
        }

        public void LoadInFile()
        {
            f.Load(Group);
        }
    }
}
