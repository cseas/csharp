using System;

abstract class Shape {
    public abstract double Area();
}

class Rectangle : Shape {
    public double Width {get; set;}
    public double Height {get; set;}

    public override double Area() {
        return Width * Height;
    }
}

class Circle : Shape {
    public double Radius {get; set;}

    public override double Area() {
        return Radius * Radius * Math.PI;
    }
}

class AreaCalculator {
    public double Area(Shape shape) {
        double area = shape.Area();
        return area;
    }
}

public class Open {
    public static void Main(string[] args) {
        Rectangle rectangle = new Rectangle();
        rectangle.Width = 20;
        rectangle.Height = 20;

        AreaCalculator areacalculator = new AreaCalculator();
        Console.WriteLine(areacalculator.Area(rectangle));
    }
}
