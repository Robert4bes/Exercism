class Lasagna
{
    //Returns amount of time Lasagna should cook for.
    public int ExpectedMinutesInOven() => 40;

    //Returns amount of cooking time remaining 
    public int RemainingMinutesInOven(int timeInOven)
    {
        return ExpectedMinutesInOven() - timeInOven;
    }
    
    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int layers)
    {
        return layers * 2;
    }

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int numberOfLayers, int timeInOven)
    {
        return PreparationTimeInMinutes(numberOfLayers) + (ExpectedMinutesInOven() - RemainingMinutesInOven(timeInOven));
    }
}
