// Console.Clear();
// Console.WriteLine("Task 41");
// Console.WriteLine("------");

// int[] inputArray = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

// Console.WriteLine($"Массив: [{string.Join(", ", inputArray)}]");

// int ReleaseArray1(int[] array)
// {
//   int count = 0;
//   foreach (int item in array)
//   {
//     if (item > 0) count++;
//   }
//   return count;
// }

// Console.WriteLine($"Чисел больше ноля: {ReleaseArray1(inputArray)}");

// Console.ReadLine();

// /*--------------------------------------------*/

// Console.Clear();
// Console.WriteLine("Task 43");
// Console.WriteLine("------");

// Console.Write("Введите b1: ");
// double b1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите k1: ");
// double k1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите b2: ");
// double b2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите k2: ");
// double k2 = Convert.ToInt32(Console.ReadLine());

// if (k1 == k2) Console.WriteLine("Не пересекаются");
// else{
//   double x = (b2-b1)/(k1-k2);
//   double y = k1*x+b1;
//   Console.WriteLine($"X = {Math.Round(x,2)}, Y = {Math.Round(y,2)}");
// }

// Console.ReadLine();

// /*--------------------------------------------*/

Console.Clear();
Console.WriteLine("Task add 1");
Console.WriteLine("------");

string enter = Console.ReadLine();

char[] strArray = enter.ToCharArray();
char[] strArrayWork = enter.ToCharArray();
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
