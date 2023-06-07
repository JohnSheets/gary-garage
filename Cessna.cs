namespace Garage
{
    public class Cessna : Vehicle, IGas
    {
        public double FuelCapacity { get; set; }
        public int CurrentTankPercentage {get; set;} = 50;

        public void RefuelTank()
        {
            // method definition omitted
            CurrentTankPercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna flys by you. Zoooooom!");
        }
        public override void Turn()
        {
            Console.WriteLine($"The Cessna banked right");
        }
        public override void Stop()
        {
            Console.WriteLine("The Cessna rolls down the runway after landing.");
            Console.WriteLine("------------");
        }


    }
}