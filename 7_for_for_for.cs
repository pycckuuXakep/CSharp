static void first()
{
    Console.WriteLine("1^k + 2^k + n^k...");
    Console.Write("Give N: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Give K: ");
    int k = Convert.ToInt32(Console.ReadLine());
    int sum = 0;
    int num = 0;
    for (int i = 1; i <= n; i++)
    {
        num = i;
        for (int ii = 2; ii <= k; ii++)
            num *= i;
        sum += num;
    }
    Console.WriteLine("SUM: " + sum);
    Console.WriteLine();
}

static void second()
{
    Console.Write("Give me num of lines: ");
    int n = Convert.ToInt32(Console.ReadLine());
    for(int i = 1; i <= n; i++)
    {
        for (int k = 1; k <= i; k++)
            Console.Write(i + " ");
        Console.WriteLine();
    }
    Console.WriteLine();

}

static void third()
{
    for(int i = 1; i<=9; i++)
    {
        for (int k = 1; k <= 9; k++)
            Console.WriteLine($"{i} * {k} = {i * k}");
        Console.WriteLine();
    }
    Console.WriteLine();

}

static void fourth()
{
    Console.Write("Give me height of rect: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("++++++++");
    for (int i = 1; i <= n; i++) {
        Console.Write("+");
        for (int k = 1; k <= 6; k++)
            Console.Write("*");
        Console.WriteLine("+");
    }
    Console.WriteLine("++++++++");
    Console.WriteLine();

}
