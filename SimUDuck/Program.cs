using SimUDuck;
using SimUDuck.FlyTypes;
using SimUDuck.QuackTypes;

internal class Program
{
    //SimUDuck
    private static void Main(string[] args)
    {
        Console.WriteLine("Types of Ducks");
        FlyNoWay flyNoWay = new FlyNoWay();
        MuteQuack muteQuack = new MuteQuack();    
        Duck duck = new Duck(flyNoWay,muteQuack );

        duck.performQuack();
        duck.performFly();
    }
}