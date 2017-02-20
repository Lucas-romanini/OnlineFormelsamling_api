using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepoOF.Helpers
{
    public class RumfangOgOverflade
    {
        //▼▼▼En Kasses Rumfang▼▼▼

        public double KasseRumfang (double hoejde, double laengde, double bredte)
        {
            double rumfang;

            rumfang = hoejde * laengde * bredte;

            return rumfang;
        }

        //▼▼▼En Kasses Overflade

        public double KasseOverflade (double hoejde, double laengde, double bredte)
        {
            double overflade;

            overflade = 2 * (laengde * hoejde + hoejde * bredte + bredte * laengde);

            return overflade;
        }

        //▼▼▼En Prismes rumfang▼▼▼

        public double PrismeRumfang (double hoejde, double grundAreal)
        {
            double rumfang;

            rumfang = hoejde * grundAreal;

            return rumfang;
        }

        //▼▼▼En Cylinders Rumfang▼▼▼

        public double CylinderRumfang(double radius, double hoejde)
        {
            double rumfang;

            rumfang = Math.PI * Math.Pow(radius, 2) * hoejde;

            return rumfang;
        }

        //▼▼▼En Cylinders Overflade▼▼▼

        public double CylinderOverflade(double radius, double hoejde)
        {
            double overflade;

            overflade = 2 * Math.PI * radius * hoejde;

            return overflade;
        }

        //▼▼▼En Kegles/Pyramides Rumfang▼▼▼

        public double KegleRumfang(double hoejde, double grundAreal)
        {
            double rumfang;

            rumfang = hoejde * grundAreal / 3;

            return rumfang;
        }

        //▼▼▼En kugles Rumfang▼▼▼

        public double KugleRumfang(double radius)
        {
            double rumfang;

            rumfang = 0.75 * Math.PI * Math.Pow(radius, 3);

            return rumfang;
        }

        //▼▼▼En Kugles Overflade▼▼▼

        public double KugleOverflade(double radius)
        {
            double overflade;

            overflade = 4 * Math.PI * Math.Pow(radius, 2);

            return overflade;
        }







    }
}