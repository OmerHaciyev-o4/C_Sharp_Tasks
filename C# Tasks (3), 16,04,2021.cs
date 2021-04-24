#region Task1
//Random random = new Random();
//int[] arr = new int[10];
//for (int i = 0; i < arr.Length; i++)
//{
//    arr[i] = random.Next(5);
//}

//for (int i = 0; i < arr.Length; i++)
//{
//    Console.Write(arr[i] + " ");
//}
//Console.WriteLine();

//int temp = 0;

//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] == 0)
//    {
//        for (int j = i; j < arr.Length - 1; j++)
//        {
//            temp = arr[j];
//            arr[j] = arr[j + 1];
//            arr[j + 1] = temp;
//            temp = 0;
//        }
//    }
//}
//for (int i = 0; i < arr.Length; i++)
//{
//    Console.Write(arr[i] + " ");
//}
//Console.WriteLine();

//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] == 0)
//    {
//        arr[i] = -1;
//    }
//}

//for (int i = 0; i < arr.Length; i++)
//{
//    Console.Write(arr[i] + " ");
//}
//Console.WriteLine();
#endregion

#region Task2
//Random random = new Random();
//int[] arr = new int[10];

//for (int i = 0; i < arr.Length; i++)
//{
//    arr[i] = random.Next(-10, 11);
//}

//for (int i = 0; i < arr.Length; i++)
//{
//    Console.Write(arr[i] + " ");
//}
//Console.WriteLine();

//int temp = 0;

//for (int i = 0; i < arr.Length; i++)
//{
//    for (int j = 0; j < arr.Length - 1; j++)
//    {
//        if (arr[j] > 0 && arr[j+1] < 0)
//        {
//            temp = arr[j];
//            arr[j] = arr[j + 1];
//            arr[j + 1] = temp;
//            temp = 0;
//        }
//        else if (arr[j] == 0)
//        {
//            for (int l = j; l < arr.Length - 1; l++)
//            {
//                temp = arr[l];
//                arr[l] = arr[l + 1];
//                arr[l + 1] = temp;
//                temp = 0;
//            }
//        }
//    }
//}

//for (int i = 0; i < arr.Length; i++)
//{
//    Console.Write(arr[i] + " ");
//}
//Console.WriteLine();
#endregion

#region Task3
//Random random = new Random();
//
//int[] arr = new int[10];
//
//for (int i = 0; i < arr.Length; i++)
//{
//    arr[i] = random.Next(5);
//}
//
//for (int i = 0; i < arr.Length; i++)
//{
//    Console.Write(arr[i] + " ");
//}
//Console.WriteLine();
//
//int number = Convert.ToInt32(Console.ReadLine());
//
//int count = 0;
//
//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] == number) { count++; }
//}
//
//if (count == 0)
//{
//    Console.WriteLine("The number you entered was not found inside the array.");
//}
//else
//{
//    Console.WriteLine("Inside the array of the number you entered " + count + " found.");
//}
#endregion

#region Task4
//Random random = new Random();
//
//int[][] arr = new int[10][];
//for (int i = 0; i < arr.Length; i++)
//{
//    arr[i] = new int[6];
//}
//
//for (int i = 0; i < arr.Length; i++)
//{
//    for (int j = 0; j < arr[i].Length; j++)
//    {
//        arr[i][j] = random.Next(0, 100);
//        Console.Write(arr[i][j] + "\t");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine();
//
//Console.Write("Enter the first column to be called: ");
//int number = Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter the second column to be called: ");
//int number1 = Convert.ToInt32(Console.ReadLine());
//
//int[] temp = new int[10];
//for (int i = 0; i < 10; i++)
//{
//    temp[i] = arr[i][number];
//}
//int c = 0;
//for (int i = 0; i < 10; i++)
//{
//    for (int j = 0; j < arr[i].Length; j++)
//    {
//        if (j == number)
//        {
//            arr[i][j] = arr[i][number1];
//            arr[i][number1] = temp[c];
//            c++;
//        }
//    }
//}
//
//
//for (int i = 0; i < arr.Length; i++)
//{
//    for (int j = 0; j < arr[i].Length; j++)
//    {
//        Console.Write(arr[i][j] + "\t");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine();
#endregion