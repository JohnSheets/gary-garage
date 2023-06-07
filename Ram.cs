namespace Garage
{
    public class Ram  : Vehicle
    {
        public double FuelCapacity { get; set; }
        public void RefuelTank()
        {
            // method definition omitted
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