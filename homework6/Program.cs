namespace homework6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1


            //static int Power(int num, int power)
            //{
            //    int result = 1;

            //    for (int i = 0; i < power; i++)
            //    {
            //        result *= num;
            //    }

            //    return result;
            //}

            //Console.Write("Enter first numbet: ");
            //int num = int.Parse(Console.ReadLine());

            //Console.Write("Enter secon: ");
            //int power = int.Parse(Console.ReadLine());

            //Console.WriteLine($"{num} xarisxad {power} aris {Power(num, power)}");

            //2

            //static bool IsPrime(int num)
            //{
            //    if (num < 2)
            //        return false;

            //    for (int i = 2; i < num; i++)
            //    {
            //        if (num % i == 0)
            //            return false;
            //    }

            //    return true;
            //}

            //Console.Write("Enter number: ");
            //int num = int.Parse(Console.ReadLine());

            //if (IsPrime(num))
            //    Console.WriteLine($"{num} martivi ricxvia");
            //else
            //    Console.WriteLine($"{num} ar aris martivi ricxvi");

            //3

            //static bool IsPalindrome(string text)
            //{
            //    if (text.Length <= 1)
            //        return true;

            //    if (text[0] != text[text.Length - 1])
            //        return false;

            //    return IsPalindrome(text.Substring(1, text.Length - 2));
            //}

            //Console.Write("sheiyvane teqsti : ");
            //string text = Console.ReadLine();

            //if (IsPalindrome(text))
            //    Console.WriteLine($"{text} is palendrom");
            //else
            //    Console.WriteLine($"{text} is not palendrom");


            //4

            //?



            //5

            //static int PowerRecursive(int num, int power)
            //{
            //    if (power == 0)
            //        return 1;

            //    return num * PowerRecursive(num, power - 1);
            //}

            //Console.Write("enter number: ");
            //int num = int.Parse(Console.ReadLine());

            //Console.Write("sheiyvane xarisxi: ");
            //int power = int.Parse(Console.ReadLine());

            //Console.WriteLine($"{num}  xarisxad {power} aris: {PowerRecursive(num, power)}");
        }
    }
}
