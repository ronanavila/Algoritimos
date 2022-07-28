namespace Algoritimos;

public static class SumTwoNumbers
{
    //CPU/TEMPO O(n^2) MEM O(1)
    public static int[] SumFor(int[] array, int number)
    {
        if (array == null) return new int[0];

        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                var first = array[i];
                var second = array[j];

                if (first + second == number)
                    return new int[] { first, second };
            }
        }
        return new int[0];
    }

    //MEMO CACHING
    //CPU/TEMPO O(n) MEM O(n)
    public static int[] SumMemo(int[] array, int number)
    {
        if (array == null) return new int[0];

        var memo = new HashSet<int>();

        for (int i = 0; i < array.Length - 1; i++)
        {
            var first = array[i];
            var second = number - first;

            if (memo.Contains(second))
                return new int[] { first, second };

            memo.Add(first);
        }
        return new int[0];
    }


    //Sliding Window
    //CPU/TEMPO O(n log n) MEM O(1)
    public static int[] SumSlide(int[] array, int number)
    {
        if (array == null) return new int[0];

        Array.Sort(array);

        var first = 0;
        var last = array.Length - 1;

        while (first < last)
        {
            var sum = array[first] + array[last];

            if (sum == number)
                return new int[] { array[first], array[last] };

            if (sum < number)
                first++;
            if(sum > number)
                last--;
        }
        return new int[0];
    }
}
