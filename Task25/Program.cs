/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в 
натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16*/

int Read(string number)
{
  System.Console.WriteLine($"Введите число {number}: ");
  int num = 0;
  while(!int.TryParse(System.Console.ReadLine(), out num))
  {
    System.Console.WriteLine("Is not a number!");
  }
  return num;
}

int Main()
{
  int a = Read("a");
  int b = Read("b");
  int result = 1;
  for(int i = 0; i < b; i++)
  {
    result = result * a;
  }
  return result;
}

void Answer()
{
  int res = Main();
  System.Console.WriteLine($"Полученное число = {res}");
}

Answer();