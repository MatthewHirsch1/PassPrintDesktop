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
        public static SerialPort serialBluetooth = new SerialPort("COM4", 9600)
        {
            ReadTimeout = 1500,
            WriteTimeout = 1500
        };
    }
}
