using System;
public interface ILamp
{
    string Type { get; set; }
    string Virobnik { get; set; }
    int Power { get; set; }
    string LightType { get; set; }
    int Number { get; set; }

    void PrintDetails();
    void ChangePower(int newPower);
}
public interface ICamera
{
    string Type { get; set; }
    string Virobnik { get; set; }
    int OpticalSensitivity { get; set; }

    void PrintDetails();
    void ChangeSensitivity(int newSensitivity);
}
public class PhotoStudio : ILamp, ICamera
{

    public string Type { get; set; }
    public string Virobnik { get; set; }
    public int Power { get; set; }
    public string LightType { get; set; }
    public int Number { get; set; }

    public int OpticalSensitivity { get; set; }

    void ILamp.PrintDetails()
    {
        Console.WriteLine($"Деталі лампи:");
        Console.WriteLine($"Тип: {Type}");
        Console.WriteLine($"Виробник: {Virobnik}");
        Console.WriteLine($"Потужність в люменах: {Power}");
        Console.WriteLine($"Тип освітлення: {LightType}");
        Console.WriteLine($"Кількість елементів: {Number}");
        Console.WriteLine();
    }

    public void ChangePower(int newPower)
    {
        Power = newPower;
        Console.WriteLine($"Потужність змінена до {newPower} люменів.");
        Console.WriteLine();
    }

    // ICamera method implementation
    void ICamera.PrintDetails()
    {
        Console.WriteLine($"Деталі камери:");
        Console.WriteLine($"Тип: {Type}");
        Console.WriteLine($"Виробник: {Virobnik}");
        Console.WriteLine($"Оптична світлочутливість: {OpticalSensitivity}");
        Console.WriteLine();
    }

    public void ChangeSensitivity(int newSensitivity)
    {
        OpticalSensitivity = newSensitivity;
        Console.WriteLine($"Оптична світлочутливість змінена на: {newSensitivity}.");
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        ILamp studio1 = new PhotoStudio();
        studio1.Type = "Студійна лампа";
        studio1.Virobnik = "СвітлоБуде";
        studio1.Power = 5000;
        ((PhotoStudio)studio1).LightType = "LED";
        ((PhotoStudio)studio1).Number = 5;

        ICamera studio2 = new PhotoStudio();
        studio2.Type = "Студійна камера";
        studio2.Virobnik = "ФотоМото";
        ((PhotoStudio)studio2).OpticalSensitivity = 1600;

        studio1.PrintDetails();
        studio2.PrintDetails();

        ((PhotoStudio)studio1).ChangePower(4000);

        ((PhotoStudio)studio2).ChangeSensitivity(2000);

        studio1.PrintDetails();
        studio2.PrintDetails();

        Console.ReadLine();
    }
}

