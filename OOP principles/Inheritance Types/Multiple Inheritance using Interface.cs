public class Program
{
    public static void Main(string[] args)
    {
        SmartPhone phone = new SmartPhone();

        phone.Call();
        phone.TakePhoto();
        phone.PlayMusic();
    }
}

public interface IPhone
{
    void Call();
}

public interface ICamera
{
    void TakePhoto();
}

public interface IMusicPlayer
{
    void PlayMusic();
}

public class SmartPhone : IPhone, ICamera, IMusicPlayer
{
    public void Call()
    {
        Console.WriteLine("Calling...");
    }

    public void TakePhoto()
    {
        Console.WriteLine("Taking photo...");
    }

    public void PlayMusic()
    {
        Console.WriteLine("Playing music...");
    }
}
