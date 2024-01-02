using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplomski
{
    [Serializable]
    public class Korisnik
    {
        /*Atributi*/
        int id_korisnika;
        string ime;
        string prezime;
        string korisnicko_ime;
        string lozinka;
        DateTime datum_zaposlenja;
        DateTime datum_isteka_ugovora;
        string posao;
        float plata;
        /*Konstruktor*/
        public Korisnik(int id_korisnika, string ime, string prezime, string korisnicko_ime, string lozinka, DateTime datum_zaposlenja, DateTime datum_isteka_ugovora, string posao, float plata)
        {
            this.Id_korisnika = id_korisnika;
            this.Ime = ime;
            this.Prezime = prezime;
            this.Korisnicko_ime = korisnicko_ime;
            this.Lozinka = lozinka;
            this.Datum_zaposlenja = datum_zaposlenja;
            this.Datum_isteka_ugovora = datum_isteka_ugovora;
            this.Posao = posao;
            this.Plata = plata;
        }
        /*Geteri i seteri*/
        public int Id_korisnika { get => id_korisnika; set => id_korisnika = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Korisnicko_ime { get => korisnicko_ime; set => korisnicko_ime = value; }
        public string Lozinka { get => lozinka; set => lozinka = value; }
        public DateTime Datum_zaposlenja { get => datum_zaposlenja; set => datum_zaposlenja = value; }
        public DateTime Datum_isteka_ugovora { get => datum_isteka_ugovora; set => datum_isteka_ugovora = value; }
        public string Posao { get => posao; set => posao = value; }
        public float Plata { get => plata; set => plata = value; }
    }
}
