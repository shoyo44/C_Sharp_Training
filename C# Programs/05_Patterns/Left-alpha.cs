public class Left_alpha
{
    public static void Main(String[] args)
    {
        char x=(char)('A'-1);
        for(int i = 1; i <= 4; i++)
        {
            for(int k = 1; k <=(i-1); k++)
            {
                Console.Write("  ");
            }
            for(int j = i; j <= 4; j++)
            {
                x=(char)(x+1);
                Console.Write(x+" ");
            }
            
            Console.WriteLine();
        }
    }
}