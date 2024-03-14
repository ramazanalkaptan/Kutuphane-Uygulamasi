namespace kutuphaneOtomasyon
{
    partial class UyePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.text_uyekitapara = new System.Windows.Forms.TextBox();
            this.btn_uyekitapYenile = new System.Windows.Forms.Button();
            this.btn_uyekitapAra = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGrid_uyekitap = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapsayfasayisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapbasimyili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_uyekitap)).BeginInit();
            this.SuspendLayout();
            // 
            // text_uyekitapara
            // 
            this.text_uyekitapara.Location = new System.Drawing.Point(114, 12);
            this.text_uyekitapara.Multiline = true;
            this.text_uyekitapara.Name = "text_uyekitapara";
            this.text_uyekitapara.Size = new System.Drawing.Size(172, 23);
            this.text_uyekitapara.TabIndex = 9;
            // 
            // btn_uyekitapYenile
            // 
            this.btn_uyekitapYenile.Location = new System.Drawing.Point(375, 12);
            this.btn_uyekitapYenile.Name = "btn_uyekitapYenile";
            this.btn_uyekitapYenile.Size = new System.Drawing.Size(77, 23);
            this.btn_uyekitapYenile.TabIndex = 7;
            this.btn_uyekitapYenile.Text = "Yenile";
            this.btn_uyekitapYenile.UseVisualStyleBackColor = true;
            this.btn_uyekitapYenile.Click += new System.EventHandler(this.btn_uyekitapYenile_Click);
            // 
            // btn_uyekitapAra
            // 
            this.btn_uyekitapAra.Location = new System.Drawing.Point(292, 12);
            this.btn_uyekitapAra.Name = "btn_uyekitapAra";
            this.btn_uyekitapAra.Size = new System.Drawing.Size(77, 23);
            this.btn_uyekitapAra.TabIndex = 8;
            this.btn_uyekitapAra.Text = "Ara";
            this.btn_uyekitapAra.UseVisualStyleBackColor = true;
            this.btn_uyekitapAra.Click += new System.EventHandler(this.btn_uyekitapAra_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(298, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "KİTAP LİSTESİ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(8, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Kitap adı giriniz :";
            // 
            // dataGrid_uyekitap
            // 
            this.dataGrid_uyekitap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_uyekitap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.kitapsayfasayisi,
            this.kitapbasimyili});
            this.dataGrid_uyekitap.Location = new System.Drawing.Point(11, 82);
            this.dataGrid_uyekitap.Name = "dataGrid_uyekitap";
            this.dataGrid_uyekitap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGrid_uyekitap.Size = new System.Drawing.Size(793, 452);
            this.dataGrid_uyekitap.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "KİTAP İSMİ";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "KİTAP YAZARI";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "DİLİ";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "YAYIN EVİ";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "TÜR";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "ADET";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // kitapsayfasayisi
            // 
            this.kitapsayfasayisi.HeaderText = "SAYFA SAYISI";
            this.kitapsayfasayisi.Name = "kitapsayfasayisi";
            // 
            // kitapbasimyili
            // 
            this.kitapbasimyili.HeaderText = "BASIM YILI";
            this.kitapbasimyili.Name = "kitapbasimyili";
            // 
            // UyePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 534);
            this.Controls.Add(this.dataGrid_uyekitap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_uyekitapara);
            this.Controls.Add(this.btn_uyekitapYenile);
            this.Controls.Add(this.btn_uyekitapAra);
            this.Controls.Add(this.label8);
            this.Name = "UyePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UyePage";
            this.Load += new System.EventHandler(this.UyePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_uyekitap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_uyekitapara;
        private System.Windows.Forms.Button btn_uyekitapYenile;
        private System.Windows.Forms.Button btn_uyekitapAra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapsayfasayisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapbasimyili;
        public System.Windows.Forms.DataGridView dataGrid_uyekitap;
    }
}