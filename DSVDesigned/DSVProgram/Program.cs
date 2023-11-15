using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSVProgram
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Auth AuthForm = new Auth();
            Application.Run(AuthForm);

            if (AuthForm.SuccessfullyAuth)
            {
                Application.Run(new Maintain());
            }
        }
    }
}