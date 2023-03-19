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
 
 int[] arr = new int[12];
 int k = 0, sum = 0;
 Random rnd = new Random();
 
 Console.WriteLine("Исходный массив");
 for (int i = 0; i < 12; i++)
 {
     arr[i] = rnd.Next(-50, 50);
     Console.Write("{0} ", arr[i]);
 }
 Console.WriteLine();
 Console.WriteLine("Отсортированный массив ");
 Array.Sort(arr);
 
 foreach(int element in arr)
 {
      Console.Write("{0} ", element);
     if (element % 2 == 0)
     {
         k++;
         sum += element;
     }
 }
 Console.WriteLine();
 Console.WriteLine("Количество четных элементов {0}, сумма четных элементов {1}", k, sum);