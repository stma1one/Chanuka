using System;

namespace Chanuka
{
    class Program
    {
        static void Main(string[] args)
        {
            Tune t = new Tune();
            t.AddNote(new Note("D", Note.D, Note.HALF));
            t.AddNote(new Note("C", Note.C, Note.EIGHTH));
            t.AddNote(new Note("D", Note.D, Note.QUARTER));
            t.AddNote(new Note("F", Note.F, Note.QUARTER));
            t.AddNote(new Note("E", Note.E, Note.QUARTER));
            t.AddNote(new Note("F", Note.F, Note.QUARTER));
            t.AddNote(new Note("D", Note.D, Note.HALF));

            t.AddNote(new Note("D", Note.D, Note.QUARTER));
            t.AddNote(new Note("C", Note.C, Note.EIGHTH));
            t.AddNote(new Note("D", Note.D, Note.QUARTER));
            t.AddNote(new Note("F", Note.F, Note.QUARTER));
            t.AddNote(new Note("E", Note.E, Note.QUARTER));
            t.AddNote(new Note("F", Note.F, Note.QUARTER));
            t.AddNote(new Note("D", Note.D, Note.HALF));

            t.AddNote(new Note("G", Note.G, Note.HALF));
            t.AddNote(new Note("F", Note.F, Note.EIGHTH));
            t.AddNote(new Note("G", Note.G, Note.QUARTER));
            t.AddNote(new Note("F", Note.F, Note.QUARTER));
            t.AddNote(new Note("D", Note.D, Note.QUARTER));
            t.AddNote(new Note("F", Note.F, Note.QUARTER));
            t.AddNote(new Note("G", Note.G, Note.HALF));

            t.AddNote(new Note("G", Note.G, Note.QUARTER));
            t.AddNote(new Note("F", Note.F, Note.EIGHTH));
            t.AddNote(new Note("G", Note.G, Note.QUARTER));
            t.AddNote(new Note("F", Note.F, Note.QUARTER));
            t.AddNote(new Note("D", Note.D, Note.QUARTER));
            t.AddNote(new Note("F", Note.F, Note.QUARTER));
            t.AddNote(new Note("G", Note.G, Note.HALF));

            t.AddNote(new Note("A", Note.A * 2, Note.QUARTER));
            t.AddNote(new Note("G", Note.G, Note.EIGHTH));
            t.AddNote(new Note("F", Note.F, Note.EIGHTH));
            t.AddNote(new Note("F", Note.F, Note.QUARTER));
            t.AddNote(new Note("D", Note.D, Note.QUARTER));
            t.AddNote(new Note("D", Note.D, Note.QUARTER));
            t.AddNote(new Note("C", Note.C, Note.QUARTER));
            t.AddNote(new Note("D", Note.D, Note.HALF));

            t.AddNote(new Note("A", Note.A * 2, Note.QUARTER));
            t.AddNote(new Note("G", Note.G, Note.EIGHTH));
            t.AddNote(new Note("F", Note.F, Note.EIGHTH));
            t.AddNote(new Note("F", Note.F, Note.QUARTER));

            t.AddNote(new Note("A", Note.A * 2, Note.QUARTER));
            t.AddNote(new Note("G", Note.G, Note.QUARTER));
            t.AddNote(new Note("F", Note.F, Note.EIGHTH));
            t.AddNote(new Note("E", Note.E, Note.EIGHTH));
            t.AddNote(new Note("D", Note.D, Note.HALF));

            t.AddNote(new Note("A", Note.A * 2, Note.QUARTER));
            t.AddNote(new Note("G", Note.G, Note.EIGHTH));
            t.AddNote(new Note("F", Note.F, Note.EIGHTH));
            t.AddNote(new Note("F", Note.F, Note.QUARTER));
            t.AddNote(new Note("D", Note.D, Note.QUARTER));
            t.AddNote(new Note("D", Note.D, Note.QUARTER));
            t.AddNote(new Note("C", Note.C, Note.QUARTER));
            t.AddNote(new Note("D", Note.D, Note.HALF));

            t.AddNote(new Note("A", Note.A * 2, Note.QUARTER));
            t.AddNote(new Note("G", Note.G, Note.EIGHTH));
            t.AddNote(new Note("F", Note.F, Note.EIGHTH));
            t.AddNote(new Note("F", Note.F, Note.QUARTER));

            t.AddNote(new Note("A", Note.A * 2, Note.QUARTER));
            t.AddNote(new Note("G", Note.G, Note.QUARTER));
            t.AddNote(new Note("F", Note.F, Note.EIGHTH));
            t.AddNote(new Note("E", Note.E, Note.EIGHTH));
            t.AddNote(new Note("D", Note.D, Note.WHOLE));



            t.Play();

            Console.ReadKey();
        }
    }
}
