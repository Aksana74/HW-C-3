// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Напитшите программу которая принимает на входе пятизначное число и проверяет, 
//является ли оно палиндромом.
int x =  ReadInt ("Введите число -");

if (IsPalindrom(M(x)));
{
System.Console.WriteLine("Палиндром");
};
else
{
 System.Console.WriteLine("Не Палиндром");
}
int ReadInt (string argument)
{
    Console.Write(argument);
    int i;
    while ( !int.TryParse(Console.ReadLine(),out i))
{
   Console.WriteLine("Это не число!");
   Console.WriteLine(argument);
   
   }
   return i;
}
    int [] M(int x)
   {
string str =x.ToString();
int [] S= new int [str.Length];
for (int i=0; i< str.Length;i++)
{
    S[i] = int.Parse(str[i].ToString());

}
return S;
}
bool IsPalindrom (int[]S)
{
int i=0;
int k =S.Length -1;
while (i<k)
{
if (S[i]==S[k])
{
    i++;
    k--;

}
else
{
 return false;

}
}
return true;
}

