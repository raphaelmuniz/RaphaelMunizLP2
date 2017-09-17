using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7_ConversorDeMedidas
{
    class conversor
    {
        public static double celsus, fahrenheit, kelvin;
        public static double km, M, Cm, pes, pol;
        public static double kg, g, lb, ton;

        public static double convercelparafar(double x)
        {
            celsus = x;
            return fahrenheit = (celsus * 1.8) + 32;
        }

        public static double convercelparakel(double x)
        {
            kelvin = x;
            return kelvin = celsus + 273;

        }
        public static double converkelparacel(double x)
        {
            celsus = x;
            return celsus = kelvin - 273;
        }
        public static double converfarparacelsu(double x)
        {
            fahrenheit = x;
            return celsus = (fahrenheit - 32) / 1.8;

        }
        public static double converfarparakel(double x)
        {
            fahrenheit = x;
            return kelvin = (fahrenheit - 32 / 1.8) + 273;

        }
        public static double converkelparafar(double x)
        {
            kelvin = x;
            return fahrenheit = (kelvin * 1.8) - 459.67;
        }
        public static double converMparakm(double x)
        {
            M = x;
            return km = M / 1000;
        }
        public static double converkmparaM(double x)
        {
            km = x;
            return M = km * 1000;
        }
        public static double convermparacm(double x)
        {
            M = x;
            return Cm = M * 100;

        }
        public static double convercmparam(double x)
        {
            Cm = x;
            return Cm = M * 100;
        }
        public static double converkmparacm(double x)
        {
            km = x;
            return Cm = km * 100000;
        }
        public static double convercmparakm(double x)
        {
            Cm = x;
            return km = Cm / 100000;
        }
        public static double convercmparapol(double x)
        {
            Cm = x;
            return pol = Cm / 0.3937;
        }
        public static double convermparapol(double x)
        {
            M = x;
            return pol = M * 39.3701;

        }
        public static double converKmparapol(double x)
        {
            km = x;
            return pol = km * 39370.1;
        }
        public static double converpolparam(double x)
        {
            pol = x;
            return M = pol * 0.0254;
        }
        public static double converpolparakm(double x)
        {
            pol = x;
            return km = pol * 0.0000254;
        }
        public static double converpolparacm(double x)
        {
            pol = x;
            return Cm = pol * 2.54;
        }
        public static double converkmparapes(double x)
        {
            km = x;
            return pes = km * 3280.84;
        }
        public static double convercmparapes(double x)
        {
            Cm = x;
            return pes = Cm / 0.0328;
        }
        public static double convermparapes(double x)
        {
            M = x;
            return pes = M * 3.2808;
        }
        public static double converpesparam(double x)
        {
            pes = x;
            return M = pes * 0.3048;
        }
        public static double converpesparakm(double x)
        {
            pes = x;
            return km = pes * 0.0003048;
        }
        public static double converpesparakm(double x)
        {
            pes = x;
            return Cm = pes * 30.48;
        }
        public static double converpesparapol(double x)
        {
            pes = x;
            return pol = pes * 12;
        }
        public static double converpolparapes(double x)
        {
            pol = x;
            return pes = pol * 0.83333;
        }
        public static double convertonparakg(double x)
        {
            ton = x;
            return kg = ton / 1000;

        }
        public static double convertonparag(double x)
        {
            ton = x;
            return g = ton / 1000000;
        }
        public static double converkgparaton(double x)
        {
            kg = x;
            return ton = kg * 1000;
        }
        public static double convergparaton(double x)
        {
            g = x;
            return ton = g * 1000000;
        }
        public static double convergparalb(double x)
        {
            lb = x;
            return g = lb / 0.0022046;
        }
        public static double converlbparag(double x)
        {
            g = x;
            return lb = g * 0.00220462;
        }
        public static double converlbparakg(double x)
        {
            kg = x;
            return lb = kg * 2.20462;

        }
        public static double converkgparalb(double x)
        {
            lb = x;
            return kg = lb / 2.20462;

        }
        public static double converlbparaton(double x)
        {
            ton = x;
            return lb = ton * 2024.62;
        }
        public static double convertonparalb(double x)
        {
            lb = x;
            return ton = lb / 2024.62;
        }
    }
}

