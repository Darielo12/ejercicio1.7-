using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1._7
{
    internal class matriz
    {
        private int[,] datos;
        public  matriz()
        {
            datos = new int[3, 3];
        }

        
        public void AsignarValores(int[,] nuevos)//parametro para asignar valores
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    datos[i, j] = nuevos[i, j];
                }
            }
        }

        
        public int SumarElementos()
        {
            int suma = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    suma += datos[i, j];
                }
            }
            return suma; 
        }//metodo usado para hacer la suma de los elementos jeje

      
    }//class

}//namespace

