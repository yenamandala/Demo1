using ConsoleApp2;

class Program
{
    static void Main()
    {
        Toysimulator robot = new Toysimulator();

        robot.Place(0, 0, Direction.NORTH);
        robot.Move();
        robot.Report(); 

        robot.Place(0, 0, Direction.NORTH);
        robot.Left();
        robot.Report();
    }
}
