using System;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите угол:");
            int gradus = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("минуты");
            int minutes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("секунды");
            int seconds = Convert.ToInt32(Console.ReadLine());

            Angle angle = new Angle(gradus, minutes, seconds);
            angle.Print();

            Console.WriteLine("Угол {0} равен {1:f4} радиан", angle.GetString(), angle.ToRadians());

            Angle angle2 = new Angle(33, 12, 10);
            Console.WriteLine("Угол {0} равен {1:f4} радиан", angle2.GetString(), angle2.ToRadians());


            Angle angle3 = new Angle(32);
            Console.WriteLine("Угол {0} равен {1:f4} радиан", angle3.GetString(), angle3.ToRadians());



            Console.ReadKey();
        }
    }


    class Angle
    {
        private int gradus;
        private int minutes;
        private int seconds;

        public Angle(int gradus, int minutes = 0, int seconds = 0)
        {
            this.Gradus = gradus;
            this.Minutes = minutes;
            this.Seconds = seconds;
        }
        public int Gradus
        {
            set
            {
                if (value >= 0 && value < 360) this.gradus = value;
                else Console.WriteLine("Градус д.б. от 0 до 360");
            }
            get
            {
                return gradus;
            }
        }

        public int Minutes
        {
            set
            {
                if (value >= 0 && value < 60) this.minutes = value;
                else Console.WriteLine("Минуты д.б. от 0 до 60");

            }
            get
            {
                return minutes;
            }
        }

        public int Seconds
        {
            set
            {
                if (value >= 0 && value < 3600) this.seconds = value;
                else Console.WriteLine("Секунды д.б. от 0 до 3600");

            }
            get
            {
                return seconds;
            }
        }

        public double ToRadians()
        {
            return (Gradus + (Minutes + (double)Seconds / 60) / 60) * Math.PI / 180;
        }

        public string GetString()
        {
            return String.Format("{0}° {1}' {2}''", Gradus, Minutes, Seconds);
        }

        public void Print()
        {

            Console.WriteLine(GetString());
        }

    }
}
