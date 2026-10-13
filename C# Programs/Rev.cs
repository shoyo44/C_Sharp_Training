using System;
public class Rev{
    public static void Main(String[] args){
        for(int i=10;i>=1;i--) Console.Write(i+((i>1)?(" "):("")));
    }
}