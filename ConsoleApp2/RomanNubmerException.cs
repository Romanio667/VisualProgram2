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
                try
                {
                    if (n == 0 || n < 0)
                    {
                        throw new Exception("Недопустимое заначение");
                    }
                    else
                    {
                        Console.WriteLine($"Вы ввели: {n}");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Ошибка: {e.Message}");
                    throw;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return nol;

        }


    }

}

