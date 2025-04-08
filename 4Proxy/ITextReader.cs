using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZ_lab3._4Proxy
{
    public interface ITextReader
    {
        char[][] ReadFile(string filePath);
    }
}
