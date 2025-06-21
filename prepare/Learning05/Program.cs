using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("My Shape Program");
      
        Square mySquare = new Square("red", 4);
        Rectangle myRect = new Rectangle("blue", 5, 3);
        Circle myCircle = new Circle("green", 2);
        
        Console.WriteLine("\n--- Testing My Shapes ---");
        
       
        int count = 0;
        do
        {
            Console.WriteLine("Square:");
            Console.WriteLine("Color: " + mySquare.color);
            Console.WriteLine("Side: " + mySquare.side);
            Console.WriteLine("Area: " + mySquare.CalculateArea());
            count++;
        } while (count < 1);
        
        count = 0;
        do
        {
            Console.WriteLine("\nRectangle:");
            Console.WriteLine("Color: " + myRect.color);
            Console.WriteLine("Length: " + myRect.length + ", Width: " + myRect.width);
            Console.WriteLine("Area: " + myRect.CalculateArea());
            count++;
        } while (count < 1);
        
        count = 0;
        do
        {
            Console.WriteLine("\nCircle:");
            Console.WriteLine("Color: " + myCircle.color);
            Console.WriteLine("Radius: " + myCircle.radius);
            Console.WriteLine("Area: " + myCircle.CalculateArea());
            count++;
        } while (count < 1);
        
        Console.WriteLine("\n Making a List of Shapes");
        
    
        List<Shape> shapeList = new List<Shape>();

        shapeList.Add(mySquare);
        shapeList.Add(myRect);
        shapeList.Add(myCircle);
        shapeList.Add(new Square("yellow", 6));
        shapeList.Add(new Circle("purple", 3));
        
        Console.Write("I have " + shapeList.Count + " shapes in my list!");
        
        //I wanted to practice do while loops cuz I used them on my last program and thought they were cool
        Console.WriteLine("\n--- Going Through My Shape List ---");
        int i = 0;
        do
        {
            Shape currentShape = shapeList[i];
            
            Console.WriteLine("\nShape #" + (i + 1) + ":");
            Console.WriteLine("Type: " + currentShape.GetType().Name);
            Console.WriteLine("Color: " + currentShape.color);
            Console.WriteLine("Area: " + currentShape.CalculateArea());
            
            
            if (currentShape is Square)
            {
                Square s = (Square)currentShape;
                Console.WriteLine("Side length: " + s.side);
            }
            else if (currentShape is Rectangle)
            {
                Rectangle r = (Rectangle)currentShape;
                Console.WriteLine("Length: " + r.length + ", Width: " + r.width);
            }
            else if (currentShape is Circle)
            {
                Circle c = (Circle)currentShape;
                Console.WriteLine("Radius: " + c.radius);
            }
            
            i++;
        } while (i < shapeList.Count);
        
    
        Console.WriteLine("\n--- Calculating Total Area ---");   // Calculates the total area 
        double totalArea = 0;
        int j = 0;
        do
        {
            totalArea = totalArea + shapeList[j].CalculateArea();
            j++;
        } while (j < shapeList.Count);
        
        Console.WriteLine("Total area of all shapes: " + totalArea);
        
       
        Console.WriteLine("\n Finding Biggest Shape");
        double biggestArea = 0;
        string biggestShapeType = "";
        int k = 0;
        do
        {
            double currentArea = shapeList[i].CalculateArea();
            if (currentArea > biggestArea)
            {
                biggestArea = currentArea;
                biggestShapeType = shapeList[k].GetType().Name;
            }
            i++;
        } while (k < shapeList.Count);
        
        Console.WriteLine("Biggest shape is a " + biggestShapeType + " with area: " + biggestArea);
        
        Console.WriteLine("\n All done!");
    }
}