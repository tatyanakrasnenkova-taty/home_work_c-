Console.WriteLine("Введите первое число ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число ");
int C = Convert.ToInt32(Console.ReadLine());

if (A > B && A > C)
{
    Console.WriteLine("Первое число максимальное");
}
if (B > C && B > A)
{
    Console.WriteLine("Второе число максимальное");
}
else
{   
    Console.WriteLine("Третье число максимальное");
}
