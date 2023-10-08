public class Car
{
    // คุณสมบัติ
    public string brand;
    public string model;
    public int numberOfDoors;
    public int numberOfWheels;

    // ความสามารถ 
    public string MoveForward()
    {
        return "Move Forward";
    }

    public string MoveBackward()
    {
        return "Move Backward";
    }

    public string Stop()
    {
        return "Stop";
    }

    public string Turn()
    {
        return "Turn";
    }

}