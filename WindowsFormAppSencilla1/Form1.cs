using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormAppSencilla1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Calcular();
        }

        private void Calcular()
        {
            double sueldoBruto, sueldoNeto, ISR, AFP, SFS;

            sueldoBruto = double.Parse(Sueldo.Text);

            ISR = 0.09 * sueldoBruto;
            AFP = 0.07 * sueldoBruto;
            SFS = 0.1 * sueldoBruto;
            sueldoNeto = sueldoBruto - (ISR + AFP + SFS);

            deduccionISR.Text = ISR.ToString();
            deduccionAFP.Text = AFP.ToString();
            deduccionSFS.Text = SFS.ToString();
            totalSueldoNeto.Text = sueldoNeto.ToString();

        }
    }
}
