using System;
using System.Windows.Forms;

namespace CubicSplineApp
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainWindow());
            }
            catch(Exception e)
            {
                MessageBox.Show("Возникла ошибка: " + e.Message);
            }
        }
    }
}
