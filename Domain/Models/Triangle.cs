namespace Domain.Models;

public static class Triangle
{
    public static double CalcTriangleArea(double b, double height)
    {
        return 0.5 * b * height;
    }
    public static double CalcTrianglePerimeter(double side1,double side2,double side3)
    {
        return side1 + side2 + side3;
    }
}
