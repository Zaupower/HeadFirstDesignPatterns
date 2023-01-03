using ObserverPattern;
using ObserverPattern.Displays;
using ObserverPattern.Interfaces;
using ObserverPattern.WeatherDataValues;
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

        WeatherData<IWeatherValues> weatherDataObserver = WeatherData<IWeatherValues>.Instance;
        CurrentConditionsDisplay<IWeatherValues> currentConditionsDisplay = new CurrentConditionsDisplay<IWeatherValues>();
        ForecastDisplay<IWeatherValues> forecast = new ForecastDisplay<IWeatherValues>();
        WeatherValues weatherValues = new WeatherValues();

        float formalValue = 0;
        weatherValues.SetPressure(formalValue);
        weatherValues.SetTemperature(formalValue);
        weatherValues.SetHumidity(formalValue);

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
            }else if (input == 1)
            {
                var weatherWithIndex = new WeatherValuesWithHeatIndex();
                weatherWithIndex.SetPressure(input);
                weatherWithIndex.SetTemperature(input);
                weatherWithIndex.SetHumidity(input);
                weatherWithIndex.SetHeatIndex();
                weatherDataObserver.measurementsChanged(weatherWithIndex);
            }
            else if (input == 69)
            {
                forecast.Subscribe(weatherDataObserver);
            }
            else
            {
                weatherValues.SetPressure(input);
                weatherValues.SetTemperature(input);
                weatherValues.SetHumidity( input);
                weatherDataObserver.measurementsChanged(weatherValues);      
            }
            
        }
        #endregion

    }
}