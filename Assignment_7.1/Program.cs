using System.Text;

namespace Assignment_7._1
{
    internal class Program
    {
        static void SelectionSort(int[] nums)
        {
            int minPos;

            for (int x = 0; x < nums.Length - 1; x++)
            {
                minPos = x;
                for (int y = x + 1; y < nums.Length; y++)
                {
                    if (nums[y] < nums[minPos])
                    {
                        minPos = y;
                    }
                }

                if (minPos != x)
                {
                    int temp = nums[minPos];
                    nums[minPos] = nums[x];
                    nums[x] = temp;
                }

            }

            

        }


        static int[] RandomNumbersArray()
        {
            Random random = new Random();
            int size = random.Next(5, 10);

            int[] array = new int[size];

            for (int i = 0; i < array.Length; i++)
            {
                int ran = random.Next(0, 101);

                while (array.Contains(ran))
                {
                    ran = random.Next(0, 100);
                }

                array[i] = ran;
            }

            return array;
        }

        static void PrintArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

        static void ExamScores()
        {
            int[] unsortedList = RandomNumbersArray();

            Console.Write("This is a Test Sorter that uses Selection Sorting!\nOriginal Test Score: ");
            PrintArray(unsortedList);

            SelectionSort(unsortedList);

            Console.Write("Sorted Test Scores: ");
            PrintArray(unsortedList);
        }

        static string Merge(string s1, string s2)
        {
            int larger = s1.Length > s2.Length ? s1.Length : s2.Length;

            StringBuilder sb = new StringBuilder();

            for (int x = 0, y = 0; x < larger; x++, y++)
            {
                if(x < s1.Length)
                {
                    sb.Append(s1[x]);
                }

                if (y < s2.Length)
                {
                    sb.Append(s2[y]);
                }
            }

            return sb.ToString();
        }

        static void Print()
        {
            ExamScores();

            string s1 = "abc", s2 = "pqr";

            Console.WriteLine($"\n\nThis is a string merger that merges two words!\nFirst String: {s1}\nSecond String: {s2}");
            string newString1 = Merge(s1, s2);
            Console.WriteLine($"Merged String: {newString1}");

            string s3 = "ab", s4 = "pqrs";

            Console.WriteLine($"\nFirst String: {s3}\nSecond String: {s4}");
            string newString2 = Merge(s3, s4);
            Console.WriteLine($"Merged String: {newString2}");

        }

        static void Main(string[] args)
        {
            Print();
        }
    }
}
