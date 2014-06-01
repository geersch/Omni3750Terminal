using System;
using System.IO.Ports;
using CGeers.Cardfon;

namespace ConsoleClientApplication
{
    class Program
    {
        static void Main()
        {            
            using (VerifoneOmni3750 omniTerminal = new VerifoneOmni3750 { TerminalId = 1234 })
            {
                // Set the communication settings of the serial port.
                omniTerminal.SerialPort.BaudRate = 9600;
                omniTerminal.SerialPort.Parity = Parity.Even;
                omniTerminal.SerialPort.DataBits = 7;
                omniTerminal.SerialPort.StopBits = StopBits.One;

                // Establish a connection to the serial port (COM1).
                omniTerminal.SerialPort.Open(5);                                
                omniTerminal.SendTransactionRequest(39.95, 101, "EUR");
            }            

            Console.ReadLine();
        }
    }
}
