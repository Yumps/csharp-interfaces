namespace csharp_Interface_exercises
{
    public class BettaFish : ISwimming
    {
        public int MaximumDepth { get; }= 25;
        public void Swim()
        {
            System.Console.WriteLine("Animal is now swimming");
        }
    }
}