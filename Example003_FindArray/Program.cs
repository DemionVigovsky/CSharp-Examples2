int[] array = {1,232,7,124,5,566,7,18};

int N = array.Length;
int find = 7;

int index = 0;

while (index < N)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}