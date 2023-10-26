namespace calculator_in_blazor_project.Shared;

public class Functions
{
    public int Add(int x, int y)
    {
        return x+y;
    }

    public int Deduct(int x, int y)
    {
        return x - y;
    }

    public int Multiply(int x, int y)
    {
        return x * y;
    }
    public int Divide(int x, int y)
    {
        if (y<0)
        {
            return 0;
        }

        return x / y;
    }
}