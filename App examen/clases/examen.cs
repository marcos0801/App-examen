using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_examen.clases
{
    class examen
    {
        /// <summary>
        /// Funcion que devuelve verdadero si es el numero primo
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static  Boolean EsPrimo(int num)
        {
            Boolean primo = true;

            for(int i=2; i<=num/2; i++)
            {
                if(num%i==0)
                {
                    primo = false;
                    break; //abandonar clase
                }
            }
            return primo;
        }
        public static int sumatoria(int limite)
        {
            int cont = 0;
            int num = 2 , suma=0 ;
            while (cont < limite)
            {
                if (EsPrimo(num))
                {
                    suma += num;
                    cont++;
                }

                num++;

            }
            
            return suma;
        }
       
    }
}
