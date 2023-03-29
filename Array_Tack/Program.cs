namespace Array_Tack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 4, 5, 6, 7 };
            InsertArray(ref arr, 1, 2, 3);
            foreach (var num in arr)
            {
                Console.WriteLine(num);
            }
        }
        public static void InsertArray(ref int[] array, params int[] nums)
        {
            int[] newArray = new int[array.Length + nums.Length];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            for (int i = 0; i < nums.Length; i++)
            {
                newArray[array.Length + i] = nums[i];
            }
            array = newArray;
        }
    }
}