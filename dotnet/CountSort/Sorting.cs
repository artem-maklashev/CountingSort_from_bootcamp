public static class Sorting
{
    public static int[] SortCounting(this int[] collection)
    {
        int max = collection[0];
        for (int i = 1; i < collection.Length; i++)
        {
            if (collection[i] > max) max = collection[i];
        }
        int[] countArr = new int[max + 1];
        foreach (int item in collection)
        {
            countArr[item]++;
        }
        
        int index = 0;
        for (int j = 0; j < countArr.Length; j++)
        {
            for (int k = 0; k < countArr[j]; k++)
            {
                collection[index++] = j;
            }
        }
        return collection;
    }
}