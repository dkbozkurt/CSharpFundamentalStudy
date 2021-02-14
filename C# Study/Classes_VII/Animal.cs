using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_VII
{
    public class Animal
    {
        public Animal()     //Constructor
        {
            name = "Not defined";
            weight = -1;
            gender = -1;
        }
        public int weight;
        public string name;
        public int gender;
        
        public string GetAnimalProperties()
        {
            //return "Weight: " + weight + "Name: " + name + "Gender: " + gender;       //Bunun yerine alttaki kullanilabilir.
            return string.Format("Weight: {0} Name: {1} Gender: {2}",weight,name,gender);
        }
    }
}
