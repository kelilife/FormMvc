using System;
using System.Windows.Forms;

using KeLi.FormMvc.Controllers;
using KeLi.FormMvc.Views;

namespace KeLi.FormMvc
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();

            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new PersonController(new PersonForm()).View);
        }
    }
}