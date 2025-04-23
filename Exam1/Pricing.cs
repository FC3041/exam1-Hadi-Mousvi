namespace Exam1;

public interface IStrategys
{
     public double off{get;set;}
}

public class NoDiscountStrategy : IStrategys
{
    public double off { get;set;}
    public NoDiscountStrategy()
    {
        this.off = 0;
    }
}

public class PercentageDiscountStrategy : IStrategys
{
    public double off { get; set; }
    public PercentageDiscountStrategy(double o)
    {
        this.off = o;
    }
}

public class PricingEngine
{
    public double Off;
    public double FinalPrice;
    
    public PricingEngine(IStrategys strategy)
    {
        this.Off = strategy.off;
    }

    public double CalculatePrice(double price)
    {
        this.FinalPrice = price - ( price * this.Off);
        return this.FinalPrice;
    }

    public void SetStrategy(IStrategys strategy)
    {
        this.Off = strategy.off;
    }
}