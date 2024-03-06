using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4._2
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Data.PhoneBook.Add("John", new Person() { Fname = "John", LName = "Robinson", Address = "219 Sunshine Way", MobilePhone = 7365245, WorkPhone= 3984736});
            Application.Run(new PhoneBook());
        }
    }
}
