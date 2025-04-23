using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZ_lab4._5Memento
{
    public class DocumentHistory
    {
        private Stack<TextDocumentMemento> history = new Stack<TextDocumentMemento>();

        public void Save(TextDocumentMemento memento)
        {
            history.Push(memento);
        }

        public TextDocumentMemento? Undo()
        {
            return history.Count > 0 ? history.Pop() : null;
        }
    }
}
