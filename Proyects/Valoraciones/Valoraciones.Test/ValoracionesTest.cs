using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valoraciones.Test
{
    [TestClass]
    public class ValoracionesTest
    {
        [TestMethod]
        public void CalcularValoracionMax()
        {
            LibroValoraciones Libro = new LibroValoraciones();
            Libro.AgregarValoracion(5);
            Libro.AgregarValoracion(4.5f);
            Libro.AgregarValoracion(3);
            Libro.AgregarValoracion(2);
            Libro.AgregarValoracion(0.5f);
            Libro.AgregarValoracion(3.5f);

            CalcularValoraciones resulatado = Libro.PublicarValoraciones();
            
            Assert.AreEqual(5,resulatado.ValoracionMax);
        }

        [TestMethod]
        public void CalcularValoracionMin()
        {
            LibroValoraciones Libro = new LibroValoraciones();
            Libro.AgregarValoracion(5);
            Libro.AgregarValoracion(4.5f);
            Libro.AgregarValoracion(3);
            Libro.AgregarValoracion(2);
            Libro.AgregarValoracion(0.5f);
            Libro.AgregarValoracion(3.5f);

            CalcularValoraciones resulatado = Libro.PublicarValoraciones();

            Assert.AreEqual(0.5, resulatado.ValoracionMin);
        }

        [TestMethod]
        public void CalcularValoracionPromedio()
        {
            LibroValoraciones Libro = new LibroValoraciones();
            Libro.AgregarValoracion(5);
            Libro.AgregarValoracion(4.5f);
            Libro.AgregarValoracion(3);
            Libro.AgregarValoracion(2);
            Libro.AgregarValoracion(0.5f);
            Libro.AgregarValoracion(3.5f);

            CalcularValoraciones resulatado = Libro.PublicarValoraciones();

            Assert.AreEqual(3.08, resulatado.PromedioValoraciones,0.01);
        }
    }
}
