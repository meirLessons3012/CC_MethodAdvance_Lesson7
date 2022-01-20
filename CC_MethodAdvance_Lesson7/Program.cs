using System;
using System.Text;

namespace CC_MethodAdvance_Lesson7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region virtual & override & new
            Person p1 = new LazyPerson("");
            LazyPerson p2 = new LazyPerson("");

            p1.GoToWork();//Method is marked as virtual so always son method will execute
            p2.GoToWork();//Method is marked as virtual so always son method will execute

            p1.Eat(); //Method is NOT marked as virtual so Person method will execute
            p2.Eat(); //Method is NOT marked but its call from full LazyPerson instance and son method will execute

            Person[] persons = new Person[2];
            Person pIndx0 = p1;
            Person pIndx1 = p2;

            Bird b1 = new Chicken();
            Bird b2 = new LazyTukon();
            Chicken b3 = new Chicken();
            LazyTukon b4 = new LazyTukon();

            #endregion

            #region this & base

            Vehicle v = new Vehicle();
            v.maxKM = 240;
            Console.WriteLine(v);
            PrivateCar pc = new PrivateCar();
            pc.maxKM = 180;
            pc.model = "mazda";
            Console.WriteLine(pc);

            #endregion

        }

        public static int MyMethod(int i, int ii)
        {
            Console.WriteLine("1");
            return 1;
        }

        public static string MyMethod(string ii, int i)
        {
            Console.WriteLine("2");
            return "2";
        }

        //Name

        public static string CreateRandomString(int length)
        {
            // creating a StringBuilder object()
            //Add using To System.Text;
            StringBuilder str_build = new StringBuilder();
            Random r = new Random();
            char letter;

            for (int i = 0; i < length; i++)
            {
                double flt = r.NextDouble();
                int shift = Convert.ToInt32(Math.Floor(25 * flt));
                letter = Convert.ToChar(shift + 65);
                str_build.Append(letter);
            }
            return str_build.ToString();
        }   
    }
}
