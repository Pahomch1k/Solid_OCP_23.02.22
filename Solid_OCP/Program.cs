using System;

namespace Solid_OCP
{

   

    class Program
    {
        public static void Client(IFile f)
        {
            Conteiner a = new Conteiner(2);
            a.SetFile(f);
            a.SaveInFile();
            a.LoadInFile();
        }

        static void Main(string[] args)
        {
            IFile f = new TextFile();
            Client(f);
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person() : this("Oleg", 0) { }

        public Person(string n, int a)
        {
            Name = n;
            Age = a;
        }

        public override string ToString()
        {
            return $"{Name}, {Age}";
        }
    }

}
