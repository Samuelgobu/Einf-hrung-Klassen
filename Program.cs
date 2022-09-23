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
            DateTime
        }
    }
}
