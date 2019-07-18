namespace csharp_Interface_exercises
{
    public class Gerbil : IWalking, IDigging 
    {
        public void Dig()
        {
            System.Console.WriteLine("Animal is Digging");
        }

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