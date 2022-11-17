using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> ListFirstName = new List<string>(); /// создаем пустой список
            string[] FirstName = new string[5]; /// создаем массив из 5 значений

            for (int i = 0; i < FirstName.Length; i++)
            {
                Console.WriteLine("Введите фамелию {0}: ", i + 1);
                string firstName = Console.ReadLine();
                ListFirstName.Add(firstName);
            }

            FamilySorted familySorted = new FamilySorted(); /// создаем экземляр класса

            try /// проверяем на правильность ввденого формата
            {
                familySorted.Read();

            }
            catch (FormatException)
            {
                Console.WriteLine("Введено не корректное значение");
            }

            Console.WriteLine();
                
            ListFirstName.Sort(); /// сортируем список
            foreach (string fName in ListFirstName)
            {
                Console.WriteLine(fName);
            }

            Console.WriteLine();

            ListFirstName.Reverse(); /// сортируем список в обратном порядке
            foreach (string fName in ListFirstName)
            {
                Console.WriteLine(fName);
            }
        }
    }

    class FamilySorted /// создаем новый класс
    {
        public delegate void FamilySortedDelegate(int number); /// создаем делегат , на ввод принимает число
        public event FamilySortedDelegate FamilySortedEvent; /// реализовываем событие
        public void Read() /// создаем метод, который читает введеное значение
        {
            Console.WriteLine();
            Console.WriteLine("Введете число 1 (сортировка А-Я), либо число 2 (сортировка Я-А): ");

            int number = Convert.ToInt32(Console.ReadLine()); /// введеное значение от пользователя

            if (number != 1 && number != 2) throw new FormatException(); /// правильно введены ли только числа 1 или 2

            NumberEntered(number);
        }

        protected virtual void NumberEntered(int number)
        {
            FamilySortedEvent?.Invoke(number);
        }
    }

}