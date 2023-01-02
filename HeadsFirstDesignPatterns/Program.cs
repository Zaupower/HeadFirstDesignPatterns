using SimUDuck;
using SimUDuck.FlyTypes;
using SimUDuck.QuackTypes;
using StrategyPattern;

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
        #endregion

    }
}