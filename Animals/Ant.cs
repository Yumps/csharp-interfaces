namespace csharp_Interface_exercises
{
    public class Ant: IWalking, IDigging
    {
        public void Walk()
        {
            System.Console.WriteLine("Animal is now walking");
        }

        public void Run()
        {
            System.Console.WriteLine("Animal is now running");
        }

        public void Dig()
        {
            System.Console.WriteLine("Animal is digging");
        }
    }
}