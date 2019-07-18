namespace csharp_Interface_exercises
{
    public class Parakeet : IWalking, IFlying
    {
            public void Run()
        {
            System.Console.WriteLine("Animal is now running");
        }

        public void Walk()
        {
            System.Console.WriteLine("Animal is now walking");
        }

        public void Fly(){
            System.Console.WriteLine("Animal is flying");
        }
    }
}