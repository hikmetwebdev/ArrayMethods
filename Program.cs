//1

static void CustomSort(int[] arr)
{
    for (int i = 0; i < arr.Length-1; i++)
    {
        for (int j = 0; j < arr.Length-i-1; j++)
        {
            if (arr[j]>arr[j+1])
            {
                int temp = arr[j];
                arr[j] = arr[j+1];
                arr[j+1] = temp;
            }
        }
    }
}

int [] arr = {3,4,5,2,4,5,66,7,8,9};
CustomSort(arr);

foreach (var item in arr)
{
    Console.WriteLine(item);
}

//2

//static void StringMethod(string []array, char s)
//{
//    char chr = s;
//    foreach (var item in array)
//    {

//        if (ContainsCharacter(item, chr))
//        {
//            Console.WriteLine(item);
//        }
//    }

//}

//string[] array = { "adam", "heyvan", "masin" };
//char chr = 's';
//StringMethod(array,chr);

//static bool ContainsCharacter(string str, char character)
//{
//    foreach (char c in str)
//    {
//        if (c == character)
//        {
//            return true;
//        }
//    }
//    return false;
//}
 ///////////////////////////////////////////////////
//3

//int [] array = {1,2,4,5,6,7,8,9,10,11,12,13,14,15};
//static void CustomReverse(int[] arr)
//{
//    for (int i = arr.Length-1; i > 0; i--)
//    {
//        Console.WriteLine(i);
//    }
//}
//CustomReverse(array);