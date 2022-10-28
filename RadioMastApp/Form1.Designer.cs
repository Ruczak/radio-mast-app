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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.outcomeLabel1 = new System.Windows.Forms.Label();
            this.saveButton1 = new System.Windows.Forms.Button();
            this.calcButton1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.freqBox = new System.Windows.Forms.TextBox();
            this.heightLabel2 = new System.Windows.Forms.Label();
            this.heightLabel1 = new System.Windows.Forms.Label();
            this.mastBar2 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mastBar1 = new System.Windows.Forms.TrackBar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.calcButton2 = new System.Windows.Forms.Button();
            this.outcomeLabel2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.axMap = new AxMapWinGIS.AxMap();
            this.latBox = new System.Windows.Forms.TextBox();
            this.pointButton = new System.Windows.Forms.Button();
            this.saveButton2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lonBox = new System.Windows.Forms.TextBox();
            this.heightBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mastBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mastBar1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axMap)).BeginInit();
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
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.outcomeLabel1);
            this.tabPage1.Controls.Add(this.saveButton1);
            this.tabPage1.Controls.Add(this.calcButton1);
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
            this.tabPage1.Text = "Dwa maszty";
            // 
            // outcomeLabel1
            // 
            this.outcomeLabel1.Location = new System.Drawing.Point(252, 18);
            this.outcomeLabel1.Name = "outcomeLabel1";
            this.outcomeLabel1.Size = new System.Drawing.Size(195, 378);
            this.outcomeLabel1.TabIndex = 10;
            this.outcomeLabel1.Text = "Wynik:";
            // 
            // saveButton1
            // 
            this.saveButton1.Location = new System.Drawing.Point(92, 209);
            this.saveButton1.Name = "saveButton1";
            this.saveButton1.Size = new System.Drawing.Size(98, 23);
            this.saveButton1.TabIndex = 9;
            this.saveButton1.Text = "Zapisz do JSON";
            this.saveButton1.UseVisualStyleBackColor = true;
            this.saveButton1.Click += new System.EventHandler(this.saveButton1_Click);
            // 
            // calcButton1
            // 
            this.calcButton1.Location = new System.Drawing.Point(10, 210);
            this.calcButton1.Name = "calcButton1";
            this.calcButton1.Size = new System.Drawing.Size(75, 23);
            this.calcButton1.TabIndex = 8;
            this.calcButton1.Text = "Oblicz";
            this.calcButton1.UseVisualStyleBackColor = true;
            this.calcButton1.Click += new System.EventHandler(this.calcButton1_Click);
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
            // freqBox
            // 
            this.freqBox.Location = new System.Drawing.Point(90, 180);
            this.freqBox.Name = "freqBox";
            this.freqBox.Size = new System.Drawing.Size(100, 20);
            this.freqBox.TabIndex = 6;
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
            // heightLabel1
            // 
            this.heightLabel1.AutoSize = true;
            this.heightLabel1.Location = new System.Drawing.Point(7, 145);
            this.heightLabel1.Name = "heightLabel1";
            this.heightLabel1.Size = new System.Drawing.Size(24, 13);
            this.heightLabel1.TabIndex = 4;
            this.heightLabel1.Text = "0 m";
            // 
            // mastBar2
            // 
            this.mastBar2.Location = new System.Drawing.Point(78, 34);
            this.mastBar2.Maximum = 100;
            this.mastBar2.Name = "mastBar2";
            this.mastBar2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.mastBar2.Size = new System.Drawing.Size(45, 104);
            this.mastBar2.TabIndex = 3;
            this.mastBar2.Scroll += new System.EventHandler(this.mastBar2_Scroll);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Maszt 1";
            // 
            // mastBar1
            // 
            this.mastBar1.Location = new System.Drawing.Point(10, 34);
            this.mastBar1.Maximum = 100;
            this.mastBar1.Name = "mastBar1";
            this.mastBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.mastBar1.Size = new System.Drawing.Size(45, 104);
            this.mastBar1.TabIndex = 0;
            this.mastBar1.Scroll += new System.EventHandler(this.mastBar1_Scroll);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.calcButton2);
            this.tabPage2.Controls.Add(this.outcomeLabel2);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.axMap);
            this.tabPage2.Controls.Add(this.latBox);
            this.tabPage2.Controls.Add(this.pointButton);
            this.tabPage2.Controls.Add(this.saveButton2);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.lonBox);
            this.tabPage2.Controls.Add(this.heightBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(767, 399);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Jeden Maszt";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // calcButton2
            // 
            this.calcButton2.Location = new System.Drawing.Point(13, 84);
            this.calcButton2.Name = "calcButton2";
            this.calcButton2.Size = new System.Drawing.Size(103, 23);
            this.calcButton2.TabIndex = 14;
            this.calcButton2.Text = "Oblicz";
            this.calcButton2.UseVisualStyleBackColor = true;
            this.calcButton2.Click += new System.EventHandler(this.calcButton2_Click);
            // 
            // outcomeLabel2
            // 
            this.outcomeLabel2.Location = new System.Drawing.Point(10, 175);
            this.outcomeLabel2.Name = "outcomeLabel2";
            this.outcomeLabel2.Size = new System.Drawing.Size(163, 218);
            this.outcomeLabel2.TabIndex = 13;
            this.outcomeLabel2.Text = "Wynik:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(179, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "°";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(179, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "°";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(179, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "m";
            // 
            // axMap
            // 
            this.axMap.Enabled = true;
            this.axMap.Location = new System.Drawing.Point(210, 9);
            this.axMap.Name = "axMap";
            this.axMap.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMap.OcxState")));
            this.axMap.Size = new System.Drawing.Size(551, 384);
            this.axMap.TabIndex = 9;
            // 
            // latBox
            // 
            this.latBox.Location = new System.Drawing.Point(87, 32);
            this.latBox.Name = "latBox";
            this.latBox.Size = new System.Drawing.Size(86, 20);
            this.latBox.TabIndex = 8;
            // 
            // pointButton
            // 
            this.pointButton.Location = new System.Drawing.Point(13, 113);
            this.pointButton.Name = "pointButton";
            this.pointButton.Size = new System.Drawing.Size(103, 23);
            this.pointButton.TabIndex = 7;
            this.pointButton.Text = "Pokaż na mapie";
            this.pointButton.UseVisualStyleBackColor = true;
            this.pointButton.Click += new System.EventHandler(this.pointButton_Click);
            // 
            // saveButton2
            // 
            this.saveButton2.Location = new System.Drawing.Point(13, 142);
            this.saveButton2.Name = "saveButton2";
            this.saveButton2.Size = new System.Drawing.Size(103, 23);
            this.saveButton2.TabIndex = 6;
            this.saveButton2.Text = "Zapisz do JSON";
            this.saveButton2.UseVisualStyleBackColor = true;
            this.saveButton2.Click += new System.EventHandler(this.saveButton2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Współrzędne:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Wysokość: ";
            // 
            // lonBox
            // 
            this.lonBox.Location = new System.Drawing.Point(87, 58);
            this.lonBox.Name = "lonBox";
            this.lonBox.Size = new System.Drawing.Size(86, 20);
            this.lonBox.TabIndex = 1;
            // 
            // heightBox
            // 
            this.heightBox.Location = new System.Drawing.Point(76, 9);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(97, 20);
            this.heightBox.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(196, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Hz";
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
            ((System.ComponentModel.ISupportInitialize)(this.mastBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mastBar1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axMap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button saveButton1;
        private System.Windows.Forms.Button calcButton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox freqBox;
        private System.Windows.Forms.Label heightLabel2;
        private System.Windows.Forms.Label heightLabel1;
        private System.Windows.Forms.TrackBar mastBar2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar mastBar1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label outcomeLabel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lonBox;
        private System.Windows.Forms.TextBox heightBox;
        private System.Windows.Forms.Button saveButton2;
        private System.Windows.Forms.TextBox latBox;
        private System.Windows.Forms.Button pointButton;
        private AxMapWinGIS.AxMap axMap;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label outcomeLabel2;
        private System.Windows.Forms.Button calcButton2;
        private System.Windows.Forms.Label label9;
    }
}

