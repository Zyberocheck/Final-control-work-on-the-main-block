﻿// Итоговая контрольная работа по основному блоку
// Урок 1. Контрольная работа
// Данная работа необходима для проверки ваших знаний и навыков по итогу прохождения первого блока обучения на программе Разработчик. Мы должны убедится, что базовое знакомство с IT прошло успешно.

// Задача алгоритмически не самая сложная, однако для полноценного выполнения проверочной работы необходимо:

// 1. Создать репозиторий на GitHub
// 2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
// 3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
// 4. Написать программу, решающую поставленную задачу
// 5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше,
//  либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


Console.Write("Введите количество элементов: ");
int size = Convert.ToInt32(Console.ReadLine());

string []  СreateArray()
{
string[] array = new string[size];
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите значение: {i+1}-й элемент: ");
    string element = Convert.ToString(Console.ReadLine());
    array[i] = element;
}
return array;
}

string [] arrayA = СreateArray();

// Находим длину нового массива чтобы не задавать в ручную и чтобы в выводе небыло невидемых "NULL"

// -----------------------------------------------------------------------------------------------------
int lengthArrayB = 0;

for (int i = 0; i <= arrayA.Length -1; i++)
{
    if (arrayA[i].Length<=3)
    {
        lengthArrayB++;
    }
}
// -----------------------------------------------------------------------------------------------------

string[] arrayB = new string[lengthArrayB];

void ArrayBmax3 (string[] arrayA, string[] arrayB)
{
    int count = 0;
    for (int i = 0; i < arrayA.Length; i++)
    {
        if(arrayA[i].Length<=3)
        {
            arrayB[count]=arrayA[i];
            count++;
        }
    }

}


void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}


PrintArray(arrayA);
ArrayBmax3(arrayA,arrayB);
Console.WriteLine();
PrintArray(arrayB);



