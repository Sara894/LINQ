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
            var selectedPeople = from p in people //передаем каждый элемент из people в переменную p
                                 where p.ToUpper().StartsWith('T')//фильтрация по критерию
                                 orderby p //сортируем по возрастанию
                                 select p //выбираем объект в создаваемую коллекцию
                                 ;

            foreach (string person in selectedPeople)
                Console.WriteLine(person);
        }
    }
}
