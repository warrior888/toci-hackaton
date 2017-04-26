using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GhostRider.Tournament.Management.Test.CoContraVariance
{
    [TestClass]
    public class VariancesPocTest
    {
        [TestMethod]
        public void GrandeFail()
        {
            Tst test = new Tst();

            test.Whatever();
        }
    }

    

    internal interface IVehicle { }

    interface ICar : IVehicle { }

    interface ISportCar : ICar {}

    interface IDieselSportCar : ISportCar { }

    interface IPorscheCayene : IDieselSportCar {}

    internal class OurCovariantGenericInterface<TVehicle> : IOurCovariantGenericInterface<TVehicle>
        where TVehicle : IVehicle
    {
    }

    class OurContravariantInterface<TVehicle> : IOurContravariantInterface<TVehicle> where TVehicle : PorscheCayene
    {
        public void Add(TVehicle vehicle)
        {
            //Vehicle.Add( (new DieselSportCar()) => Entities. );
            //Vehicle.Add(vehicle);
            //((PorscheCayene)vehicle).ThisWillFail();
        }
    }


    class Vehicle : IVehicle { }

    class Car : Vehicle, ICar { }

    class SportCar : Car, ISportCar { }

    class DieselSportCar : SportCar, IDieselSportCar {  }

    class PorscheCayene : DieselSportCar, IPorscheCayene
    {
        public void ThisWillFail()
        {
            
        }
    }

    class PorscheCayeneTurbo : PorscheCayene { }

    internal interface IOurCovariantGenericInterface<out TVehicle> where TVehicle : IVehicle
    {
    }

    interface IOurContravariantInterface<in TVehilce> where TVehilce : PorscheCayene
    {
        void Add(TVehilce vehicle);
    }

    class Tst
    {
        public void Whatever()
        {
            List<IVehicle> vehicles = new List<IVehicle>
            {
                
            };// typ deklaracji jest ogolniejszy, typ powolania bardzierj szczegolowy

            IOurCovariantGenericInterface<IVehicle> test = new OurCovariantGenericInterface<PorscheCayene>();
            IOurContravariantInterface<PorscheCayeneTurbo> test2 = new OurContravariantInterface<PorscheCayene>();

            //test2.Add(new DieselSportCar());

            //test2.Veh = new DieselSportCar();

            //((OurContravariantInterface<PorscheCayene>)test2).Vehicle2.ThisWillFail();

            //test2.TestFail(((PorscheCayene)new DieselSportCar()));

            //((PorscheCayene)((WillThisFail)test2).Vehicle).ThisWillFail();

            //test2.Add(new DieselSportCar());
        }
    }
}