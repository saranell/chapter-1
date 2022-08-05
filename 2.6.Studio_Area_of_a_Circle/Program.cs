// Calculate the Area of a Circle
Console.WriteLine("Enter a radius: ");

double r = double.Parse (Console.ReadLine());

double area = Math.PI * r * r;

Console.WriteLine($"The area of a circle with radius {r} is: {area}");

double circumference = 2 * Math.PI * r;
double diameter = 2 * r;

Console.WriteLine($"The circumference is {circumference} & the diameter is {diameter}");

Console.WriteLine("What is the mpg of your car? ");

double mpg = double.Parse(Console.ReadLine());
double gallons = mpg / diameter;

Console.WriteLine($"It will take {gallons} gallons to go around the circle.");
