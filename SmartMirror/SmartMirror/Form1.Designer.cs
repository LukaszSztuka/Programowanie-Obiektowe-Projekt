
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
            this.zegarLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.dataLabel = new System.Windows.Forms.Label();
            this.pogodaTemp = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pogodaIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pogodaIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // zegarLabel
            // 
            this.zegarLabel.AutoSize = true;
            this.zegarLabel.BackColor = System.Drawing.Color.Transparent;
            this.zegarLabel.Font = new System.Drawing.Font("Segoe UI", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.zegarLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.zegarLabel.Location = new System.Drawing.Point(12, 9);
            this.zegarLabel.Name = "zegarLabel";
            this.zegarLabel.Size = new System.Drawing.Size(315, 142);
            this.zegarLabel.TabIndex = 0;
            this.zegarLabel.Text = "22:22";
            this.zegarLabel.Click += new System.EventHandler(this.czasLabel_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // dataLabel
            // 
            this.dataLabel.AutoSize = true;
            this.dataLabel.BackColor = System.Drawing.Color.Transparent;
            this.dataLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.dataLabel.Location = new System.Drawing.Point(34, 132);
            this.dataLabel.Name = "dataLabel";
            this.dataLabel.Size = new System.Drawing.Size(260, 45);
            this.dataLabel.TabIndex = 1;
            this.dataLabel.Text = "23 czerwiec 2021";
            // 
            // pogodaTemp
            // 
            this.pogodaTemp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pogodaTemp.AutoSize = true;
            this.pogodaTemp.BackColor = System.Drawing.Color.Transparent;
            this.pogodaTemp.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pogodaTemp.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.pogodaTemp.Location = new System.Drawing.Point(1130, 40);
            this.pogodaTemp.Name = "pogodaTemp";
            this.pogodaTemp.Size = new System.Drawing.Size(109, 54);
            this.pogodaTemp.TabIndex = 2;
            this.pogodaTemp.Text = "15*C";
            this.toolTip1.SetToolTip(this.pogodaTemp, "Aktualna odczuwalna temperatura");
            // 
            // pogodaIcon
            // 
            this.pogodaIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pogodaIcon.Image = global::SmartMirror.Properties.Resources.icon1;
            this.pogodaIcon.Location = new System.Drawing.Point(1146, 97);
            this.pogodaIcon.Name = "pogodaIcon";
            this.pogodaIcon.Size = new System.Drawing.Size(83, 80);
            this.pogodaIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pogodaIcon.TabIndex = 3;
            this.pogodaIcon.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1262, 616);
            this.Controls.Add(this.pogodaIcon);
            this.Controls.Add(this.pogodaTemp);
            this.Controls.Add(this.dataLabel);
            this.Controls.Add(this.zegarLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pogodaIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Label zegarLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label dataLabel;
        private System.Windows.Forms.Label pogodaTemp;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pogodaIcon;
    }
}

