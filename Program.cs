// Написать программу, которая из имеющегося массива строк формирует массив строк, 
// длина которых меньше или равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомедуеться пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

internal class NewBaseType
{
    private static void Main(string[] args) //метод создает массив с клавиатуры через  Enter.
    {
        Console.Write("Введите размерность массива:\t "); // колливество элементов в массиве
        int countArray = int.Parse(Console.ReadLine());
        string[] myArray = new string[countArray];


        for (int i = 0; i < myArray.Length; i++)
        {
            Console.Write($"\nВведите элемент массива под номером {i + 1}:\t ");
            myArray[i] = Console.ReadLine();
        }

        Console.WriteLine("\nВывод массива: ");
        Console.WriteLine(string.Join(" ", myArray));
        
        SortedArray(myArray);
    }

    static void SortedArray(string[] myArray) //метод для сортировки массива
    {
        var newArray = new string[myArray.Length];
        int count = 0;
        for (int i = 0; i < myArray.Length; i++)
        {
            if (myArray[i].Length <= 3)  // Если символов в элементе массива меньше 3, то добавить его в пустой массив
            {
                newArray[count] = myArray[i];
                count++;
            }
        }
        Console.WriteLine("\nВывод отсортированного массива: ");
        Console.WriteLine(string.Join(" ", newArray));
    }
}