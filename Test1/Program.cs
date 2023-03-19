// Задача 38
// double[] NewArray (int size, int min, int max)
//  {
//      double[] arr = new double[size];
//      for (int i = 0; i < size; i++)
//      {
//          arr[i] = Math.Round(new Random().NextDouble() *100, 2);
//      }
//      return arr;
//  }

//  double [] doubleArray = NewArray (5,0,1);
//  Console.WriteLine ($"массив вещественных чисел: [{String.Join("; ", doubleArray)}]");

//  double minValue = doubleArray[0];
//  double maxValue = doubleArray[0];

//  for (int i = 0; i < doubleArray.Length; i++)
//  {
//      if (minValue > doubleArray[i])
//      {
//          minValue = doubleArray[i];
//      }
//      else if (doubleArray[i] > maxValue)
//      {
//          maxValue = doubleArray[i];
//      }
//  }
//  Console.WriteLine ($"Минимальное число в массиве: {minValue}"); 

//  Console.WriteLine ($"Максимальное число в массиве: {maxValue}");     

//  double differentNumber = 0;

//  Console.WriteLine ($"Разница максимального и минимального: {differentNumber = maxValue - minValue}");


// Задача 34
 
// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// FillArrayRandomNumbers(numbers);
// Console.WriteLine("Наш массив: ");
// PrintArray(numbers);
// int count = 0;

// for (int j = 0; j < numbers.Length; j++)
// if (numbers[j] % 2 == 0)
// count++;

// Console.WriteLine($"{count} четных чисел");

// void FillArrayRandomNumbers(int[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] = new Random().Next(100,1000);
//     }
// }
// void PrintArray(int[] numbers)
// {
//     Console.Write("[ ");
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         Console.Write(numbers[i] + " ");
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }


// Задача 38
// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// double[] numbers = new double[size];
// FillArrayRandomNumbers(numbers);
// Console.WriteLine(" Наш массив: ");
// PrintArray(numbers);
// double min = Int32.MaxValue;
// double max = Int32.MinValue;

// for (int k = 0; k < numbers.Length; k++)
// {
//     if (numbers[k] > max)
//         {
//             max = numbers[k];
//         }
//     if (numbers[k] < min)
//         {
//             min = numbers[k];
//         }
// }

// Console.WriteLine($"Максимальное значение = {max}, минимальное значение = {min}");
// Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

// void FillArrayRandomNumbers(double[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
//         }
// }
// void PrintArray(double[] numbers)
// {
//     Console.Write("[ ");
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             Console.Write(numbers[i] + " ");
//         }
//     Console.Write("]");
//     Console.WriteLine();
// }