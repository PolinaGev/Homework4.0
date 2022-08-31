int Degree(int number, int n)
{
  int num_n=1;
  for(int i=0; i<n; i++) 
  {
    num_n*=number;
  }
  return num_n;
}
Console.Write(Degree(3, 5));