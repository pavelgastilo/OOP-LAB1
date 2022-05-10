using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace lab1
{
    public partial class BankForm : Form
    {
        AdminController admin = new AdminController();
        public BankForm(AdminController adm)
        {
            InitializeComponent();
            admin = adm;
        }

        public void Open()
        {
            ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin.CheckAllLogs(richTextBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignUpForm StartForm = new SignUpForm();
            Thread myThread1 = new Thread(StartForm.Open);
            myThread1.Start();
            this.Close();
            this.Dispose();
        }
    }
}
