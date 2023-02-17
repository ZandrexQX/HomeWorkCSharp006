Console.Clear();
Console.WriteLine("Task 41");
Console.WriteLine("------");

int[] inputArray = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

Console.WriteLine($"Массив: [{string.Join(", ", inputArray)}]");

int ReleaseArray1(int[] array)
{
  int count = 0;
  foreach (int item in array)
  {
    if (item > 0) count++;
  }
  return count;
}

Console.WriteLine($"Чисел больше ноля: {ReleaseArray1(inputArray)}");

Console.ReadLine();

/*--------------------------------------------*/

Console.Clear();
Console.WriteLine("Task 43");
Console.WriteLine("------");

Console.Write("Введите b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

if (k1 == k2) Console.WriteLine("Не пересекаются");
else{
  double x = (b2-b1)/(k1-k2);
  double y = k1*x+b1;
  Console.WriteLine($"X = {Math.Round(x,2)}, Y = {Math.Round(y,2)}");
}

Console.ReadLine();

/*--------------------------------------------*/

Console.Clear();
Console.WriteLine("Task add 1");
Console.WriteLine("------");

char[] strArray = Console.ReadLine().ToCharArray();
Console.WriteLine("------");
string result = "";
Comb(strArray,result,strArray.Length);

void Comb(char[] array,string str, int n){
    foreach (var i in array)
    {
        string a = str;
        if(a.Length == array.Length) Console.WriteLine(a);
        if (n==0) return;
        if (!str.Contains(i)) a += i;
        Comb(array,a,n-1);
    }
}


Console.ReadLine();

/*--------------------------------------------*/

Console.Clear();
Console.WriteLine("Task add 2");
Console.WriteLine("------");

Console.Write("Введите x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите x3: ");
double x3 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y3: ");
double y3 = Convert.ToDouble(Console.ReadLine());

double a = Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2));
double b = Math.Sqrt((x3-x2)*(x3-x2)+(y2-y3)*(y2-y3));
double c = Math.Sqrt((x3-x1)*(x3-x1)+(y1-y3)*(y1-y3));

double s = (Math.Sqrt(Math.Pow((a*a+b*b+c*c),2)
            -2*(Math.Pow(a,4)+Math.Pow(b,4)+Math.Pow(c,4))))/4;

Console.WriteLine($"Площадь треугольника равна: {Math.Round(s,2)}");

Console.ReadLine();

/*--------------------------------------------*/