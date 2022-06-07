int[] array = { 1, 12, 31, 4, 18, 15, 16, 17, 18 };

int find  = 18;
int index = 0;
int lenght = array.Length;

while(index < lenght)
    {
        if(array[index] == find) 
            {
                Console.WriteLine(index);
                break;
            }
        index++;
    }
