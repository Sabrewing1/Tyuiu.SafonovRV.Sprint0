using Tyuiu.SafonovRV.Sprint0.Task6.V0.Lib;

using System.Globalization;

namespace Tyuiu.SafonovRV.Sprint0.Task6.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numsArray = new int[] { 1, 2, 3, 4, 5};
            // Пример циклической структуры в библиотеке классов в методе AdditionArray
            Console.WriteLine("Сумма элементов массива = " + DataService.AdditionArray (numsArray));
            // Пример циклической структуры в библиотеке классов в методе SubtrationArray
            Console.WriteLine("Разность элементов массива = " + DataService.SubtrationArray(numsArray));
            // Пример циклической структуры в библиотеке классов в методе MultiplicationArray
            Console.WriteLine("Произведение элементов массива = " + DataService.MultiplicationArray(numsArray));
            
            Console.ReadKey();
        }
    }
}
