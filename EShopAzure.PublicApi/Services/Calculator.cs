using EShopAzure.PublicApi.Interfaces;

public class Calculator : ICalculator
{
    private readonly ILogger<Calculator> _logger;

    public Calculator(ILogger<Calculator> logger)
    {
        _logger = logger;
    }

    public double CalculatePi(long iterations)
    {
        _logger.LogInformation("Calculating Pi");
        double pi = 0;
        bool isPositive = true;

        for (long i = 0; i < iterations; i++)
        {
            if (isPositive)
            {
                pi += 1.0 / (2 * i + 1);
            }
            else
            {
                pi -= 1.0 / (2 * i + 1);
            }
            isPositive = !isPositive;
        }

        return pi * 4;
    }
}

