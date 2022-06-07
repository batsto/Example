int[] array  = {1,24,35,48,75,68,74,83,94};

int result(int x, int y, int z) 
    {
        int max = x;
        if(y > x) max = y;
        if(z > y) max = z;
        return max;
    }


int max =result(result(array[0], array[1], array[2]),
                result(array[3], array[4], array[5]),
                result(array[6], array[7], array[8]));

Console.WriteLine(max);