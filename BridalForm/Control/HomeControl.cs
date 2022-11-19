using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace BridalForm.Control
{
    public partial class HomeControl : UserControl
    {
        private DataTable datatable { get; set; }
        private SQLiteConnection con { get; set; }
        private SQLiteDataAdapter adapter { get; set; }

        public HomeControl()
        {
            InitializeComponent();
            DataSetting();
        }

        //画面設定
        private void DataSetting()
        {
            //Font
            lblTotal.Font      = new Font("Arial", 12);
            checkSearch.Font = new Font("Arial", 12);
            groupBox1.Font   = new Font("Arial", 12);
            groupBox3.Font   = new Font("Arial", 12);
            groupBox4.Font   = new Font("Arial", 12);
            groupBox5.Font   = new Font("Arial", 12);
            groupBox6.Font   = new Font("Arial", 12);
            btnSearch.Font   = new Font("Arial", 15);
            btnReset.Font    = new Font("Arial", 15);
            //Bold
            btnSearch.Font   = new Font(btnSearch.Font, FontStyle.Bold);
            btnReset.Font    = new Font(btnReset.Font, FontStyle.Bold);

            //入力画面
            groupBox1.Enabled = Focused;　　　//入力不可
            //非表示
            btnReset.Visible = false;
            //grid
            Searchgrid.ReadOnly = true; 　　      　//読み取り専用
            Searchgrid.AllowUserToAddRows = false;  //一番下の行削除
            Searchgrid.RowHeadersVisible = false;   //一番左の列削除
            Searchgrid.AlternatingRowsDefaultCellStyle.BackColor = Color.Lavender;


        }

        /// <summary>
        /// チェックボックスの切り替え表示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSearch.Checked) 
            {
                groupBox1.Enabled = true;
                btnSearch.Text = "検索";
                btnReset.Visible = true;
            }
            else 
            {
                groupBox1.Enabled = false;
                btnSearch.Text = "表示";
                checkout();
                btnReset.Visible = false;
            }
        }

        //データの表示
        private void dataload()
        {
            con = new SQLiteConnection(@"DataSource = ..\..\..\data\bridal.db");
            con.Open();

            //空のテーブルを作ります。
            //この時点では、DataGridViewと紐づいていません。
            datatable = new DataTable();

            //データテーブルをDataGridViewに紐づけます。
            Searchgrid.DataSource = datatable;

            //データを読み込みます
            DataRead();

            if (btnSearch.Text == "表示")
            { }
            else
            {
                Searchdata();
            }
        }

        private void DataRead()
        {
            //DataGridViewにどんどん追加されるので、一度初期化してから追加する
            datatable.Clear();
            adapter = new SQLiteDataAdapter("SELECT * FROM table_address;", con);
            adapter.Fill(datatable);

            //非表示
            Searchgrid.Columns["id"].Visible = false;
            Searchgrid.Columns["新郎新婦"].Visible = false;
            //位置設定
            Searchgrid.Columns["性別"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //幅設定
            Searchgrid.Columns["名前"].Width = 100;
            Searchgrid.Columns["ナマエ"].Width = 120;
            Searchgrid.Columns["性別"].Width = 55;
            Searchgrid.Columns["〒"].Width = 80;
            Searchgrid.Columns["住所１"].Width = 150;
            Searchgrid.Columns["住所２"].Width = 150;
            Searchgrid.Columns["備考"].Width = 100;
        }

        //絞り込み検索処理
        private void Searchdata()
        {
            if (rbtnKazu.Checked) {
                datatable.DefaultView.RowFilter = "新郎新婦 = '和雅'";  //和雅 一致
            } if (rbtnRisa.Checked) {
                datatable.DefaultView.RowFilter = "新郎新婦 = '理沙'";  //理沙 一致
            } if (rbtnMen.Checked) {
                datatable.DefaultView.RowFilter = "性別 = '男'";        //男   一致
            } if (rbtnWemen.Checked) {
                datatable.DefaultView.RowFilter = "性別 = '女'";        //女   一致
            } if (rbtnYadd.Checked) {
                datatable.DefaultView.RowFilter = "〒 = ''";            //空白 一致
            } if (rbtnNadd.Checked) {
                datatable.DefaultView.RowFilter = "〒 <> ''";           //空白 除外
            } if (rbtnYnote.Checked) {
                datatable.DefaultView.RowFilter = "備考 <> ''";         //空白 除外
            }
        }

        //チェックを全て外す
        private void checkout()
        {
            rbtnKazu.Checked  = false;
            rbtnRisa.Checked  = false;
            rbtnMen.Checked   = false;
            rbtnWemen.Checked = false;
            rbtnYadd.Checked  = false;
            rbtnNadd.Checked  = false;
            rbtnYnote.Checked = false;
        }

        /// <summary>
        /// 表示・検索ボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataload();

            string d = Searchgrid.Rows.Count.ToString();
            lblTotal.Text = "合計人数：" + d + "人";
        }

        /// <summary>
        /// リセットボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            checkout();
        }
    }//Class
}

