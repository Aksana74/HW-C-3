// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Опрделение расстояния между точкаи по координатам 3D;
//A(3,6,8)B (2,1,-7)>15.84
//A (7,-5,0); В (1,-1,9)>11.53
int x1 = ReadInt("Введите x первой точки");
int y1 = ReadInt("Введите y первой точки");
int z1 = ReadInt("Введите z первой точки");

int x2 = ReadInt ("Введите x второй точки");
int y2 = ReadInt ("Введите y второй точки");
int z2 = ReadInt ("Введите z второй точки");

Concole.WriteLine($"Расстояние точкой 1 и точкой 2 = {GetLine (x1,y1,z1,x2,y2,z2)}");

int ReadInt(string argument)
{
    Concole.Write($"Input {argument}:");

    int i;

    while (!int.TryParse(Concole.ReadLine(), out i))

{
    Concole.WriteLine("It s not a number");
}
return i;
}
    double GetLine (int x1,int y1,int z1,int x2,int y2,int z2)
{
        double Line = Math.Sqrt((Math.Pow(x1-x2,2)+ Math.Pow(y1-y2,2)+Math.Pow(z1-z2,2)));
        return Line;
}
