namespace Modul_1_Variablen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Variablen beginnen immer mit einem Buchstaben
            //drüfen Buchstaben, Zahlen und einige Sonderzeichen enthalten(Unterstrich)
            //möglichst nur englisches Alphabet
            //in einem Gültigkeitsbereich nie Variablen mit gleichem Namen
            //Zuweisung per Gleichheitszeichen
            //Variabler auf rechter Seite MUSS VORHER einen Wert erhalten!

            //Variablen bestehen aus ihrem Namen und einem Datentypen

            /*Datentypen für Ganzzahlen sind: byte; short; int; und long
             *Datentypen für Dezimalzahlen sind: float; double und decimal
             *Dabei ist wichtig, dass entsprechende Zahlen auch mit einem . abgetrennt sind (quasi das Komma)
             *Datentyp für Wahrheitswerte ist: bool
             *Werte für werden via KLEINEM true oder false zugewiesen und GROßEM True oder False ausgegeben
             *Datentyp für einzelne Zeichen ist: char
             *Datentyp für Zeichenfolgen ist: string*/

            //Deklarierung einer einzelnen Variable:
            int Zahl1;

            //Deklarierung mehrerer Variablen vom gleichen Typ:
            string Satz1, Satz2, Satz3;

            //Zuweisung eines Wertes:
            Satz1 = "Hallo";

            //Initialisierung mit Wert:
            int Zahl2 = 2;

            /*Bezüglich des Gültigkeitsbereiches:
             *Variable in einer Methode ist AUSSCHLIEßLICH in dieser Methode bekannt
             *erneuter Aufruf der Methode führt auch zu einer erneuten Deklarierung der Variablen
             *vorherige Variable kann also so nicht wieder verwendet werden
             *
             *Variable ausßerhalb einer Methode ist für die GANZE Klasse gültig
             *es handelt sich dann um die Eigenschaft des jeweiligen Objektes der Klasse, also um eine OBJEKTEIGENSCHAFT!
             *diese Variable kann dann von JEDER in der Klasse befindlichen Methode benutzt werden
             *damit sie nur in dieser Klasse bekannt ist, muss sie mit private deklariert werden
             *via public wäre sie auch in anderen Klassen anwendbar
             *
             *auch hier gilt nochmal: lokale Variablen mit DEMSELBEN Namen in einer Methode sind nicht zulässig und führen zu einem FEHLER!
             *WICHTIG!: eine Objekteigenschaft(Klassenvariable) wird von gleichgenannten lokalen Variablen überschrieben!*/
         
        }

        /*Konstanten:
          *sind vordefinierte Werte, können also während LAUFZEIT nicht verändert werden
          *aussagekräftige Namen sind hier empfehlenswert
          *sollten an ZENTRALER Stelle definiert werden, in einer Methode wären sie also ziemlich sinnlos, können aber dennoch dort deklariert werden
          *auch werden Objekteigenschaftskonstanten von lokalen Konstanten ÜBERSCHRIEBEN!
          *sie werden also zum Beispiel wie hier in einer Klasse deklariert
          *es muss zudem auch immer direkt ein Wert initialisiert werden(via = )
          *Schlüsselwort lautet const*/


        private const int KonstanteZahl1 = 5;


        /*Enumerationen:
         *sind Aufzählungen von Konstanten
         *haben denselben Datentyp, welcher GANZZAHLIG sein muss (byte; short; int; long)
         *direkt bei der Deklararion werden ihnen Werte zugewiesen
         *Schlüsselwort ist enum
         Deklaration folgt nach dem Muster: private(etc) enum Name : Datentyp, danach dann geschweifte Klammern mit den jeweiligen Zuweisung darin*/


        //hier erfolgt eine eigene Enumeration sowie deren Aufruf

        private enum Pilz : int
        {
            Steinpilz = 1, Fliegenpilz = 2, Stinkmorchel = 3
        }

        //hier folgt der Aufruf, bloß auskommentiert, da zu faul jetzt ein Label zu erstellen
        //ACHTUNG!: $ , sowie die Nutzung geschweifter Klammern danach erwirkt, dass auch die WERTE von berechneten Ausdrücken in ZEICHENFOLGEN genutzt und dargestellt werden können
        //(Angabe von z.B. int in einem größeren String)

        // LblAnzeige.Text = $"Pilz: {Pilz.Steinpilz}";

        //Weiterhin gibt es bereits vorgefertigte Enumerationen wie z.B. DayOfWeek


    }
}