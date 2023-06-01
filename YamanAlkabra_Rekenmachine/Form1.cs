using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YamanAlkabra_Rekenmachine
{
    public partial class frmYaman_Rekenmachine : Form
    {
        public frmYaman_Rekenmachine()
        {
            InitializeComponent();
        }
        // plus
        private void btn1_Click(object sender, EventArgs e)
        {
            double txt1 = Convert.ToDouble(txtValue1.Text);
            double txt2 = Convert.ToDouble(txtValue2.Text);

            double sum = txt1 + txt2;
            // het antwoord komt in de derde tekstbox
            txtValue3.Text = sum.ToString();
        }
        //min
        private void btn2_Click(object sender, EventArgs e)
        {
            double txt1 = Convert.ToDouble(txtValue1.Text);
            double txt2 = Convert.ToDouble(txtValue2.Text);

            double sum = txt1 - txt2;
            // het antwoord komt in de derde tekstbox
            txtValue3.Text = sum.ToString();
        }
        //keer
        private void btn4_Click(object sender, EventArgs e)
        {
            double txt1 = Convert.ToDouble(txtValue1.Text);
            double txt2 = Convert.ToDouble(txtValue2.Text);

            double sum = txt1 * txt2;
            // het antwoord komt in de derde tekstbox
            txtValue3.Text = sum.ToString();
        }
        //gedeelddoord
        private void btn3_Click(object sender, EventArgs e)
        {
            double txt1 = Convert.ToDouble(txtValue1.Text);
            double txt2 = Convert.ToDouble(txtValue2.Text);

            double sum = txt1 / txt2;
            // het antwoord komt in de derde tekstbox
            txtValue3.Text = sum.ToString();
        }
    }
}
