bool triangle(int a, int b, int c)
{
  if (a < b + c && b < a + c && c < a + b)
  {
    return true;
  }
  else
  {
    return false;
  }
}


System.Console.Write("Введите сторону А ");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите сторону B ");
int b = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите сторону C ");
int c = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(triangle(a, b, c));