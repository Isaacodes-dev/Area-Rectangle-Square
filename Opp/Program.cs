﻿using Opp;

Rectangle r = new Rectangle();
Square s = new Square();
Console.WriteLine("Please select the following options\n 1. For Area of a Square \n 2. For Area of a Rectangle. ");
string? option = Console.ReadLine();
int convertOption = Convert.ToInt32(option);
switch (convertOption)
{
    case 1:
        s = new Square();
        Console.WriteLine("Enter Length");
        string? squarelength = Console.ReadLine();
        s.length = Convert.ToDouble(squarelength);
        s.DisplayAreaOfSquare();
        break;
    case 2: 
        r = new Rectangle();
        Console.WriteLine("Enter Length");
        string? length = Console.ReadLine();
        Console.WriteLine("Enter Width");
        string? width = Console.ReadLine();
        r.length = Convert.ToDouble(length);
        r.width = Convert.ToDouble(width);
        r.Display();
        break;
}
