using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieWSrodowskuWindowsProjekt
{
    public delegate void MyDelegation();
    class mySerialPort : SerialPort
    {
        public mySerialPort(string portName, int baudRate, Parity parity, int dataBits, StopBits stopBits) : base(portName, baudRate, parity, dataBits, stopBits)
        {
            this.PortName = portName;
            this.BaudRate = baudRate;
            this.Parity = parity;
            this.DataBits = dataBits;
            this.StopBits = stopBits;
        }

        public event MyDelegation nameEvent;
    }
}
