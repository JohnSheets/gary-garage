namespace Garage
{
    class Program
    {
        static void Main(string[] args) 
        {
            Zero fxs = new Zero();
            Tesla modelS = new Tesla();
            Cessna mx410 = new Cessna();
            Ram cummins = new Ram();

            fxs.Drive();
            fxs.Turn();
            fxs.Stop();
            modelS.Drive();
            modelS.Turn();
            modelS.Stop();
            mx410.Drive();
            mx410.Turn();
            mx410.Stop();
            cummins.Drive();
            cummins.Turn();
            cummins.Stop();
        }
    }
}