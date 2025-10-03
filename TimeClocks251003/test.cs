// See https://aka.ms/new-console-template for more information
using CsharpLab251003_2;
using System.Globalization;

Console.WriteLine("Hello, World!");

public class Test
{
    public static void Main(string[] args)
    {
        Console.Write("Enter London time (HH:mm): ");
        var input = Console.ReadLine();

        if (!DateTime.TryParseExact(input, "HH:mm",
                CultureInfo.InvariantCulture, DateTimeStyles.None, out var tOnly))
        {
            Console.WriteLine("Invalid time format.");
            return;
        }

        // Combine today’s date with the entered time
        var london = DateTime.Today.AddHours(tOnly.Hour).AddMinutes(tOnly.Minute);

        LocalTime[] clocks =
        {
            new LondonTime(london),
            new NYTime(london),
            new TokyoTime(london),
            new HongKongTime(london)
        };

        foreach (var c in clocks) c.DisplayTimeAndCity();
    }
}
