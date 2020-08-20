using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*COMP123 - Assignment5 -  Dollar Computer
 Created By: Christina May Pakingan
 Student#: 301121940
 Date Created: August 17, 2020
 Date Modified: August 19, 2020*/
namespace COMP123_Assignment5
{
    static class Program
    {
        //instantiate new object
        public static product Product  = new product();

        public static SplashForm splashForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Run splashform
            splashForm = new SplashForm();
            Application.Run(splashForm);
        }
    }
}
