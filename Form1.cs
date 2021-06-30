using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmSubtracao : Form
    {
        [DllImport ("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
               int left,
               int top,
               int right,
               int bottom,
               int width,
               int height
           );
        public frmSubtracao()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            float N1, N2, Resultado;

            N1 = Convert.ToInt32(txtn1.Text);
            N2 = Convert.ToInt32(txtn2.Text);

            Resultado = N1 - N2;        

            txtresultado.Text = Convert.ToString(Resultado);

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtn1.Clear();
            txtn2.Clear();
            txtresultado.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
