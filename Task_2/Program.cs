int Sum( int value)
{
    int result = 0;
    while(value > 0)
        {
            result += value % 10;
            value /= 10;
        }
    return result;
}
System.Console.WriteLine(Sum(452));