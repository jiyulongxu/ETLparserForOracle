﻿using System;
using System.Windows.Forms;
using OracleConnectETLParser1.Controllers;

namespace OracleConnectETLParser1
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
           // Application.Run(new Form1());
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxx");           
            Manager test=new Manager();
            test.CreateDB_Objects();
            Console.ReadKey();
        }
    }
}
