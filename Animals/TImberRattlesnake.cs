namespace csharp_Interface_exercises
{
    public class TimberRattlesnake : IWalking
    {
        public void Run()
        {
            System.Console.WriteLine("Animal is now running");
        }

        public void Walk()
        {
            System.Console.WriteLine("Animal is now walking");
        }
    }
}