using System;
using System.Collections.Generic;
using System.Text;

namespace StaticUtility
{
    public class Utility
    {
        //all static methods
        
        public static string EnterP1(string question)
        {
            Console.WriteLine(question);
            string name = Console.ReadLine() ??"";
            return name;
        }
        
        public static void RecieveP1(string name)
        {
            Console.WriteLine($"Welcome Player 1: {name.ToUpper()}"); 
        }
        //RollStats(player1);
        public static void RollStats(string name)
        {
            int health = Random.Shared.Next(1, 100);
            int attack = Random.Shared.Next(1, 100);
            int playerLevel = Random.Shared.Next(1, 20);

            Console.WriteLine($"Here are your player Stats:\n   Health: {health}\n   Attack: {attack}\n   Level: {playerLevel}\n\n Thank you for joining the Game!");
        }
    }
}
