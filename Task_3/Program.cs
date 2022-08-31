int[] GetArray()
{
int [] massiv = new int[8];
for (int i = 0; i < massiv.Length; i++)
{
    massiv[i] = new Random().Next(10);
}
return massiv;
}
System.Console.WriteLine($"[{string.Join(", ", GetArray())}]");