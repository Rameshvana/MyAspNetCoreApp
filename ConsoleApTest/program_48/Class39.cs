namespace program_48
{
    public class Class39
    {
        public int CountDublicateArray(int[] arr)
        {
            int[] arr1 = { 1, 2, 3, 2, 4, 5, 1, 5 };

            int[] emtyArray = new int[5];
            List<int> num = new List<int>();

            int dublicate_values_count = 0;

            foreach (var item in arr)
            {
                if (!num.Contains(item))
                {
                    num.Add(item);
                }
            }

            foreach (var i in num)
            {
                int count = 0;
                foreach (var item in arr)
                {
                    if (i == item)
                    {
                        count++;
                    }
                }

                if (count >= 2)
                {
                    //Console.WriteLine($"the value {i} repeted {count} times");
                    dublicate_values_count++;
                }
            }
           return dublicate_values_count;
        }

    }


}
