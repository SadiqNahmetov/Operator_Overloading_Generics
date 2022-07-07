using System;
using System.Collections.Generic;
using System.Text;

namespace LessonReview.Models
{
    public class Manat
    {
      public double Azn { get; set; }

       public Manat( double azn)
        {
            Azn = azn;
        }



        public static implicit operator Dollar(Manat manat)
        {
            return new Dollar(manat.Azn / 1.7);
        }

        //public double ConvertAznToUsd(double azn)
        //{
        //    return azn / 1.7;
        //}
    }
}
