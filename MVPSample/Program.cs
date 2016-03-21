using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVPSample.Model;
using MVPSample.Presenter;

namespace MVPSample
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //model
            Model1 model = new Model1();

            //view
            MainView view = new MainView();

            //presenter
            Presenter1 presenter = new Presenter1(model,view);

            Application.Run(view);
        }
    }
}
