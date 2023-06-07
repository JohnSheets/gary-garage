namespace Garage
{
    public class Cessna : Vehicle
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
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