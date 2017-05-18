using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program4
{
    class Program
    {
        static void Main(string[] args)
        {
            Pracownicy Dyrektor = new Pracownicy();
            Pracownicy Kierownik = new Pracownicy();
            Pracownicy Pracownik1 = new Pracownicy("o", "o", "");
            Pracownicy Pracownik2 = new Pracownicy("o", "o", "");

            Dyrektor.setAll("o", "o", "Dyrektor", 98453234543, 564376956, "Dobiegniew", 3400, 600);
            Console.WriteLine("Imię i nazwisko:" + " " + Dyrektor.getImie() + " " + Dyrektor.getNazwisko());
            Console.WriteLine("Stanowisko:" + " " + Dyrektor.getStanowisko());
            Console.WriteLine("PESEL:" + " " + Dyrektor.getPESEL());
            Console.WriteLine("Nr_telefonu:" + " " + Dyrektor.getTelefon());
            Console.WriteLine("Adres:" + " " + Dyrektor.getAdres());
            Console.WriteLine("Pensja:" + " " + Dyrektor.getpensja());
            Console.WriteLine("Premia:" + " " + Dyrektor.getPremia());

            Console.WriteLine(" ");

            Kierownik.setAll("o", "o", "Kierownik", 53426825934, 184676548, "Strzelce Kraj", 3000, 550);
            Console.WriteLine("Imię i nazwisko:" + " " + Kierownik.getImie() + " " + Kierownik.getNazwisko());
            Console.WriteLine("Stanowisko:" + " " + Kierownik.getStanowisko());
            Console.WriteLine("PESEL:" + " " + Kierownik.getPESEL());
            Console.WriteLine("Nr_telefonu:" + " " + Kierownik.getTelefon());
            Console.WriteLine("Adres:" + " " + Kierownik.getAdres());
            Console.WriteLine("Pensja:" + " " + Kierownik.getpensja());
            Console.WriteLine("Premia:" + " " + Kierownik.getPremia());

            Console.WriteLine(" ");

            Console.WriteLine("Imię i nazwisko:" + " " + Pracownik1.getImie() + " " + Pracownik1.getNazwisko());
            Console.WriteLine("Stanowisko:" + " " + Pracownik1.getStanowisko());

            Console.WriteLine(" ");

            Console.WriteLine("Imię i nazwisko:" + " " + Pracownik2.getImie() + " " + Pracownik2.getNazwisko());
            Console.WriteLine("Stanowisko:" + " " + Pracownik2.getStanowisko());

            Console.WriteLine("Naciśnij dowolny klawisz aby zakończyć");
            Console.ReadKey();
        }
    }
    public class Pracownicy
    {
        private string Imie;
        private string Nazwisko;
        private string Adres;
        private int Nr_telefonu;
        private long PESEL;
        private string stanowisko;
        private int pensja, premia;
        public Pracownicy()
        {

        }
        public Pracownicy(string Imie, string Nazwisko, string stanowisko)
        {
            this.Imie = Imie;
            this.Nazwisko = Nazwisko;
            this.stanowisko = "Nie podano";
        }
        public Pracownicy(string Imie, string Nazwisko, string stanowisko, long PESEL, int Nr_telefonu, string Adres, int pensja, int premia)
        {
            this.Imie = Imie;
            this.Nazwisko = Nazwisko;
            this.stanowisko = stanowisko;
            this.PESEL = PESEL;
            this.Nr_telefonu = Nr_telefonu;
            this.Adres = Adres;
            this.pensja = pensja;
            this.premia = premia;
        }
        public void setAll(string Imie, string Nazwisko, string stanowisko, long PESEL, int Nr_telefonu, string Adres, int pensja, int premia)
        {
            this.Imie = Imie;
            this.Nazwisko = Nazwisko;
            this.stanowisko = stanowisko;
            this.PESEL = PESEL;
            this.Nr_telefonu = Nr_telefonu;
            this.Adres = Adres;
            this.pensja = pensja;
            this.premia = premia;
        }
        public string getImie()
        {
            return Imie;
        }
        public string getNazwisko()
        {
            return Nazwisko;
        }
        public string getAdres()
        {
            return Adres;
        }
        public int getTelefon()
        {
            return Nr_telefonu;
        }
        public long getPESEL()
        {
            return PESEL;
        }
        public string getStanowisko()
        {
            return stanowisko;
        }
        public int getpensja()
        {
            return pensja;
        }
        public int getPremia()
        {
            return premia;
        }
    }
}
