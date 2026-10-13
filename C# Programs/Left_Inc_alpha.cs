public class Left_Inc_alpha
{
    public static void Main(String[] args)
    {
        
        for(int i = 1; i <= 4; i++)
        {
            char x=(char)('A'-2);
            for(int k = 1; k <=(i-1); k++)
            {
                Console.Write("  ");
            }
            for(int j = i; j <= 4; j++)
            {
               
                x=(char)(x+2);
                Console.Write(x+" ");
            }
            
            Console.WriteLine();
        }
    }
}