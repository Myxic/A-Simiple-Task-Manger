using System;
using System.Diagnostics;
using A_Simiple_Task_Manager;

namespace A_Simiple_Task_Manger
{
    class TasksManager 
    {
        protected static void ViewProcesses() 
	    {
            var runningProcesses = from proc in Process.GetProcesses()
                                   where proc.ProcessName != ""
                                   orderby proc.ProcessName
                                   select proc;

            foreach (var processes in runningProcesses) {
                string info = $"Process ID: {processes.Id}, Process Name: {processes.ProcessName}";
                Console.WriteLine(info);
	        }
            Program.OptionKeys();
	    }
        protected static void KillProcess()
        {

        }
        protected static void KillProcessById()
	    {
            var runningProcesses = from proc in Process.GetProcesses()
                                   select proc.Id;

        Start: Console.WriteLine("Enter Process Id ");
            var ID = Console.ReadLine();
            try
            {
                int Id = Convert.ToInt32(ID);
                if (runningProcesses.Contains(Id)) 
		        {
                    Console.WriteLine(Process.GetProcessById(Id));
                    Process.GetProcessById(Id).Kill();
                }
                else    
		        {
                    Console.Clear();
                    Console.WriteLine($"{Id} is an invalid Id");
                    ViewProcesses();
		        }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
	       
	    }
        protected static void StartProcess() 
	    {
            start: Console.Write("Enter the directory of the process you want to start or [0] to return to Main Menu\n ==> ");

            var directory = Console.ReadLine();
            switch (directory)
	        {
                case "0":
                    Console.Clear();
                    Program.MenuCommands();
                    break;
                default:
                    try
                    {
                        Process proc = Process.Start($"{directory}");
                    }
                    catch (Exception ex)
                    {
                        Console.Clear();
                        Console.WriteLine(ex.Message);
                        goto start;
                    }
                    Program.OptionKeys();
                    break;

                    }
           
	    }
    }
}