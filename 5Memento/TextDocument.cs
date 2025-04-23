using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZ_lab4._5Memento
{
    public class TextDocument
    {
        public string Content { get; set; }

        public TextDocument(string content = "")
        {
            Content = content;
        }

        public void Show()
        {
            Console.WriteLine($"[Документ]: {Content}");
        }

        public TextDocumentMemento Save()
        {
            return new TextDocumentMemento(Content);
        }

        public void Restore(TextDocumentMemento memento)
        {
            Content = memento.Content;
        }
    }
}
