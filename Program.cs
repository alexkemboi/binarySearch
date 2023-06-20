using System;
class Program
{
    static int findTerm(int[] arr,int target)
    {
        int left = 0;
        int right = arr.Length - 1;
        while (left <= right)
        {
            int mid = (left + right) / 2;
            if (arr[mid] == target)
            {
                return mid;

            }
            else if (arr[mid] > target)
            {
                right = mid - 1;
            }
            else 
            {
                left = mid + 1;
            }
        }
        return -1;
    }
    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
        int target = 7;
        int solution = findTerm(arr,target);
        if (solution !=-1)
        {
            Console.WriteLine($"The index of {target} is {solution}");
        }
        else
        {
            Console.WriteLine($"The index of {target} not found");
        }
    }
}