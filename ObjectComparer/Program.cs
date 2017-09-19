using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectComparer
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = new Student { RollNumber = 1, Name = "Shubhangi" };
            var s2 = new Student { RollNumber = 1, Name = "Shubhangi" };
            var s3 = new Student { RollNumber = 1 };
            var comparer = new Comparer();
            var areSame = comparer.Compare(s1, s2);
            Console.WriteLine($"s1 == s2 = {areSame}");


            areSame = comparer.Compare(s3, s2);
            Console.WriteLine($"s2 == s3 = {areSame}");
            Console.ReadLine();
        }

        private static Address GetAddress(int v)
        {
            return new Address
            {
                Lane = $"Lane{v}",
                City = $"City{v}",
                State = $"State{v}",
                Country = $"Country{v}"
            };
        }
    }
    public class Student
    {
        public int RollNumber { get; set; }
        public string Name { get; set; }
    }
}
