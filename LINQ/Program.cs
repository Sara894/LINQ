using System;
using System.Collections.Generic;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] people = { "Tom", "Tailer","Bob","Sam","Tim" };

            //создаем новый список для результатов
            var selectedPeople = new List<string>();

            //проходим по массиву 
            foreach(string person in people )
            {
                //если строка начинается на букву T
                if (person.ToUpper().StartsWith("T"))
                    selectedPeople.Add(person);
            }

            //сортируем список
            selectedPeople.Sort();

            foreach (string person in selectedPeople)
                Console.WriteLine(person);

        }
    }
}
