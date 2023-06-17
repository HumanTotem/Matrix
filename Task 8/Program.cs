int max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}
int a = 1;
int b = 2;
int c = 6;
int d = 8;
int e = 478;
int f = 3;
int max1 = max(a, b, c);
int max2 = max(d, e, f);
int max4 = max(max1, max2, 0);
System.Console.WriteLine(max4);