class Program
{
    static void Main(string[] args)
    {
        // тип [] название массива
        // int [] numbers = new int[4] {1,1,23,4};

        // int[] nums1 = new int[] {1,23,4,5};
        // int[] nims2 = new[] {1,23,4,5};
        int[] nums3 = {1,2,3,45,43,2,234,1,412,4,21,214,12,4,214,12,34};
        for(int i = 1; i < nums3.Length; i++)
        {
            nums3[i] = 0;
            Console.WriteLine(nums3[i]);
        }
    }        
}