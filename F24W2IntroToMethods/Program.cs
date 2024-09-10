namespace F24W2IntroToMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 5;
            string str = "hello";
            int[] arr = { 3, 1, 4, 6, 7, 5, 8 };

            Console.WriteLine("Before changes:\n");
            Console.WriteLine("num = " + num);
            Console.WriteLine("str = " + str);
            Console.WriteLine("arr[0] = " + arr[0]);

            ChangeValue(ref num, str, arr);

            Console.WriteLine("\n\nAfter changes:\n");
            Console.WriteLine("num = " + num);
            Console.WriteLine("str = " + str);
            Console.WriteLine("arr[0] = " + arr[0]);

            Console.WriteLine("\n\n");


            int a = 4, b = 6;
            //int sum, mul;
            Calculate(a, b, out int sum, out int mul);

            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Mul = " + mul);

            Console.WriteLine("\n\n");



            Console.WriteLine("a = " + a + " b = " + b);
            Console.WriteLine($"a = {a} b = {b}");
            Console.WriteLine("a = {0} b = {1}", a, b);

            Console.WriteLine("\n\n");


            PrintArray(arr);
            PrintArray(4, 3, 4, 5, 65, 76, 8, 76, 5, 4, 3, 32, 65);
        }

        static void PrintArray(params int[] a)
        {
            Console.WriteLine("\nNumber of items: " + a.Length);

            foreach (int i in a)
                Console.Write(i + " ");
            Console.WriteLine();
        }


        static void Calculate(int x, int y, out int sum, out int mul)
        {
            sum = x + y;
            mul = x * y;
        }


        static void ChangeValue(ref int n, string s, int[] a)
        {
            n = n + 100;
            s = "bye";
            a[0] = 100;
        }
    }
}
