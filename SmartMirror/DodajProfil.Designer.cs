
namespace SmartMirror
{
    partial class DodajProfil
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
            this.nazwaTextBox = new System.Windows.Forms.TextBox();
            this.pogodaProgCheckBox = new System.Windows.Forms.CheckBox();
            this.dataCheckBox = new System.Windows.Forms.CheckBox();
            this.zegarCheckBox = new System.Windows.Forms.CheckBox();
            this.pogodaCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dodajButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tokenButton = new System.Windows.Forms.Button();
            this.kalendarzCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // nazwaTextBox
            // 
            this.nazwaTextBox.Location = new System.Drawing.Point(74, 45);
            this.nazwaTextBox.Name = "nazwaTextBox";
            this.nazwaTextBox.Size = new System.Drawing.Size(100, 23);
            this.nazwaTextBox.TabIndex = 0;
            this.nazwaTextBox.TextChanged += new System.EventHandler(this.nazwaTextBoxChanged);
            // 
            // pogodaProgCheckBox
            // 
            this.pogodaProgCheckBox.AutoSize = true;
            this.pogodaProgCheckBox.Checked = true;
            this.pogodaProgCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pogodaProgCheckBox.Location = new System.Drawing.Point(242, 52);
            this.pogodaProgCheckBox.Name = "pogodaProgCheckBox";
            this.pogodaProgCheckBox.Size = new System.Drawing.Size(120, 19);
            this.pogodaProgCheckBox.TabIndex = 10;
            this.pogodaProgCheckBox.Text = "Pogoda prognoza";
            this.pogodaProgCheckBox.UseVisualStyleBackColor = true;
            // 
            // dataCheckBox
            // 
            this.dataCheckBox.AutoSize = true;
            this.dataCheckBox.Checked = true;
            this.dataCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dataCheckBox.Location = new System.Drawing.Point(242, 102);
            this.dataCheckBox.Name = "dataCheckBox";
            this.dataCheckBox.Size = new System.Drawing.Size(50, 19);
            this.dataCheckBox.TabIndex = 9;
            this.dataCheckBox.Text = "Data";
            this.dataCheckBox.UseVisualStyleBackColor = true;
            // 
            // zegarCheckBox
            // 
            this.zegarCheckBox.AutoSize = true;
            this.zegarCheckBox.Checked = true;
            this.zegarCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.zegarCheckBox.Location = new System.Drawing.Point(242, 77);
            this.zegarCheckBox.Name = "zegarCheckBox";
            this.zegarCheckBox.Size = new System.Drawing.Size(56, 19);
            this.zegarCheckBox.TabIndex = 8;
            this.zegarCheckBox.Text = "Zegar";
            this.zegarCheckBox.UseVisualStyleBackColor = true;
            // 
            // pogodaCheckBox
            // 
            this.pogodaCheckBox.AutoSize = true;
            this.pogodaCheckBox.Checked = true;
            this.pogodaCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pogodaCheckBox.Location = new System.Drawing.Point(242, 27);
            this.pogodaCheckBox.Name = "pogodaCheckBox";
            this.pogodaCheckBox.Size = new System.Drawing.Size(67, 19);
            this.pogodaCheckBox.TabIndex = 7;
            this.pogodaCheckBox.Text = "Pogoda";
            this.pogodaCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nazwa";
            // 
            // dodajButton
            // 
            this.dodajButton.Enabled = false;
            this.dodajButton.Location = new System.Drawing.Point(164, 212);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(100, 23);
            this.dodajButton.TabIndex = 13;
            this.dodajButton.Text = "Dodaj";
            this.dodajButton.UseVisualStyleBackColor = true;
            this.dodajButton.Click += new System.EventHandler(this.dodajButtonClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 14;
            // 
            // tokenButton
            // 
            this.tokenButton.Location = new System.Drawing.Point(74, 143);
            this.tokenButton.Name = "tokenButton";
            this.tokenButton.Size = new System.Drawing.Size(100, 23);
            this.tokenButton.TabIndex = 15;
            this.tokenButton.Text = "Dodaj Token";
            this.tokenButton.UseVisualStyleBackColor = true;
            this.tokenButton.Click += new System.EventHandler(this.dodajTokenClick);
            // 
            // kalendarzCheckBox
            // 
            this.kalendarzCheckBox.AutoSize = true;
            this.kalendarzCheckBox.Checked = true;
            this.kalendarzCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.kalendarzCheckBox.Location = new System.Drawing.Point(242, 127);
            this.kalendarzCheckBox.Name = "kalendarzCheckBox";
            this.kalendarzCheckBox.Size = new System.Drawing.Size(87, 19);
            this.kalendarzCheckBox.TabIndex = 16;
            this.kalendarzCheckBox.Text = "Wydarzenia";
            this.kalendarzCheckBox.UseVisualStyleBackColor = true;
            // 
            // DodajProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 259);
            this.Controls.Add(this.kalendarzCheckBox);
            this.Controls.Add(this.tokenButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dodajButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pogodaProgCheckBox);
            this.Controls.Add(this.dataCheckBox);
            this.Controls.Add(this.zegarCheckBox);
            this.Controls.Add(this.pogodaCheckBox);
            this.Controls.Add(this.nazwaTextBox);
            this.Name = "DodajProfil";
            this.Text = "DodajProfil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nazwaTextBox;
        public System.Windows.Forms.CheckBox pogodaProgCheckBox;
        private System.Windows.Forms.CheckBox dataCheckBox;
        private System.Windows.Forms.CheckBox zegarCheckBox;
        public System.Windows.Forms.CheckBox pogodaCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dodajButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button tokenButton;
        private System.Windows.Forms.CheckBox kalendarzCheckBox;
    }
}