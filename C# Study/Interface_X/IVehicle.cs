//Dogukan Kaan Bozkurt
//      github.com/dkbozkurt

using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_X
{
    public interface IVehicle
    {
        //INTERFACE summarize: ( OZET CLASSLAR )
        //Özet sinif tanimlanir ve icine kullanilacak funclar yazilir.bu ornekte IVehicle ornek sinif.
        //Bu siniftan turuyen tum sunuflar IVehiclenin tum methodlarini icermek&doldurmak zorundadir.
        void Run();
        void Stop();
        void Move(int speed);
        void Brake();
        int GasLevel();

    }
}
