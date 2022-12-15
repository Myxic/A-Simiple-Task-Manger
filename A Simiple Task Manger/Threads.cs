﻿using System;
using System.Diagnostics;
using A_Simiple_Task_Manager;


namespace A_Simiple_Task_Manger
{
    internal class Threads : TasksManager
    {
        public Threads()
        {
        }
        protected static void CheckingThread()
        {
            var runningProcesses = from proc in Process.GetProcesses()
                                   select proc.Id;
        Start: Console.WriteLine("Enter Id number of the Process you want to check");
            var ID = Console.ReadLine();

            try
            {

                int Id = Convert.ToInt32(ID);
                if (runningProcesses.Contains(Id))
                {
                    Process proc = Process.GetProcessById(Id);
                    Console.WriteLine($"Here is the thread for {proc.ProcessName}");
                    ProcessThreadCollection TheThread = proc.Threads;

                    foreach (ProcessThread pt in TheThread)
                    {
                        string info = $"Thread ID for {proc.ProcessName} is : {pt.Id} \t Start Time: {pt.StartTime.ToShortTimeString()}\tPriority: {pt.PriorityLevel}";
                        Console.WriteLine(info);
                        Program.OptionKeys();
                    }
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

        protected static void CreateNewThread()
        {
            //Thread thr = Thread.GetCurrentProcessorId();

        }
        protected static void IsAlive() 
	    {
            var ID = Console.ReadLine();
            try
            {
                int Id = Convert.ToInt32(ID);
                Thread thr = Thread.CurrentThread;

                Console.WriteLine($"Is this Thread Alive? : {thr.IsAlive}");
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine(ex.Message);
                ViewProcesses();
            }
            
        }
        protected static void IsBackGround() 
	    {
            //Thread thr = Thread.GetCurrentProcessorId();

            //Console.WriteLine($"Is this Thread Background? : {thr.IsBackground}");
        }
    }
}

