﻿
Console.WriteLine("Задача 3:\n Напишите программу, которая выводит третью цифру заданного числа\n или сообщает, что третьей цифры нет.");

int EnterNumberTest(){
    bool readlineFromStrToInt = true;
    int number =0;
    while (readlineFromStrToInt){
        Console.Write("Введите число : ");
        string numberSTR = Console.ReadLine();
        
        if (int.TryParse(numberSTR, out int numberInt) ){
            number = numberInt;
            readlineFromStrToInt = false;
        }
        else Console.WriteLine("Ввели не число , повторите попытку");
    }
    return number;
}

string number = Convert.ToString(EnterNumberTest());

if (number[0] == '-'){
    if (number.Length >=4) Console.WriteLine($"{number} - > {number[3]}");
    else Console.WriteLine($" {number} - > нет 3го числа");
}
else{
    if (number.Length >=3) Console.WriteLine($"{number} - > {number[2]}");
    else Console.WriteLine($" {number} - > нет 3го числа");
}

Console.ReadLine();