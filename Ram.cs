namespace Garage
{
    public class Ram  : Vehicle, IGas
    {
        public double FuelCapacity { get; set; }
        public int CurrentTankPercentage { get; set;} = 20;
        public void RefuelTank()
        {
            // method definition omitted
            CurrentTankPercentage = 100;
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram flashes past you. Rrrruummbbble!");
        }
         public override void Turn()
        {
            Console.WriteLine($"The Ram Turned right.");
        }
        public override void Stop()
        {
            Console.WriteLine("The Ram came to a stop.");
            Console.WriteLine("------------");
        }

    }
}