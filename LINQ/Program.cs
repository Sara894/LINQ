using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //источник данных - любой
            string[] people = { "Tom", "Tim", "Masha", "Mitya" };
            //массив для результата запроса
            var selectedPeople = people.Where(p => p.ToUpper().StartsWith("T")).OrderBy(p=>p);

            foreach (string person in selectedPeople)
                Console.WriteLine(person);

            int number = (from p in people where p.ToUpper().StartsWith("T") select p).Count();
            Console.WriteLine(number);
        }
    }
}
