using System;

namespace ConsoleApp1
{
    class Program
    {
        #region 1
        static int productive(int n, int m, int x)
        {




            int[,] array = new int[n, m];
            Console.WriteLine("");
            Random r = new Random();

            for (int i = 0; i < n; i++)

            {
                for (int j = 0; j < m; j++)
                {

                    array[i, j] = r.Next(1, 10);
                    Console.Write($"{array[i, j]} ");




                }
                Console.WriteLine();
            }
            for (int i = 0; i < n; i++)

            {
                if (i == n / 2)
                    Console.Write($"{x}*|");
                else Console.Write($"{"  "}|");

                for (int j = 0; j < m; j++)
                {

                    Console.Write($"{array[i, j]} ");

                }

                if (i == n / 2)
                    Console.Write("|=");
                else Console.Write("|");


                Console.WriteLine();
            }


            Console.WriteLine();

            for (int i = 0; i < n; i++)

            {
                Console.Write($"{"  "}|");
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = x * array[i, j];
                    Console.Write($"{array[i, j]} ");

                }
                Console.Write("|");
                Console.WriteLine();
            }





            return 0;
        }
        static int Matrix_addition(int n, int m)
        {



            int[,] array1 = new int[n, m];
            int[,] array2 = new int[n, m];
            Console.WriteLine("");
            Random r = new Random();
            Console.WriteLine("m1");
            for (int i = 0; i < n; i++)

            {
                for (int j = 0; j < m; j++)
                {

                    array1[i, j] = r.Next(1, 10);
                    Console.Write($"{array1[i, j]}  ");




                }
                Console.WriteLine();
            }

            Console.WriteLine("m2");
            for (int i = 0; i < n; i++)

            {
                for (int j = 0; j < m; j++)
                {

                    array2[i, j] = r.Next(1, 10);
                    Console.Write($"{array2[i, j]}  ");




                }
                Console.WriteLine();
            }

            Console.WriteLine("m1+m2");

            for (int i = 0; i < n; i++)
            {
                Console.Write("|");
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{array1[i, j] + array2[i, j]}");

                }
                Console.Write("|");

                Console.WriteLine();
            }
            return 0;
        }

        static int Subtraction_matrices(int n, int m)
        {



            int[,] array1 = new int[n, m];
            int[,] array2 = new int[n, m];
            Console.WriteLine("");
            Random r = new Random();
            Console.WriteLine("m1");
            for (int i = 0; i < n; i++)

            {
                for (int j = 0; j < m; j++)
                {

                    array1[i, j] = r.Next(1, 10);
                    Console.Write($"{array1[i, j]}  ");




                }
                Console.WriteLine();
            }

            Console.WriteLine("m2");
            for (int i = 0; i < n; i++)

            {
                for (int j = 0; j < m; j++)
                {

                    array2[i, j] = r.Next(1, 10);
                    Console.Write($"{array2[i, j]}  ");




                }
                Console.WriteLine();
            }

            Console.WriteLine("m1-m2");

            for (int i = 0; i < n; i++)
            {
                Console.Write("|");
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{array1[i, j] - array2[i, j]}   ");

                }
                Console.Write("|");

                Console.WriteLine();
            }
            return 0;
        }
        static void Skylar_productive(int n1, int n2, int m1, int m2)
        {
            if (m1 != n2)
            { Console.WriteLine("Matrix multiplication not possible"); }
            else
            {
                int[,] array1 = new int[n1, m1];
                int[,] array2 = new int[n2, m2];
                int[,] array3 = new int[n1, m2];
                Console.WriteLine("");
                Random r = new Random();
                Console.WriteLine("m1");
                for (int i = 0; i < n1; i++)

                {
                    for (int j = 0; j < m1; j++)
                    {

                        array1[i, j] = r.Next(1, 10);
                        Console.Write($"{array1[i, j]}  ");




                    }
                    Console.WriteLine();
                }

                Console.WriteLine("m2");
                for (int i = 0; i < n2; i++)

                {
                    for (int j = 0; j < m2; j++)
                    {

                        array2[i, j] = r.Next(1, 10);
                        Console.Write($"{array2[i, j]}  ");




                    }
                    Console.WriteLine();
                }

                for (int i = 0; i < n1; i++)
                {
                    for (int j = 0; j < m2; j++)
                    {
                        array3[i, j] = 0;
                        for (int k = 0; k < m1; k++)
                        {
                            array3[i, j] += array1[i, k] * array2[k, j];
                        }
                    }
                }
                Console.WriteLine("The product of the two matrices is :");
                for (int i = 0; i < n1; i++)
                {
                    for (int j = 0; j < m2; j++)
                    {
                        Console.Write(array3[i, j] + "\t");
                    }
                    Console.WriteLine();


                }

            }

        }
        #endregion

        #region 2

        static void shortest_word(string text) {



            if (!string.IsNullOrEmpty(text))
            {
                var words = text.Split(' '); //

                var position = 0;
                for (var i = 0; i < words.Length; i++)
                {
                    var word = words[i];
                    if (word.Length < words[position].Length)
                    {
                        position = i;
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Is the shortest word in the text: {0} \n",
                                   words[position]);
                
            }
            else
            {
                Console.WriteLine("Text is empty!");
                Console.WriteLine();

            }



             }

        static void longest_word(string text)
        {

            if (!string.IsNullOrEmpty(text))
            {
                var words = text.Split(' '); //

                var position = 0;
                for (var i = 0; i < words.Length; i++)
                {
                    var word = words[i];
                    if (word.Length > words[position].Length)
                    {
                        position = i;
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Is the longest word in the text: {0} \n",
                                   words[position]);
                
            }
            else
            {
                Console.WriteLine("Text is empty!");
                Console.WriteLine();

            }
        }
        #endregion

        #region 3

        static string removeduplicat(char []text)
        {
            int index = 0;
            int j;
            for (int i = 0; i < text.Length; i++)
            { for ( j = 0; j < i; j++)
                {
                    if (text[i] == text[j])
                    {
                        break;
                    }
                }
                if (j == i)
                {
                    text[index++] = text[i];
                }
            }

            char[] newtext = new char[index];
            Array.Copy(text, newtext, index);
            return String.Join("", newtext);
            
        }
        #endregion

        #region 4
        static void Progressia( int[] Array)
        {

            double q = Array[1] / Convert.ToDouble(Array[0]);
            double d = Array[1]- Array[0];
            bool Arithmetic = true;
            bool Geometric = true;
            for (int i = 1; i < Array.Length - 1; i++)
            {

                if (Arithmetic == true)
                    if (Array[i + 1] - Array[i] != d)
                        Arithmetic = false;

                if (Geometric == true)
                    if (Array[i + 1] / Array[i] != q)
                        Geometric = false;

            }

            if (Geometric == true)
            { Console.WriteLine("The Sequence is an geometric progression"); }
            else if (Arithmetic == true)
            { Console.WriteLine("The sequence is an arithmetic progression"); }
            else
            { Console.WriteLine("Sequence is not arithmetic or geometric progression"); }


        }
        #endregion


        #region 5
        static int ackermann(int n, int m)
        {

            if (m == 0)
            {

                return n + 1;

            }
            else if ((m > 0) && (n == 0))
            {

                return ackermann(m - 1, n);

            }
            else if ((m > 0) && (n > 0))
            {

                return ackermann(m - 1, ackermann(m, n - 1));

            }
            else
            {

                return 0;

            }

        }
        #endregion
        static int  Main()
            {

            #region 1
            //Console.WriteLine("Number of lines:");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Number of columns:");
            //int m = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Number :");

            //  int x = Convert.ToInt32(Console.ReadLine());

            // productive(n, m, x);
            // Matrix_addition(n, m);
            //Subtraction_matrices(n, m);

            //Console.WriteLine("Number of rows in the first matrix:");
            //int n1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Number of columns of the first matrix:");
            //int m1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Number of rows in the second matrix:");
            //int n2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Number of columns in the second matrix:");
            //int m2 = Convert.ToInt32(Console.ReadLine());
            //Skylar_productive(n1, n2, m1, m2);

            #endregion

            #region 2
            //Console.Write("Enter the text");
            //Console.WriteLine();
            //var text = Console.ReadLine();
            //shortest_word(text);
            //longest_word(text);

            #endregion

            #region 3
            //Console.WriteLine("Number of array elements:");
            //int n = Convert.ToInt32(Console.ReadLine());

            //char[] text = new char[n];

            //for (int i = 0; i < text.Length; i++)
            //{
            //    text[i] = Convert.ToChar(Console.Read());

            //}

            //Console.WriteLine(removeduplicat(text));
            #endregion

            #region 4
            //  Console.WriteLine("Number of numbers:");
            //  int n = Convert.ToInt32(Console.ReadLine());
            //  int[] Numbers = new int[n];
            //  for (int i = 0; i < Numbers.Length; i++)
            //  { 
            //      Numbers[i]= Convert.ToInt32(Console.ReadLine());
            //  }
            //Progressia(Numbers);
            //  Console.ReadLine();
            #endregion

            #region 5
            //Console.Write("n=");
            
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine();
            //Console.Write("m=");
            //int m = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Result={ackermann(n, m)}");

            #endregion
            return 0;

            
            }
        }
    }



