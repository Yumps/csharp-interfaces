namespace csharp_Interface_exercises
{
    public class Mouse : IDigging, ISwimming, IWalking
    {   
        public int MaximumDepth {get;} = 5;
            public void Run()
        {
            System.Console.WriteLine("Animal is now running");
        }

        public void Walk()
        {
            System.Console.WriteLine("Animal is now walking");
        }

        public void Swim()
        {
            System.Console.WriteLine("Animal is now swimming");
        }

        public void Dig()
        {
            System.Console.WriteLine("Animal is digging");
        }
    }
}