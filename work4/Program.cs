Console.WriteLine("Введите число: ");
int C = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= C; i++)
{
    if(i % 2 == 0)
    {
        Console.WriteLine(i);
    }
    
}