using A_Simiple_Task_Manger;
//using static A_Simiple_Task_Manger.TasksManager;

namespace A_Simiple_Task_Manager;
class Program : Threads
{
    static void Main(string[] args)
    {
        MenuCommands();
    }

    private static void MenuCommands()
    {
        string Menu = "Enter: \n 1: To view all Running Tasks \n 2: To Start any task\n 3: For More Options(Threads) \n 0: To Exit Console";
       start: Console.Write($"******************************************\n{Menu}\n*******************************************\n ==> ");
        string? input = Console.ReadLine();

        switch (input)
        {
            case "1":
                Console.Clear();
                ViewProcesses();
                break;
            case "2":
                Console.Clear();
                StartProcess();
                break;
            case "3":
                Console.Clear();
                ThreadsOptions();
                break;
            case "0":
                Environment.Exit(0);
                break;
            default:
                Console.Clear();
                Console.WriteLine($"{input} is an invalid Option, please Select a valid option");
                goto start;
        }

    }

    public static void OptionKeys(){
        string Options = "Enter:\n0: To Return to Main Menu \n 1: Kill a Process by its Id Number \n 2: To start a new process \n 3: Check Theard of a process by its Id";
      start:  Console.Write($"***************************************\n{Options}\n************************************\n ==>  ");
        string? input2 = Console.ReadLine();
        switch (input2) {
            case "0":
                Console.Clear();
                MenuCommands();
                break;
            case "1":
                Console.Clear();
                KillProcessById();
                break;
            case "2":
                Console.Clear();
                StartProcess();
                break;
            case "3":
                Console.Clear();
                CheckingThread();
                break;
            default:
                Console.Clear();
                Console.WriteLine($"{input2} is an invalid option");
                goto start;
	}
    }
    public static void ThreadsOptions() 
    {
        string Options = "Enter:\n 0: To Return to Main Menu\n 1: Create Custom Thread\n 2: Check if a thread is Alive\n 3: Check if Thread is Background ";
       Start: Console.WriteLine(Options);
        string? Input = Console.ReadLine();

        switch (Input)   
	    {
            case "0":
                Console.Clear();
                MenuCommands();
                break;
            case "1":
                Console.Clear();
                CreateNewThread();
                break;
            case "2":
                Console.Clear();
                IsAlive();
                break;
            case "3":
                Console.Clear();
                IsBackGround();
                break;
            default:
                Console.Clear();
                Console.WriteLine($"{Input} is not a Valid Option");
                goto Start;
	    }
    }
}

