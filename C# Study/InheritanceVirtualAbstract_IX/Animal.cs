//Dogukan Kaan Bozkurt
//      github.com/dkbozkurt

using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceVirtualAbstract_IX
{

    //ABSTRACT

    public abstract class Animal        //abstract kelime anlami olarak soyut. 
                                        //Animaldan turuyen diger classlarda , abstract classta bulunan abstract func(Move) olamk zorunda. 
    {
        public int w;
        public int l;
        public string n;
        public int energy=0;

        public string GetProperties()
        {
            return String.Format("Name:{0} Lenght:{1} Weight:{2} ", n, l, w);
        }
        public abstract void Move();        //abstract func !!! Icleri bos olmak zorunda. Bundan turuyen classlar tarafından doldurulur.
                                            //Yapilma sebebi move her hayvan turune gore degisiklik gosterebilir.

        public virtual void Sleep()         //virtual func !!! Isteyen alt classta bunu turetsin isteyen turetmesin istiyorsak virtual kullanilir.
        {
            energy += 5;
        }
    }
}
