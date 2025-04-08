using KPZ_lab3.Composit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZ_lab3.Flyweight
{
    internal class FlyweightFactory
    {
        private readonly Dictionary<string, LightElementNode> _flyweights = new Dictionary<string, LightElementNode>();

        public LightElementNode GetFlyweight(string tagName)
        {
            if (!_flyweights.ContainsKey(tagName))
            {
                var newNode = new LightElementNode(tagName, tagName == "h1" || tagName == "h2" || tagName == "blockquote", false);
                _flyweights[tagName] = newNode;
            }
            return _flyweights[tagName];
        }
    }
}
