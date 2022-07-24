Random random = new Random();
            string[] num;
            int[,] array;
            int sizerow = 4, sizecoll = 4, startVal = 0;
            /*Задайте двумерный массив. Напишите программу, которая упорядочит 
          по убыванию элементы каждой строки двумерного массива.
          Например, задан массив:*/
            int[,] CreateArray(int[,] arr,Random rand)
            {
                
                for(int i=0;i<arr.GetLength(0);i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                        arr[i, j] = rand.Next(0, 100);
                }
                    
                return arr;
            }
            void PrintArray(int[,] arr)
            {
                for(int i=0;i<arr.GetLength(0);i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                        Console.Write(arr[i, j] + "\t");
                    Console.WriteLine();
                }

            }
            int[,] SortArray(int[,] arr)
            {
                int value = 0;
                for(int i=0;i<arr.GetLength(0);i++)
                {
                    for(int j=0;j<arr.GetLength(1);j++)
                    {
                        for(int k=0;k<arr.GetLength(1);k++)
                        {
                            if(arr[i,j]>arr[i,k])
                            {
                                value = arr[i, j];
                                arr[i, j] = arr[i, k];
                                arr[i, k] = value;
                            }
                        }
                    }
                }
                return arr;
            }
            void FindMinSumArr(int[,] arr)
            {
                int sum=0,min,row=0;
                for (int i = 0; i < arr.GetLength(1); i++)
                    sum = sum + arr[0, i];
                for(int i=0;i<arr.GetLength(0);i++)
                {
                    min = 0;
                    for(int j=0;j<arr.GetLength(1);j++)
                    {
                        min += arr[i, j];
                    }
                    if(sum>min)
                    {
                        sum = min;
                        row = i;
                    }
                }
                Console.WriteLine("минимальная сумма элементов принадлежит строке " + row);
                for (int i = 0; i < arr.GetLength(1); i++)
                    Console.Write(arr[row, i] + "\t");
            }
            int[,] MultArray(int[,]arr1,int[,] arr2)
            {
                int[,] array3 = new int[arr1.GetLength(0), arr1.GetLength(1)];
                for(int i=0;i<array3.GetLength(0);i++)
                {
                    for (int j = 0; j < array3.GetLength(1); j++)
                        array3[i, j] = arr1[i, j] * arr2[j, i];
                }

                return array3;
            }
            bool Find(int[,,]arr, int x)
            {
               for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {

                        for (int k = 0; k < arr.GetLength(2); k++)
                        {
                            if (arr[i, j, k] == x)
                            {
                                return true;
                                
                            }

                        }
                    }
                }
                return false;
            }
            Console.WriteLine("программа сортирует двумерный массив по убыванию в каждой строке");
            Console.Write("введите количество строк и столбцов через запятую :");
            num = Console.ReadLine().Split(',');
            array = new int[int.Parse(num[0]), int.Parse(num[1])];
            PrintArray(CreateArray(array,random));
            SortArray(array);
            Console.WriteLine("\nотсортированный массив =");
            PrintArray(array);
            /*Задайте прямоугольный двумерный массив. 
             Напишите программу, которая будет находить строку с наименьшей суммой элементов.*/
            Console.WriteLine("найти в двумерном, прямоугольном массиве, строку с наименьшей суммой:");
            Console.WriteLine("введите размер массива через пробел: ");
            num = Console.ReadLine().Split(' ');
            int[,] MinSumArr = new int[int.Parse(num[0]), int.Parse(num[1])];
            CreateArray(MinSumArr,random);
            PrintArray(MinSumArr);
            FindMinSumArr(MinSumArr);
            /*Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.*/
            Console.WriteLine("\n найти произведение двух матриц");
            Console.Write("введите значение количества строк и колонок первого массива (строка=колонке): ");
            int rowAndcol1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("введите значение количества строк и колонок второго массива(строка=колонке): ");
            int rowAndcol2 = Convert.ToInt32(Console.ReadLine());
            if (rowAndcol1 != rowAndcol2)
                Console.WriteLine("выполнение операции невозможно, разные размеры массивов");
            else
            {
                int[,] arr1 = new int[rowAndcol1, rowAndcol1];
                int[,] arr2 = new int[rowAndcol2, rowAndcol2];
                CreateArray(arr1,random);
                CreateArray(arr2,random);
                PrintArray(arr1);
                Console.WriteLine();
                PrintArray(arr2);
                Console.WriteLine();
                PrintArray(MultArray(arr1, arr2));

            }
            /*Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
            Напишите программу, которая будет построчно выводить массив, 
            добавляя индексы каждого элемента. массив размером 2 x 2 x 2*/
            Console.WriteLine("задать трехмерный массив размером 2х2х2, вывести построчно с индексом");
            int[,,] arr_x_3 = new int[2, 2, 2];
            int un_num;
            for(int i=0;i<arr_x_3.GetLength(0);i++)
            {
                for(int j=0;j<arr_x_3.GetLength(1);j++)
                {
                    for (int k = 0; k < arr_x_3.GetLength(2);)
                    {
                        un_num = random.Next(0, 9);
                        if (Find(arr_x_3, un_num))
                            continue;
                        arr_x_3[i, j, k] = un_num;
                        k++;
                    }
                }
            }
            for(int i=0;i<arr_x_3.GetLength(0);i++)
            {
                for(int j=0;j<arr_x_3.GetLength(1);j++)
                {
                   for(int k=0;k<arr_x_3.GetLength(2);k++)
                    {
                        Console.Write("строка "+i+" "+j+" "+k+" = "+arr_x_3[i,j,k]+"\t");

                    }
                    Console.WriteLine();
                }
                //Console.WriteLine();
            }
            /*Заполните спирально массив 4 на 4.*/
            Console.WriteLine("массив 4х4 по спирали");
            int[,] circleArr = new int[sizerow, sizecoll];
            for (int i = 0; i < circleArr.GetLength(1); i++)
            {
                startVal++;
                circleArr[0, i] = startVal;
                
            }
            for(int i=0;i<circleArr.GetLength(0);i++)
            {
                circleArr[i, circleArr.GetLength(1) - 1] = startVal;
                startVal++;
            }
            for(int i=circleArr.GetLength(1)-2;i>=0; i--)
            {
                circleArr[circleArr.GetLength(0) - 1, i] = startVal;
                startVal++;
            }
            for(int i=circleArr.GetLength(0)-2;i>0;i--)
            {
                circleArr[i, 0] = startVal;
                startVal++;
            }
            for (int a = 1, b = 1; startVal < circleArr.GetLength(0) * circleArr.GetLength(1);)
            {
                while (circleArr[a, b + 1] == 0)
                {
                    circleArr[a, b] = startVal;
                    startVal++;
                    b++;
                }
                while (circleArr[a + 1, b] == 0)
                {
                    circleArr[a, b] = startVal;
                    startVal++;
                    a++;
                }
                while (circleArr[a, b - 1] == 0)
                {
                    circleArr[a, b] = startVal;
                    startVal++;
                    b--;
                }
                while (circleArr[a - 1, b] == 0)
                {
                    circleArr[a, b] = startVal;
                    startVal++;
                    a--;
                }
            }
            for (int x = 0; x < circleArr.GetLength(0); x++)
            {
                for (int y = 0; y < circleArr.GetLength(1); y++)
                {
                    if (circleArr[x, y] == 0)
                    {
                        circleArr[x, y] = startVal;
                    }
                }
            }
            for (int x = 0; x < circleArr.GetLength(0); x++)
            {
                for (int y = 0; y < circleArr.GetLength(1); y++)
                {
                    if (circleArr[x, y] < 10)
                    {
                        Console.Write(circleArr[x, y] + ",  ");
                    }
                    else
                    {
                        Console.Write(circleArr[x, y] + ", ");
                    }
                }
                Console.WriteLine("");
            }
            Console.WriteLine("простой вариант: ");
            int[,] cir2 = new int[,]
            {
                {1,2,3,4 },
                {12,13,14,5 },
                {11,16,15,6 },
                {10,9,8,7 }
            };
            for(int i=0;i<cir2.GetLength(0);i++)
            {
                for (int j = 0; j < cir2.GetLength(1); j++)
                    Console.Write(cir2[i, j] + "\t");
                Console.WriteLine();
            }


            Console.ReadKey();

