/* A little bit of my pervert fantasy. */
static void second() {
    int num = 2; int sum = 1;
    while(num * 5 != sum) sum += num++;
    Console.WriteLine(num);
}
static void third() {
    double a = double.Parse(Console.ReadLine());
    int n = 0;
    while(fact(n) < a && !(fact(n+1) > a)) ++n;
    Console.WriteLine(n);
}
static void fourth() {
    int n = int.Parse(Console.ReadLine());
    int k = int.Parse(Console.ReadLine());
    int i = 0; while(++i*k <= n); --i;
    Console.WriteLine($"{n}/{k} = {i}\n{n}/{k} = {n-i*k}");
}
static void fifth() {
    int n = int.Parse(Console.ReadLine());
    int k = 0; int sum = 0;
    while(sum <= n) sum += ++k;
    Console.Write($"K = {k}, SUM = {sum}");
}
static int fact(int n) {return n == 0 ? 1 : n * fact(n-1);}
