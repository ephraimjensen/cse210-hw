using System.IO.Pipes;

class Car
{
    public string _model;
    public string _make;
    public int _milesPerGallon;
    public int _tankSize;
    public Person owner;

    public int TotalRange()
    {
        var returnThis = _milesPerGallon * _tankSize;
        return returnThis;
    }

    public void Display()
    {

        Console.WriteLine($"{_make} {_model} {_milesPerGallon} {_tankSize} total range = {TotalRange()} {owner.Display()}");

    }
}
