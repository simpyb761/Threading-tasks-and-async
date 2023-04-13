using System;
using static System.Console;
namespace threadRace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Read, Set Go...");
            int t1Location = 0;
            int t2Location = 0;
            int t3Location = 0;
            int t4Location = 0;
            int t5Location = 0;

            //Creating Threads
            Thread t1 = new Thread(delegate ()
            {
                Thread.CurrentThread.Name = "Lux";
                for (int i = 0; i < 100; i++)
                {
                    if (t1Location < 100 && t2Location < 100 && t3Location<100 && t4Location<100 && t5Location <100)
                        MoveIt(ref t1Location);
                }

            });
            Thread t2 = new Thread(delegate ()
            {
                Thread.CurrentThread.Name = "Ahri";
                for (int i = 0; i < 100; i++)
                {
                    if (t1Location < 100 && t2Location < 100 && t3Location < 100 && t4Location < 100 && t5Location < 100)
                        MoveIt(ref t2Location);

                }
            });
            Thread t3 = new Thread(delegate ()
            {
                Thread.CurrentThread.Name = "Leblanc";
                for (int i = 0; i < 100; i++)
                {
                    if (t1Location < 100 && t2Location < 100 && t3Location < 100 && t4Location < 100 && t5Location < 100)
                        MoveIt(ref t3Location);
                }
            });
            Thread t4 = new Thread(delegate ()
            {
                Thread.CurrentThread.Name = "Neeko";
                for (int i = 0; i < 100; i++)
                {
                    if (t1Location < 100 && t2Location < 100 && t3Location < 100 && t4Location < 100 && t5Location < 100)
                        MoveIt(ref t4Location);
                }
            });
            Thread t5 = new Thread(delegate ()
            {
                Thread.CurrentThread.Name = "Jinx";
                for (int i = 0; i < 100; i++)
                {
                    if (t1Location < 100 && t2Location < 100 && t3Location < 100 && t4Location < 100 && t5Location < 100)
                        MoveIt(ref t5Location);
                }
            });

            //Executing the methods
            t2.Priority = ThreadPriority.Highest;
            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();
            t5.Start();
            Console.WriteLine("Race has ended");
        }
        static void MoveIt(ref int location)
        {
            location++;
            Console.WriteLine($"{Thread.CurrentThread.Name} location={location}");
            if (location >= 100)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} is the winner");
                return;
            }
        }

    }
}