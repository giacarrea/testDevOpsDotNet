namespace App;
using App.structs;
using App.Interfaces;

public static class ExoStructs
{
    public static void DiagonalCoords()
    {
        var coords = new Coord[5,5];
        for(int i = 1; i <= 5; i++)
            coords[i-1, i-1] = new Coord(i, i);

        for(int i = 0; i < coords.GetLength(0); i++)
        {            
            for(int j = 0; j < coords.GetLength(1); j++)
            {
                var curCoord = coords[i,j];
                if(curCoord.Equals(default(Coord)))
                    Console.Write("         ");
                else
                    Console.Write(curCoord+" "); 
            }
            Console.WriteLine();
        }
    }

    public static void TemperatureStuff()
    {
        Celcius c = new Celcius(36.6);
        Fahrenheit f = new Fahrenheit(97.88);

        Console.WriteLine($"Temp in Celcius: {c.Temperature}°C");
        Console.WriteLine($"Temp in Fahrenheit: {f.Temperature}°F");

        Console.WriteLine($"Celcius is ITemperature: {c is ITemperature}");
        Console.WriteLine($"Fahrenheit is ITemperature: {f is ITemperature}");
    }
}