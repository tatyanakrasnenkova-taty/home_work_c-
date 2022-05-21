Console.Clear();

Console.WriteLine("Задача 2:\n Напишите программу, которая выводит случайное трёхзначное число\n и удаляет вторую цифру этого числа.");
Console.ReadLine();
Random rnd = new Random();

string numberSTR = Convert.ToString(rnd.Next(100,1000));
void writeNeededSymbols(string number,int firstCharPossition, int secondCharPossition){
    int i =0;
    Console.Write($"{number} - > ");
    foreach (char numberChar in number){
        if ((i == firstCharPossition-1) || (i == secondCharPossition-1)) Console.Write(numberChar);
        i++;
    }
}
writeNeededSymbols(numberSTR,1,3);

Console.ReadLine();