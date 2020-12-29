using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MementoPatternDp
{
    public class Caretaker
    {
        private List<Memento> mementoList = new ArrayList<Memento>();

        public void add(Memento state)
        {
            mementoList.Add(state);
        }

        public Memento get(int index)
        {
            return mementoList.get(index);
        }

    }
}
