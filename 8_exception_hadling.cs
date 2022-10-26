static void first()
{
    int U, R;
    try
    {
        Console.WriteLine("This program evaluate I = U / R");
        Console.Write("U: ");
        U = Convert.ToInt32(Console.ReadLine());
        Console.Write("R: ");
        R = Convert.ToInt32(Console.ReadLine());
    }
    catch
    {
        Console.WriteLine("ERROR: Input is any INT number. NOT float/double/decimal or String...");
        return;
    }
}
static void second()
{
    int U, R;
    try
    {
        Console.WriteLine("This program evaluate I = U / R");
        Console.Write("U: ");
        U = Convert.ToInt32(Console.ReadLine());
        Console.Write("R: ");
        R = Convert.ToInt32(Console.ReadLine());
    }
    catch
    {
        Console.WriteLine("ERROR: Input is any number. ONLY.");
        return;
    }
    double I;
    try
    {
        if (R == 0)
        {
            throw new DivideByZeroException();
        }
        I = U / R;
        Console.WriteLine("I = {0}", I);
    }
    catch
    {
        Console.WriteLine("ERROR: R should be > 0!");
    }
}

static void third()
{
    int X, Y;
    try
    {
        Console.WriteLine("This program evaluate + - * /  of two positive numbers.");
        Console.Write("X: ");
        X = Convert.ToInt32(Console.ReadLine());
        if (X < 0)
            throw new Exception();
        Console.Write("Y: ");
        Y = Convert.ToInt32(Console.ReadLine());
        if (Y < 0)
            throw new Exception();
        Console.WriteLine("X + Y = " + (X + Y));
        Console.WriteLine("X - Y = " + (X - Y));
        Console.WriteLine("X * Y = " + (X * Y));
        Console.WriteLine("X / Y = " + (X / Y));
    }
    catch
    {
        Console.WriteLine("ERROR: Input should be positive!");
        return;
    }
}
