/* --- I FILE ---
 
InputStream ------ OutputStream
     |                   |

BinaryReader ----- BinaryWriter
1001010101111001010010101010100010010010 -->

StreamReader ----- StreamWriter
10010101 01111001 01001010 1010100 10010010 -->

StringReader ----- StringWriter
Ciao io mi chiamo Davide, vivo a Napoli -->

----- Standard Streams -----

Standars Input Stream --> rappresentato come Console.In, ci permette di fornire i dati da tastiera ai nostri programmi (WriteLine)

Standard Output Stream --> rappresentato come Console.Out, ci permette di stampare a video i risultati dei nostri programmi (ReadLine)

Standard Error Stream --> rappresentato come Console.Error, è usato per mostrare a video gli errori prodotti dai nostri programmi

----- Gestione dei file -----

File è una classe statica di C# che ermette di manipolare i file. Con il metodo Open possiamo aprire qualunque tipo di file. Questo metodo vuole:
1- una variabile PATH di tipo string che contiene il path del file
2- un parametro MODE di tipo FileMode che indica la modalità con cui un file viene aperto

Streamreader file = File.OpenText{"..."};
FileStream file = File.Open("...", FileMode.Open);



if (File.Exists("C:\Users\Davide\pincopallino.txt"))
{
console.writeLine("Il file esiste");
} else {
console.writeline("Il file non esiste");
}

Directory.CreateDirectory

*/
using NewLiveCoding;



List<Libro> listaDiLibriPreferiti = new List<Libro>();

string path = "C:\\Users\\Dario\\Desktop\\LibriPreferiti.txt";

StreamReader file = File.OpenText(path);

// Butto via la prima riga
string rigaDaButtare = file.ReadLine();

// Da qui in poi sono alla seconda riga

while (!file.EndOfStream)
{
    string riga = file.ReadLine();
    string[] informazioni = riga.Split(',');

    if (informazioni.Length == 3)
    {
        string titolo = informazioni[0];
        string autore = informazioni[1];
        int anno = int.Parse(informazioni[2]);

        titolo.Replace("- ", "");
        Libro libroPreferito = new Libro(titolo, autore, anno);
        listaDiLibriPreferiti.Add(libroPreferito);
        Console.WriteLine(riga);
    } else
    {
        Console.WriteLine("Mi dispiace ma non è un libro compatibile");
    }
}
file.Close();

// ---------- Scrivere su un file ---------

StreamWriter fileDascrivere = File.CreateText("C:\\Users\\Dario\\Desktop\\LibriPreferitiFormattati.txt");

foreach (Libro libro in listaDiLibriPreferiti)
{
    Console.WriteLine(libro.ToString());
    Console.WriteLine();
}







