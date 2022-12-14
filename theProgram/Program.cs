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

int elements;  //Записываем в переменную число кол-ва элементов в первом массиве
while (true)   //проверка на правильность ввода кол-ва элементов
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
//создаем первый массив с кол-вом элементов  =  elements. 
string[] array = CreateArray(elements);
for (int i = 0; i < elements; i++)
{
    Write($"Введите {i + 1}-й элемент массива: ");      
    array[i] = ReadLine();   //вводим любые сиволы вручную, поочередно в каждый элемент
}

//считаем количество элементов с числом символов(индексов) <= 3 в первом массиве array
int resultElements = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        resultElements++;
    }
}

//Cоздаем итоговый массив длиной = resultElements и кол-вом символов каждого элемента <= 3
string[] newArray = CreateArray(resultElements);
int j = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        newArray[j] = array[i];
        j++;
    }
}

//Выводим итоговый ответ(массив)
if (resultElements == 0)
{
    WriteLine("В заданном массиве: ");
    PrintArray(array);
    WriteLine();
    WriteLine($"Количествово найденых элемтов с числом сиволов <= 3  -  [{resultElements}]");
    WriteLine("Итоговоый массив:  []");
}
else
{
    WriteLine("Исходный массив:");
    PrintArray(array);
    WriteLine();
    WriteLine($"Количествово найденых элемтов с числом сиволов <= 3  -  [{resultElements}]");
    WriteLine("Итоговый массив:");
    PrintArray(newArray);
}



//метод создания массива 
string[] CreateArray(int size)
{
    string[] array = new string[size];
    return array;
}

//void метод вывода массива
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







