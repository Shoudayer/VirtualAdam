using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;


namespace VirtualAdam
{
    public partial class vAdam : Form
    {
        int counter4017 = 0;
        SerialPort port = new SerialPort("COM2", 9600, Parity.None, 8, StopBits.One);//meme parametre que GTC mais sur com2
        string rep = " ";//init pour +=
        string cmdRecues = "";
        public vAdam()
        {

            InitializeComponent();
            tb_log.Text = rep;
            port.Open();
            port.DataReceived +=
            new SerialDataReceivedEventHandler(port_DataReceived);

        }
        public void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            rep += port.ReadExisting();

            tb_log.BeginInvoke((Action)(() =>
                       {
                           tb_log.Text = rep;//log toutes les requetes reçues 
                       }));

            int addr = Convert.ToInt16(tb_addr.Text);
            int addr2 = Convert.ToInt16(tb_addr2.Text);

            tb_rep.BeginInvoke((Action)(() =>
            {
                
                tb_rep.Text = cmdRecues;//log toutes les requetes reçues 

                if (rep.Contains("$" + addr.ToString("X2") + "2"))
                {//si dans lesemble des requete il ya eu celle attendue   si $xx2
                      string cmdRecue=("$" + addr.ToString("X2") + "2") ;
                    port.Write("!" + addr.ToString("X2") + "0A0600\r");//repondre en tant que le module repondre !xx0A0600
                    rep = rep.Replace(cmdRecue, "");
                    cmdRecues += cmdRecue;

                }

                else if (rep.Contains("$" + addr2.ToString("X2") + "2"))
                {   string cmdRecue=("$" + addr2.ToString("X2") + "2");
                    port.Write("!" + addr.ToString("X2") + "070600\r");
                    rep = rep.Replace(cmdRecue, "");
                    cmdRecues += cmdRecue;
                }

                else if (rep.Contains("#" + addr.ToString("X2")) )//4017 demande de lecture
                {
                    string[] strLect = {">-00.024-00.024-00.024-00.024-00.023-00.024-00.000-00.022",
                                        ">-00.024-00.023-00.024-00.023+02.598+00.104-00.021-00.024",
                                        ">-00.024-00.024-00.024-00.023+02.599+00.104-00.022-00.023",
                                        ">-00.023-00.024-00.023-00.023+02.599+00.104-00.021-00.023",
                                        ">-00.023-00.023-00.023-00.023+02.599+00.106-00.022-00.023",
                                        ">-00.024-00.024-00.024-00.024-00.016-00.022-00.024-00.024",
                                        ">-00.024-00.024-00.024-00.024-00.017-00.024-00.024-00.024",
                                        ">-00.024-00.023-00.024+02.628+00.109-00.022+00.000-00.022",
                                        ">-00.024-00.023-00.023+02.629+00.110-00.021-00.023-00.023",
                                        ">-00.023-00.023-00.023-00.021-00.023-00.023-00.023-00.022",
                                        ">-00.023-00.023-00.024-00.022-00.024-00.024-00.024-00.024",
                                        ">-00.022-00.022-00.022+02.627+00.109-00.021-00.022-00.022",
                                        ">-00.022-00.022-00.023+02.627+00.107-00.020-00.022-00.022",
                                        ">-00.023-00.023-00.024+02.768+00.117-00.020-00.023-00.023",
                                        ">-00.024-00.023-00.024+02.870+00.120-00.021-00.023-00.024",
                                        ">-0.0234-0.0233-0.0235+999999+0.1077-0.0224-0.0235-0.0232",
                                        ">-0.0339-0.0241-0.0241+999999+0.1013-0.0222-0.0240-0.0241",
                                        };



                    string cmdRecue = ("#" + addr.ToString("X2"));
                    port.Write(strLect[counter4017] + "\r");
                    if (counter4017 < strLect.Length-1) {
                        counter4017++;
                    }else if (counter4017==strLect.Length-1){
                        counter4017 = 0;
                    }

                    //ihm adam virtuel
                    rep = rep.Replace(cmdRecue, "");
                    cmdRecues += cmdRecue;

                }

                else if(rep.Contains("$"+addr2.ToString("X2") + '6') ){//4050
                    string cmdRecue = ("$" + addr2.ToString("X2")+'6');
                    port.Write(">04\r");
                    rep = rep.Replace(cmdRecue, "");
                    cmdRecues += cmdRecue;
                }

                else{
                    if (rep.Length > 3000) {
                        rep = "";
                    }
                }


            }));

        }



        ~vAdam()
        {
            port.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rep = " ";
            tb_rep.Text = " ";


        }

        private void vAdam_Load(object sender, EventArgs e)
        {

        }
    }
}
