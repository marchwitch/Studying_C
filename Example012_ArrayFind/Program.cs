//

int[] array = { 1, 12, 31, 18, 4, 15, 16, 17, 18 };

int size = array.Length;
int find = 18; // типа мы ищем, какую позицию (индекс) в массиве занимает число 4
int index = 0;

while (index < size)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }

    index++; //index = index + 1
}