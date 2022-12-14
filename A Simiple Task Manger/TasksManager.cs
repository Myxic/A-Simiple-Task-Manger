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

            Console.WriteLine("Enter Process Id ");
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
            }
	       
	    }
        protected static void StartProcess() 
	    { 

	    }
    }
}