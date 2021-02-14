//Dogukan Kaan Bozkurt
//      github.com/dkbozkurt

using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceVirtualAbstract_IX
{
    public class Cat : Animal       //Cat inheritance of animal
    {
        public int runSpeed;
        public string sound;

        public string GetProperties()
        {
            string animalProperties = base.GetProperties();     //base. using. !!!      //Turedigi classin . dan sonraki functionun cagir.!!!
            string catProperties = string.Format("Run Speed:{0} Sound:{1}", runSpeed, sound);
            return animalProperties + catProperties;
        }

        public override void Move()         //abstract func. override ettik.
        {
            throw new NotImplementedException();
        }

        public override void Sleep()        //virtual func. override ettik.
        {
            energy+=2;
        }
    }
}
