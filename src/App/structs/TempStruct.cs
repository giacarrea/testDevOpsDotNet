using App.Interfaces;
namespace App.structs;

public struct Celcius : ITemperature
{
    public double Temperature { get; set; }

    public Celcius(double temp)
    {
        Temperature = temp;
    }
}

public struct Fahrenheit : ITemperature
{    
    public double Temperature { get; set; }

    public Fahrenheit(double temp)
    {
        Temperature = temp;
    }
}