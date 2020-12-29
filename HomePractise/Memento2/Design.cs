using System.Collections.Generic;

namespace Memento2
{
    internal class Design
    {
        public static void Main(string[] args)
        {
            List<Life.Memento> savedTimes = new ArrayList<Life.Memento>();

            Life life = new Life();

            //time travel and record the eras 
            life.set("1000 B.C.");
            savedTimes.Add(life.saveToMemento());
            life.set("1000 A.D.");
            savedTimes.Add(life.saveToMemento());
            life.set("2000 A.D.");
            savedTimes.Add(life.saveToMemento());
            life.set("4000 A.D.");

            life.restoreFromMemento(savedTimes.get(0));


        }
    }
}
