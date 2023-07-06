int Max (int arg1, int arg2, int arg3){

    int result = arg1;

    if (arg2>result) result = arg2;
    if (arg3>result) result = arg3;
    return result;

}

int a1 = 21;
int b1 = 34;
int c1 = 41;
int a2 = 2;
int b2 = 4;
int c2 = 122;
int a3 = 22;
int b3 = 31;
int c3 = 44;

// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

Console.WriteLine(max);

