public class BinarySearch
{
    public static string Search(int []arr,int key)
    {
        int low=0;
        int high= arr.Length-1;
        
        while(low <= high)
        {
            int mid= (low+high)/2;
            if(arr[mid] == key)
                return mid.ToString();
            else if(key < arr[mid])
                high = mid-1;
            else
                low = mid+1;
        }
        return "Not Found !";
    }
}