namespace Garage
{
    public class Zero  : Vehicle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero Zips past you. Zzziiiiiiippp!");
        }
        public override void Turn()
        {
            Console.WriteLine($"The Zero slid right.");
        }
        public override void Stop()
        {
            Console.WriteLine("The Zero screeches to a hault.");
            Console.WriteLine("------------");
        }
    }
}