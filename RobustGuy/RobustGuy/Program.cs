using System;

namespace RobustGuy
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Podaj datę urodzenia");
            string birthday = Console.ReadLine();
            Console.Write("Podaj wzrost w centymetrach:");
            string height = Console.ReadLine();
            RobustGuy guy = new RobustGuy(birthday, height);
            Console.WriteLine(guy.ToString());
            Console.ReadKey();

        }
        
          
        
        class RobustGuy
        {
            public DateTime? Birthday { get; private set; }
            public int? Height { get; private set; }
            public RobustGuy(string birthday, string height)
            {
                DateTime tempDate;
                if (DateTime.TryParse(birthday, out tempDate))
                    Birthday = tempDate;
                else
                    Birthday = null;
                int tempInt;
                if (int.TryParse(height, out tempInt))
                    Height = tempInt;
                else
                    Height = null;

            }
            public override string ToString()
            {

                string description;
                if (Birthday != null)
                    description = "Urodziłem się dnia " + Birthday.Value.ToLongDateString();
                else
                    description = "Nie znam daty swoich urodzin";
                if (Height != null)
                    description += ", mam " + Height + " centymetrów wzrostu.";
                else
                    description += ", nie wiem, ile mam wzrostu.";
                return description;
            }

        }
    }
    }

