
namespace SmartMirror
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblGodzina = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblData = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGodzina
            // 
            this.lblGodzina.AutoSize = true;
            this.lblGodzina.BackColor = System.Drawing.Color.Transparent;
            this.lblGodzina.Font = new System.Drawing.Font("Segoe UI", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGodzina.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblGodzina.Location = new System.Drawing.Point(12, 9);
            this.lblGodzina.Name = "lblGodzina";
            this.lblGodzina.Size = new System.Drawing.Size(315, 142);
            this.lblGodzina.TabIndex = 0;
            this.lblGodzina.Text = "22:22";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.Transparent;
            this.lblData.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblData.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblData.Location = new System.Drawing.Point(34, 132);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(260, 45);
            this.lblData.TabIndex = 1;
            this.lblData.Text = "23 czerwiec 2021";
            // 
            // lblTemp
            // 
            this.lblTemp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTemp.AutoSize = true;
            this.lblTemp.BackColor = System.Drawing.Color.Transparent;
            this.lblTemp.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTemp.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTemp.Location = new System.Drawing.Point(1250, 40);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(109, 54);
            this.lblTemp.TabIndex = 2;
            this.lblTemp.Text = "15*C";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1382, 450);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblGodzina);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGodzina;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblTemp;
    }
}

