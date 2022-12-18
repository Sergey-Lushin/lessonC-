int [] array = { 11, 21, 18, 31, 41, 15, 61, 71, 18, 91 };

int n = array.Length;
int find = 18;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
//Console.WriteLine("Hello, World!");
