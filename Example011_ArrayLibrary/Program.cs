void FillArray(int[] collection)
    {
        int length = collection.Length;
        int index = 0;
        while (index < length)
        {
            collection[index] = new Random().Next(1, 99);
            index++;
        }
    }

void PrintArray(int[] col) 
    {
        int count = col.Length;
        int position = 0;
        while(position < count) 
            {
                Console.Write(col[position] + " ");
                position++;
            
            }
    }


int IndexOff(int[] collection, int find)
    {
        int length = collection.Length;
        int index = 0;
        int position  = -1;
        while(index < length)
            {
                if(collection[index] == find)
                    {
                        position = index;
                        break;
                        
                    }
                index++;
            }
        return position;
    }


int[] array = new int[1000];
FillArray(array);
PrintArray(array);

Console.WriteLine();
Console.WriteLine();

Console.WriteLine(IndexOff(array, 55));






