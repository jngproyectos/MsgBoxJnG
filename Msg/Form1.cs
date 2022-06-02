using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Msg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
        }
        #region Btns
        private void btnCer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
        }
        private void btnMin_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Minimized;
            else if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Minimized;
        }
        private void button1_Click(object sender, EventArgs e)
        {
        }

        #endregion
        //Evento click para mostrar el MessageBox
        private void btnWar_Click(object sender, EventArgs e)
        {
            MsgBox m = new MsgBox("warning", "Este es un ejemplo de un message box personalizado");
            //m.ShowDialog();
            DialogResult dg = m.ShowDialog();
            label1.Text = dg.ToString();
        }

        private void btnQues_Click(object sender, EventArgs e)
        {
            MsgBox m = new MsgBox("question", "Este es un ejemplo de un message box personalizado");

            DialogResult dg = m.ShowDialog();
            label1.Text = dg.ToString();
        }

        private void btnError_Click(object sender, EventArgs e)
        {
            MsgBox m = new MsgBox("error", "Este es un ejemplo de un message box personalizado");
            //m.ShowDialog();
            DialogResult dg = m.ShowDialog();
            label1.Text = dg.ToString(); 
        }
    }
}
