using System;
using System.Collections.Generic;
using System.Text;

namespace LessonReview.Models
{
    public class Dollar
    {
        public double Usd { get; set; }
        public Dollar(double usd)
        {
            Usd = usd;
        }
        
        //public static explicit operator Manat(Dollar dollar)
        //{
        //    return new Manat(dollar.Usd * 1.7);
        //}
    }
}
