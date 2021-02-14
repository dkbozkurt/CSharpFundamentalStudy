//Dogukan Kaan Bozkurt
//      github.com/dkbozkurt

using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceVirtualAbstract_IX
{
    public class Bird : Animal      //Bird inheritance of animal
    {
        public int flySpeed;
        public int flyDistance;

        public string GetProperties()
        {
            string animalProperties = base.GetProperties();
            string birdProperties = string.Format("Fly Speed:{0} Fly Distance:{1}", flySpeed, flyDistance);
            return animalProperties + birdProperties;
        }

        public override void Move()         //abstract func. override ettik.
        {
            throw new NotImplementedException();
        }
    }
}
