using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace PassPrintDesktop
{
    public class Variables // Class used to store public variables accessible throughout the project
    {
        // Bluetooth connection to the Arduino
        public static SerialPort serialBluetooth = new SerialPort("COM10", 9600)
        {
            ReadTimeout = 2000,
            WriteTimeout = 2000
        };
       // public static SerialPort serialBluetoothIN = new SerialPort("COM11", 9600)
        //{
          //  ReadTimeout = 2000,
           // WriteTimeout = 2000
        //};
    }
}
