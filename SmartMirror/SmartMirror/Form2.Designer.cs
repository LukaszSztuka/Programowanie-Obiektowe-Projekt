
namespace SmartMirror
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.miastoTextBox = new System.Windows.Forms.TextBox();
            this.zatwierdzButton = new System.Windows.Forms.Button();
            this.pogodaCheckBox = new System.Windows.Forms.CheckBox();
            this.zegarCheckBox = new System.Windows.Forms.CheckBox();
            this.dataCheckBox = new System.Windows.Forms.CheckBox();
            this.pogodaProgCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Podaj nazwę miasta:";
            // 
            // miastoTextBox
            // 
            this.miastoTextBox.Location = new System.Drawing.Point(44, 60);
            this.miastoTextBox.Name = "miastoTextBox";
            this.miastoTextBox.Size = new System.Drawing.Size(113, 23);
            this.miastoTextBox.TabIndex = 1;
            this.miastoTextBox.TextChanged += new System.EventHandler(this.miastoTextBox_TextChanged);
            // 
            // zatwierdzButton
            // 
            this.zatwierdzButton.Enabled = false;
            this.zatwierdzButton.Location = new System.Drawing.Point(45, 104);
            this.zatwierdzButton.Name = "zatwierdzButton";
            this.zatwierdzButton.Size = new System.Drawing.Size(113, 28);
            this.zatwierdzButton.TabIndex = 2;
            this.zatwierdzButton.Text = "Zatwierdź";
            this.zatwierdzButton.UseVisualStyleBackColor = true;
            this.zatwierdzButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // pogodaCheckBox
            // 
            this.pogodaCheckBox.AutoSize = true;
            this.pogodaCheckBox.Checked = true;
            this.pogodaCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pogodaCheckBox.Location = new System.Drawing.Point(201, 29);
            this.pogodaCheckBox.Name = "pogodaCheckBox";
            this.pogodaCheckBox.Size = new System.Drawing.Size(67, 19);
            this.pogodaCheckBox.TabIndex = 3;
            this.pogodaCheckBox.Text = "Pogoda";
            this.pogodaCheckBox.UseVisualStyleBackColor = true;
            // 
            // zegarCheckBox
            // 
            this.zegarCheckBox.AutoSize = true;
            this.zegarCheckBox.Checked = true;
            this.zegarCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.zegarCheckBox.Location = new System.Drawing.Point(201, 79);
            this.zegarCheckBox.Name = "zegarCheckBox";
            this.zegarCheckBox.Size = new System.Drawing.Size(56, 19);
            this.zegarCheckBox.TabIndex = 4;
            this.zegarCheckBox.Text = "Zegar";
            this.zegarCheckBox.UseVisualStyleBackColor = true;
            // 
            // dataCheckBox
            // 
            this.dataCheckBox.AutoSize = true;
            this.dataCheckBox.Checked = true;
            this.dataCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dataCheckBox.Location = new System.Drawing.Point(201, 104);
            this.dataCheckBox.Name = "dataCheckBox";
            this.dataCheckBox.Size = new System.Drawing.Size(50, 19);
            this.dataCheckBox.TabIndex = 5;
            this.dataCheckBox.Text = "Data";
            this.dataCheckBox.UseVisualStyleBackColor = true;
            // 
            // pogodaProgCheckBox
            // 
            this.pogodaProgCheckBox.AutoSize = true;
            this.pogodaProgCheckBox.Checked = true;
            this.pogodaProgCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pogodaProgCheckBox.Location = new System.Drawing.Point(201, 54);
            this.pogodaProgCheckBox.Name = "pogodaProgCheckBox";
            this.pogodaProgCheckBox.Size = new System.Drawing.Size(120, 19);
            this.pogodaProgCheckBox.TabIndex = 6;
            this.pogodaProgCheckBox.Text = "Pogoda prognoza";
            this.pogodaProgCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AcceptButton = this.zatwierdzButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(341, 166);
            this.Controls.Add(this.pogodaProgCheckBox);
            this.Controls.Add(this.dataCheckBox);
            this.Controls.Add(this.zegarCheckBox);
            this.Controls.Add(this.pogodaCheckBox);
            this.Controls.Add(this.zatwierdzButton);
            this.Controls.Add(this.miastoTextBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Miasto";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox miastoTextBox;
        private System.Windows.Forms.Button zatwierdzButton;
        private System.Windows.Forms.CheckBox zegarCheckBox;
        private System.Windows.Forms.CheckBox dataCheckBox;
        public System.Windows.Forms.CheckBox pogodaCheckBox;
        public System.Windows.Forms.CheckBox pogodaProgCheckBox;
    }
}