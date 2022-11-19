using BridalForm.Control;
using BridalForm.parts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BridalForm
{
    public partial class Form1 : Form
    {
        public UserControl1 user;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            user = new UserControl1();
            user.Dock = DockStyle.Fill;
            panel1.Controls.Add(user);
        }
    }
}
