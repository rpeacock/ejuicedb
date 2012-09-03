using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBClassLib
{
    public class Class1
    {
        //this is a comment
    }

    

   public class Juice
    {
       
        public static char Delimit = ';';
        public string Name { get; set; }
        public double Amount { get; set; }
        public string Concentration { get; set; }

        public Juice(string name, string amount, string concentration)
        {
            this.Name = name;
            this.Amount = Convert.ToDouble(amount);
            this.Concentration = concentration;
        }

        public static Juice ParseJuice(string line)
        {
            string[] jArray = line.Split(Juice.Delimit);
            if (jArray.Length < 3)
            {
                throw new Exception("Not enough data in file");
            }
            return new Juice(jArray[0], jArray[1], jArray[2]);
        }
    }

   public class Flavor : Juice
   {
       public string Name { get; set; }
       public double Amount { get; set; }
   }
}
