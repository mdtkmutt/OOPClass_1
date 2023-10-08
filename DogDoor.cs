public class DogDoor
{
    public bool open;

    public void Open()
    {
        Console.WriteLine("The dog door is Open");
        this.open = true;
    }

    public void Close()
    {
        Console.WriteLine("The  dog door is Close");
        this.open = false;
    }
}