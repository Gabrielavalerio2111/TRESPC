using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRABALHO
{
    class Menu
    {
        public string Id { set; get; }
        public string Nome { set; get; }
        public string Fone { set; get; }

        public override string ToString()
        {
            return "Id: " + Id + ", Nome: " + Nome + ", Fone: " + Fone;
        }

    }
}
