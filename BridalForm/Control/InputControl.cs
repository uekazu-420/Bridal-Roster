using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace BridalForm.Control
{
    public partial class InputControl : UserControl
    {
        private DataTable datatable { get; set; }
        private SQLiteConnection con { get; set; }
        private SQLiteDataAdapter adapter { get; set; }

        public InputControl()
        {
            InitializeComponent();
        }

        private void InputControl_Load(object sender, EventArgs e)
        {
            //事前にテーブルの作成
            CreateTable();
            DataSetting();
            GetGendeList();
        }

        //画面設定
        private void DataSetting()
        {
            //Font
            textname.Font    = new Font("Arial", 11);
            textname11.Font  = new Font("Arial", 11);
            textname3.Font   = new Font("Arial", 11);
            textname33.Font  = new Font("Arial", 11);
            combos.Font      = new Font("Arial", 11);
            label5.Font      = new Font("Arial", 11);
            textadd.Font     = new Font("Arial", 11);
            textAdress1.Font = new Font("Arial", 11);
            textAdress2.Font = new Font("Arial", 11);
            textAdress3.Font = new Font("Arial", 11);
            nolike1.Font     = new Font("Arial", 9);
            nolike2.Font     = new Font("Arial", 9);
            nolike3.Font     = new Font("Arial", 9);
            nolike4.Font     = new Font("Arial", 9);
            nolike5.Font     = new Font("Arial", 9);
            nolike6.Font     = new Font("Arial", 9);
            nolike7.Font     = new Font("Arial", 9);
            nolike8.Font     = new Font("Arial", 9);
            nolike9.Font     = new Font("Arial", 9);
            nolike10.Font    = new Font("Arial", 9);
            number.Font      = new Font("Arial", 11);

            //入力画面
            groupBox2.Enabled = Focused;
            textAdress1.ReadOnly = true;
            combos.DropDownStyle = ComboBoxStyle.DropDownList;
            //表示
            nametext.Visible = false;
            //Grid
            Inputgrid.AllowUserToAddRows = false;
            Inputgrid.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
            Inputgrid.MultiSelect = false;
        }

        /// <summary>
        /// チェックボックスの切り替え表示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) {
                groupBox2.Enabled = true;
            } else {
                groupBox2.Enabled = false; }
        }

        /// <summary>
        /// 郵便番号から住所検索 ボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddSearch_Click(object sender, EventArgs e)
        {
            string Address;           //住所
            Boolean blnFlag = false;  //見つかったかどうかのフラグ

            //郵便番号が入力されていないとき
            if (textadd.Text == "")
            {
                MessageBox.Show("郵便番号が入力されていません。");
                this.textadd.Focus();
                return; //処理を抜ける
            }

            //マウスカーソルを砂時計にする
            Cursor.Current = Cursors.WaitCursor;
            string sKey = textadd.Text;

            //文字列の前後のスペースをとる
            sKey = sKey.Trim(' ');

            //Microsoft.VisualBasic名前空間のStrConv関数を使って、
            //全角文字を半角文字に変換
            //sKey = Strings.StrConv(sKey, VbStrConv.Narrow, 0);

            // 文字列の長さを取得する
            int iLength = sKey.Length;
            if (iLength == 8)　//"-"が含まれている
            {
                // 先頭文字目の後から '-' を検索し、見つかった位置を取得する
                int iFind = sKey.IndexOf('-', 0);

                //左から3文字+"-"文字以降をtmpZip変数に代入
                sKey = sKey.Substring(0, 3) + sKey.Substring(iFind + 1);
            }
            try
            {
                //StreamReaderオブジェクトの作成
                StreamReader sr = new StreamReader("C:\\data\\KEN_ALL.CSV", Encoding.Default);

                //1行ずつ読み込み
                string dat;
                while ((dat = sr.ReadLine()) != null)
                {
                    string tmpZip;

                    //カンマで区切られた文字列を取得
                    string[] sbuf = dat.Split(',');

                    //配列の3番目が郵便番号
                    tmpZip = sbuf[2].Trim('"');

                    //入力された郵便番号と比較
                    if (sKey == tmpZip)
                    {
                        //住所を作成
                        //都道府県名+市区町村名+町域名
                        Address = sbuf[6].Trim('"') + sbuf[7].Trim('"') + sbuf[8].Trim('"');

                        //テキストボックスに住所を表示
                        textAdress1.Text = Address;
                        blnFlag = true; //フラグをTrueにして
                        break;          //ループを抜ける
                    }
                    Application.DoEvents();
                }
                //ファイルを閉じる
                sr.Close();
            }
            catch (Exception ex)
            {
                //ファイルエラーが発生
                MessageBox.Show(ex.Message, "ファイルエラー",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return; //処理を抜ける
            }
            finally
            {
                //マウスカーソルをデフォルトにする
                Cursor.Current = Cursors.Default;
            }
            if (blnFlag == false)
            {
                MessageBox.Show("該当の郵便番号は見つかりませんでした。","郵便番号検索",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 郵便番号入力設定
        /// ImeModeプロパティをDisableに変更
        /// ShortcutsEnabledプロパティをFalseに変更
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textadd_KeyPress(object sender, KeyPressEventArgs e)
        {
            //バックスペースが押された時は有効（Deleteキーも有効）
            if (e.KeyChar == '\b')
            {
                return;
            }

            //数値0～9以外が押された時はイベントをキャンセルする
            if ((e.KeyChar < '0' || '9' < e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //テーブルを作成
        void CreateTable()
        {
            using (var cn = new SQLiteConnection(@"data source =" + _source.bridal))
            {
                cn.Open();

                using (var cmd = new SQLiteCommand(cn))
                {
                        cmd.CommandText = "create table if not exists table_address(" +
                            "id integer primary key autoincrement," +
                            "新郎新婦 text ," +
                            "名前 text ," +
                            "ナマエ text ," +
                            "性別 text ," +
                            "〒 text ," +
                            "住所１ text ," +
                            "住所２ text ," +
                            "備考 text )";
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //データの表示
        private void dataload()
        {
            con = new SQLiteConnection(@"data source =" + _source.bridal);
            con.Open();

            //空のテーブルを作ります。
            //この時点では、DataGridViewと紐づいていません。
            datatable = new DataTable();

            //データテーブルをDataGridViewに紐づけます。
            Inputgrid.DataSource = datatable;

            //データを読み込みます
            DataRead();

            //除外
            if (nametext.Text == "和雅") {
                datatable.DefaultView.RowFilter = "新郎新婦 <> '理沙'";
            } else {
                datatable.DefaultView.RowFilter = "新郎新婦 <> '和雅'";
            }
        }

        private void DataRead()
        {
            //DataGridViewにどんどん追加されるので、一度初期化してから追加する
            datatable.Clear();
            adapter = new SQLiteDataAdapter("SELECT * FROM table_address;", con);
            adapter.Fill(datatable);

            //非表示
            Inputgrid.Columns["id"].Visible = false;
            Inputgrid.Columns["新郎新婦"].Visible = false;
            //位置設定
            Inputgrid.Columns["性別"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //幅設定
            Inputgrid.Columns["名前"].Width   = 100;
            Inputgrid.Columns["ナマエ"].Width = 120;
            Inputgrid.Columns["性別"].Width   = 55;
            Inputgrid.Columns["〒"].Width     = 80;
            Inputgrid.Columns["住所１"].Width = 150;
            Inputgrid.Columns["住所２"].Width = 150;
            Inputgrid.Columns["備考"].Width   = 100;
        }

        //データを追加
        void Insert(string a, string b, string c, string d, string e, string f, string g, string h )
        {
            using (var cn = new SQLiteConnection(@"data source =" + _source.bridal))
            {
                cn.Open();

                using (var cmd = new SQLiteCommand(cn))
                {
                    string str = $"insert into table_address(新郎新婦, 名前, ナマエ, 性別, 〒, 住所１, 住所２, 備考) values('{a}', '{b}', '{c}', '{d}', '{e}', '{f}', '{g}', '{h}' )";
                    cmd.CommandText = str;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //データを削除
        void Delete(int id)
        {
            using (var cn = new SQLiteConnection(@"data source =" + _source.bridal))
            {
                cn.Open();

                using (var cmd = new SQLiteCommand(cn))
                {
                    cmd.CommandText = $"delete from table_address where id = {id}";
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// 入力ボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInput_Click(object sender, EventArgs e)
        {
            //ボタンクリック確認
            if (nametext.Text == "") {
                MessageBox.Show("和雅？理沙？選択してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; }
            //名前の記入確認
            if (textname.Text == "") {
                MessageBox.Show("未記入の項目があります。", "エラー",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; }
            //ナマエの記入確認
            if (textname11.Text == "") {
                MessageBox.Show("未記入の項目があります。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; }
            //性別の入力確認
            if (combos.Text == "") {
                MessageBox.Show("未記入の項目があります。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; }

            //全角カタカナ記入確認　
            if (!(Regex.Match(textname11.Text, @"^[\u30a0-\u30ff　]+$")).Success) {
                MessageBox.Show("記入方法が違います。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; }

            if (checkBox1.Checked) {
                errorCheck(); } 
            else { }

            string newa = nametext.Text;
            string newb = textname.Text;
            string newc = textname11.Text;
            string newd = combos.Text;
            string newe = textadd.Text;
            string newf = textAdress1.Text + textAdress2.Text;
            string newg = textAdress3.Text;
            string newh = richNote.Text;

            Insert(newa, newb, newc, newd, newe, newf, newg, newh);

            dataload();
        }

        //住所入力をした時のエラー検索
        private void errorCheck()
        {
            //住所の記入確認
            if (textadd.Text == "") {
                MessageBox.Show("未記入の項目があります。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; }
            //住所2の記入確認
            if (textAdress1.Text == "") {
                MessageBox.Show("未記入の項目があります。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; }
            //住所2の記入確認
            if (textAdress2.Text == "") {
                MessageBox.Show("未記入の項目があります。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; }
        }

        /// <summary>
        /// 削除ボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void contextdelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("本当に削除してもいいですか？", "注意", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

            // どこも選択されていないときに実行されるかもしれないので例外処理をしている
            try
            {
                DataGridViewCell cell = Inputgrid.SelectedCells[0];
                int i = cell.RowIndex;
                DataGridViewRow row = Inputgrid.Rows[i];
                string value = row.Cells[0].Value.ToString();
                int id = int.Parse(value);

                Delete(id);
                dataload();
            }
            catch
            {
                MessageBox.Show("行が選択されていません");
            }
        }

        /// <summary>
        /// 和雅関係のみ表示クリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKazu_Click(object sender, EventArgs e)
        {
            //ボタンの色を変更する
            btnKazu.BackColor = Color.Aqua;
            btnRisa.UseVisualStyleBackColor = true;

            nametext.Text = btnKazu.Text;

            dataload();
        }

        /// <summary>
        /// 理沙関係のみ表示クリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRisa_Click(object sender, EventArgs e)
        {
            //ボタンの色を変更する
            btnRisa.BackColor = Color.Pink;
            btnKazu.UseVisualStyleBackColor = true;

            nametext.Text = btnRisa.Text;

            dataload();
        }

        /// <summary>
        /// リセットボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            textname.ResetText();
            textname11.ResetText();
            combos.ResetText();
            textadd.ResetText();
            textAdress1.ResetText();
            textAdress2.ResetText();
            textAdress3.ResetText();
            richNote.ResetText();
        }

        private void GetGendeList()
        {
            // XML読み込み
            XElement xml = XElement.Load(_source.gender);

            // user.nameの値を取得
            IEnumerable<String> names = from item in xml.Elements("sends") select item.Value;

            foreach (string i in names)
            {
                combos.Items.Add(Path.GetFileNameWithoutExtension(i));
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }//Class
}
