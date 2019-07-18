namespace csharp_Interface_exercises
{
    public class SeaTurtle : IWalking, ISwimming
    {
        public int MaximumDepth { get; } = 100;

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
    }
}