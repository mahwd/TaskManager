using System;


namespace taskManager
{
    partial class Program
    {
        public class TimerHandler
        {
            // =================================================    parametrs   =================================================================

            //private delegate void DeadLin eEventHandler(Object source, EventArgs e);
            private static System.Timers.Timer Count;
            private static int DeadLine;
            public static int timer;

            // ===================================================    methods   =================================================================


            // timer every time calling OnCountDown 

            public static void SetTimer(tasks some)
            {
                // created a timer with a second interval.
                Count = new System.Timers.Timer(1000);
                // raising eventhandler OnCountDown. 
                Count.Elapsed += OnCountDown;
                Count.AutoReset = true;
                Count.Enabled = true;
                DeadLine = some.DeadLine;
                timer = some.DeadLine;
            }

            //   every 1 sec timer calls this private method its calculating deadline of task  if deadLine is banged stops timer and cw "some kind of shit"

            private static void OnCountDown(object source,EventArgs e)
            {
                timer--;
                if(tasks.happened == false)
                Console.WriteLine("                                                                              remaining:{0}sec", timer);
                if (timer <= 0)
                {
                    if (tasks.happened == false)
                    {
                        Console.WriteLine(" \n DeadLine of the task is expired , your task canceled ..." + Count.Interval);
                        tasks.happened = true;
                    }
                    Count.Stop();       // stops raised timer  by falsing Count.Enabled ;
                    Count.Dispose();        // wipes all resources used by System.ComponentModel.Component

                }
            }
        }
    }
}







