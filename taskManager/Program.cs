using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Diagnostics;




namespace taskManager
{
    partial class Program
    {
        public static void Main(string[] args)
        {
            var Task1 = new tasks("C# variables and their definitions", 2, 10, 1);
            var Task2 = new tasks("delefates in C# Events and Event handlers", 3, 15, 2);
            var Task3 = new tasks("Object and class logic in C#", 4, 5, 3);
            var Task4 = new tasks("Lenovo Boost Your Productivity With Performance You Can Count On", 2, 7, 4);
            string userInput = "";
            string taskSelect = "";
            int check = 0;

            string username = "";
            Console.Write("Username daxil edin:");
            username = Console.ReadLine();
            if (username == "iso")
            {
                tasks.print(tasks.taskList[0]);
                tasks.print(tasks.taskList[2]);
            }
            else if (username == "heso")
            {
                tasks.print(tasks.taskList[1]);
                tasks.print(tasks.taskList[3]);
            }
            else
            {
                
                while (userInput != "exit")
                {
                    check = 0;
                    Console.Clear();


                    while (check == 0)
                    {
                        tasks.print();
                        Console.Write("\n Her hansi bir taski secin:");
                        taskSelect = Console.ReadLine();
                        try
                        {
                            Console.Clear();
                            tasks.print(tasks.taskList[int.Parse(taskSelect) - 1]);
                            check = 1;
                            tasks.executeTask(tasks.taskList[int.Parse(taskSelect) - 1]);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine(" \n ================!!! DUZGUN INDEXI DAXIL EDIN !!!===============");
                        }

                    }
                }
            }




                Thread.Sleep(1000);
                Console.Write("\n proqramdan cixmaq ucun 'exit' daxil edin:");
                userInput = Console.ReadLine();
                Console.Clear();
            }
        }
    }








