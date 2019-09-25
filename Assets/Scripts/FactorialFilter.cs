
public class FactorialFilter
{
    public static int factorial(int x)
    {
        if (x == 1)
        {
            return 1;
        }
        else
        {
            return x * factorial(x - 1);
        }
            
    }
    public static int[] factorials(int[]xs)
    {
        int[] result = new int[xs.Length];
        for(int i =0; i<xs.Length;i++)
        {
            result[i] = factorial(xs[i]);
        }
        return result; ;
    }

}
