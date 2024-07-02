namespace dotnet_dsa.fundamentals;

using System;

abstract class Shape
{
    public abstract double Area { get; set; }
}

class Square(double side) : Shape
{
    public double _side = side;

    public override double Area {
        get => Math.Round(_side * _side, 2);
        set => _side = Math.Round(Math.Sqrt(value), 2);
    }
}