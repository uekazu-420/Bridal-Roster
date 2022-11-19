namespace BridalForm.Control
{
    partial class HomeControl
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.Searchgrid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rbtnYnote = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbtnKazu = new System.Windows.Forms.RadioButton();
            this.rbtnRisa = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbtnMen = new System.Windows.Forms.RadioButton();
            this.rbtnWemen = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rbtnYadd = new System.Windows.Forms.RadioButton();
            this.rbtnNadd = new System.Windows.Forms.RadioButton();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkSearch = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.Searchgrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Searchgrid
            // 
            this.Searchgrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Searchgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Searchgrid.Location = new System.Drawing.Point(3, 161);
            this.Searchgrid.Name = "Searchgrid";
            this.Searchgrid.RowTemplate.Height = 21;
            this.Searchgrid.Size = new System.Drawing.Size(1097, 501);
            this.Searchgrid.TabIndex = 80;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Location = new System.Drawing.Point(33, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 118);
            this.groupBox1.TabIndex = 76;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "検索一覧";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rbtnYnote);
            this.groupBox6.Location = new System.Drawing.Point(416, 24);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(101, 55);
            this.groupBox6.TabIndex = 83;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "その他";
            // 
            // rbtnYnote
            // 
            this.rbtnYnote.AutoSize = true;
            this.rbtnYnote.Location = new System.Drawing.Point(15, 25);
            this.rbtnYnote.Name = "rbtnYnote";
            this.rbtnYnote.Size = new System.Drawing.Size(65, 16);
            this.rbtnYnote.TabIndex = 82;
            this.rbtnYnote.TabStop = true;
            this.rbtnYnote.Text = "備考あり";
            this.rbtnYnote.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbtnKazu);
            this.groupBox3.Controls.Add(this.rbtnRisa);
            this.groupBox3.Location = new System.Drawing.Point(34, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(101, 77);
            this.groupBox3.TabIndex = 83;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "新郎新婦";
            // 
            // rbtnKazu
            // 
            this.rbtnKazu.AutoSize = true;
            this.rbtnKazu.Location = new System.Drawing.Point(15, 25);
            this.rbtnKazu.Name = "rbtnKazu";
            this.rbtnKazu.Size = new System.Drawing.Size(47, 16);
            this.rbtnKazu.TabIndex = 82;
            this.rbtnKazu.TabStop = true;
            this.rbtnKazu.Text = "和雅";
            this.rbtnKazu.UseVisualStyleBackColor = true;
            // 
            // rbtnRisa
            // 
            this.rbtnRisa.AutoSize = true;
            this.rbtnRisa.Location = new System.Drawing.Point(15, 47);
            this.rbtnRisa.Name = "rbtnRisa";
            this.rbtnRisa.Size = new System.Drawing.Size(47, 16);
            this.rbtnRisa.TabIndex = 82;
            this.rbtnRisa.TabStop = true;
            this.rbtnRisa.Text = "理沙";
            this.rbtnRisa.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbtnMen);
            this.groupBox4.Controls.Add(this.rbtnWemen);
            this.groupBox4.Location = new System.Drawing.Point(158, 24);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(101, 77);
            this.groupBox4.TabIndex = 83;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "性別";
            // 
            // rbtnMen
            // 
            this.rbtnMen.AutoSize = true;
            this.rbtnMen.Location = new System.Drawing.Point(15, 25);
            this.rbtnMen.Name = "rbtnMen";
            this.rbtnMen.Size = new System.Drawing.Size(35, 16);
            this.rbtnMen.TabIndex = 82;
            this.rbtnMen.TabStop = true;
            this.rbtnMen.Text = "男";
            this.rbtnMen.UseVisualStyleBackColor = true;
            // 
            // rbtnWemen
            // 
            this.rbtnWemen.AutoSize = true;
            this.rbtnWemen.Location = new System.Drawing.Point(15, 47);
            this.rbtnWemen.Name = "rbtnWemen";
            this.rbtnWemen.Size = new System.Drawing.Size(35, 16);
            this.rbtnWemen.TabIndex = 82;
            this.rbtnWemen.TabStop = true;
            this.rbtnWemen.Text = "女";
            this.rbtnWemen.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rbtnYadd);
            this.groupBox5.Controls.Add(this.rbtnNadd);
            this.groupBox5.Location = new System.Drawing.Point(288, 24);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(99, 77);
            this.groupBox5.TabIndex = 83;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "住所";
            // 
            // rbtnYadd
            // 
            this.rbtnYadd.AutoSize = true;
            this.rbtnYadd.Location = new System.Drawing.Point(15, 25);
            this.rbtnYadd.Name = "rbtnYadd";
            this.rbtnYadd.Size = new System.Drawing.Size(65, 16);
            this.rbtnYadd.TabIndex = 82;
            this.rbtnYadd.TabStop = true;
            this.rbtnYadd.Text = "住所あり";
            this.rbtnYadd.UseVisualStyleBackColor = true;
            // 
            // rbtnNadd
            // 
            this.rbtnNadd.AutoSize = true;
            this.rbtnNadd.Location = new System.Drawing.Point(15, 47);
            this.rbtnNadd.Name = "rbtnNadd";
            this.rbtnNadd.Size = new System.Drawing.Size(66, 16);
            this.rbtnNadd.TabIndex = 82;
            this.rbtnNadd.TabStop = true;
            this.rbtnNadd.Text = "住所なし";
            this.rbtnNadd.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(605, 19);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(59, 12);
            this.lblTotal.TabIndex = 66;
            this.lblTotal.Text = "合計人数：";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(718, 86);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(114, 60);
            this.btnReset.TabIndex = 84;
            this.btnReset.Text = "リセット";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(589, 86);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(114, 60);
            this.btnSearch.TabIndex = 84;
            this.btnSearch.Text = "表示";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.checkSearch);
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1103, 158);
            this.panel2.TabIndex = 83;
            // 
            // checkSearch
            // 
            this.checkSearch.AutoSize = true;
            this.checkSearch.Location = new System.Drawing.Point(33, 15);
            this.checkSearch.Name = "checkSearch";
            this.checkSearch.Size = new System.Drawing.Size(119, 16);
            this.checkSearch.TabIndex = 86;
            this.checkSearch.Text = "絞り込み検索をする";
            this.checkSearch.UseVisualStyleBackColor = true;
            this.checkSearch.CheckedChanged += new System.EventHandler(this.checkSearch_CheckedChanged);
            // 
            // HomeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Searchgrid);
            this.Name = "HomeControl";
            this.Size = new System.Drawing.Size(1103, 665);
            ((System.ComponentModel.ISupportInitialize)(this.Searchgrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView Searchgrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton rbtnYnote;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rbtnYadd;
        private System.Windows.Forms.RadioButton rbtnNadd;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbtnMen;
        private System.Windows.Forms.RadioButton rbtnWemen;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbtnKazu;
        private System.Windows.Forms.RadioButton rbtnRisa;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox checkSearch;
    }
}
