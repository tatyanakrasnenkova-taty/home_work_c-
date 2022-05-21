
Console.WriteLine("Задача 4:\n Напишите программу, которая принимает на вход цифру,\n обозначающую день недели, и проверяет,\n является ли этот день выходным. ");

int EnterNumberTest(){
    bool readlineFromStrToInt = true;
    int number =0;
    while (readlineFromStrToInt){
        Console.Write("Введите число : ");
        string numberSTR = Console.ReadLine();
        
        if (int.TryParse(numberSTR, out int numberInt) ){
            number = numberInt;
            if (number > 7 || number < 1) Console.WriteLine("Нет такого дня недели, нужно было ввести от 1 до 7");
            else readlineFromStrToInt = false;
        }
        else Console.WriteLine("Ввели не число , повторите попытку");
    }
    return number;
}

int number = EnterNumberTest();

if (number == 7 || number == 6) Console.WriteLine($"{number} - > ДА! это выходной!");
else Console.WriteLine($"{number} - > Нет, ещё не выходной  ");


Console.Write("\n\n");

Console.ReadLine();