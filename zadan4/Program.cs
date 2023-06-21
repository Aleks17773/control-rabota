//Написать программу, которая из имеющегося массива строк формирует
//новый массив из строк, длина которых меньше, либо равна 3 символам.

string[] array1 = new string[] {"54,1", "78", "numbers", "мир"};
string[] array2 = new string[array1.Length];
void SecondArrayWithIF(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
   Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
}
SecondArrayWithIF(array1, array2);
PrintArray(array2);

