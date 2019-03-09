using System;
using System.Collections.Generic;

namespace JosephusProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of people");
            var numberOfPeople = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter killing interval.");
            var killingInterval = Convert.ToInt32(Console.ReadLine());

            List<int> People = new List<int>(CreatePeople(numberOfPeople));


            LastPersonStanding(People, killingInterval);

            Console.ReadLine();
        }

        public static void LastPersonStanding(List<int> people, int killingInterval)
        {
            do
            {
                var counter = 1;

                for (int i = 0; i < people.Count; i++)
                {
                    if (counter == killingInterval)
                    {
                        counter = 1;
                        Console.WriteLine($"You killed { people[0]}");
                        people.RemoveAt(0);
                    } else
                    {
                        people.Add(people[0]);
                        people.RemoveAt(0);
                        counter++;
                        i--;
                    } 
                }
            } while (people.Count > 1);
            Console.WriteLine($"Last person standing {people[0]}!");

            Console.WriteLine($"The winner is " + people[0].ToString());
            Console.ReadKey();
        }
        public static List<int> CreatePeople(int numberOfPeople)
        {
            List<int> tempList = new List<int>();
            for (int i = 1; i <= numberOfPeople; i++)
            {
                tempList.Add(i);
            }
            return tempList;
        }
    }
}
