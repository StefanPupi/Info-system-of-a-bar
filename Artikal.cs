using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplomski
{
    [Serializable]
    class Artikal
    {
        /*Atributi*/
        int id_artikal;
        string naziv;
        string jedinica_prodaje;
        float kolicina;
        float cena;
        float minimalna_kolicina;
        double barkod;
        string kategorija;
        /*Konstruktor*/
        public Artikal(int id_artikal, string naziv, string jedinica_prodaje, float kolicina, float cena, float minimalna_kolicina, double barkod, string kategorija)
        {
            this.id_artikal = id_artikal;
            this.naziv = naziv;
            this.jedinica_prodaje = jedinica_prodaje;
            this.kolicina = kolicina;
            this.cena = cena;
            this.minimalna_kolicina = minimalna_kolicina;
            this.barkod = barkod;
            this.Kategorija = kategorija;
        }
        /*Geteri i seteri*/
        public int Id_artikal { get => id_artikal; set => id_artikal = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public float Kolicina { get => kolicina; set => kolicina = value; }
        public float Cena { get => cena; set => cena = value; }
        public float Minimalna_kolicina { get => minimalna_kolicina; set => minimalna_kolicina = value; }
        public double Barkod { get => barkod; set => barkod = value; }
        public string Jedinica_prodaje { get => jedinica_prodaje; set => jedinica_prodaje = value; }
        public string Kategorija { get => kategorija; set => kategorija = value; }
    }
}
