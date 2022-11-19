using BridalForm.Control;
using BridalForm.parts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BridalForm.Memo
{
    public partial class MainForm : Form
    {
        //form設定
        public HomeControl  homecontrol;
        public InputControl inputcontrol;
        public partsCon1    partscon1;
        public partsCon2    partscon2;

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ロードイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            //panel設定
            homecontrol = new HomeControl();
            homecontrol.Dock = DockStyle.Fill;
            pnlShowForm.Controls.Add(homecontrol);

            inputcontrol = new InputControl();
            inputcontrol.Dock = DockStyle.Fill;
            pnlShowForm.Controls.Add(inputcontrol);

            partscon1 = new partsCon1();
            partscon1.Dock = DockStyle.Fill;
            pnlTop.Controls.Add(partscon1);

            partscon2 = new partsCon2();
            partscon2.Dock = DockStyle.Fill;
            pnlTop.Controls.Add(partscon2);

            //起動時に homecontrol を表示
            homecontrol.Show();

            //最大・最小非表示
            MinimizeBox = false;
            MaximizeBox = false;
        }

        /// <summary>
        /// ホームボタンのクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHome_Click(object sender, EventArgs e)
        {
            HideAllForm();
            homecontrol.Show();
            partscon2.Show();
        }

        /// <summary>
        /// 入力ボタンのクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInput_Click(object sender, EventArgs e)
        {
            HideAllForm();
            inputcontrol.Show();
            partscon1.Show();
        }

        //全部非表示にする
        public void HideAllForm()
        {
            homecontrol.Hide();
            inputcontrol.Hide();
            partscon1.Hide();
            partscon2.Hide();
        }

    }//Class
}
