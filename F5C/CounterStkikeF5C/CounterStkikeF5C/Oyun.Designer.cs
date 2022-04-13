
namespace CounterStkikeF5C
{
    partial class Oyun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Oyun));
            this.btn_atesEt = new System.Windows.Forms.Button();
            this.btn_doldur = new System.Windows.Forms.Button();
            this.pictureBox_silah = new System.Windows.Forms.PictureBox();
            this.progressBar_mermi = new System.Windows.Forms.ProgressBar();
            this.label_silahAd_SilahMermi = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_silah)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_atesEt
            // 
            this.btn_atesEt.BackColor = System.Drawing.Color.Transparent;
            this.btn_atesEt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_atesEt.FlatAppearance.BorderSize = 0;
            this.btn_atesEt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_atesEt.Font = new System.Drawing.Font("rayando", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atesEt.ForeColor = System.Drawing.Color.Black;
            this.btn_atesEt.Location = new System.Drawing.Point(34, 490);
            this.btn_atesEt.Name = "btn_atesEt";
            this.btn_atesEt.Size = new System.Drawing.Size(300, 42);
            this.btn_atesEt.TabIndex = 2;
            this.btn_atesEt.Text = "FIRE";
            this.btn_atesEt.UseVisualStyleBackColor = false;
            this.btn_atesEt.Click += new System.EventHandler(this.btn_atesEt_Click);
            // 
            // btn_doldur
            // 
            this.btn_doldur.BackColor = System.Drawing.Color.Transparent;
            this.btn_doldur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_doldur.FlatAppearance.BorderSize = 0;
            this.btn_doldur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_doldur.Font = new System.Drawing.Font("rayando", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_doldur.ForeColor = System.Drawing.Color.Black;
            this.btn_doldur.Location = new System.Drawing.Point(487, 490);
            this.btn_doldur.Name = "btn_doldur";
            this.btn_doldur.Size = new System.Drawing.Size(300, 42);
            this.btn_doldur.TabIndex = 3;
            this.btn_doldur.Text = "RELOAD";
            this.btn_doldur.UseVisualStyleBackColor = false;
            this.btn_doldur.Click += new System.EventHandler(this.btn_doldur_Click);
            // 
            // pictureBox_silah
            // 
            this.pictureBox_silah.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_silah.Location = new System.Drawing.Point(34, 12);
            this.pictureBox_silah.Name = "pictureBox_silah";
            this.pictureBox_silah.Size = new System.Drawing.Size(753, 421);
            this.pictureBox_silah.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_silah.TabIndex = 4;
            this.pictureBox_silah.TabStop = false;
            // 
            // progressBar_mermi
            // 
            this.progressBar_mermi.Location = new System.Drawing.Point(549, 570);
            this.progressBar_mermi.Name = "progressBar_mermi";
            this.progressBar_mermi.Size = new System.Drawing.Size(247, 23);
            this.progressBar_mermi.TabIndex = 5;
            this.progressBar_mermi.Value = 100;
            // 
            // label_silahAd_SilahMermi
            // 
            this.label_silahAd_SilahMermi.AutoSize = true;
            this.label_silahAd_SilahMermi.Location = new System.Drawing.Point(444, 576);
            this.label_silahAd_SilahMermi.Name = "label_silahAd_SilahMermi";
            this.label_silahAd_SilahMermi.Size = new System.Drawing.Size(0, 17);
            this.label_silahAd_SilahMermi.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(802, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1200, 666);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // Oyun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1711, 724);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label_silahAd_SilahMermi);
            this.Controls.Add(this.progressBar_mermi);
            this.Controls.Add(this.pictureBox_silah);
            this.Controls.Add(this.btn_doldur);
            this.Controls.Add(this.btn_atesEt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "Oyun";
            this.Text = "Oyun";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Oyun_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_silah)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_atesEt;
        private System.Windows.Forms.Button btn_doldur;
        private System.Windows.Forms.PictureBox pictureBox_silah;
        private System.Windows.Forms.ProgressBar progressBar_mermi;
        private System.Windows.Forms.Label label_silahAd_SilahMermi;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}