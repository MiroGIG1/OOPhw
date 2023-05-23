using System;
using System.Collections.Generic;

namespace Model_me_this_Football
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Football_Player> player = new List<Football_Player>();
            int n = 11;
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] data = input.Split(',');
                if (data[0] == "1")
                {
                    Football_Player f = new Football_Player();
                    f.Name = data[1];
                    f.Number = int.Parse(data[2]);
                    f.Age = int.Parse(data[3]);
                    f.Height = double.Parse(data[4]);
                }
            }
        }
    }
}
