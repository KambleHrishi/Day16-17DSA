namespace AlgorithmPrograms
{
    public class Program
    {
        public static void Main(string[]args)
        {
            int[] arr = new int[5] { 23, 9, 85, 12, 99 };
            int n = 5, i, j, val, flag;
            Console.WriteLine("Insertion Sort");
            Console.WriteLine("Initial array is: ");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
            for (i = 1; i < n; i++)
            {
                val = arr[i];
                flag = 0;
                for (j = i - 1; j >= 0 && flag != 1;)
                {
                    if (val < arr[j])
                    {
                        arr[j + 1] = arr[j];
                        j--;
                        arr[j + 1] = val;
                    }
                    else flag = 1;
                }
            }
            Console.WriteLine(" \nSorted Array is: ");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
        }
    }
}
