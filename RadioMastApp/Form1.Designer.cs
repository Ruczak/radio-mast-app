namespace RadioMastApp
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.mastBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mastBar2 = new System.Windows.Forms.TrackBar();
            this.heightLabel1 = new System.Windows.Forms.Label();
            this.heightLabel2 = new System.Windows.Forms.Label();
            this.freqBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.saveButton1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mastBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mastBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 425);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.saveButton1);
            this.tabPage1.Controls.Add(this.calcButton);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.freqBox);
            this.tabPage1.Controls.Add(this.heightLabel2);
            this.tabPage1.Controls.Add(this.heightLabel1);
            this.tabPage1.Controls.Add(this.mastBar2);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.mastBar1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(767, 399);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Obliczenia";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(767, 399);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mapa";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // mastBar1
            // 
            this.mastBar1.Location = new System.Drawing.Point(10, 34);
            this.mastBar1.Name = "mastBar1";
            this.mastBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.mastBar1.Size = new System.Drawing.Size(45, 104);
            this.mastBar1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Maszt 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Maszt 2";
            // 
            // mastBar2
            // 
            this.mastBar2.Location = new System.Drawing.Point(78, 34);
            this.mastBar2.Name = "mastBar2";
            this.mastBar2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.mastBar2.Size = new System.Drawing.Size(45, 104);
            this.mastBar2.TabIndex = 3;
            // 
            // heightLabel1
            // 
            this.heightLabel1.AutoSize = true;
            this.heightLabel1.Location = new System.Drawing.Point(7, 145);
            this.heightLabel1.Name = "heightLabel1";
            this.heightLabel1.Size = new System.Drawing.Size(24, 13);
            this.heightLabel1.TabIndex = 4;
            this.heightLabel1.Text = "0 m";
            // 
            // heightLabel2
            // 
            this.heightLabel2.AutoSize = true;
            this.heightLabel2.Location = new System.Drawing.Point(75, 145);
            this.heightLabel2.Name = "heightLabel2";
            this.heightLabel2.Size = new System.Drawing.Size(24, 13);
            this.heightLabel2.TabIndex = 5;
            this.heightLabel2.Text = "0 m";
            // 
            // freqBox
            // 
            this.freqBox.Location = new System.Drawing.Point(90, 180);
            this.freqBox.Name = "freqBox";
            this.freqBox.Size = new System.Drawing.Size(100, 20);
            this.freqBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Częstotliwość:";
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(10, 210);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 8;
            this.calcButton.Text = "Oblicz";
            this.calcButton.UseVisualStyleBackColor = true;
            // 
            // saveButton1
            // 
            this.saveButton1.Location = new System.Drawing.Point(92, 209);
            this.saveButton1.Name = "saveButton1";
            this.saveButton1.Size = new System.Drawing.Size(98, 23);
            this.saveButton1.TabIndex = 9;
            this.saveButton1.Text = "Zapisz do JSON";
            this.saveButton1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(209, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Wynik:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Zasięg Radiowy";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mastBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mastBar2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button saveButton1;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox freqBox;
        private System.Windows.Forms.Label heightLabel2;
        private System.Windows.Forms.Label heightLabel1;
        private System.Windows.Forms.TrackBar mastBar2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar mastBar1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
    }
}

