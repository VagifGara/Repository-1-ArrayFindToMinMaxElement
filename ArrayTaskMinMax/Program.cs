namespace ArrayTaskMinMax
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Arrayin elementlerini daxil edin:");
           int [] arr= new int[5];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine( $"Arrayinn en kicik elementi :{MinElement(arr)}");
            Console.WriteLine($"Arrayinn en boyuk elementi :{MaxElement(arr)}");
        }


        public static int MinElement(int [] arr)
        {
            

            int min = arr[0];

            for (int i = 0; i <arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }
            return min;
        }

        public static int MaxElement(int[] arr)
        {
            int max= arr[arr.Length - 1];

            for (int i = 0;  i <arr.Length;  i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            return max;
        }
    }
}