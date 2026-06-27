namespace homework5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            //            int[][] students =
            //{
            //                new int[] { 90, 85, 100 },
            //                new int[] { 70, 80 },
            //                new int[] { 95, 88, 92, 100 }
            //            };

            //            for (int i = 0; i < students.Length; i++)
            //            {
            //                int sum = 0;

            //                for (int j = 0; j < students[i].Length; j++)
            //                {
            //                    sum += students[i][j];
            //                }

            //                double average = (double)sum / students[i].Length;

            //                Console.WriteLine($"Student {i + 1}: {average}");

            //            }



            //2

            //Random random = new Random();
            //int[] passcodes = new int[10];

            //for (int i = 0; i < passcodes.Length; i++)
            //{
            //    passcodes[i] = random.Next(1000, 10000);
            //}

            //Console.Write("Enter passcode: ");
            //int userCode = int.Parse(Console.ReadLine());

            //bool found = false;

            //for (int i = 0; i < passcodes.Length; i++)
            //{
            //    if (passcodes[i] == userCode)
            //    {
            //        found = true;
            //        break;
            //    }
            //}

            //if (found)
            //{
            //    Console.WriteLine("Correct");
            //}
            //else
            //{
            //    Console.WriteLine("Wrong");
            //}



            //3


            //int[] numbers = { -5, 12, 8, -20, 30, 7 };

            //int min = numbers[0];
            //int max = numbers[0];

            //for (int i = 1; i < numbers.Length; i++)
            //{
            //    if (numbers[i] < min)
            //    {
            //        min = numbers[i];
            //    }

            //    if (numbers[i] > max)
            //    {
            //        max = numbers[i];
            //    }
            //}

            //Console.WriteLine("Min: " + min);
            //Console.WriteLine("Max: " + max);



            //4

            //string[] words = { "Hello", "it", "CSharp" };

            //for (int i = 0; i < words.Length; i++)
            //{
            //    for (int j = 0; j < words[i].Length; j++)
            //    {
            //        Console.WriteLine(words[i][j]);
            //    }
            //}

            //5

//            string[] emails =
//{
//    "user@gmail.com",
//    "testmail.com",
//    "admin@yahoo.com"
//};

//            for (int i = 0; i < emails.Length; i++)
//            {
//                bool hasAt = false;

//                for (int j = 0; j < emails[i].Length; j++)
//                {
//                    if (emails[i][j] == '@')
//                    {
//                        hasAt = true;
//                        break;
//                    }
//                }

//                Console.WriteLine(emails[i] + " = " + hasAt);
//            }

        }
    }
}
