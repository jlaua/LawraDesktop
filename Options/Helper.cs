using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Options
{
    public static class Helper
    {

        public static bool solonumeros( char character )
        {
            if ( char.IsDigit( character ) )
                return false;
            else if ( char.IsControl( character ) )
                return false;
            else
                return true;
        }

        public static bool solotexto( char character )
        {
            if ( Char.IsLetter( character ) )
                return false;
            else if ( Char.IsControl( character ) )
                return false;
            else if ( Char.IsSeparator( character ) )
                return false;
            else
                return true;
        }

        public static bool ValidarEdadMaximayMinima(DateTime dateEntered, int MaxAge, int MinAge)
        {
            TimeSpan edadMaxima = new DateTime( dateEntered.Year, dateEntered.Month, dateEntered.Day ).AddYears( MaxAge ) - DateTime.Now;
            TimeSpan edadMinima = DateTime.Now - new DateTime( dateEntered.Year, dateEntered.Month, dateEntered.Day ).AddYears( MinAge );

            if ( edadMaxima.TotalDays >= 0 && edadMinima.TotalDays >= 0 ) return true;
            
            return false;
        }

        public static bool ValidarFechaDeExpiracion( DateTime dateEntered, int MaxDaysBeforeExpire )
        {
            var dateIn = new DateTime( dateEntered.Year, dateEntered.Month, dateEntered.Day );
            TimeSpan diffExpireDate = DateTime.Now.AddDays(MaxDaysBeforeExpire) - dateIn;

            if ( diffExpireDate.TotalDays < 0 ) return true;
            
            return false;
        }

        public static string NameImageRandom( int size )
        {
            Random random = new Random( (int) DateTime.Now.Ticks );
            StringBuilder builder = new StringBuilder();
            char ch;
            for ( int i = 0; i < size; i++ )
            {
                ch = Convert.ToChar( Convert.ToInt32( Math.Floor( 26 * random.NextDouble() + 65 ) ) );
                builder.Append( ch );
            }

            return builder.ToString();
        }

        public static bool ValidacionMayoriaDeEdad(DateTime _fecharegistrada)
        {
            DateTime InputDate = new DateTime(_fecharegistrada.Year, _fecharegistrada.Month, _fecharegistrada.Day).AddYears(18);
            DateTime InputDateMax = new DateTime(_fecharegistrada.Year, _fecharegistrada.Month, _fecharegistrada.Day).AddYears(85);
            TimeSpan edadActual = DateTime.Now - InputDate;
            TimeSpan edadMax = DateTime.Now - InputDateMax;

            if (edadActual.Days < 0 && edadMax.TotalDays < 0)
                return false;
            else
                return true;
        }

        public static bool CorreoElectronico(string Mail)
        {
            String expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

            if (Regex.IsMatch(Mail, expresion))
            {
                if (Regex.Replace(Mail, expresion, String.Empty).Length == 0)
                    return true;
                else
                    return false;
            }
            else
               return false;
        }

        public static void IsPhone(object sender, KeyPressEventArgs e, char cSymbol)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != cSymbol) e.Handled = true;

            if (e.KeyChar == cSymbol && char.IsNumber(e.KeyChar)) e.Handled = true;
        }

    }
}
