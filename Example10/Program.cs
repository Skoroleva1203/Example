// Найти элемент массива, равный find

int[] array = {1,52,6,7,15,24,75,9,17};

int n = array.Length;
int find = 15;
int index = 0;

while (index < n)
{
    if (array[index] == find)
{
    Console.WriteLine(index);
    break;
}
    index ++;    
}
