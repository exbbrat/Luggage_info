
using System;
using System.Collections.Generic;
using System.Linq;
 


namespace ConsoleApp1
{
    public class Laggage_info
    {

        public string name;
        public static int count_all;
        public static double weight_all, weight_medium;
        public static Dictionary<string, double> information = new Dictionary<string, double>();
        public static Dictionary<string, double> information_new = new Dictionary<string, double>();
        public Laggage_info(string name, int count, double weight)
        {
            information.Add($"{name} has  {count} things with a total {weight} weight, average baggage weight",Math.Round(weight / count,2));


        }
        public Laggage_info(string name, int count, double[] weight)
        {
            string str = "";
            for (int i = 0; i < weight.Length; i++)
            {
                str += $"{weight[i]};";
                weight_all += weight[i];
            }
            str = str.Remove((str.Length - 1));
            information.Add($"{name} has  {count} things ({str}) with a total {weight_all} weight, average baggage weight", weight_all / count);
        }



        public void Print()
        {
            weight_medium = weight_all / count_all;
            //Console.WriteLine($"{weight_all} - {count_all} - {weight_medium}");
            var list = information.Keys.ToList();


            foreach (var key in list)
            {
                if ((information[key] + 300) == weight_medium || (information[key] - 300) == weight_medium) information_new.Add(key, information[key]);

                Console.WriteLine("{0}: {1}", key, information[key]);
            }

            Console.WriteLine("\n\n Baggage whose average weight differs by 300 grams from the total weight of the items");
            var list_1 = information_new.Keys.ToList();

            if (information_new.Count == 0) Console.WriteLine("Empty");
            else
            {
                foreach (var key in list_1)
                {
                    Console.WriteLine("{0}: {1}", key, information_new[key]);
                }
            }


        }
        ~Laggage_info() { }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("FIO \t Count thing  \t\t\t Medium weight");

            Laggage_info info = new("Dmitry Ivanko", 10, 23.2);
            Laggage_info info_1 = new("Ann Vasilenko", 10, 35.6);
            Laggage_info info_2 = new("Yan Gordienko", 12, 75);
            Laggage_info info_3 = new("Ameli Lisova", 3, 29.8);
            Laggage_info info_4 = new("Ivan Durnev", 1, 34);
            Laggage_info info_5 = new("Hrystyna Dnova", 2, 21.08);
            Laggage_info info_6 = new("Alexey Ivleev", 3, 120.2);
            Laggage_info info_7 = new("Dina Saeva", 15, 45);
            Laggage_info info_8 = new("Arina Zelensky", 15, 43);
            Laggage_info info_9 = new("Ivan Holoborodko", 1, 42);
            Laggage_info info_10 = new("Anastasya Sycheva", 6, 53.2);

            //double[] Array = { 3, 2, 1, 7, 8, 3 };

            //Laggage_info info_11 = new("Anastasya Sycheva", 6, Array);

            Laggage_info info_11 = new("Vitaliy Pavlyuk", 7, 101.1);
            Laggage_info info_12 = new("Raisa Sergienko", 4, 19.44);
            Laggage_info info_13 = new("Timofey Yanovych", 11, 99.9);
            Laggage_info info_14 = new("Valentina Shinkarenko", 5, 74.3);
            Laggage_info info_15 = new("Alla Ponomarenko", 15, 12.3);

            info.Print();

            Console.WriteLine("It's end !");
        }
    }
}
