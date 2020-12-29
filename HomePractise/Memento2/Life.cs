using System;
using System.Text;

namespace Memento2
{
    public class Life
    {
        private string time;

        public void set(string time)
        {
            Console.WriteLine("Setting time to " + time);
        }

        public Memento saveToMemento()
        {
            Console.WriteLine("Saving time to Memento");
                return new Memento(time);
        }

        public void restoreFromMemento(Memento memento)
        {
            time = memento.getSavedTime();
            Console.WriteLine("TIme restored from Memento: " + time);
        }

        public class Memento
        {
            private string time;

            public Memento(string timeToSave)
            {
                time = timeToSave;
            }

            public string getSavedTime()
            {
                return time;
            }

        }
    }
}
