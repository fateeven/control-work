//Написать программу, которая из имеющегося массива строк формирует массив из строк,
//длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
//либо задать на старте выполнения алгоритма.
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
using System;
using static System.Console;

Clear();


//Вводим количество элементов первого массива - count
Write("Введите число элементов массива: ");
string numberElements = ReadLine();
//Записываем в переменную число кол-ва элементов в первом массиве, после проверки
int elements;           
//проверка на правильность вводных данных
while (true)
{
    if (int.TryParse(numberElements, out elements) == false)
    {
        WriteLine("Вы ввели не числовое значение, попробуйте еще раз!");
        Write("Введите число элементов массива: ");
        numberElements = ReadLine();
    }
    else if (elements <= 0)
    {
        WriteLine("Количество элементов не может быть отрицательным или нулевым, попробуйте еще раз!");
        Write("Введите число элементов массива: ");
        numberElements = ReadLine();
    }
    else break;
}

//метод создания массива
string[] CreateArray(int size)
{
    string[] array = new string[size];
    return array;
}

//создаем первый массив с кол-вом элементов  =  elements
string[] array = CreateArray(elements);
for (int i = 0; i < elements; i++)
{
    Write($"Введите {i + 1}-й элемент массива: ");
    array[i] = ReadLine();
}

//метод Voidd вывода элементов массива в консоль
void PrintArray(string[] inArray)
{
    Write("[");
    for (int i = 0; i < inArray.Length - 1; i++)
    {
        Write($"'{inArray[i]}', ");
    }
    Write($"'{inArray[inArray.Length - 1]}'");
    Write("]");
}
//Выводим первый массив
PrintArray(array);