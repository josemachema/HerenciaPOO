using WinFormsApp1.ClaseAbstractaEjemploReal;
using WinFormsApp1.Polimorfimo;
using WinFormsApp1.Problema1;
using WinFormsApp1.ProblemaEdad;

namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FormsAbstracto());
        }
    }
}