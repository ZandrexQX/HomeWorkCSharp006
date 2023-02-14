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