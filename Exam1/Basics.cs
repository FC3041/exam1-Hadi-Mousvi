using System.ComponentModel;

namespace Exam1;

public interface IShape
{
    public double GetArea();
    public double GetPerimeter();
}

public class Q1_Add
{
    public static int Add(int a , int b)
    {
        return a+b;
    }
}

public class Basics
{
    public static void Q2MultiplyAndReset(ref int a , ref int b)
    {
        a *= b;
        b = 1;
    }

    public static void Q5TryCatchFinally(bool Do_Throw , List<string> Pr , bool Do_Catch = false)
    {
        try
        {
            Pr.Add("Try");
            if(Do_Throw)
                throw new InvalidOperationException();
            else
                Pr.Add("AfterTry");
        }
        catch(InvalidOperationException)
        {   
            Pr.Add("Catch");
            if(Do_Catch)
            {
                throw new InvalidOperationException();
            }
        }
        finally
        {
            Pr.Add("Finally");
        }
    }
}

public struct Type1
{
    public int Count;
}
public class Type2
{
    public int Count; 
}

public class Q4Person
{
    public string Name;
    public int Age;

    public Q4Person(string name , int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public string Introduce() => $"Hello, my name is {this.Name} and I am {this.Age} years old.";
}


public class Q6Temperature
{
    private int ci = 0;
    private int fi = 0;
    private double celsius;
    private bool Cimplemented = false;
    private bool Fimplemented = false;
    private double fahrenheit;

    public double Celsius { 
        get
        {
            if(this.Fimplemented)
            {
                celsius = 5.0/9 * (this.fahrenheit - 32);
                this.Fimplemented = false;
            }
            return celsius;
        } 
        set
        { celsius = value;
         this.Cimplemented = true;}}
    public double Fahrenheit { 
        get
        {
            if(this.Cimplemented)
            {
                fahrenheit = 32 + (this.celsius * 9.0/5);
                this.Cimplemented = false;
            }
            // this.ci++;
            return fahrenheit;
        } 
        set {
            fahrenheit = value;
            this.Fimplemented = true;} }
}

public class Q7Circle : IShape
{
    public double Radius;

    public Q7Circle(double radius)
    {
        this.Radius = radius;
    }

    public double GetArea()
    {
        return Math.PI * this.Radius* this.Radius;
    }

    public double GetPerimeter()
    {
        return 2.0 * Math.PI * this.Radius;
    }
}

public class Q7Rectangle : IShape
{
    public double Width;
    public double Height;
    public Q7Rectangle(double w , double h)
    {
        this.Width = w;
        this.Height = h;
    }
    public double GetArea()
    {
        return this.Width * this.Height;
    }

    public double GetPerimeter()
    {
        return 2.0 * (this.Height + this.Width);
    }
}

public class ShapeUtils
{
    public static double Q7TotalArea(IShape[] shapes)
    {
        double result = 0;
        foreach(var shape in shapes)
        {
            result += shape.GetArea();
        }
        return result;
    }
}