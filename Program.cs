using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Einführung_Klassen
{

    internal class Program
    {
        static void Main(string[] args)
        {
            //Student student1 = new Student();
            //student1.Vorname = "Rohan";
            //student1.Vorname = "Khalil";

            Student student1 = new Student("Rohan", "Acharya", 20, "Nepal", "T21", "27.11.2001");
            student1.Begrüsung();
            Student student2 = new Student("Khalil", "Acharya", 20, "Nepal", "T21", "27.11.2001");
            student2.Begrüsung();

            Hund hund1 = new Hund("Firulais", "Schwarz", 7, 75);
            hund1.Bellen();
        }
    }
    /* --- Klassen in C#---
     * Klassen ermöglichen es Code in C# weiter zu strukturieren und
     * übersichtlicher zu machen
     * 
     * Man unercheidet zwischen statischen Klassen ohne Objekte und 
     * Klassen mit Objekten.
     * 
     * Wir können zum Beispiel eine Klasse erstellen, in der Studenten 
     * gespeichert sind. Die Studenten sind in dem Fall die Objekte in der Klasse.
     * 
     * ---Eigenschaften---
     * Jedes Objekt benötigt Eigenschaften, damit man zwischen mehreren Objekten
     * unterscheiden kann. Eine Eigenschaft ist eine besondere Variable.
     * Eigenschaften sind GEKAPSELTE Variablen. Das bedeutet: nicht jedes Objekt
     * oder jede Methode kann ohne Weiteres auf diese Variablen zugriefen.
     * 
     * Ein Student hat zum Beispiel folgende Eigenschaften:
     * Vorname, Nachname, Alter, Nationalität, Gruppe, ...
     */
    class Student
    {
        // Am Anfang der Klasse werden die Eigenschaften definiert:
        public string Vorname { get; set; }
        private string Nachname;
        private int Alter;
        private string Nationalität;
        private string Gruppe;
        private string Birthday;
        /*Eigenschaften können public oder private sein. Eine public
         * Eigenschaft kann auch in anderen Klassen gesehen verändert
         * werden. Eine private Eigenschaft ist nur Methoden in der eigenen
         * Klasse sichtbar. Normalerweise sollten Eigenschaften private sein.
         * 
         * Wenn Eigenschaften privat sind, braucht man einen KONSTRUKTOR
         * um Objekte mir dieser Eigenschaft zu erzeugen.
         * Ein Konstruktor sieht zum Beispiel so aus:
         * 
         */
        public Student(string vorname, string nachname, int alter, string nation, string gruppe, string birthday)
        {
            Vorname = vorname;
            Nachname = nachname;
            Alter = alter;
            Nationalität = nation;
            Gruppe = gruppe;
            Birthday = birthday;
        }
        private static void Geburtstag()
        {
            //Wenn der Student Geburtstag hat, wird sein Alter um 1 erhöht.
            DateTime dt = DateTime.Now; //Die aktuelle Uhrzeit und das aktuelle Datum
            Console.WriteLine(dt.Date);
        }
        public void Begrüsung()
        {
            Console.WriteLine(Vorname + " sagt Halle!");
        }
        
    }
    /*Übung 1: Erstellen Sie die Klasse Hund. Onjekte in dieser Klasse haben
     * die Eigenschaften:
     * Farbe; Größe, Name, Alter.
     * In der Klasse gibt es die Methode Bellen(). Wenn die Methode in der
     * Main-Methode aufgerufen wird, wird "Name bellt." in die Konsole
     * geschrieben. Erstellen Sie einen Hund in der Main-Methode und lassen Sie
     * ihn bellen.
     */
    class Hund
    {

        public string Name;
        public string Farbe;
        public int Alter;
        public double Größe;
        public Hund(string name, string farbe, int alter, double größe)
        {
            Name = name;
            Farbe = farbe;
            Alter = alter;
            Größe = größe;

        }
        public void Bellen()
        {
            Console.WriteLine(Name + " bellt jetzt. " + Name +" blafft Sie an");
        }
    }
}
