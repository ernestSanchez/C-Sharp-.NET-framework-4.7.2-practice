using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juego3EnRaya
{
    class Program
    {
        //creacion de arreglo bidimensional para tablero del juego 
        static int[,] tablero = new int[3, 3];//<--- 3 filas -3 columnas
        //creamos un arreglo para los simbolos del tablero: Espacio en blanco, jug.1, jug.2
        static char[] simbolo = { ' ', 'O', 'X' };

        static void Main(string[] args)
        {
            bool terminado = false;

            //Dibujar el tablero inicial
            DibujarTablero();
            Console.WriteLine("Jugador 1 = O\nJugador 2 = X");


            do //utilizamos el ciclo do-while porque desconocemos el numero de veces que se tiene que realizar//
            {
                //turno jugador 1
                PreguntarPosicion(1); //envia el valor de 1 a la funcion PreguntarPosicion

                //dibujar la casilla del jugador 1
                DibujarTablero();

                //comprobar si gano la partida el jugador 1
                terminado = ComprobarGanador();

                if(terminado == true)
                {
                    Console.WriteLine("¡El jugador 1 ha ganado!");
                }
                else
                {
                    terminado = ComprobarEmpate();
                   
                    if(terminado == true)
                    {
                        Console.WriteLine("Empate!!!");
                    }
                    else
                    {
                        //turno Jugador 2
                        PreguntarPosicion(2);
                       
                        //dibujar la casilla del jugador 2
                        DibujarTablero();

                        //comprobar si gano la partida el jugador 2
                        terminado = ComprobarGanador();

                        if (terminado == true )
                        {
                            Console.WriteLine("¡El jugador 2 ha ganado!");
                        }
                    }


                }

                //repetir hasta 3 en linea o empate
            } while (terminado == false); /*mientras la variable sea igual a false se seguira repitiendo el ciclo 
                                            hasta que sea true */

        }//Cierre de main

        static void DibujarTablero()
        {
            //variables del conteo del ciclo 
            int fila = 0;
            int columna = 0;

            Console.WriteLine();//<---- espacio antes de dibujar tablero 
            Console.WriteLine("-------------");// <---- dibujar linea horizontal

            for(fila = 0; fila < 3; fila++)
            {
                Console.Write("|");//<---- dibujar la primera linea vertical 
               
                for(columna = 0; columna < 3; columna++)
                {
                    //Asigna: un Espacio, O,X, segun corresponda
                    Console.Write(" {0} |",simbolo[tablero[fila,columna]]);
                }
                Console.WriteLine();
                Console.WriteLine("-------------"); //<--- dibujar las lineas horizontales por cada iteracion del bucle
            }
        }

        //preguntar donde escribir y lo dibuja en el tablero 
        static void PreguntarPosicion(int jugador)//<---- 1= Jugsador1 ; 2= Jugador2
        {
            int fila, columna;
            do
            {
                Console.WriteLine();
                Console.WriteLine("turno Jugador: {0}",jugador);
                //pedimos el numero de fila
                do
                {
                    Console.Write("selecciona la fila (1 a 3): ");
                    fila = Convert.ToInt32(Console.ReadLine());

                } while ((fila < 1)||(fila > 3));// ejecutar mientras fila sea menor que 1 o mayor que 3 

                //pedimos el numero de columna 
                do
                {
                    Console.Write("selecciona la columna (1 a 3): ");
                    columna = Convert.ToInt32(Console.ReadLine());

                } while ((columna < 1) || (columna > 3));

                if (tablero[fila -1,columna-1] != 0)
                {
                    Console.WriteLine("Casilla ocupada!");
                }

            } while (tablero[fila - 1, columna - 1] != 0);

            //si todo es correcto se le asigna al jugador correspondiente 
            tablero[fila - 1, columna - 1] = jugador;
        }

        //Devuelve true si se crea 3 en linea 
        static bool ComprobarGanador()
        {
            int fila = 0;
            int columna = 0;
            bool tresEnLinea = false;


            //si en alguna fila todas las casillas son iguales y no estan vacias:
            for (fila = 0; fila <3; fila++)
            {
                if ((tablero[fila,0] == tablero[fila,1]) && (tablero[fila, 0] == tablero[fila, 2]) && (tablero[fila, 0] != 0))
                {
                    tresEnLinea = true;
                }
            }

            //si en alguna columna todas las casillas son iguales y no estan vacias..
            for (columna = 0; columna < 3; columna++)
            {
            if ((tablero[0, columna] == tablero[1, columna]) && (tablero[0, columna] == tablero[2, columna]) && 
                    (tablero[0, columna] != 0))
                {
                    tresEnLinea = true;
                }
            }

            //si en alguna diagonal todas las casillas son iguales y no estan vacias..
            if ((tablero[0, 0] == tablero[1, 1]) && (tablero[0, 0] == tablero[2, 2]) && (tablero[0, 0] != 0))
            {
                tresEnLinea = true;
            }

            if ((tablero[0, 2] == tablero[1, 1]) && (tablero[0, 2] == tablero[2, 0]) && (tablero[0, 2] != 0))
            {
                tresEnLinea = true;
            }

            return tresEnLinea;
        }

        // devuelve "true" si hay empate
        static bool ComprobarEmpate()
        {
            bool hayEspacio = false;
            int fila = 0;
            int columna = 0;

            for (fila = 0; fila < 3; fila++)
            {
                for(columna = 0; columna < 3; columna++)
                {
                    if (tablero[fila, columna] == 0) /*si encuentra una sola casilla vacia quiere 
                                                            decir que aun se puede seguir jugando */
                    {
                        hayEspacio = true;
                    }
                }
            }

            return !hayEspacio; /*si el ciclo anterior nos regresa true,indicandonos que si hay espacios, 
                                        entonces se tiene que regresar una negacion de true 
                                    para que la condicion de empate no se cumpla en la funcion de Main()*/

        }
    }
}
