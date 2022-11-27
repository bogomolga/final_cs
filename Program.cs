﻿// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекоменд. пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] arrayStr = {"Один", "человек", "крепко", "уснул.", "Во", "сне", "он", "увидел", "вкусный", "кисель.", "Но", "ему", 
                    "нечем", "было", "его", "есть.", "На", "другую", "ночь", "он", "лёг", "и", "положил", "с", "собой", "ложку.", 
                    "Но", "кисель", "ему", "не", "приснился.", "Integer:", "25", "! &", "fin"};
PrintArray(arrayStr, "Массив: [");


//-------------------



void PrintArray(string[] collection, string msg)
{
    int length=collection.Length;
    int index=0;
    Console.Write(msg);
    while(index<length)
    {
        if (index!=length-1)
        {
            Console.Write(collection[index]+", ");
        }
        else
        {
            Console.Write(collection[index]+"]");
        }
        index++;
    } Console.WriteLine();
}