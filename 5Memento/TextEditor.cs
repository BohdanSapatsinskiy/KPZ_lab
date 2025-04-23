using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZ_lab4._5Memento
{
    public class TextEditor
    {
        private TextDocument document;
        private DocumentHistory history;

        public TextEditor(TextDocument document)
        {
            this.document = document;
            this.history = new DocumentHistory();
        }

        public void Type(string text)
        {
            history.Save(document.Save());
            document.Content += text;
        }

        public void Undo()
        {
            var memento = history.Undo();
            if (memento != null)
            {
                document.Restore(memento);
            }
            else
            {
                Console.WriteLine("Немає попередніх версій для скасування.");
            }
        }

        public void ShowDocument()
        {
            document.Show();
        }
    }
}
