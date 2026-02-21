namespace DateNight.Models;

public class DateCalculator
{
    public string CoffeeCost { get; set; }
    public string DinnerCost { get; set; }
    public string MovieCost { get; set; }

    public string GetTotalCost()
    {
        decimal decCoffee, decDinner, decMovie;
        if(!decimal.TryParse(CoffeeCost, out decCoffee))
        {
            if(!string.IsNullOrEmpty(CoffeeCost))
            {
                throw new Exception("Invalid Coffee Cost");
            }
        }

        if (!decimal.TryParse(DinnerCost, out decDinner))
        {
            throw new Exception("Invalid Dinner Cost");
        }
        if (!decimal.TryParse(MovieCost, out decMovie))
        {
            throw new Exception("Invalid Movie Cost");
        }

        return (decCoffee + decDinner + decMovie).ToString("C");
    }
}