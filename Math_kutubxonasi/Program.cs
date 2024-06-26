﻿using Math_kutubxonasi;
internal class Program
{
    private static void Main(string[] args)
    {
        Linear_algebra obj = new Linear_algebra();
        Console.WriteLine("Kichik dasturimizga xush kelibsiz!\n");
        int n = 0;
        do
        {
            Console.WriteLine("Kerakli bo'limni tanlang:\n");
            Console.WriteLine(" 1 -> Tublikka tekshirish;\n\n 2 -> Fibonachi;\n\n 3 -> Daraja;\n\n 4 -> Mukammallikka tekshirish;\n\n 5 -> Matritsalarni qo'shish;\n\n 0 -> Tugatish;\n");
            n = Convert.ToInt32(Console.ReadLine());
            switch(n)
            {
                //Tub sonlar
                case 1 :
                    {
                        Console.Clear();
                        
                        Console.WriteLine("Kerakli bo'limni tanlang :\n1 - [1, N] oraliqdagi tub sonlarni chiqarish;\n2 - Kiritlgan sonni tublikka tekshirish; "); 
                        short chek = Convert.ToInt16(Console.ReadLine());
                        if(chek == 2)
                        {
                            Console.Write("Kerakli sonni kiriting : "); ;
                            long isTub = Convert.ToInt64(Console.ReadLine());
                        Console.Write("\tKiritilgan son tub");
                        if (!obj.IsTub(isTub)) Console.WriteLine(" emas\n");
                        }
                        else
                        {
                            Console.Write("Chegarani kiriting : ");
                            int isTub = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"[1, {isTub}] oraliqdagi tub sonlar :");
                            var tubNumbers = obj.Tub(isTub);
                            PrintList(tubNumbers);
                        }
                        Console.ReadKey();
                        break;
                    }
                    //Fibonachi
                case 2:
                    {
                        Console.Clear();
                        Console.WriteLine("\nKerakli bo'limni tanlang:\n\n 1 -> Kiritlgan son fibonachimi?\n\n 2 -> [a, b] oraliqdagi fibonachi sonlar;\n\n 3 -> a va b bilan boshlanuvchi N ta fibonachi sonlar;\n");
                        int amal = Convert.ToInt32(Console.ReadLine());
                        switch (amal)
                        {
                            case 1:
                                Console.Write(" Tekshiriladigan sonni kiriting: ");
                                long isFibonachi = Convert.ToInt64(Console.ReadLine());
                                Console.Write(" Kiritilgan son fibonachi son");
                                if (!obj.Fibonachi(isFibonachi)) Console.WriteLine(" emas");
                                break;
                            case 2:
                                Console.WriteLine(" Kerakli oraliqni kiriting: ");
                                string[] num = Console.ReadLine().Split();
                                long x = Convert.ToInt64(num[0]), y = Convert.ToInt64(num[1]);
                                Console.WriteLine($" [{x}, {y}] oraliqdagi fibonachi sonlar :\n");
                                var fibos = obj.Fibonachi(x, y);
                                PrintList(fibos);
                                break;
                            default:
                                Console.WriteLine(" Boshlang'ich qiymatlar va fibonachi sonlar sonini kiriting:");
                                string[] nums = Console.ReadLine().Split();
                                long a1 = Convert.ToInt64(nums[0]), a2 = Convert.ToInt64(nums[1]);
                                int count = Convert.ToInt32(nums[2]);
                                Console.WriteLine($"{a1} va {a2} bilan boshlanuvchi {count} ta fibonachi son:");
                                var fibs = obj.Fibonachi(a1, a2, count);
                                PrintList(fibs);
                                break;
                        }
                        break;
                    }
                case 3: Console.WriteLine("Double: a va Int: n larni kiritng:");
                        string[] s = Console.ReadLine().Split();
                        double a = Convert.ToDouble(s[0]);
                        int N = Convert.ToInt32(s[1]);
                        Console.WriteLine($"\t{a} ^ {N} = {obj.Pow(a, N)}\n");
                        break;
                case 4:
                    Console.Write("\tTekshiriladigan sonni kiriting: ");
                    long check = Convert.ToInt64(Console.ReadLine());
                    Console.Write($" {check} soni mukammal son");
                    if (!obj.IsPerfect(check)) Console.Write(" emas");
                    Console.WriteLine();
                    break;

                case 5:
                    Console.Clear();
                    Console.WriteLine(" Matritsalar o'lchamini kiriting: ");
                    string[] size = Console.ReadLine().Split();
                    int lines = int.Parse(size[0]), rows = int.Parse(size[1]);
                    Console.WriteLine(" 1 - matritsani kiriting:");
                    var firstMatrix = ScanMatrix(lines, rows);
                    Console.WriteLine(" 2 - matritsani kiriting:");
                    var secondMatrix = ScanMatrix(lines, rows);
                    Console.WriteLine("\n\nYig'indisi: ");
                    PrintMatrix(obj.AddMatrix(firstMatrix, secondMatrix));
                    break;
                 
            }
            if (n != 0) Console.ReadKey();
            Console.Clear();
        } while (n < 6 && n > 0);
    }
    static void PrintMatrix(double[,] matrix)
    {
        int n = matrix.GetLength(0), m = matrix.GetLength(1);
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine();
            for (int j = 0; j < m; j++)
                Console.Write(" " + matrix[i, j]);
        }
    }
    static double[,] ScanMatrix(int n, int m)
    {
        double[,]  matrix = new double[n, m];
        Console.WriteLine($" [{n}, {m}] o'lchamdagi matritsani kiriting:\n");
        string[] line;
        for (int i = 0; i < n; i ++)
        {
            line = Console.ReadLine().Split();
            for (int j = 0; j < m; j ++)
                matrix[i, j] = double.Parse(line[j]);
        }
        return matrix;
    }

    static void PrintList(List<long> ints)
    {
        foreach(int i in ints)
         Console.Write(" " + i); 
        Console.WriteLine('\n');
    }
}