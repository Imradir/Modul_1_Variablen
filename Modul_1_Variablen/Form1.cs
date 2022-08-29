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
            //dr�fen Buchstaben, Zahlen und einige Sonderzeichen enthalten(Unterstrich)
            //m�glichst nur englisches Alphabet
            //in einem G�ltigkeitsbereich nie Variablen mit gleichem Namen
            //Zuweisung per Gleichheitszeichen
            //Variabler auf rechter Seite MUSS VORHER einen Wert erhalten!

            //Variablen bestehen aus ihrem Namen und einem Datentypen

            /*Datentypen f�r Ganzzahlen sind: byte; short; int; und long
             *Datentypen f�r Dezimalzahlen sind: float; double und decimal
             *Dabei ist wichtig, dass entsprechende Zahlen auch mit einem . abgetrennt sind (quasi das Komma)
             *Datentyp f�r Wahrheitswerte ist: bool
             *Werte f�r werden via KLEINEM true oder false zugewiesen und GRO�EM True oder False ausgegeben
             *Datentyp f�r einzelne Zeichen ist: char
             *Datentyp f�r Zeichenfolgen ist: string*/

            //Deklarierung einer einzelnen Variable:
            int Zahl1;

            //Deklarierung mehrerer Variablen vom gleichen Typ:
            string Satz1, Satz2, Satz3;

            //Zuweisung eines Wertes:
            Satz1 = "Hallo";

            //Initialisierung mit Wert:
            int Zahl2 = 2;

            /*Bez�glich des G�ltigkeitsbereiches:
             *Variable in einer Methode ist AUSSCHLIE�LICH in dieser Methode bekannt
             *erneuter Aufruf der Methode f�hrt auch zu einer erneuten Deklarierung der Variablen
             *vorherige Variable kann also so nicht wieder verwendet werden
             *
             *Variable aus�erhalb einer Methode ist f�r die GANZE Klasse g�ltig
             *es handelt sich dann um die Eigenschaft des jeweiligen Objektes der Klasse, also um eine OBJEKTEIGENSCHAFT!
             *diese Variable kann dann von JEDER in der Klasse befindlichen Methode benutzt werden
             *damit sie nur in dieser Klasse bekannt ist, muss sie mit private deklariert werden
             *via public w�re sie auch in anderen Klassen anwendbar
             *
             *auch hier gilt nochmal: lokale Variablen mit DEMSELBEN Namen in einer Methode sind nicht zul�ssig und f�hren zu einem FEHLER!
             *WICHTIG!: eine Objekteigenschaft(Klassenvariable) wird von gleichgenannten lokalen Variablen �berschrieben!*/
         
        }

        /*Konstanten:
          *sind vordefinierte Werte, k�nnen also w�hrend LAUFZEIT nicht ver�ndert werden
          *aussagekr�ftige Namen sind hier empfehlenswert
          *sollten an ZENTRALER Stelle definiert werden, in einer Methode w�ren sie also ziemlich sinnlos, k�nnen aber dennoch dort deklariert werden
          *auch werden Objekteigenschaftskonstanten von lokalen Konstanten �BERSCHRIEBEN!
          *sie werden also zum Beispiel wie hier in einer Klasse deklariert
          *es muss zudem auch immer direkt ein Wert initialisiert werden(via = )
          *Schl�sselwort lautet const*/


        private const int KonstanteZahl1 = 5;


        /*Enumerationen:
         *sind Aufz�hlungen von Konstanten
         *haben denselben Datentyp, welcher GANZZAHLIG sein muss (byte; short; int; long)
         *direkt bei der Deklararion werden ihnen Werte zugewiesen
         *Schl�sselwort ist enum
         Deklaration folgt nach dem Muster: private(etc) enum Name : Datentyp, danach dann geschweifte Klammern mit den jeweiligen Zuweisung darin*/


        //hier erfolgt eine eigene Enumeration sowie deren Aufruf

        private enum Pilz : int
        {
            Steinpilz = 1, Fliegenpilz = 2, Stinkmorchel = 3
        }

        //hier folgt der Aufruf, blo� auskommentiert, da zu faul jetzt ein Label zu erstellen
        //ACHTUNG!: $ , sowie die Nutzung geschweifter Klammern danach erwirkt, dass auch die WERTE von berechneten Ausdr�cken in ZEICHENFOLGEN genutzt und dargestellt werden k�nnen
        //(Angabe von z.B. int in einem gr��eren String)

        // LblAnzeige.Text = $"Pilz: {Pilz.Steinpilz}";

        //Weiterhin gibt es bereits vorgefertigte Enumerationen wie z.B. DayOfWeek


    }
}