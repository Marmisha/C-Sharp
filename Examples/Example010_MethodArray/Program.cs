﻿// Зададим массив. Придумаем число и будем проверять, есть ли оно в массиве.
int [] array = {1,12,31,4,18,15,16,17,18};
int n =  array.Length;
int findNum = 18; // число, которе будем искать в массиве.

int index = 0; // счетчик

while(index<n)
{
    if (array[index] == findNum)
    {
        Console.WriteLine(index);
        break;
    }
index++;
}