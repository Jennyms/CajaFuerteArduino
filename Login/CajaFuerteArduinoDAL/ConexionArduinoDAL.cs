using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace CajaFuerteArduinoDAL
{
   
    public class ConexionArduinoDAL
    {
        SerialPort serialPort;

        public ConexionArduinoDAL()
        {
          
        }
        public void init()
        {
            serialPort = new SerialPort();
            serialPort.PortName = "COM5";
            serialPort.BaudRate = 9600;

            try
            {
                serialPort.Open();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }

        }
        public void enviarOpcion(string letra)
        {

            serialPort.Write(letra);
            
        }

        public void SendServoInfo(int channel, int pos)
        {
  
            string message = channel.ToString() + ':' + pos.ToString() + '*';

            try
            {
                serialPort.Write(message);

            }
            catch
            {

            }

        }
        public void CerrarAbrirServo(int angulo)
        {          
            SendServoInfo(0, angulo);
        }
        public void cerrarPuerto()
        {
            if (serialPort.IsOpen) serialPort.Close();
        }
    }
}
