namespace RandomStudent.Generator;

public static class GradeGenerator
{
    private static readonly Random _rnd = new Random();

    private const double Min = 0.0;
    private const double Max = 10.0;

    public static double Gen()
    {
        return Math.Round(_rnd.NextDouble() * (Max - Min) + Min, 2);
    }
}