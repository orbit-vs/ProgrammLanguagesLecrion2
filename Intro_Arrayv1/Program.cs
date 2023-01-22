int [] array = {1,12,31,4,15,16,17,8 };

int n = array.Length;
int find = 18;

int index = 0;

while (index <n)
{

    if(array[index] == find)
    {
        Console.WriteLine(index);
    }
    //index = index +1;
    index++;
}