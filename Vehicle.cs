namespace Garage;

    public class Vehicle
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine("Vrooom!");
        }
        public virtual void Turn()
        {
            Console.WriteLine("");
        }
        public virtual void Stop()
        {
            Console.WriteLine("");
        }
    }
            public interface IElectric 
            {
                void ChargeBattery();
                int CurrentChargePercentage { get; }
            }
            public interface IGas 
            {
                void RefuelTank();
                int CurrentTankPercentage { get; }
            }
