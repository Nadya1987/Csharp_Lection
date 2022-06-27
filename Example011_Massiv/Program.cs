int[] array = {1, 12, 31, 4, 15, 31, 16, 17,18};

int n = array.Length;// возвращает длину или количество элементов массива
int find = 4;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index ++;
}