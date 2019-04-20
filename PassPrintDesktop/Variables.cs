using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;

namespace PassPrintDesktop
{
    public class Variables // Class used to store public variables accessible throughout the project
    {
        // Bluetooth connection to the Arduino
        public static SerialPort serialBluetooth = new SerialPort("COM6", 9600)//outgoing
        {
            ReadTimeout = 2000,
            WriteTimeout = 2000
        };
        // public static SerialPort serialBluetoothIN = new SerialPort("COM11", 9600)
        //{
        //  ReadTimeout = 2000,
        // WriteTimeout = 2000
        //};

        //public static bool fingerOK = false; // Access from anywhere

        public static bool authenticatefunc() {


            Variables.serialBluetooth.Write("Authenticate Fin%");

            bool fingerOK = false;
            bool disconnectRequested = false;

            while (!disconnectRequested)
            {


                try
                {

                    string incData = Variables.serialBluetooth.ReadLine();
                    incData.Trim();
                    //MessageBox.Show(incData1, "PRIOR TO IF: From BT through Variables class");
                    if (incData != null)
                    {
                        disconnectRequested = true;
                        //MessageBox.Show(incData + "\n" + string.Equals(incData, "ok"), "From BT through Variables class");
                        
                        if (string.Equals(incData,"ok")) {
                            fingerOK = true;
                            MessageBox.Show("Fingerprint Approved", "Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                        continue;
                    }
                }


                catch { }
            }
            return fingerOK;
        }
    }
}