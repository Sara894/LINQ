using System;
using System.Collections.Generic;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //источник данных - любой
            string[] people = { "Tom", "Tim", "Masha", "Mitya" };
            //массив для результата запроса
            var selectedPeople = new List<string>();

            //проходим по массиву 
            foreach(string person in people)
            {
                //если строка начинается на букву Т забираем слово
                if (person.ToUpper().StartsWith("T"))
                    selectedPeople.Add(person);
            }

            //сортируем список выбранных имен
            selectedPeople.Sort();

            foreach (string person in selectedPeople)
                Console.WriteLine(person);
        }
    }
}
