using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC_MethodAdvance_Lesson7
{
    public class Bird
    {
        public virtual void Shower()
        {
            Console.WriteLine("fun from Bird");
        }

        public void Fly()
        {
            Console.WriteLine("yu huuu from Bird");
        }
    }

    public class Chicken : Bird
    {
        public override void Shower()
        {
            Console.WriteLine("fun from Chicken");
        }

        public void Fly()
        {
            Console.WriteLine("yu huuu  from Chicken");
        }
    }

    public class LazyTukon : Bird
    {
        public virtual void Shower()
        {
            Console.WriteLine("fun from LazyTukon");
        }

        public void Fly()
        {
            Console.WriteLine("yu huuu  from LazyTukon");
        }
    }
}
