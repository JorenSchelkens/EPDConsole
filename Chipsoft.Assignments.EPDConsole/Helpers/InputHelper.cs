namespace Chipsoft.Assignments.EPDConsole.Helpers;

public static class InputHelper
{
    public static string ReadString(string helperText)
    {
        string? result = null;

        while (result == null)
        {
            Console.Write($"{helperText}: ");
            result = Console.ReadLine();
        }

        return result;
    }

    public static DateOnly ReadDateOnly(string helperText)
    {
        DateOnly result;

        do
        {
            Console.Write($"{helperText} (dd/mm/yyyy): ");
        } while (!DateOnly.TryParse(Console.ReadLine(), out result) && result == DateOnly.MinValue);

        return result;
    }

    public static DateTime ReadDateTime(string helperText)
    {
        DateTime result;

        do
        {
            Console.Write($"{helperText} (dd/mm/yyyy hh:mm): ");
        } while (!DateTime.TryParse(Console.ReadLine(), out result) && result == DateTime.MinValue);

        return result;
    }

    public static int ReadInt(string helperText)
    {
        int result;

        do
        {
            Console.Write($"{helperText}: ");
        } while (!int.TryParse(Console.ReadLine(), out result));

        return result;
    }

    public static void WaitToContinue()
    {
        Console.WriteLine();
        Console.Write("Druk op een toets om verder te gaan ");
        Console.ReadKey();
    }
}