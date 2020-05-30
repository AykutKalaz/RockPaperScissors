namespace RockPaperScissors
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
            this.pctBen = new System.Windows.Forms.PictureBox();
            this.pctBilgisayar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSec = new System.Windows.Forms.ComboBox();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.btnGoster = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctBen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBilgisayar)).BeginInit();
            this.SuspendLayout();
            // 
            // pctBen
            // 
            this.pctBen.Location = new System.Drawing.Point(26, 37);
            this.pctBen.Name = "pctBen";
            this.pctBen.Size = new System.Drawing.Size(185, 220);
            this.pctBen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBen.TabIndex = 0;
            this.pctBen.TabStop = false;
            // 
            // pctBilgisayar
            // 
            this.pctBilgisayar.Location = new System.Drawing.Point(251, 37);
            this.pctBilgisayar.Name = "pctBilgisayar";
            this.pctBilgisayar.Size = new System.Drawing.Size(185, 220);
            this.pctBilgisayar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBilgisayar.TabIndex = 1;
            this.pctBilgisayar.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(92, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(296, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bilgisayar";
            // 
            // cmbSec
            // 
            this.cmbSec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSec.FormattingEnabled = true;
            this.cmbSec.Items.AddRange(new object[] {
            "Taş",
            "Kağıt",
            "Makas"});
            this.cmbSec.Location = new System.Drawing.Point(26, 263);
            this.cmbSec.Name = "cmbSec";
            this.cmbSec.Size = new System.Drawing.Size(185, 21);
            this.cmbSec.TabIndex = 4;
            this.cmbSec.SelectedIndexChanged += new System.EventHandler(this.cmbSec_SelectedIndexChanged);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.Location = new System.Drawing.Point(170, 325);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(0, 25);
            this.lblSonuc.TabIndex = 5;
            // 
            // btnGoster
            // 
            this.btnGoster.Location = new System.Drawing.Point(136, 290);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(75, 23);
            this.btnGoster.TabIndex = 6;
            this.btnGoster.Text = "Göster";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 370);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.cmbSec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pctBilgisayar);
            this.Controls.Add(this.pctBen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctBen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBilgisayar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctBen;
        private System.Windows.Forms.PictureBox pctBilgisayar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSec;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Button btnGoster;
    }
}

