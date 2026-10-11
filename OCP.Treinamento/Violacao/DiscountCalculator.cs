using System;

public class DiscountCalculator
{
    public decimal Calculate(string customerType, decimal total)
    {
        if (customerType == "Regular")
            return total * 0.05m;

        if (customerType == "Premium")
            return total * 0.10m;

        if (customerType == "Employee")
            return total * 0.20m;

        return 0m;
    }
}