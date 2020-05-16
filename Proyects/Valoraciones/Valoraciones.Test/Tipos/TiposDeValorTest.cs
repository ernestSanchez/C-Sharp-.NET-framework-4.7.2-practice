using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valoraciones.Test.Tipos
{
   
   [TestClass]
   public class TiposDeValorTest
    {
        /*
        int x; //<--- numeros enteros
        float y; //<--- decimales hasta 6 
        double z; //<--- decimales hasta 12
        string cadenas; //<---- texto

        */

        [TestMethod]
        public void VariableTiposDeValor()
        {
            int x1 = 10;
            int x2 = x1;
            Assert.AreEqual(x1, x2);
        }

        [TestMethod]
        public void VariableTiposDeValorEnum()
        {
            LibroValoraciones Libro = new LibroValoraciones();
            Libro.Idioma = IdiomaLibro.ES;


            Assert.AreEqual(Libro.Idioma, IdiomaLibro.ES);
        }
    }
}
