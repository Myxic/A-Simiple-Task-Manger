﻿namespace A_Simiple_Task_Manager;
class Program
{
    static void Main(string[] args)
    {
        OptionKeys();
    }

    private static void MenuCommands()
    {
        string Menu = "Enter: \n 1: To view all Running Tasks \n 2: To Create a custom process and kill it \n 3: Check if a thread isLive or Backgroun \n 4: To Should be able to start any task \n 5: To Exit Console";
       start: Console.Write($"***************************************\n{Menu}\n*****************************************\n ==> ");
        string? input = Console.ReadLine();

        switch (input)
        {
            case "1":
                break;
            case "2":
                break;
            case "3":
                break;
            case "4":
                break;
            case "5":
                Environment.Exit(5);
                break;
            default:
                Console.Clear();
                Console.WriteLine($"{input} is an invalid Option, please Select a valid option");
                goto start;
        }

    }

    public static void OptionKeys(){
        string Options = "Enter:\n0: To Return to Main Menu ";
      start:  Console.Write($"***************************************\n{Options}\n************************************\n ==>  ");
        string? input2 = Console.ReadLine();
        switch (input2) {
            case "0":
                Console.Clear();
                MenuCommands();
                break;
            default:
                Console.Clear();
                Console.WriteLine($"{input2} is an invalid option");
                goto start;
	}
    }
}

