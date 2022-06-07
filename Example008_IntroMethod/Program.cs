int result(int x, int y, int z) 
    {
        int max = x;
        if(y > x) max = y;
        if(z > y) max = z;
        return max;
    }

int a1 = 112125;
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 2311;
int c2 = 33;
int a3 = 13;
int b3 = 23111;
int c3 = 313;





int sum = result(result(a1, b1, c1), result(a2, b2, c2), result(a3, b3, c3));
Console.WriteLine(sum);

