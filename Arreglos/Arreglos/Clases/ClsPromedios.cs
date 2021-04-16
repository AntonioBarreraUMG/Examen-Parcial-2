using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos.Clases
{
    class ClsPromedios : InterfacePromedios
    {
        public int promedios_por_parcial(string[,] matriz, int columna_parcial)
        {
            int promedio = 0;

            for (int fila = 1; fila < matriz.GetLength(0); fila++)
            {
                promedio += Convert.ToInt32(matriz[fila, columna_parcial]);
            }
                
            promedio /= (matriz.GetLength(0) - 1);
            return promedio;
        }

        public int promedios_por_seccion(string[,] matriz, int columna_parcial, string seccion)
        {
            int promedio = 0;
            int contador = 0;

            for (int fila = 1; fila < matriz.GetLength(0); fila++)
            {
                if (matriz[fila, 5] == seccion)
                {
                    promedio += Convert.ToInt32(matriz[fila, columna_parcial]);
                    contador++;
                }
            }

            promedio /= contador; 
            return promedio;
        }

        public int promedios_general_seccion(string[,] matriz, string seccion)
        {
            int promedio = 0;
            int contador = 0;

            for (int fila = 1; fila < matriz.GetLength(0); fila++)
            {
                if (matriz[fila, 5] == seccion)
                {
                    promedio += Convert.ToInt32(matriz[fila, 2]);
                    promedio += Convert.ToInt32(matriz[fila, 3]);
                    promedio += Convert.ToInt32(matriz[fila, 4]);
                    contador++;
                }
            }

            promedio /= (contador * 3);
            return promedio;
        }

        public string[,] Clasificar_Alumnos(string[,] matriz, string seccion)
        {
            int tamaño = 0;
            int contador = 0;

            for(int fila = 1; fila < matriz.GetLength(0); fila++)
            {
                if(matriz[fila, 5] == seccion)
                {
                    tamaño++;
                }
            }

            string[,] MatrizAlumnos = new string[tamaño, 2];

            for(int fila = 1; fila < matriz.GetLength(0); fila++)
            {
                if (matriz[fila, 5] == seccion)
                {
                    MatrizAlumnos[contador, 0] = matriz[fila, 1];
                    MatrizAlumnos[contador, 1] = matriz[fila, 5];
                    contador++;
                }
            }

            return MatrizAlumnos;
        }

        public string[,] sumatoria_general_por_alumno(string[,] matriz)
        {
            int sumatoria = 0;

            string[,] SumatoriaAlumnos = new string[matriz.GetLength(0) - 1, 2];

            for (int fila = 1; fila < matriz.GetLength(0); fila++)
                {
                sumatoria = Convert.ToInt32(matriz[fila, 2]) + Convert.ToInt32(matriz[fila, 3]) + Convert.ToInt32(matriz[fila, 4]);
                SumatoriaAlumnos[fila - 1, 0] = matriz[fila, 1];
                SumatoriaAlumnos[fila - 1, 1] = Convert.ToString(sumatoria);
                }

            return SumatoriaAlumnos;
        }
    }
}
