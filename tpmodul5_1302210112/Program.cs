﻿internal class Program
{
    public class HaloGeneric
    {
         public static void sapaUser<T>(T inputuser){
            Console.WriteLine("Hallo user " + inputuser);
        }
    }
    private static void Main(string[] args)
    {
        HaloGeneric.sapaUser<string>("Alfian");
    }
}