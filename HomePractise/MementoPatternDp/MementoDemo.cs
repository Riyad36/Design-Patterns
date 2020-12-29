using System;
using System.Collections.Generic;
using System.Text;

namespace MementoPatternDp
{
    public class MementoDemo
    {
        public static void main(String[] args)
        {
            Originator originator = new Originator();
            Caretaker careTaker = new Caretaker();

            originator.setState("State #1");
            originator.setState("State #2");
            careTaker.add(originator.saveStateToMemento());

            originator.setState("State #3");
            careTaker.add(originator.saveStateToMemento());

            originator.setState("State #4");
            Console.WriteLine("Current State: " + originator.getState());

            originator.getStateFromMemento(careTaker.get(0));
            Console.WriteLine("First saved State: " + originator.getState());
            originator.getStateFromMemento(careTaker.get(1));
            Console.WriteLine("Second saved State: " + originator.getState());
        }
    }
}
