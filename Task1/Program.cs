using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Programm
    {
        static void Main(string[] args)
        {
            string error = "Ошибка в БД";

            try
            {
                Console.WriteLine("Блок Try начал свою работу!");
                throw new Exception(error);
            }

            catch (Exception ex) when (ex.Message == error) /// делаем фильтрацию по соственному типу исключения
            {
                Console.WriteLine(ex.Message);
            }

            catch (Exception ex) when (ex is ArgumentNullException) /// делаем фильтрацию исключений
            {
                Console.WriteLine("Аргумент пустой!");
            }

            catch (Exception ex) when (ex is FileNotFoundException) /// делаем фильтрацию исключений
            {
                Console.WriteLine("Файл не найден");
            }

            catch (Exception ex) when (ex is PlatformNotSupportedException) /// делаем фильтрацию исключений
            {
                Console.WriteLine("Операция не поддерживается на текущей платформе");
            }

            catch (Exception ex) when (ex is IndexOutOfRangeException) /// делаем фильтрацию исключений
            {
                Console.WriteLine("Индекс находится за пределами границ массива");
            }

            finally
            {
                Console.WriteLine("Блок finally сработал!");
            }
            Console.ReadLine();
        }

    }

}