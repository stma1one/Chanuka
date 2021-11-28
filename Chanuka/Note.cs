using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chanuka
{
    public class Tune
    {
        private Node<Note> notes;


        public void AddNote(Note n)
        {

            if (notes == null)
                notes = new Node<Note>(n);
            else
            {
                Node<Note> temp = notes;
                while (temp.HasNext())
                    temp = temp.GetNext();
                temp.SetNext(new Node<Note>(n));
            }
        }

        public void Play()
        {
            Node<Note> temp = notes;
            while (temp!=null)
            {
                temp.GetValue().Play();
                temp = temp.GetNext();
            }
        }

        public void RevPlay()
        {

        }

        public void DelNote(Note n)
        {

        }

        public int HowManyNotes(Note s)
        {
            return 0;
        }


    }
    public class Note
    {
        public const int WHOLE = 1600, HALF = WHOLE / 2, QUARTER = HALF / 2, EIGHTH = QUARTER / 2, SIXTEEN = EIGHTH / 2;
        public  const int REST = 0, GbelowC = 196, A = 220,
                        Asharp = 233,
                        B = 247,
                        C = 262,
                        Csharp = 277,
                        D = 294,
                        Dsharp = 311,
                        E = 330,
                        F = 349,
                        Fsharp = 370,
                        G = 392,
                        Gsharp = 415;

        private string name;
        private int frequncy;
        private int duration;

        public Note(string name,int frequency,int duration)
        {
            this.name = name;
            this.frequncy = frequency;
            this.duration = duration;
        }
        public int GetFreQ()
        {
            return frequncy;
        }
        public int GetDuration()
        {
            return duration;
        }
        public string GetName()
        {
            return name;
        }

        public void Play()
        {
            Console.Beep(frequncy, duration);
        }

    }
}
