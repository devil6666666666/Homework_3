// Принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
string s = Convert.ToString(number);
if(s.Length != 5)
{
    Console.WriteLine("Это не пятизначное число!");
    return;
}
char [] ar = s.ToCharArray();
if (ar[0] == ar[4] && ar[1] == ar[3])
{
    Console.WriteLine("Введенное число является палиндромом");
}
else Console.WriteLine("Введенное число не является палиндромом");