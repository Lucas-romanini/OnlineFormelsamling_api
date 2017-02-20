using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepoOF.Helpers
{
    public class Areal
    {
        //▼▼▼Cirklens Areal▼▼▼
        public double CirkelAreal(double radius)
        {
            double areal;

            areal = Math.PI * Math.Pow(radius, 2);

            return areal;
        }

        //▼▼▼Cirklens Omkreds beregnet med radius▼▼▼
        public double CirkelOmkredsRad(double radius)
        {
            double omkresrad;

            omkresrad = 2 * Math.PI * radius;

            return omkresrad;
        }

        //▼▼▼Cirklens Omkreds beregnet med diameter▼▼▼
        public double CirkelOmkredDia(double diameter)
        {
            double omkredsdia;

            omkredsdia = Math.PI * diameter;

            return omkredsdia;
        }

        //▼▼▼Rektanglens Areal▼▼▼
        public double RektangelAreal(double laengde, double bredte)
        {
            double areal;

            areal = laengde * bredte;

            return areal;
        }


        //▼▼▼Rektanglens Omkreds▼▼▼
        public double RektangelOmkreds (double laengde, double bredte)
        {
            double omkreds;

            omkreds = 2 * (laengde + bredte);

            return omkreds;
        }

        //▼▼▼Trapezens Areal▼▼▼
        public double TrapezAreal(double hoejde, double side1, double side2)
        {
            double areal;

            areal = 2 / 1 * hoejde * (side1 + side2);

            return areal;
        }

        //▼▼▼Parallelogramets Areal▼▼▼
        public double ParallelogramAreal (double hoejde, double grundlinje)
        {
            double areal;

            areal = hoejde * grundlinje;

            return areal;
        }
        
        //▼▼▼Trekantens Areal▼▼▼
        public double TrekantAreal (double hoejde, double grundlinje)
        {
            double areal;

            areal = 0.5 * hoejde * grundlinje;

            return areal;
        }

        //▼▼▼Herons formel▼▼▼
        public double HeronsFormel (double side1, double side2, double side3)
        {
            double s;

            s = (side1 + side2 + side3);

            double heronsFormel;

            heronsFormel = Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));

            return heronsFormel;
        }

     







    }
}