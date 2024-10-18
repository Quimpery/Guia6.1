using Guia6._1.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia6._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            List<string> patentes = new List<string>
            {
                "OXY333","OYZ 013","AAA 123","BCD-456","AB 123 CD","YZ5432EF","QW 3456 AB"
            };

            IPrueba procesar = null;
            if(rbRegex.Checked)
            {
                procesar = new RegexProcesableImp1();
            }
            else if(rbString.Checked)
            {
                procesar = new StringProcesableImpl();
            }
            else
            {
                MessageBox.Show("Seleccione alguna de las opciones por favor");
                return;
            }
            tbVer.Clear();
            foreach(string patente in patentes)
            {
                string descripcion = procesar.Procesar(patente, out string patenteFormateada);

                tbVer.Text += $"{patenteFormateada}{descripcion} \r\n";
            }
            
        }
    }
}
