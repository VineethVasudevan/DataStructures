public class SelectionSort
{
    public static void Sort(int []arr)
    {
        for(int i=0;i < arr.Length -1; i++)
        {
            for(int j= i+1; j< arr.Length; j++)
            {
                if(arr[j] < arr[i])
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }  
            }
        }

        foreach(int e in arr)
        {
            System.Console.WriteLine(e);
        }
    }

}