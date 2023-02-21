//Homework3

//Task1. Напишите программу, которая принимает на вход число 
//и проверяет, является ли оно палиндромом.

int NumberLength(long number)
{
  int length = 0;
  while(number>0)
  {
    number = number/10;
    length ++;
  }
  return length;
}

bool IsPalindrome(long number, int size)
{
  int index = 1;
  long degree = 1;
  while(index<size)
  {
   degree = degree*10;
   index++;
  }
  int count = 1;
  while(count <= size/2)
  {
    if (number%10 != number/degree)return false;
    number = (number%degree)/10;
    degree = degree/100;
    count++;
  }
  return true;
}

Console.Write("Input number: ");
long numberToWork = Convert.ToInt64(Console.ReadLine());
if(numberToWork<0)Console.WriteLine("Number must be positive");
else Console.WriteLine($"Your number is palindrome: {IsPalindrome(numberToWork,NumberLength(numberToWork))}");


//Task2. Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.

/*
double Distance(double x1, double y1, double z1, double x2, double y2, double z2)
{
  double X = x1 - x2;
  double Y = y1 - y2;
  double Z = z1 - z2;
  return Math.Sqrt(X*X + Y*Y + Z*Z);
}

Console.Write("Input first x: ");
double firstX = Convert.ToDouble(Console.ReadLine());
Console.Write("Input first y: ");
double firstY = Convert.ToDouble(Console.ReadLine());
Console.Write("Input first z: ");
double firstZ = Convert.ToDouble(Console.ReadLine());
Console.Write("Input second x: ");
double secondX = Convert.ToDouble(Console.ReadLine());
Console.Write("Input second y: ");
double secondY = Convert.ToDouble(Console.ReadLine());
Console.Write("Input second z: ");
double secondZ = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Distance between points is {Math.Round(Distance(firstX, firstY, firstZ, secondX, secondY, secondZ),2)}");
*/

//Task3. Напишите программу, которая принимает на вход число (N) и выдаёт 
//таблицу кубов чисел от 1 до N.

/*
void FindCube(int N)
{
  int count = 1;
  while (count <= N)
  {
    Console.WriteLine(count+" "+count*count*count);
    count++;
  }
}
Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number>0) FindCube(number);
else Console.Write("Number must be positive");
*/


