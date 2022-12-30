using SimUDuck;
using SimUDuck.FlyTypes;
using SimUDuck.QuackTypes;

internal class Program
{
    private static void Main(string[] args)
    {
        #region SimUDuck
        Console.WriteLine("Wood Duck");
        FlyNoWay flyNoWay = new FlyNoWay();
        MuteQuack muteQuack = new MuteQuack();
        Duck duck = new Duck(flyNoWay, muteQuack);

        duck.performQuack();
        duck.performFly();
        #endregion

    }
}