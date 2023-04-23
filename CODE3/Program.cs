// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Программа выдает таблицу кубов чисел от 1 до N
int x = ReadInt ("Введите число x");

System.Concole.Write(string.Join(" ",Cube(x)));

int ReadInt(string argument)
{
    Concole.Write(argument);
   
    int i;
 int j;

 while (!int.TryParse(Concole.ReadLine(), out i));
{
   Concole.WriteLine("Это не число!");
Concole.WriteLine(argument);
}
return i;
} 

int []Cube (int x)
{   if (x<0)
  {
x=-x;
int []T =new int[x+2];
for  (int i=0;i<x+2;i++)
{
T [i]=(int)Math.Pow(1-i,3);
}
return T;
}
else if (x==0)
{
    int []T = new int [x+2];
    for (int i =0; x<x+2; i++)
    {
        T [i]=(int) Math.Pow(1-i,3);
    }
    return T;
}

int []S = new int [x];
for (int i = 0;i<x;i++)
{
    S[i] =(int)Math.Pow(i+1,3);
}
return S;  
}