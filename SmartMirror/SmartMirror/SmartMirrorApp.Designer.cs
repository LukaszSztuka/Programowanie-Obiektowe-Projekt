
namespace SmartMirror
{
    partial class SmartMirrorApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SmartMirrorApp));
            this.zegarLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.dataLabel = new System.Windows.Forms.Label();
            this.pogodaTemp = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pogodaTemp2 = new System.Windows.Forms.Label();
            this.pogodaIcon = new System.Windows.Forms.PictureBox();
            this.pogodaIcon2 = new System.Windows.Forms.PictureBox();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.Etykietalabel = new System.Windows.Forms.Label();
            this.Eventlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pogodaIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pogodaIcon2)).BeginInit();
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
            // 
            // timer
            // 
            this.timer.Interval = 60000;
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
            this.pogodaTemp.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pogodaTemp.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.pogodaTemp.Location = new System.Drawing.Point(1120, 52);
            this.pogodaTemp.Name = "pogodaTemp";
            this.pogodaTemp.Size = new System.Drawing.Size(126, 62);
            this.pogodaTemp.TabIndex = 2;
            this.pogodaTemp.Text = "15*C";
            this.toolTip1.SetToolTip(this.pogodaTemp, "Aktualna odczuwalna temperatura");
            // 
            // pogodaTemp2
            // 
            this.pogodaTemp2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pogodaTemp2.AutoSize = true;
            this.pogodaTemp2.BackColor = System.Drawing.Color.Transparent;
            this.pogodaTemp2.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pogodaTemp2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.pogodaTemp2.Location = new System.Drawing.Point(1130, 132);
            this.pogodaTemp2.Name = "pogodaTemp2";
            this.pogodaTemp2.Size = new System.Drawing.Size(109, 54);
            this.pogodaTemp2.TabIndex = 4;
            this.pogodaTemp2.Text = "15*C";
            this.toolTip2.SetToolTip(this.pogodaTemp2, "Jutrzejsza odczuwalna temperatura");
            // 
            // pogodaIcon
            // 
            this.pogodaIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pogodaIcon.Image = global::SmartMirror.Properties.Resources.icon1;
            this.pogodaIcon.Location = new System.Drawing.Point(1022, 41);
            this.pogodaIcon.Name = "pogodaIcon";
            this.pogodaIcon.Size = new System.Drawing.Size(92, 86);
            this.pogodaIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pogodaIcon.TabIndex = 3;
            this.pogodaIcon.TabStop = false;
            // 
            // pogodaIcon2
            // 
            this.pogodaIcon2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pogodaIcon2.Image = global::SmartMirror.Properties.Resources.icon1;
            this.pogodaIcon2.Location = new System.Drawing.Point(1068, 133);
            this.pogodaIcon2.Name = "pogodaIcon2";
            this.pogodaIcon2.Size = new System.Drawing.Size(56, 53);
            this.pogodaIcon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pogodaIcon2.TabIndex = 5;
            this.pogodaIcon2.TabStop = false;
            // 
            // Etykietalabel
            // 
            this.Etykietalabel.AutoSize = true;
            this.Etykietalabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Etykietalabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Etykietalabel.Location = new System.Drawing.Point(35, 200);
            this.Etykietalabel.Name = "Etykietalabel";
            this.Etykietalabel.Size = new System.Drawing.Size(259, 30);
            this.Etykietalabel.TabIndex = 6;
            this.Etykietalabel.Text = "Nadchodzące wydarzenia";
            // 
            // Eventlabel
            // 
            this.Eventlabel.AutoSize = true;
            this.Eventlabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Eventlabel.Location = new System.Drawing.Point(35, 239);
            this.Eventlabel.Name = "Eventlabel";
            this.Eventlabel.Size = new System.Drawing.Size(71, 30);
            this.Eventlabel.TabIndex = 7;
            this.Eventlabel.Text = "label2";
            // 
            // SmartMirrorApp
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1262, 616);
            this.Controls.Add(this.Eventlabel);
            this.Controls.Add(this.Etykietalabel);
            this.Controls.Add(this.pogodaIcon2);
            this.Controls.Add(this.pogodaTemp2);
            this.Controls.Add(this.pogodaIcon);
            this.Controls.Add(this.pogodaTemp);
            this.Controls.Add(this.dataLabel);
            this.Controls.Add(this.zegarLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SmartMirrorApp";
            this.Text = "Nadchodzące wydarzenia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pogodaIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pogodaIcon2)).EndInit();
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
        private System.Windows.Forms.Label pogodaTemp2;
        private System.Windows.Forms.PictureBox pogodaIcon2;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Label Etykietalabel;
        private System.Windows.Forms.Label Eventlabel;
    }
}

