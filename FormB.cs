using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formlar
{
    public partial class FormB : Form
    {
        public FormB()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Form Yükleniyor.");
            {
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Form Kapandı.");
            {
                this.Close();
            }
        }

        private void FormB_Load(object sender, EventArgs e)
        {
            MessageBox.Show("FormB Click Olayı Çalışıyor.");
        }
    }    
}
