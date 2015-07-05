using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace LawrApp
{

    public class Program : WindowsFormsApplicationBase
    {
        public Program() : base( AuthenticationMode.Windows )
        {
            this.IsSingleInstance = false;
            this.EnableVisualStyles = true;

            /*ES AQUI DONDE DETERMINAMOS EL COMPORTAMIENTO DE FINALIZACION DEL PROGRAMA*/
            this.ShutdownStyle = ShutdownMode.AfterAllFormsClose;
        }

        protected override void OnCreateMainForm()
        {
            DataGeneral data = new DataGeneral();
            this.MainForm = new frmMain(data);
        }

        [STAThread]
        internal static void Main( string[] Args )
        {
            string[] arg = new string[0];
            new Program().Run( arg );
        }
    }

    //static class Program
    //{
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>

        //[STAThread]
        //static void Main()
        //{
        //    Application.EnableVisualStyles();
        //    Application.SetCompatibleTextRenderingDefault( false );
        //    Application.Run( new frmLogIn() );
        //}
    //}
}
