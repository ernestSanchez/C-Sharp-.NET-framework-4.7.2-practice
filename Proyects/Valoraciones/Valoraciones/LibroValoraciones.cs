using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valoraciones
{
    public enum IdiomaLibro //<--- declaro el enum para los idiomas del libro
    {
        none, EN, ES, GE, IT
    }
    public class LibroValoraciones
    {
        private string _valoaracionesLetras;
        public string ValoracionesLetras
        {
            get
            {
                return _valoaracionesLetras;
            }
        }

        private string _nombre;
        public string Nombre
        {

            get
            {
                return _nombre;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _nombre = value;
                }
            }
        }
        public IdiomaLibro Idioma;
        private List<float> valoraciones; //<--- datos privados en minus
        public LibroValoraciones() 
        {
            valoraciones = new List<float>(); 
        }
        public CalcularValoraciones PublicarValoraciones() //<---todos los datos publics en mayus
        {
            CalcularValoraciones calculo = new CalcularValoraciones();
            float sumaValoraciones = 0;
            foreach (float valoracion in valoraciones)
            {
                //sumaValoraciones = sumaValoraciones + valoracion; <--- manera basica y abajo manera limpia
                calculo.ValoracionMax = Math.Max(valoracion, calculo.ValoracionMax);
                calculo.ValoracionMin = Math.Min(valoracion, calculo.ValoracionMin);

                sumaValoraciones += valoracion;
            }


            calculo.PromedioValoraciones = sumaValoraciones / valoraciones.Count;
            AsignarLetraVloracion(calculo.PromedioValoraciones);
            return calculo;
        }

        private void AsignarLetraVloracion(float VL)
        {
           if (VL <= 5 && VL > 4)
            {
                _valoaracionesLetras = "A";
            }
           else if (VL <= 4 && VL > 3)
            {
                _valoaracionesLetras = "B";
            }
           else if (VL <= 3 && VL > 2)
            {
                _valoaracionesLetras = "C";
            }
            else if (VL <= 2 && VL > 1)
            {
                _valoaracionesLetras = "D";
            }
            else             
            {
                _valoaracionesLetras = "E";
            }
        }

        public void AgregarValoracion(float valoracion)  
        {
            valoraciones.Add(valoracion);
        }

        
    }
}
