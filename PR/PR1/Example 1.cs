/*
 * Автор программы - Бобоев Азизджон 11-707.
 * 
 * Что делает программа:
 *  - Программа меняет местами значения в переменных без использования новой переменной.
 */

using System;

namespace ConsoleApp
{
    class SwapNumbersProgram
    {
        public static void Main(string[] args)
        {
            int firstNum = 10;
            int secondNum = 5;

            secondNum = secondNum - firstNum;
            firstNum = secondNum + firstNum;
            secondNum = firstNum - secondNum;

            Console.WriteLine("Значение 1-ой переменной: {0}. Значение второй переменной: {1}", firstNum, secondNum);
            
            Console.ReadKey();
        }
    }
} 