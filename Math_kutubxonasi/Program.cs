using Math_kutubxonasi;
internal class Program
{
    private static void Main(string[] args)
    {
        Math_lib obj = new Math_lib();
        Console.WriteLine("Kichik dasturimizga xush kelibsiz!\n");
        int n = 0;
        do
        {
            Console.WriteLine("Kerakli bo'limni tanlang:\n");
            Console.WriteLine(" 1 -> Tublikka tekshirish;\n\n 2 -> Fibonachi;\n\n 3 -> Daraja;\n\n 4 -> Mukammallikka tekshirish;\n\n 0 -> Tugatish;\n");
            n = Convert.ToInt32(Console.ReadLine());
            switch(n)
            {
                //Tub sonlar
                case 1 :
                    {
                        Console.WriteLine("Hi");
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
                            obj.Tub(isTub);
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
                                obj.Fibonachi(x, y);
                                break;
                            default:
                                Console.WriteLine(" Boshlang'ich qiymatlar va fibonachi sonlar sonini kiriting:");
                                string[] nums = Console.ReadLine().Split();
                                long a1 = Convert.ToInt64(nums[0]), a2 = Convert.ToInt64(nums[1]);
                                int count = Convert.ToInt32(nums[2]);
                                Console.WriteLine($"{a1} va {a2} bilan boshlanuvchi {count} ta fibonachi son:");
                                obj.Fibonachi(a1, a2, count);
                                break;
                        }
                        Console.ReadKey();
                        break;
                    }
                case 3: Console.WriteLine("Double: a va Int: n larni kiritng:");
                        string[] s = Console.ReadLine().Split();
                        double a = Convert.ToDouble(s[0]);
                        int N = Convert.ToInt32(s[1]);
                        Console.WriteLine($"\t{a} ^ {N} = {obj.Pow(a, N)}\n");
                        Console.ReadKey();
                        break;
                case 4:
                    Console.Write("\tTekshiriladigan sonni kiriting: ");
                    long check = Convert.ToInt64(Console.ReadLine());
                    Console.Write($" {check} soni mukammal son");
                    if (!obj.IsPerfect(check)) Console.Write(" emas");
                    Console.WriteLine();
                    Console.ReadKey();
                    break;
                 }
            Console.Clear();
        } while (n < 5 && n > 0);
    }
}