namespace Practice3.entity;

public class Television
{
    private uint _numberOfChannel;

    public Television()
    {
        _numberOfChannel = 1;
    }

    public void NextChannel()
    {
        if (_numberOfChannel == uint.MaxValue)
        {
            return;
        }

        _numberOfChannel++;
    }

    public void PreviousChannel()
    {
        if (_numberOfChannel == 1)
        {
            return;
        }

        _numberOfChannel--;
    }

    public void SetChannel(uint numberOfChannel)
    {
        if (numberOfChannel <= 0)
        {
            throw new ArgumentException("Номер каналу повинен бути лише додатнім числом.");
        }

        _numberOfChannel = numberOfChannel;
    }

    public void Display()
    {
        Console.WriteLine("Television зараз на каналі {0}", _numberOfChannel);
    }
}