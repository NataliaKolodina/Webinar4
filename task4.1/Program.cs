// Напишите программу, которая выводит 2 массива из 8 элементов, заполненный нулями в случайном порядке, и складывает их.


Console.Clear();
int[] arr1 = new int[8];
int[] arr2 = new int[8];
int[] arr3 = new int[8];
RandomArray(arr1);
RandomArray(arr2);
SumArray(arr1, arr2, arr3);
PrintArray(arr3);

void RandomArray(int[] array)
{
    for (int i = 0; i < 8; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < 8; i++)
    {
        Console.Write(array[i] + ", ");
    }
}

void SumArray(int[] array1, int[] array2, int[] array3)
{
    for (int i = 0; i < 8; i++)
    {
        array3[i] = array1[i] + array2[i];
    }
}
