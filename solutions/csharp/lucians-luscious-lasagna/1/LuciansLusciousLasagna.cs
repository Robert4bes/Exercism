class Lasagna
{
    public int cookingMinutes = 40;

    //Returns amount of time Lasagna should cook for.
    public int ExpectedMinutesInOven()
    {
        return cookingMinutes;
    }

    //Returns amount of cooking time remaining 
    public int RemainingMinutesInOven(int timeInOven)
    {
        int remainingTime = cookingMinutes - timeInOven;
        return remainingTime;
    }
    
    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int layers)
    {
        int preparationTime = layers * 2;
        return preparationTime;
    }

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int numberOfLayers, int timeInOven)
    {
        int elapsedTime = PreparationTimeInMinutes(numberOfLayers) + (ExpectedMinutesInOven() - RemainingMinutesInOven(timeInOven));
        return elapsedTime;
    }
}
