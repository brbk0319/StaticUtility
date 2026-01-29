using StaticUtility;
namespace StaticsOnly
{
    class Program
    {
        static void Main()
        {
            string player1 = Utility.EnterP1("What's your name?");
            Utility.RecieveP1(player1);
            Utility.RollStats(player1);
        }
    }
}