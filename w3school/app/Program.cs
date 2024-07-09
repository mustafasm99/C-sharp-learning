using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            Car taota = new Car();
            Console.WriteLine(taota.GetColor());
            taota.SetColor("#ff2200");
            Console.WriteLine(taota.GetColor());

            Track zivk = new Track(40, "tank");
            // Using the inheritance to update the values for the tracks
            zivk.SetData("black", "deadTrack", 1954);

            Console.WriteLine(zivk.WHO);

            // start time 
            DateTime start_time = DateTime.Now;
            Console.WriteLine("Start Time: " + start_time);

            // Action 
            for (int i = 0; i < 1000000; i++)
            {
                if (i == 50)
                {
                    Console.WriteLine("The counter breaks at: " + i);
                    break;
                }
                Console.WriteLine(i);
            }

            // end time 
            DateTime end_time = DateTime.Now;
            Console.WriteLine("End Time: " + end_time);

            // Calculate total time
            TimeSpan totalTime = end_time - start_time;
            Console.WriteLine("Total Time: " + totalTime);
        }
    }

    // These are the classes
    class Car
    {
        public string name;
        public string color;
        public int year;

        public Car()
        {
            // This is the constructor
            this.color = "xnxx";
            this.name = "sex";
            this.year = 12;
        }

        public void SetColor(string color)
        {
            this.color = color;
        }

        // Set the car values [color, name, year]
        public void SetData(string color, string name, int year)
        {
            this.color = color;
            this.name = name;
            this.year = year;
        }

        public string GetColor()
        {
            return this.color;
        }
    }

    class Track : Car
    {
        int size;
        string type;
        int totalWorkTime;

        public Track(int size, string type)
        {
            if (size < 10)
            {
                Console.WriteLine("Error: this is not a Track, it's a car.");
                return;
            }
            int current_time = 2024;
            this.totalWorkTime = current_time - this.year;
            this.size = size;
            this.type = type;
        }

        public string WHO
        {
            get
            {
                return @$"
                #################################
                # This is a Track description    #
                # Type        : {this.type}     #
                # Name        : {this.name}     #
                # Size        : {this.size}     #
                # Color       : {this.color}    #
                # Year        : {this.year}     #
                # This Track has been {2024 - this.year} years in use #
                #################################
                ";
            }
        }
    }
}
