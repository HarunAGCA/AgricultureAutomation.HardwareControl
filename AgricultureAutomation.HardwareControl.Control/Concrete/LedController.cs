using AgricultureAutomation.HardwareControl.Control.Abstract;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Text;

namespace AgricultureAutomation.HardwareControl.Control.Concrete
{
    public class LedController : ILedController
    {
        public void Close()
        {

            SerialPort serialPort = new SerialPort("Com6",9600);
            if (!serialPort.IsOpen)
            {
                serialPort.Open();
            }

            serialPort.Write("Close");

            serialPort.Close();
        }

        public void Open()
        {
            SerialPort serialPort = new SerialPort("Com6",9600);
            if (!serialPort.IsOpen)
            {
                serialPort.Open();
            }

            serialPort.Write("Open");

            serialPort.Close();
        }
    }
}
