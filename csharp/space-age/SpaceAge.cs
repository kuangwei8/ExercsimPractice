using System;

public class SpaceAge
{
    int n;
    double secInEarth = 31557600.00; 
    public SpaceAge(int seconds)
    {
        this.n = seconds; 
        
    }

    public double OnEarth()
    {
        return n / secInEarth; 
    }

    public double OnMercury()
    {
        return n/(0.2408467*secInEarth); 
    }

    public double OnVenus()
    {
        return n / (0.61519726 * secInEarth);
    }

    public double OnMars()
    {
        return n / (1.8808158 * secInEarth);
    }

    public double OnJupiter()
    {
        return n / (11.862615 * secInEarth);
    }

    public double OnSaturn()
    {
        return n / (29.447498 * secInEarth);
    }

    public double OnUranus()
    {
        return n / (84.016846 * secInEarth);
    }

    public double OnNeptune()
    {
        return n / (164.79132 * secInEarth);
    }
}

//Earth: orbital period 365.25 Earth days, or 31557600 seconds
//Mercury: orbital period 0.2408467 Earth years
//Venus: orbital period 0.61519726 Earth years
//Mars: orbital period 1.8808158 Earth years
//Jupiter: orbital period 11.862615 Earth years
//Saturn: orbital period 29.447498 Earth years
//Uranus: orbital period 84.016846 Earth years
//Neptune: orbital period 164.79132 Earth years