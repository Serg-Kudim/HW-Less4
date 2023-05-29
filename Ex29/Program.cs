// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int InputNumber()
{
    Console.Write("Enter the size of the array: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
void CreateArray(int[] arr)
{
    
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Enter the element of the array {i}: "); 
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    
}
void PrintArray(int[] arr){
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
int size = InputNumber();
int[] array = new int[size];
CreateArray(array);
PrintArray(array);