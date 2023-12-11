using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labb3
{
    public class Person
    {
        // Egenskaper
        public Gender TheGender { get; private set; }
        public Hair TheHair { get; set; }
        public DateTime Birthday { get; set; }

        public string Eyecolor { get; set; }

        //Konstrukor
        public Person (Gender gender, Hair hair, String eyecolor, DateTime birthday)
        {
            TheGender=gender;
            TheHair=hair;
            Eyecolor=eyecolor;
            Birthday=birthday;
        }

        public override string ToString()
        {
            return $"Gender: {TheGender}" +
                $"\nHair : {TheHair.Hairlength} {TheHair.Haircolor}" +
                $"\nEyecolor : {Eyecolor}" +
                $"\nBirthday : {Birthday:yyyy/MM/dd}";
        }
    }


}
