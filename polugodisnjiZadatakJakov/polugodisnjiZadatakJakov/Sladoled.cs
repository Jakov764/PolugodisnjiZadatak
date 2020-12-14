using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polugodisnjiZadatakJakov
{
    public class Sladoled
    {
        public string naziv { get; set; }
        public string oblik { get; set; }
        public string okus { get; set; }
        public string preljev { get; set; }
        public double cijena { get; set; }




        public Sladoled(string naziv, string oblik, string okus, string preljev)
        {
            this.naziv = naziv;
            this.oblik = oblik;
            this.okus = okus;
            this.preljev = preljev;
        }

        public string Ispis()
        {
            string ispis = string.Format("Naziv: {0}, Oblik: {1}, Okus: {2}, Preljev {3}", naziv, oblik, okus, preljev);
            return ispis;
        }
        public string Ispis2()
        {
            string ispis = string.Format("Naziv: {0}, Oblik: {1}, Okus: {2}, Preljev {3}, Cijena: {4}", naziv, oblik, okus, preljev, cijena);
            return ispis;
        }
    }
}
