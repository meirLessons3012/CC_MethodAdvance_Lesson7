using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC_MethodAdvance_Lesson7
{
    public class Person
    {
        public string name;

        public Person()
        {

        }
        public Person(string name)
        {   
            this.name = name;
        }
        public virtual void Eat()
        {
            Console.WriteLine("eating...");
        }

        public virtual void GoToWork()
        {
            Console.WriteLine("food");
            Console.WriteLine("bla bla");
            Console.WriteLine("train");
        }
    }

    public class LazyPerson : Person
    {
        public string lastName;
        public override void GoToWork()
        {

            Console.WriteLine("open comp...");
        }
        public override void Eat()
        {
            Console.WriteLine("Eating 2...");
        }
        public LazyPerson(string name) : base(name)
        {
            Console.WriteLine(name);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }

    public class Student : Person
    {
        public new void Eat()
        {
            Console.WriteLine("Eating 2...");
        }
    }
}
