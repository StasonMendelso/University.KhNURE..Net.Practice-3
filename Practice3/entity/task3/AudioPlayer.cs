namespace Practice3.entity;

public class AudioPlayer
{
    private byte _volume;

    public byte Volume
    {
        get => _volume;
        set
        {
            if (value > 100)
            {
                throw new ArgumentException("Гучність може бути в межах 0-100 включно");
            }

            _volume = value;
        }
    }

}