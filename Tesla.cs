
namespace Garage
{
    public class Tesla : Vehicle, IElectric
    {
        public double BatteryKWh { get; set; }
        public int CurrentChargePercentage { get; set;} = 70;

        public void ChargeBattery()
        {
            // method definition omitted
            CurrentChargePercentage = 100;
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