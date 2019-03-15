using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace PassPrintDesktop
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
            Application.Run(new FormMainMenu());
            SerialPort serialBluetooth = new SerialPort("COM4", 9600)
            {
                ReadTimeout = 1500,
                WriteTimeout = 1500
            };
            //while (true)
            //{
            //    try { // Try to open serial port for Bluetooth connection
            //        serialBluetooth.Open();
            //        break; }
            //    catch (Exception) { MessageBox.Show("Please connect the device via Bluetooth and try again.", "Connection Error"); }
            //}

        }
    }
}
