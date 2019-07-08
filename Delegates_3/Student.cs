using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_3
{
    class Student
    {
        private string name;
        private int id;
        private int mark;

        public Student(string name, int id, int mark)
        {
            this.name = name;
            this.id = id;
            this.mark = mark;
        }

        public override string ToString()
        {
            return string.Format($"Имя => {name}, ID => {id}, Оценка => {mark}");
        }

        // Пользовательская функция сравнение, возвращающая булевое значение
        public static bool IsLeftGreater(object left, object right)
        {
            Student leftStudent = (Student)left;
            Student rightStudent = (Student)right;
            return rightStudent.mark < leftStudent.mark;
        }
    }
}
