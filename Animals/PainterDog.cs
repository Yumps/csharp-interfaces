namespace csharp_Interface_exercises
{
    public class PaintedDog : IWalking
    {
        public void Run()
        {
            System.Console.WriteLine("The animal is now running");
        }

        public void Walk()
        {
            System.Console.WriteLine("The animal is now walking");
        }
    }
}