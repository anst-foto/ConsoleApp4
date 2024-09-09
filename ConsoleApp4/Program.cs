const int N = 3;
const int M = 3;
var array = new int [M, N];

for (int i = 0; i < M; i++)
{
    for (int j = 0; j < N; j++)
    {
        array[i, j] = i * N + j;
    }
}

var max = array.Cast<int>().Max();
var min = array.Cast<int>().Min();

var avgs = new double[M];
for (int i = 0; i < M; i++)
{
    var sum = 0;
    for (int j = 0; j < N; j++)
    {
        sum += array[i, j];
    }
    
    avgs[i] = (double)sum / N;
}

for (int i = 0; i < M; i++)
{
    for (int j = 0; j < N; j++)
    {
        Console.Write(array[i, j] + " ");
    }

    Console.WriteLine();
}
Console.WriteLine($"Max: {max}, Min: {min}");
for(int i = 0; i < M; i++)
{
    Console.WriteLine($"avg [{i}]: {avgs[i]}");
}