namespace GhostRider.Tournament.Management.Test.CoContraVariance
{
    public class CoContravariancePoc
    {
        public void Tewst()
        {
            IGarage<IVehicle> garage = new CustomGarage<IVehicle>();

            ((IGarage<ISportCar>) garage).Leave();

            ((IPorsche)garage.Leave()).PorscheSpeedUp(); // TO SIE POSKLADA
        }
    }

    interface IGarage<out TVehicle> where TVehicle : IVehicle
    {
        TVehicle Leave();
    }

    interface IVehicle
    {
        void SpeedUp();
    }

    interface ISportCar : IVehicle { }

    interface IPorsche : ISportCar
    {
        void PorscheSpeedUp();
    }

    class CustomGarage<TVehicle> : IGarage<TVehicle> where TVehicle : IVehicle
    {
        public TVehicle Leave()
        {
            throw new System.NotImplementedException();
        }
    }

    interface IOrganism
    {
    }

    interface IAnimal : IOrganism
    {
        
 
    }

    interface IElephant : IAnimal
    {
        void Try();
    }

    interface IEnvironment<in TOrganism> where TOrganism : IOrganism
    {
         
    }

    interface IOcean<in TOrganism> : IEnvironment<TOrganism> where TOrganism : IOrganism { }

    interface IPacific<in TOrganism> : IOcean<TOrganism> where TOrganism : IOrganism
    {
        void AmIPacificOcean(TOrganism org);
    }

    class Elephant : IElephant {
        public void Try()
        {
            throw new System.NotImplementedException();
        }
    }
    class Pacific<TOrganism> : IPacific<TOrganism> where TOrganism : IOrganism {
        public void AmIPacificOcean(TOrganism org)
        {
            throw new System.NotImplementedException();
        }
    }

    class Organism : IOrganism { }

    public class Test
    {
        public void Whatever()
        {
            IPacific<IElephant> test = new Pacific<IOrganism>();

            //test.AmIPacificOcean(new Organism());
        }
    }
}