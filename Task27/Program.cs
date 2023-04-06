/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12*/

int Read(string number)
{
  int n = 0;
  System.Console.WriteLine($"Введите {number}: ");
  while(!int.TryParse(System.Console.ReadLine(), out n))
  {
    System.Console.WriteLine("Это не число!");
  }
  return n;
}

int Main()
{
  int number = Read("число");
  int sum = 0;
  while(number>0)
  {
    sum = sum + number % 10;
    number = number / 10;
  }
  return sum;
}
void Answer()
{
  int x = Main();
  System.Console.WriteLine($"Сумма всех цифр числа равняется: {x}");
}

Answer();