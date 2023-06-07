namespace Garage
{
    public class Tesla : Vehicle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla flashes past you. Vroooooom!");
        }
        public override void Turn()
        {
            Console.WriteLine($"The Tesla qickly turnned right.");
        }
        public override void Stop()
        {
            Console.WriteLine("The Tesla stops.");
            Console.WriteLine("------------");
        }
    }
}