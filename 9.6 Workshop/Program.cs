using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchPractices
{
    class Programm
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Блок Try начал свою работу!");

                Method2();
            }
            catch (Exception ex) when (ex is ArgumentNullException) /// делаем фильтрацию исключений
            {
                Console.WriteLine("Аргумент пустой!");
            }

            catch (Exception ex) when (ex is FileNotFoundException) /// делаем фильтрацию исключений
            {
                Console.WriteLine("Файл не найден");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace.ToString()); /// последовательность действий, которые привели к исключению
            }


            finally
            {
                Console.WriteLine("Блок finally сработал!");
            }
            Console.ReadLine();
        }

        static void Method1()  /// создаем метод1
        {
            try
            {
                throw new Exception("Внутренней исключение");
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        static void Method2()  /// создаем метод2
        {
            try
            {
                Method1();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }

}