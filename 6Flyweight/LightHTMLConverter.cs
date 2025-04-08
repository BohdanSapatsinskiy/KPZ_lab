using KPZ_lab3.Composit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZ_lab3.Flyweight
{
    public class LightHTMLConverter
    {
        public List<LightElementNode> ConvertTextToHTML(string[] lines)
        {
            List<LightElementNode> htmlNodes = new List<LightElementNode>();

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                LightElementNode node;

                if (i == 0)
                {
                    node = new LightElementNode("h1", true, false);
                }
                else if (line.StartsWith(" "))
                {
                    node = new LightElementNode("blockquote", true, false);
                }
                else if (line.Length < 20)
                {
                    node = new LightElementNode("h2", false, false);
                }
                else
                {
                    node = new LightElementNode("p", false, false);
                }

                var textNode = new LightTextNode(line);
                node.AddChild(textNode);

                htmlNodes.Add(node);
            }
            return htmlNodes;
        }
    }
}

