using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RNE
{
    public class RomanNumberException : Exception
    {
        public RomanNumberException Vod(int n)
        {
            RomanNumberException nol = null;
            try
            {

                throw new Exception("Ошибка: Недопустимое значение, допустимый диапозон {1-999}");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return nol;

        }


    }

}

