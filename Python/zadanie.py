def kalkulator():
    print("Kalkulator")
    try:
        a = float(input("Podaj pierwszą liczbę: "))
        b = float(input("Podaj drugą liczbę: "))
        operacja = input("Wybierz operację (+, -, *, /): ")

        if operacja == '+':
            wynik = a + b
        elif operacja == '-':
            wynik = a - b
        elif operacja == '*':
            wynik = a * b
        elif operacja == '/':
            if b != 0:
                wynik = a / b
            else:
                print("Błąd: Nie można dzielić przez zero!")
                return
        else:
            print("Błąd: Nieprawidłowa operacja!")
            return

        print(f"Wynik: {wynik}")
    except ValueError:
        print("Błąd: Podaj prawidłowe liczby!")


def konwerter_temperatur():
    print("Konwerter Temperatur")
    kierunek = input("Wybierz kierunek (C -> F, F -> C): ").upper()

    try:
        if kierunek == 'C':
            celsius = float(input("Podaj temperaturę w °C: "))
            fahrenheit = celsius * 1.8 + 32
            print(f"{celsius}°C = {fahrenheit}°F")
        elif kierunek == 'F':
            fahrenheit = float(input("Podaj temperaturę w °F: "))
            celsius = (fahrenheit - 32) / 1.8
            print(f"{fahrenheit}°F = {celsius}°C")
        else:
            print("Błąd: Wybierz C lub F!")
    except ValueError:
        print("Błąd: Podaj prawidłową temperaturę!")


def srednia_ocen():
    print("Średnia ocen ucznia")
    try:
        liczba_ocen = int(input("Podaj liczbę ocen: "))

        if liczba_ocen <= 0:
            print("Błąd: Liczba ocen musi być większa od 0!")
            return

        suma = 0
        for i in range(liczba_ocen):
            ocena = float(input(f"Podaj ocenę {i + 1} (1-6): "))
            if ocena < 1 or ocena > 6:
                print("Uwaga: Ocena powinna być w skali 1-6!")
            suma += ocena

        srednia = suma / liczba_ocen
        print(f"Średnia: {srednia:.2f}")

        if srednia >= 3.0:
            print("Uczeń zdał.")
        else:
            print("Uczeń nie zdał.")
    except ValueError:
        print("Błąd: Podaj prawidłowe liczby!")


def main():
    while True:
        print("\n" + "=" * 40)
        print("MENU")
        print("=" * 40)
        print("1. Kalkulator dwóch liczb")
        print("2. Konwerter temperatur (C ↔ F)")
        print("3. Średnia ocen ucznia")
        print("4. Wyjście z programu")

        wybor = input("\nWybierz opcję (1-4): ")

        if wybor == '1':
            kalkulator()
        elif wybor == '2':
            konwerter_temperatur()
        elif wybor == '3':
            srednia_ocen()
        elif wybor == '4':
            print("Dziękuję za skorzystanie z programu!")
            break
        else:
            print("Błąd: Wybierz opcję od 1 do 4!")


if __name__ == "__main__":
    main()
