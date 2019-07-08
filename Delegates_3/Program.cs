using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_3
{
    public delegate bool CompareDelegate(object lhs, object rhs);

    public class Program
    {
        // Объявление делегата, ссылающегося на функцию
        // с двумя параметрами и выводом булевого типа

        static void Main(string[] args)
        {
            Random r = new Random();
            // Создание массива объектов класса Student.cs
            Student[] students = {
        new Student("Mark", 1, r.Next()%101),
        new Student("David", 2, r.Next()%101),
        new Student("Lavish", 3, r.Next()%101),
        new Student("Voora", 4, r.Next()%101),
        new Student("Boll", 5, r.Next()%101),
        new Student("Donna", 6, r.Next()%101),
        new Student("Adam", 7, r.Next()%101),
        new Student("Steve", 8, r.Next()%101),
        new Student("Ricky", 9, r.Next()%101),
        new Student("Brett", 10, r.Next()%101)
      };

            // Создание делегата с передачей статического метода класса Student в качестве аргумента
            CompareDelegate StudentCompareOp = new CompareDelegate(Student.IsLeftGreater);


            for (int i = 0; i < students.Length; i++)
                Console.WriteLine(students[i].ToString());
            Console.WriteLine();

            // Вызов статического метода класса BubbleSortClass, передача массива объектов и делегата
            BubbleSortClass.Sort(students, StudentCompareOp);

            for (int i = 0; i < students.Length; i++)
                Console.WriteLine(students[i].ToString());

        }
    }
}
