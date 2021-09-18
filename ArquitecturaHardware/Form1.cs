using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace ArquitecturaHardware
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] Portlst;
        SerialPort arduino = new SerialPort();
        string Estado, SerialDataIn;
        bool light_1 = false, light_2 = false, light_3 = false, light_4 = false,Start = true;

        private void Form1_Load(object sender, EventArgs e)
        {
            Portlst = SerialPort.GetPortNames();
            cmb_COM.Items.AddRange(Portlst);
            btn_desconectar.Enabled = false;
            cmb_COM.SelectedIndex = 0;
            cmb_baudrate.SelectedIndex = 0;
        }

        private void btn_conectar_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = cmb_COM.Text;
            serialPort1.BaudRate = Convert.ToInt32(cmb_baudrate.Text);
            serialPort1.Open();
            if (serialPort1.IsOpen)
            {
                pb_conexion.Value = 100;
                lbl_conexion.ForeColor = Color.Green;
                lbl_conexion.Text = "CONNECTED!!";
                cmb_baudrate.Enabled = false;
                cmb_COM.Enabled = false;
                btn_conectar.Enabled = false;
                btn_desconectar.Enabled = true;
                groupBox2.Enabled = true;
                EscucharArduino();
            }            
        }

        private void btn_desconectar_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {                
                serialPort1.Close();
                pb_conexion.Value = 0;
                lbl_conexion.ForeColor = Color.Black;
                lbl_conexion.Text = "DESCONNECTED!!";
                cmb_baudrate.Enabled = true;
                cmb_COM.Enabled = true;
                btn_desconectar.Enabled = false;
                btn_conectar.Enabled = true;
                groupBox2.Enabled = false;
                pbox_light_1.Image = ArquitecturaHardware.Properties.Resources.switch_off;
                pbox_light_2.Image = ArquitecturaHardware.Properties.Resources.switch_off;
                pbox_light_3.Image = ArquitecturaHardware.Properties.Resources.switch_off;
                pbox_light_4.Image = ArquitecturaHardware.Properties.Resources.switch_off;
            }                
        }

        private void pbox_light_1_Click(object sender, EventArgs e)
        {
            serialPort1.Write("led4");
            if (light_1)
                pbox_light_1.Image = ArquitecturaHardware.Properties.Resources.switch_off;
            else
                pbox_light_1.Image = ArquitecturaHardware.Properties.Resources.switch_on;

            light_1 = !light_1;
            
        }

        private void pbox_light_2_Click(object sender, EventArgs e)
        {
            if (light_2)
                pbox_light_2.Image = ArquitecturaHardware.Properties.Resources.switch_off;
            else
                pbox_light_2.Image = ArquitecturaHardware.Properties.Resources.switch_on;

            serialPort1.Write("led3");
            light_2 = !light_2;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
                serialPort1.Close();
            
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialDataIn = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(ChangeStatus));
            
        }       
        
        private void ChangeStatus(object sender, EventArgs e)
        {
            if (!Start && SerialDataIn != "") {
                if (SerialDataIn.Substring(0, 1) == "4") 
                {
                    light_4 = !light_4;
                    if (!light_4)
                        pbox_light_4.Image = ArquitecturaHardware.Properties.Resources.switch_off;
                    else
                        pbox_light_4.Image = ArquitecturaHardware.Properties.Resources.switch_on;
                }
                if (SerialDataIn.Substring(0, 1) == "5")
                {
                    light_3 = !light_3;
                    if (!light_3)
                        pbox_light_3.Image = ArquitecturaHardware.Properties.Resources.switch_off;
                    else
                        pbox_light_3.Image = ArquitecturaHardware.Properties.Resources.switch_on;
                }
                if (SerialDataIn.Substring(0, 1) == "6") 
                {
                    light_2 = !light_2;
                    if (!light_2)
                        pbox_light_2.Image = ArquitecturaHardware.Properties.Resources.switch_off;
                    else
                        pbox_light_2.Image = ArquitecturaHardware.Properties.Resources.switch_on;
                }
                if (SerialDataIn.Substring(0, 1) == "7")
                {
                    light_1 = !light_1;
                    if (!light_1)
                        pbox_light_1.Image = ArquitecturaHardware.Properties.Resources.switch_off;
                    else
                        pbox_light_1.Image = ArquitecturaHardware.Properties.Resources.switch_on;
                }
            }
        }

        private void pbox_light_3_Click(object sender, EventArgs e)
        {
            if (light_3)
                pbox_light_3.Image = ArquitecturaHardware.Properties.Resources.switch_off;
            else
                pbox_light_3.Image = ArquitecturaHardware.Properties.Resources.switch_on;

            serialPort1.Write("led2");
            light_3 = !light_3;
        }

        private void pbox_light_4_Click(object sender, EventArgs e)
        {
            if (light_4)
                pbox_light_4.Image = ArquitecturaHardware.Properties.Resources.switch_off;
            else
                pbox_light_4.Image = ArquitecturaHardware.Properties.Resources.switch_on;

            serialPort1.Write("led1");
            light_4 = !light_4;
        }

        void EscucharArduino()
        {

            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Write("S");
                    Estado = serialPort1.ReadLine();
                    light_1 = Convert.ToBoolean(Convert.ToInt32(Estado.Substring(0, 1)));
                    light_2 = Convert.ToBoolean(Convert.ToInt32(Estado.Substring(1, 1)));
                    light_3 = Convert.ToBoolean(Convert.ToInt32(Estado.Substring(2, 1)));
                    light_4 = Convert.ToBoolean(Convert.ToInt32(Estado.Substring(3, 1)));

                    if (!light_1)
                        pbox_light_1.Image = ArquitecturaHardware.Properties.Resources.switch_off;
                    else
                        pbox_light_1.Image = ArquitecturaHardware.Properties.Resources.switch_on;
                    if (!light_2)
                        pbox_light_2.Image = ArquitecturaHardware.Properties.Resources.switch_off;
                    else
                        pbox_light_2.Image = ArquitecturaHardware.Properties.Resources.switch_on;
                    if (!light_3)
                        pbox_light_3.Image = ArquitecturaHardware.Properties.Resources.switch_off;
                    else
                        pbox_light_3.Image = ArquitecturaHardware.Properties.Resources.switch_on;
                    if (!light_4)
                        pbox_light_4.Image = ArquitecturaHardware.Properties.Resources.switch_off;
                    else
                        pbox_light_4.Image = ArquitecturaHardware.Properties.Resources.switch_on;

                    Start = false;
                }
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
        }
    }
}
