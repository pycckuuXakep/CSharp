namespace Practice_6 {
    internal class Program {
        static void Main(string[] args) {
            fifth();
        }

        static void second() {
            int number = 2;
            int sum = 1;
            while(number * 5 != sum) {
                sum += number;
                ++number;
            }
            Console.WriteLine(number);
        }

        static void third() {
            double a = Convert.ToDouble(Console.ReadLine());
            int n = 0;
            while(fact(n) < a && !(fact(n+1) > a)) ++n;
            Console.WriteLine(n);
        }

        static void fourth() {
            int n = Convert.ToInt32(Console.ReadLine());
            int k = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            while(n >= k) {
                n -= k;
                i++;
            }
            Console.WriteLine($"{n+i*k} / {k} = {i} \n" +
                              $"{n+i*k} / {k} = {n}");
        }

        static void fifth() {
            int n = Convert.ToInt32(Console.ReadLine());
            int k = 0;
            int sum = 0;
            while(sum <= n) sum += ++k;
            Console.WriteLine($"K = {k}, SUM = {sum}");
        }

        static int fact(int n) {
            return n == 0 ? 1 : n * fact(n-1);
        }
    }
}
