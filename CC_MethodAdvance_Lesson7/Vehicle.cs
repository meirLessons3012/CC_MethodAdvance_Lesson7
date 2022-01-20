using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC_MethodAdvance_Lesson7
{
    internal class Vehicle
    {
        public int maxKM;

        public string GetYourYear()
        {
            return "2022";
        }
        public override string ToString()
        {
            return $"MAX KM: {maxKM}.";
        }
    }

    internal class PrivateCar : Vehicle
    {
        public string model;

        public PrivateCar()
        {
            model = base.GetYourYear();
        }

        public string GetYourYear()
        {
            return "2021";
        }

        public override string ToString()
        {
            return base.ToString() + $" model: {model}";
        }

    }

}
