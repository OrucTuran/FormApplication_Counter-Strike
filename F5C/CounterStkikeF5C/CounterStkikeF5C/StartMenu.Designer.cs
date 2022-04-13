
namespace CounterStkikeF5C
{
    partial class StartMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartMenu));
            this.btn_baslik = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_baslik
            // 
            this.btn_baslik.BackColor = System.Drawing.Color.Transparent;
            this.btn_baslik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_baslik.FlatAppearance.BorderSize = 0;
            this.btn_baslik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_baslik.Font = new System.Drawing.Font("rayando", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_baslik.ForeColor = System.Drawing.Color.Black;
            this.btn_baslik.Location = new System.Drawing.Point(12, 3);
            this.btn_baslik.Name = "btn_baslik";
            this.btn_baslik.Size = new System.Drawing.Size(1130, 130);
            this.btn_baslik.TabIndex = 0;
            this.btn_baslik.Text = "COUNTER STRIKE";
            this.btn_baslik.UseVisualStyleBackColor = false;
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.Transparent;
            this.btn_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_start.FlatAppearance.BorderSize = 0;
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start.Font = new System.Drawing.Font("rayando", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.ForeColor = System.Drawing.Color.Black;
            this.btn_start.Location = new System.Drawing.Point(12, 396);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(181, 42);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "START";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_baslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "StartMenu";
            this.Text = "START MENU";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.StartMenu_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_baslik;
        private System.Windows.Forms.Button btn_start;
    }
}

