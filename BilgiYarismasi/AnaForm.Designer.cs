namespace BilgiYarismasi
{
    partial class AnaForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbSorular = new System.Windows.Forms.ListBox();
            this.btnYenile = new System.Windows.Forms.Button();
            this.btnZamanIleri = new System.Windows.Forms.Button();
            this.btnZamanGeri = new System.Windows.Forms.Button();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.lblZamanSayac = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pBoxSoru = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblCevap = new System.Windows.Forms.Label();
            this.btnCevap = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.timerSayac = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSoru)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.086614F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.824147F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.99213F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.96588F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1381, 938);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lbSorular);
            this.panel1.Controls.Add(this.btnYenile);
            this.panel1.Controls.Add(this.btnZamanIleri);
            this.panel1.Controls.Add(this.btnZamanGeri);
            this.panel1.Controls.Add(this.lblMesaj);
            this.panel1.Controls.Add(this.lblZamanSayac);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 130);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.tableLayoutPanel1.SetRowSpan(this.panel1, 2);
            this.panel1.Size = new System.Drawing.Size(345, 808);
            this.panel1.TabIndex = 2;
            // 
            // lbSorular
            // 
            this.lbSorular.BackColor = System.Drawing.Color.OliveDrab;
            this.lbSorular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbSorular.ForeColor = System.Drawing.Color.White;
            this.lbSorular.FormattingEnabled = true;
            this.lbSorular.ItemHeight = 25;
            this.lbSorular.Location = new System.Drawing.Point(18, 43);
            this.lbSorular.Name = "lbSorular";
            this.lbSorular.Size = new System.Drawing.Size(304, 329);
            this.lbSorular.TabIndex = 21;
            // 
            // btnYenile
            // 
            this.btnYenile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYenile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYenile.ForeColor = System.Drawing.Color.White;
            this.btnYenile.Location = new System.Drawing.Point(7, 390);
            this.btnYenile.Margin = new System.Windows.Forms.Padding(4);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(318, 64);
            this.btnYenile.TabIndex = 20;
            this.btnYenile.Text = "YENİLE";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // btnZamanIleri
            // 
            this.btnZamanIleri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZamanIleri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnZamanIleri.Image = ((System.Drawing.Image)(resources.GetObject("btnZamanIleri.Image")));
            this.btnZamanIleri.Location = new System.Drawing.Point(247, 512);
            this.btnZamanIleri.Margin = new System.Windows.Forms.Padding(4);
            this.btnZamanIleri.Name = "btnZamanIleri";
            this.btnZamanIleri.Size = new System.Drawing.Size(67, 79);
            this.btnZamanIleri.TabIndex = 18;
            this.btnZamanIleri.UseVisualStyleBackColor = true;
            this.btnZamanIleri.Click += new System.EventHandler(this.btnZamanIleri_Click);
            // 
            // btnZamanGeri
            // 
            this.btnZamanGeri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZamanGeri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnZamanGeri.Image = ((System.Drawing.Image)(resources.GetObject("btnZamanGeri.Image")));
            this.btnZamanGeri.Location = new System.Drawing.Point(7, 512);
            this.btnZamanGeri.Margin = new System.Windows.Forms.Padding(4);
            this.btnZamanGeri.Name = "btnZamanGeri";
            this.btnZamanGeri.Size = new System.Drawing.Size(67, 79);
            this.btnZamanGeri.TabIndex = 17;
            this.btnZamanGeri.UseVisualStyleBackColor = true;
            this.btnZamanGeri.Click += new System.EventHandler(this.btnZamanGeri_Click);
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMesaj.ForeColor = System.Drawing.Color.Maroon;
            this.lblMesaj.Location = new System.Drawing.Point(16, 677);
            this.lblMesaj.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(0, 29);
            this.lblMesaj.TabIndex = 16;
            // 
            // lblZamanSayac
            // 
            this.lblZamanSayac.AutoSize = true;
            this.lblZamanSayac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblZamanSayac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblZamanSayac.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblZamanSayac.ForeColor = System.Drawing.Color.White;
            this.lblZamanSayac.Location = new System.Drawing.Point(104, 519);
            this.lblZamanSayac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblZamanSayac.Name = "lblZamanSayac";
            this.lblZamanSayac.Size = new System.Drawing.Size(100, 71);
            this.lblZamanSayac.TabIndex = 15;
            this.lblZamanSayac.Text = "60";
            this.lblZamanSayac.Click += new System.EventHandler(this.lblZamanSayac_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "SORULAR";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(75, 476);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(345, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1036, 66);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "BİLGİ YARIŞMASI";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.pBoxSoru);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(345, 130);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1036, 591);
            this.panel3.TabIndex = 4;
            // 
            // pBoxSoru
            // 
            this.pBoxSoru.BackColor = System.Drawing.Color.Transparent;
            this.pBoxSoru.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBoxSoru.Location = new System.Drawing.Point(0, 0);
            this.pBoxSoru.Margin = new System.Windows.Forms.Padding(4);
            this.pBoxSoru.Name = "pBoxSoru";
            this.pBoxSoru.Size = new System.Drawing.Size(1036, 591);
            this.pBoxSoru.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxSoru.TabIndex = 3;
            this.pBoxSoru.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(345, 66);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1036, 64);
            this.panel4.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.lblCevap);
            this.panel5.Controls.Add(this.btnCevap);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(345, 721);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1036, 217);
            this.panel5.TabIndex = 6;
            // 
            // lblCevap
            // 
            this.lblCevap.AutoSize = true;
            this.lblCevap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCevap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCevap.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCevap.ForeColor = System.Drawing.Color.White;
            this.lblCevap.Location = new System.Drawing.Point(153, 85);
            this.lblCevap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCevap.Name = "lblCevap";
            this.lblCevap.Size = new System.Drawing.Size(2, 93);
            this.lblCevap.TabIndex = 18;
            // 
            // btnCevap
            // 
            this.btnCevap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCevap.BackgroundImage")));
            this.btnCevap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCevap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCevap.Location = new System.Drawing.Point(4, 71);
            this.btnCevap.Margin = new System.Windows.Forms.Padding(4);
            this.btnCevap.Name = "btnCevap";
            this.btnCevap.Size = new System.Drawing.Size(141, 117);
            this.btnCevap.TabIndex = 17;
            this.btnCevap.UseVisualStyleBackColor = true;
            this.btnCevap.Click += new System.EventHandler(this.btnCevap_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 44);
            this.label3.TabIndex = 16;
            this.label3.Text = "Cevap";
            // 
            // timerSayac
            // 
            this.timerSayac.Interval = 1000;
            this.timerSayac.Tick += new System.EventHandler(this.timerSayac_Tick);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1381, 938);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AnaForm";
            this.Text = "Ana Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSoru)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblZamanSayac;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Timer timerSayac;
        private System.Windows.Forms.PictureBox pBoxSoru;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Button btnZamanIleri;
        private System.Windows.Forms.Button btnZamanGeri;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblCevap;
        private System.Windows.Forms.Button btnCevap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.ListBox lbSorular;
    }
}

