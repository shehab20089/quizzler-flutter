using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Humman h1 = new Humman();
            h1.printData();
        }
    }
    class Humman
    {
        int age;
        string name;

        void printData()
        {
            System.Console.WriteLine($"your name is {this.name} and your age is {this.age} ");
        }

    }



}