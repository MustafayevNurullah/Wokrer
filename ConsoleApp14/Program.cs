using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            //staj 3 ilden 5 ile qederolanda meuniyyet gunu  daxil etmemisiz.
            //3 ilden 5 ile qeder staj olarsa ozumden 31 gun mezuniyyet daxil etdim.
            Main_();
        }
        static void Main_()
        {
            Worker[] array = new Worker[0];
            DateTime todayy = DateTime.Now;
            Worker worker = new Worker();
            int counter = 0;
            while (counter < 5)
            {
                Console.WriteLine("Enter Name");
                string Name = Console.ReadLine();
                try
                {
                    if (string.IsNullOrEmpty(Name))
                    {
                        throw new Exception("Enter Empty Name");
                    }
                    if (string.IsNullOrWhiteSpace(Name))
                    {
                        throw new Exception(" Enter Null space");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
                Console.WriteLine("Enter Surname");
                string Surname = Console.ReadLine();
                try
                {
                    if (string.IsNullOrEmpty(Surname))
                    {
                        throw new Exception("Enter Empty Surname");
                    }
                    if (string.IsNullOrWhiteSpace(Surname))
                    {
                        throw new Exception(" Enter Null space");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
                Console.WriteLine("Enter Position");
                string Position = Console.ReadLine();
                try
                {
                    if (string.IsNullOrEmpty(Position))
                    {
                        throw new Exception("Enter Empty Position");
                    }
                    if (string.IsNullOrWhiteSpace(Position))
                    {
                        throw new Exception(" Enter Null space");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
                Console.WriteLine("Enter date");
                DateTime Date = Convert.ToDateTime(Console.ReadLine()).Date;
                string q = Convert.ToString(Date);
                try
                {
                    if (string.IsNullOrEmpty(q))
                    {
                        throw new Exception("Enter Empty Date");
                    }
                    if (string.IsNullOrWhiteSpace(q))
                    {
                        throw new Exception(" Enter Null space");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }

                worker.add(Name, Surname, Position, Date);
                Array.Resize(ref array, array.Length + 1);
                array[array.Length - 1] = new Worker();
                array[array.Length - 1].add(Name, Surname, Position, Date);

                counter++;
                Thread.Sleep(1000);
                Console.Clear();

                if (counter == 5)
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        DateTime today = DateTime.Now;
                        TimeSpan difference = today.Subtract(array[i].Date_);
                        var a = Convert.ToInt32(difference.Days / 365);
                        Console.WriteLine("*************************************************");
                        Console.WriteLine("Name");
                        Console.WriteLine(array[i].Name_);
                        Console.WriteLine("Surname");
                        Console.WriteLine(array[i].Surname_);
                        Console.WriteLine("Position");
                        Console.WriteLine(array[i].Position_);
                        Console.WriteLine("Year");
                        Console.WriteLine(a);
                        if (a >= 1 && a <= 3)
                        {
                            Console.WriteLine("staj");
                            Console.WriteLine("30 day");
                        }
                        if (a > 3 && a <= 5)
                        {
                            Console.WriteLine("staj");
                            Console.WriteLine("31 day");
                        }
                        if (a > 5 && a <= 7)
                        {
                            Console.WriteLine("staj");
                            Console.WriteLine("33 day");
                        }
                        if (a > 7 && a <= 10)
                        {
                            Console.WriteLine("staj");
                            Console.WriteLine("35 day");
                        }
                        if (a > 10)
                        {
                            Console.WriteLine("staj");
                            Console.WriteLine("40 day");
                        }

                    }
                    Environment.Exit(0);
                }

            }
        }
        class Myexception : Exception
        {
            public Myexception(string message) : base(message) { }
        }
        class Worker
        {
            string Name;
            string Surname;
            string Position;
            DateTime Date;

            public Worker() { }
            public void add(string Name, string Surname, string Position, DateTime Date)
            {
                this.Name = Name;
                this.Surname = Surname;
                this.Position = Position;
                this.Date = Date;

            }
            public string Name_
            {
                get
                {
                    return Name;
                }
            }
            public string Surname_
            {
                get
                {
                    return Surname;
                }
            }
            public string Position_
            {
                get
                {
                    return Position;
                }
            }
            public DateTime Date_
                //
            {
                get
                {
                    return Date;
                }
            }
        }

    }
}