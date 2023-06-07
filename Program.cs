namespace Garage
{
    class Program
    {
        static void Main (string[] args)
        {
            Zero fxs = new Zero();
            Zero fx = new Zero();
            Tesla modelS = new Tesla();

            List<IElectric> electricVehicles = new List<IElectric>() {
                fx, fxs, modelS
            };

            Console.WriteLine("Electric Vehicles");
            foreach(IElectric ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            foreach(IElectric ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }

            foreach(IElectric ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }


            /***********************************************/

            Ram ram = new Ram ();
            Cessna cessna150 = new Cessna ();

            List<IGas> gasVehicles = new List<IGas>() {
                ram, cessna150
            };

            Console.WriteLine("Gas Vehicles");
            foreach(IGas gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }

            foreach(IGas gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
            }

            foreach(IGas gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }
        }
    }
}



// namespace Garage
// {
//     class Program
//     {
//         static void Main(string[] args) 
//         {
//             Zero fxs = new Zero();
//             Tesla modelS = new Tesla();
//             Cessna mx410 = new Cessna();
//             Ram cummins = new Ram();

//             fxs.Drive();
//             fxs.Turn();
//             fxs.Stop();
//             modelS.Drive();
//             modelS.Turn();
//             modelS.Stop();
//             mx410.Drive();
//             mx410.Turn();
//             mx410.Stop();
//             cummins.Drive();
//             cummins.Turn();
//             cummins.Stop();
//         }
//     }
// }