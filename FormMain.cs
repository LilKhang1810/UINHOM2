using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UINHOM2
{
    public partial class FormMain : Form
    {
        private Form currentChildForm;
        public FormMain()
        {
            InitializeComponent();
        }
        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Trangchu());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Quanlilophoc());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Thongtingiangvien());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
