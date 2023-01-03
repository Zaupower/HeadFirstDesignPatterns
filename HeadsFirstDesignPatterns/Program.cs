using ObserverPattern;
using ObserverPattern.Interfaces;
using SimUDuck;
using SimUDuck.FlyTypes;
using SimUDuck.QuackTypes;
using StrategyPattern;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        #region StrategyPattern - SimUDuck
        //Description of Strategy Pattern 
        //This Pattern defines a family of algorithms, encapsulates each one, and makes them interchangeable.
        //Strategy lets the algorithm vary independently from clients that use it.(In this case let Client be Duck child classes, like WoodDuck)

        Console.WriteLine("Wood Duck");
        FlyNoWay flyNoWay = new FlyNoWay();
        MuteQuack muteQuack = new MuteQuack();
        Duck woodDuck = new WoodDuck(flyNoWay, muteQuack);

        woodDuck.performQuack();
        woodDuck.performFly();

        #endregion

        #region ObserverPattern - Weather-O-Ram
        //Description of Observer Pattern
        // 1

        WeatherData weatherDataObserver = WeatherData.Instance;
        CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay();
        ForecastDisplay forecast = new ForecastDisplay();
        WeatherValues weatherValues = new WeatherValues();
        float formalValue = 0;
        weatherValues.pressure = formalValue;
        weatherValues.temperature = formalValue;
        weatherValues.humidity = formalValue;

        //weatherDataObserver.Subscribe(currentConditionsDisplay);
        //weatherDataObserver.Subscribe(forecast);

        forecast.Subscribe(weatherDataObserver);
        currentConditionsDisplay.Subscribe(weatherDataObserver);
        while (true)
        {
            Console.WriteLine("Mighty GOOD Input the Weather!");
            int input = Convert.ToInt32(Console.ReadLine());    
            if (input == 0)
            {
                //Test unsubcribe
                forecast.Unsubscribe();
            }
                weatherValues.pressure = input;
                weatherValues.temperature = input;
                weatherValues.humidity = input;
                weatherDataObserver.measurementsChanged(weatherValues);            
        }
        #endregion

    }
}