/*Number Guessing Game
Create a number guessing game.
•	Generate a random number between 1 and 100.
•	Allow the player to guess the number.
•	Display whether the guess is too high or too low.
•	Limit the number of attempts.
•	Assign a score based on the attempts used.
•	Ask whether the player wants to play another round.
*/
using System;
public class Number_Guessing_Game
{
    public static void Main(String[] args)
    {
        string play_again="yes";
        while(play_again=="yes"){
        Console.WriteLine("Welcome to Number Guessing Game");
        Console.WriteLine("The Random number is generated successfully");
        int random_number=Random.Shared.Next(1,101);
        Console.Write("Enter your guessing number : ");
        int guessing_number=Convert.ToInt32(Console.ReadLine());
        int attempt=0;
        while(guessing_number!=random_number || attempt<20)
        {
            if(guessing_number==random_number){
                Console.WriteLine("Congratulations you guessed the correct number "+random_number);
                int score=100-(attempt*5);
                Console.WriteLine("Your score is : "+score+" with the total attempts "+(attempt++));
                break;
            }
            else if (guessing_number < random_number)
            {
                Console.WriteLine("Your guessed number "+guessing_number+" is lessser than the random number");
                Console.Write("Enter your updated guessing number : ");
                guessing_number=Convert.ToInt32(Console.ReadLine());
                attempt++;
            }
            else if (guessing_number > random_number)
            {
                Console.WriteLine("Your guessed number "+guessing_number+"  is greater than the random number");
                Console.Write("Enter your updated guessing number : ");
                guessing_number=Convert.ToInt32(Console.ReadLine());
                attempt++;
            }
            else if(attempt>20)
            {
                Console.WriteLine("You have reached the maximum limit of "+attempt);
            }
        }
        Console.Write("Do you want to play again : ");
        play_again=Console.ReadLine();
        }
    }
}