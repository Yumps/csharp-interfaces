namespace csharp_Interface_exercises
{
    public class Finch : IFlying, IWalking
    {
        public void Fly()
        {
            System.Console.WriteLine("Animal is Flying");
        }

        public void Run()
        {
            System.Console.WriteLine("Animal is Running");
        }

        public void Walk()
        {
            System.Console.WriteLine("Animal is Walking");
        }
    }
}