static void first()
{
    Console.WriteLine("[FIRST]");
    Console.Write("The sum of first six's numbers is:");
    int i = 1;
    int sum = 0;
    do { sum += i++; } while (i <= 6);
    Console.WriteLine(sum);
    Console.WriteLine("");

}
static void second()
{
    Console.WriteLine("[SECOND]");
    Console.WriteLine("Second exercise. I multiplicate numbers. Zero is end of file");
    int summarize = 1;
    int count = 0;
    int x = 1;
    do
    {
        Console.WriteLine("Give me another num and I '*' it");
        summarize *= x;
        count++;
        x = Convert.ToInt32(Console.ReadLine());
    } while (x != 0);
    Console.WriteLine($"Sum of {count} num's is {summarize}");
    Console.WriteLine("");
}

static void third()
{
    Console.WriteLine("[THIRD]");
    Console.WriteLine("Give me A and i give you the sum of 1 + 1/2 + 1/k where k is the smallest num and sum > A");
    int A = Convert.ToInt32(Console.ReadLine());
    double sum = 1;
    double k = 1;
    do
    {
        k++;
        sum = sum + (1d / k);
    } while (sum <= A);
    Console.WriteLine("The smallest k is " + k);
    Console.WriteLine("PS: sum is " + sum);
    Console.WriteLine("");

}

static void fourth()
{
    Console.WriteLine("[FOURTH]");
    Console.WriteLine("Give me % (> 0 but < 25): ");
    double P = Convert.ToDouble(Console.ReadLine()) / 100;
    Console.WriteLine("THE P IS " + P);
    int month = 0;
    double sum = 10000;
    do
    {
        sum += sum * P;
        month++;
    } while (sum <= 11000);
    Console.WriteLine("MONTH: " + month);
    Console.WriteLine("VKLAD: " + sum);
    Console.WriteLine("");

}
