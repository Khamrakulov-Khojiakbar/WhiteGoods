﻿using System;
using System.Windows.Forms;
using WhiteGoods.WinForms.Forms;

namespace WhiteGoods.WinForms
{
    public static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AnalogForm3());
        }
    }
}
