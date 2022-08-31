// int a = int.Parse(Console.ReadLine());
//             int s = 0;
//             while (a > 0)
//             {
 
//                 s = s + a % 10;
//                 a = a /10 ;
 
//             }
//  Console.WriteLine(s);
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