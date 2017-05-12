using System;
using System.Collections.Generic;




namespace taskManager
{
    partial class Program
    {
        
        public class tasks
        {
            public static string input = "";
            public static bool happened = false;
            public string taskContent;
            public int strange; 
            public int index;
            public int DeadLine;
            public static List<tasks> taskList = new List<tasks>();
            public tasks(string content,int Strange, int deadline,int Index)

            {
                taskContent = content;
                strange = Strange;
                DeadLine = deadline;
                index = Index;
                taskList.Add(this);
            }

            public static void print(tasks someTask)
            {
                Console.WriteLine($"taskiniz: \n Content:  {someTask.taskContent}\n Cetinlik:  {someTask.strange} \n Deadline:  {someTask.DeadLine} \n Index:  {someTask.index} " +
                    $"\n========================================================================================================================");
            }

            public static void print()
            {
                for (int i = 0; i < taskList.Count; i++)
                {
                    Console.WriteLine($"\n Tapwiriq:   {taskList[i].taskContent} \n Cetinliyi:  {taskList[i].strange}\n Deadline:   {taskList[i].DeadLine} \n index:   {taskList[i].index}"+
                      $"\n===================================================================================================================");
                }
            }

            public static int CalcSec(DateTime ConvDate)
            {
                TimeSpan diff = ConvDate - DateTime.Now;
                return (int)diff.TotalSeconds;
            }



            public static void executeTask(tasks someTask)
            {
                happened = false;
                TimerHandler.SetTimer(someTask);
                if (TimerHandler.timer >0)
                    input = Console.ReadLine();
                if (input == "done" && TimerHandler.timer>0)
                {
                    if (happened == false)
                    {
                        Console.WriteLine("Siz taski muveffeqiyyetle yerine yetirdiniz :O ");
                        happened = true;
                    }
                }
                else
                {   
                    if (happened == false)
                    {
                        Console.WriteLine("Cavabiniz  yalniwdir bextinizi bir daha sinayin ");
                        happened = true;
                    }
                }
                
            }
        }

    }
}







