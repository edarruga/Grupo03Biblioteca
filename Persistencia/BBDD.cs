using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    internal class BBDD
    {
        private static Table<string, LibroDato> tablaLibro = new Table<string, LibroDato>;

        public static Table<string, LibroDato> TablaLibro
        {
            get { return tablaLibro; }
        }

        private BBDD(){}
    }
}
