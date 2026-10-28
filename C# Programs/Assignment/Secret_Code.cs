/*Generate a secret 4-digit code.
•	Allow the player 10 attempts to crack it.
•	Tell the player how many digits are correct and in the correct position.
•	Reduce the remaining attempts after each guess.
•	Award a score based on how quickly the code is cracked.
•	Ask whether the player wants to try a new code.*/
using System;
using System.Numerics;
public class Secret_Code
{
    public static void Main(String[] args)
    {
        int attempt=10;
        int original_code=Random.Shared.Next(1000,10000);
        Console.Write("Enter your guessing code : ");
        int guessed_code=Convert.ToInt32(Console.ReadLine());
        while (attempt <= 1)
        {
            string correct_code=original_code.ToString();
            string guessed_code1=guessed_code.ToString();

            if (correct_code == guessed_code1)
            {
                Console.WriteLine("Congratulations! You found the correct code");
                int points=attempt*10;
                Console.WriteLine("The total points earned : "+points);
                break;
            }
            

        }



    }
}
