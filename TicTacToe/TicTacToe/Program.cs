//Name: Assignment 1
//Program: Software Development Diploma
//Course Code: SODV2101 - Rapid Application Development
//Author: Jorge Eduardo Schmitt Gayer
//Student IDs: 424267

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace TicTacToe
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
            Application.Run(new TicTacToe());
        }
    }
}
