using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLiveCoding
{
    internal class Libro
    {
        private string titolo;
        private string autore;
        private int anno;

        public Libro(string titolo, string autore, int anno)
        {
            this.titolo = titolo;
            this.autore = autore;
            this.anno = anno;
        }

        public override string ToString()
        {
            string rappresentazioneInStringa = "-------- Libro --------\n";
            rappresentazioneInStringa += "Titolo:\t" + this.titolo + "\n";
            rappresentazioneInStringa += "Autore:\t" + this.autore + "\n";
            rappresentazioneInStringa += "Anno: \t" + this.anno + "\n";
            rappresentazioneInStringa += "---------------------------";
            return rappresentazioneInStringa;
        }
    }
}
