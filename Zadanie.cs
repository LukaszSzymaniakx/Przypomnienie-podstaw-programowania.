using System;

class Program
{
    static void Kalkulator()
    {
        Console.WriteLine("Kalkulator");
        try
        {
            Console.Write("Podaj pierwszą liczbę: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Podaj drugą liczbę: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Wybierz operację (+, -, *, /): ");
            string operacja = Console.ReadLine();

            double wynik = 0;
            bool poprawnaOperacja = true;

            switch (operacja)
            {
                case "+":
                    wynik = a + b;
                    break;
                case "-":
                    wynik = a - b;
                    break;
                case "*":
                    wynik = a * b;
                    break;
                case "/":
                    if (b != 0)
                        wynik = a / b;
                    else
                    {
                        Console.WriteLine("Błąd: Nie można dzielić przez zero!");
                        poprawnaOperacja = false;
                    }
                    break;
                default:
                    Console.WriteLine("Błąd: Nieprawidłowa operacja!");
                    poprawnaOperacja = false;
                    break;
            }

            if (poprawnaOperacja)
                Console.WriteLine($"Wynik: {wynik}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Błąd: Podaj prawidłowe liczby!");
        }
    }

    static void KonwerterTemperatur()
    {
        Console.WriteLine("Konwerter temperatur");
        Console.Write("Wybierz kierunek (C -> F, F -> C): ");
        string kierunek = Console.ReadLine().ToUpper();

        try
        {
            if (kierunek == "C")
            {
                Console.Write("Podaj temperaturę w °C: ");
                double celsius = Convert.ToDouble(Console.ReadLine());
                double fahrenheit = celsius * 1.8 + 32;
                Console.WriteLine($"{celsius}°C = {fahrenheit}°F");
            }
            else if (kierunek == "F")
            {
                Console.Write("Podaj temperaturę w °F: ");
                double fahrenheit = Convert.ToDouble(Console.ReadLine());
                double celsius = (fahrenheit - 32) / 1.8;
                Console.WriteLine($"{fahrenheit}°F = {celsius}°C");
            }
            else
            {
                Console.WriteLine("Błąd: Wybierz C lub F!");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Błąd: Podaj prawidłową temperaturę!");
        }
    }

    static void SredniaOcen()
    {
        Console.WriteLine("Średnia ocen ucznia");
        try
        {
            Console.Write("Podaj liczbę ocen: ");
            int liczbaOcen = Convert.ToInt32(Console.ReadLine());

            if (liczbaOcen <= 0)
            {
                Console.WriteLine("Błąd: Liczba ocen musi być większa od 0!");
                return;
            }

            double suma = 0;
            for (int i = 0; i < liczbaOcen; i++)
            {
                Console.Write($"Podaj ocenę {i + 1} (1-6): ");
                double ocena = Convert.ToDouble(Console.ReadLine());
                if (ocena < 1 || ocena > 6)
                {
                    Console.WriteLine("Uwaga: Ocena powinna być w skali 1-6!");
                }
                suma += ocena;
            }

            double srednia = suma / liczbaOcen;
            Console.WriteLine($"Średnia: {srednia:F2}");

            if (srednia >= 3.0)
                Console.WriteLine("Uczeń zdał.");
            else
                Console.WriteLine("Uczeń nie zdał.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Błąd: Podaj prawidłowe liczby!");
        }
    }

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n" + new string('=', 40));
            Console.WriteLine("MENU");
            Console.WriteLine(new string('=', 40));
            Console.WriteLine("1. Kalkulator dwóch liczb");
            Console.WriteLine("2. Konwerter temperatur (C -> F)");
            Console.WriteLine("3. Średnia ocen ucznia");
            Console.WriteLine("4. Wyjście z programu");

            Console.Write("Wybierz opcję (1-4): ");
            string wybor = Console.ReadLine();

            switch (wybor)
            {
                case "1":
                    Kalkulator();
                    break;
                case "2":
                    KonwerterTemperatur();
                    break;
                case "3":
                    SredniaOcen();
                    break;
                case "4":
                    Console.WriteLine("Dziękuję za skorzystanie z programu!");
                    return;
                default:
                    Console.WriteLine("Błąd: Wybierz opcję od 1 do 4!");
                    break;
            }
        }
    }
}