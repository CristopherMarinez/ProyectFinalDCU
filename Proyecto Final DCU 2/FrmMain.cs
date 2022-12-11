using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_DCU_2
{
    public partial class FrmMain : Form
    {
        private int n;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = txtID.Text;
            dataGridView1.Rows[n].Cells[1].Value = txtNombre.Text;
            dataGridView1.Rows[n].Cells[2].Value = txtApellido.Text;
            dataGridView1.Rows[n].Cells[3].Value = txtTelefono.Text;
            dataGridView1.Rows[n].Cells[4].Value = txtCorreo.Text;
            dataGridView1.Rows[n].Cells[5].Value = txtMatricula.Text;
            txtID.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            txtMatricula.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (n != 1)
            {
                dataGridView1.Rows.RemoveAt(n);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult n = MessageBox.Show("Desea Salir de la aplicacion?", "App Registro Escolar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (n==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnrestaurar.Visible = false;
            btnmaximizar.Visible = true;
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnmaximizar.Visible = false;
            btnrestaurar.Visible = true;
        }
    }
}
