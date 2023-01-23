namespace Kanban
{
    partial class Form1
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
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.txtSoyisim = new System.Windows.Forms.TextBox();
            this.txtIsTanimi = new System.Windows.Forms.TextBox();
            this.rdbToDo = new System.Windows.Forms.RadioButton();
            this.rdbDoing = new System.Windows.Forms.RadioButton();
            this.rdbDone = new System.Windows.Forms.RadioButton();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblIs = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.btnDoingEkle = new System.Windows.Forms.Button();
            this.btnDoneEkle1 = new System.Windows.Forms.Button();
            this.btnDoneEkle2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(115, 28);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(220, 20);
            this.txtIsim.TabIndex = 0;
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.Location = new System.Drawing.Point(115, 54);
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(220, 20);
            this.txtSoyisim.TabIndex = 0;
            // 
            // txtIsTanimi
            // 
            this.txtIsTanimi.Location = new System.Drawing.Point(115, 80);
            this.txtIsTanimi.Name = "txtIsTanimi";
            this.txtIsTanimi.Size = new System.Drawing.Size(220, 20);
            this.txtIsTanimi.TabIndex = 0;
            // 
            // rdbToDo
            // 
            this.rdbToDo.AutoSize = true;
            this.rdbToDo.Location = new System.Drawing.Point(115, 134);
            this.rdbToDo.Name = "rdbToDo";
            this.rdbToDo.Size = new System.Drawing.Size(55, 17);
            this.rdbToDo.TabIndex = 1;
            this.rdbToDo.TabStop = true;
            this.rdbToDo.Text = "To Do";
            this.rdbToDo.UseVisualStyleBackColor = true;
            // 
            // rdbDoing
            // 
            this.rdbDoing.AutoSize = true;
            this.rdbDoing.Location = new System.Drawing.Point(196, 134);
            this.rdbDoing.Name = "rdbDoing";
            this.rdbDoing.Size = new System.Drawing.Size(53, 17);
            this.rdbDoing.TabIndex = 1;
            this.rdbDoing.TabStop = true;
            this.rdbDoing.Text = "Doing";
            this.rdbDoing.UseVisualStyleBackColor = true;
            // 
            // rdbDone
            // 
            this.rdbDone.AutoSize = true;
            this.rdbDone.Location = new System.Drawing.Point(284, 134);
            this.rdbDone.Name = "rdbDone";
            this.rdbDone.Size = new System.Drawing.Size(51, 17);
            this.rdbDone.TabIndex = 1;
            this.rdbDone.TabStop = true;
            this.rdbDone.Text = "Done";
            this.rdbDone.UseVisualStyleBackColor = true;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(26, 34);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(31, 13);
            this.lblAd.TabIndex = 2;
            this.lblAd.Text = "İsim :";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(26, 61);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(48, 13);
            this.lblSoyad.TabIndex = 2;
            this.lblSoyad.Text = "Soyisim :";
            // 
            // lblIs
            // 
            this.lblIs.AutoSize = true;
            this.lblIs.Location = new System.Drawing.Point(26, 87);
            this.lblIs.Name = "lblIs";
            this.lblIs.Size = new System.Drawing.Size(55, 13);
            this.lblIs.TabIndex = 2;
            this.lblIs.Text = "İş Tanımı :";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(26, 134);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(38, 13);
            this.lblState.TabIndex = 2;
            this.lblState.Text = "Statü :";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(115, 172);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(134, 22);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Kişiyi Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 234);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(306, 237);
            this.dataGridView1.TabIndex = 4;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(356, 234);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(306, 237);
            this.dataGridView2.TabIndex = 4;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(668, 234);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(306, 237);
            this.dataGridView3.TabIndex = 4;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(139, 218);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(69, 13);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "To Do Listesi";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(482, 218);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(67, 13);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Doing Listesi";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(796, 218);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(65, 13);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "Done Listesi";
            // 
            // btnDoingEkle
            // 
            this.btnDoingEkle.Location = new System.Drawing.Point(36, 495);
            this.btnDoingEkle.Name = "btnDoingEkle";
            this.btnDoingEkle.Size = new System.Drawing.Size(134, 22);
            this.btnDoingEkle.TabIndex = 3;
            this.btnDoingEkle.Text = "Doing Listesine Ekle";
            this.btnDoingEkle.UseVisualStyleBackColor = true;
            this.btnDoingEkle.Click += new System.EventHandler(this.btnDoingEkle_Click);
            // 
            // btnDoneEkle1
            // 
            this.btnDoneEkle1.Location = new System.Drawing.Point(185, 495);
            this.btnDoneEkle1.Name = "btnDoneEkle1";
            this.btnDoneEkle1.Size = new System.Drawing.Size(134, 22);
            this.btnDoneEkle1.TabIndex = 3;
            this.btnDoneEkle1.Text = "Done Listesine Ekle";
            this.btnDoneEkle1.UseVisualStyleBackColor = true;
            this.btnDoneEkle1.Click += new System.EventHandler(this.btnDoneEkle1_Click);
            // 
            // btnDoneEkle2
            // 
            this.btnDoneEkle2.Location = new System.Drawing.Point(442, 495);
            this.btnDoneEkle2.Name = "btnDoneEkle2";
            this.btnDoneEkle2.Size = new System.Drawing.Size(134, 22);
            this.btnDoneEkle2.TabIndex = 3;
            this.btnDoneEkle2.Text = "Done Listesine Ekle";
            this.btnDoneEkle2.UseVisualStyleBackColor = true;
            this.btnDoneEkle2.Click += new System.EventHandler(this.btnDoneEkle2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 529);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDoneEkle2);
            this.Controls.Add(this.btnDoneEkle1);
            this.Controls.Add(this.btnDoingEkle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lblIs);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.rdbDone);
            this.Controls.Add(this.rdbDoing);
            this.Controls.Add(this.rdbToDo);
            this.Controls.Add(this.txtIsTanimi);
            this.Controls.Add(this.txtSoyisim);
            this.Controls.Add(this.txtIsim);
            this.Name = "Form1";
            this.Text = "Kanban";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.TextBox txtSoyisim;
        private System.Windows.Forms.TextBox txtIsTanimi;
        private System.Windows.Forms.RadioButton rdbToDo;
        private System.Windows.Forms.RadioButton rdbDoing;
        private System.Windows.Forms.RadioButton rdbDone;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblIs;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Button btnDoingEkle;
        private System.Windows.Forms.Button btnDoneEkle1;
        private System.Windows.Forms.Button btnDoneEkle2;
    }
}

