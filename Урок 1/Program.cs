using System.Linq;
using static System.Console;

var isEnd = false;
do{
    WriteLine("Введите номер задания (1, 2, 3, 4) для выхода введите q или пустую строку чтобы выйти");
    switch(ReadLine())
    {
        case "1":
            WriteLine(@"Задача 1: Напишите программу, которая на вход
принимает два числа и выдаёт, какое число большее, а
какое меньшее.");
            WriteLine("Введите 2 числа");
            var arr = new [] {0, 0}.Select(x => new string(ReadLine().Where((ch, idx) => char.IsDigit(ch) || (idx == 0 && ch == '-')).ToArray())).Select(x => x.Length > 0 ? int.Parse(x) : 0).ToArray();
            WriteLine($"Большее число является {(arr[0] > arr[1] ? arr[0] : arr[1])}");
            break;
        case "2":
            WriteLine(@"Задача 2: Напишите программу, которая принимает на
вход три числа и выдаёт максимальное из этих чисел.");
            WriteLine("Введите 3 числа");
            var arr1 = new [] {0, 0, 0}.Select(x => new string(ReadLine().Where((ch, idx) => char.IsDigit(ch) || (idx == 0 && ch == '-')).ToArray())).Select(x => x.Length > 0 ? int.Parse(x) : 0).ToArray();
            WriteLine($"Большее число является {(arr1[0] > arr1[1] ? arr1[0] > arr1[2] ? arr1[0] : arr1[2] : arr1[1] > arr1[2] ? arr1[1] : arr1[2])}");
            break;
        case "3":
            WriteLine(@"Задача 3: Напишите программу, которая на вход
принимает число и выдаёт, является ли число чётным
(делится ли оно на два без остатка).");
            WriteLine("Введите число");
            var val = int.TryParse(new string(ReadLine().Where((ch, idx) => char.IsDigit(ch) || (idx == 0 && ch == '-')).ToArray()), out var v) ? v % 2 == 0? true : false : false;
            WriteLine(val ? "да" : "нет");
            break;
        case "4":
            WriteLine(@"Задача 4: Напишите программу, которая на вход
принимает число (N), а на выходе показывает все чётные
числа от 1 до N.");
            WriteLine("Введите число");
            if(int.TryParse(new string(ReadLine().Where((ch, idx) => char.IsDigit(ch)).ToArray()), out var val2))
                WriteLine(string.Join(", ", Enumerable.Range(1, val2 % 2 == 0 ? val2 : val2 - 1).Where(e => e % 2 == 0)));
            else
                WriteLine("Число не введино");
            break;
        case "q": case "":
            isEnd = true;
            break;
        default:
            break;
    }
}while(!isEnd);
    
