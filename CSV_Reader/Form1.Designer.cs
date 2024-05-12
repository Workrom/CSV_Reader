namespace CSV_Reader
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
            this.ReadPage = new System.Windows.Forms.TabPage();
            this.Readbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.WritePage = new System.Windows.Forms.TabPage();
            this.ClearAllbtn = new System.Windows.Forms.Button();
            this.Loadbtn = new System.Windows.Forms.Button();
            this.Writebtn = new System.Windows.Forms.Button();
            this.Write_PRbool = new System.Windows.Forms.ComboBox();
            this.Write_Programmerlbl = new System.Windows.Forms.Label();
            this.WRite_AgeNum = new System.Windows.Forms.NumericUpDown();
            this.Write_Agelbl = new System.Windows.Forms.Label();
            this.Write_Nametxb = new System.Windows.Forms.TextBox();
            this.Write_Namelbl = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.ReadPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.WritePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WRite_AgeNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ReadPage);
            this.tabControl1.Controls.Add(this.WritePage);
            this.tabControl1.Location = new System.Drawing.Point(18, 18);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(944, 455);
            this.tabControl1.TabIndex = 0;
            // 
            // ReadPage
            // 
            this.ReadPage.Controls.Add(this.Readbtn);
            this.ReadPage.Controls.Add(this.dataGridView1);
            this.ReadPage.Location = new System.Drawing.Point(4, 29);
            this.ReadPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ReadPage.Name = "ReadPage";
            this.ReadPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ReadPage.Size = new System.Drawing.Size(936, 422);
            this.ReadPage.TabIndex = 0;
            this.ReadPage.Text = "Read";
            this.ReadPage.UseVisualStyleBackColor = true;
            // 
            // Readbtn
            // 
            this.Readbtn.Location = new System.Drawing.Point(153, 352);
            this.Readbtn.Name = "Readbtn";
            this.Readbtn.Size = new System.Drawing.Size(125, 62);
            this.Readbtn.TabIndex = 1;
            this.Readbtn.Text = "Read";
            this.Readbtn.UseVisualStyleBackColor = true;
            this.Readbtn.Click += new System.EventHandler(this.Readbtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(455, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(474, 406);
            this.dataGridView1.TabIndex = 0;
            // 
            // WritePage
            // 
            this.WritePage.Controls.Add(this.ClearAllbtn);
            this.WritePage.Controls.Add(this.Loadbtn);
            this.WritePage.Controls.Add(this.Writebtn);
            this.WritePage.Controls.Add(this.Write_PRbool);
            this.WritePage.Controls.Add(this.Write_Programmerlbl);
            this.WritePage.Controls.Add(this.WRite_AgeNum);
            this.WritePage.Controls.Add(this.Write_Agelbl);
            this.WritePage.Controls.Add(this.Write_Nametxb);
            this.WritePage.Controls.Add(this.Write_Namelbl);
            this.WritePage.Controls.Add(this.dataGridView2);
            this.WritePage.Location = new System.Drawing.Point(4, 29);
            this.WritePage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.WritePage.Name = "WritePage";
            this.WritePage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.WritePage.Size = new System.Drawing.Size(936, 422);
            this.WritePage.TabIndex = 1;
            this.WritePage.Text = "Write";
            this.WritePage.UseVisualStyleBackColor = true;
            // 
            // ClearAllbtn
            // 
            this.ClearAllbtn.Location = new System.Drawing.Point(124, 387);
            this.ClearAllbtn.Name = "ClearAllbtn";
            this.ClearAllbtn.Size = new System.Drawing.Size(135, 27);
            this.ClearAllbtn.TabIndex = 11;
            this.ClearAllbtn.Text = "ClearAll";
            this.ClearAllbtn.UseVisualStyleBackColor = true;
            this.ClearAllbtn.Click += new System.EventHandler(this.ClearAllbtn_Click);
            // 
            // Loadbtn
            // 
            this.Loadbtn.Location = new System.Drawing.Point(124, 321);
            this.Loadbtn.Name = "Loadbtn";
            this.Loadbtn.Size = new System.Drawing.Size(135, 27);
            this.Loadbtn.TabIndex = 10;
            this.Loadbtn.Text = "Load";
            this.Loadbtn.UseVisualStyleBackColor = true;
            this.Loadbtn.Click += new System.EventHandler(this.Loadbtn_Click);
            // 
            // Writebtn
            // 
            this.Writebtn.Location = new System.Drawing.Point(124, 354);
            this.Writebtn.Name = "Writebtn";
            this.Writebtn.Size = new System.Drawing.Size(135, 27);
            this.Writebtn.TabIndex = 9;
            this.Writebtn.Text = "Write";
            this.Writebtn.UseVisualStyleBackColor = true;
            this.Writebtn.Click += new System.EventHandler(this.Writebtn_Click);
            // 
            // Write_PRbool
            // 
            this.Write_PRbool.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Write_PRbool.FormattingEnabled = true;
            this.Write_PRbool.Location = new System.Drawing.Point(17, 231);
            this.Write_PRbool.Name = "Write_PRbool";
            this.Write_PRbool.Size = new System.Drawing.Size(100, 28);
            this.Write_PRbool.TabIndex = 8;
            // 
            // Write_Programmerlbl
            // 
            this.Write_Programmerlbl.AutoSize = true;
            this.Write_Programmerlbl.Location = new System.Drawing.Point(21, 208);
            this.Write_Programmerlbl.Name = "Write_Programmerlbl";
            this.Write_Programmerlbl.Size = new System.Drawing.Size(96, 20);
            this.Write_Programmerlbl.TabIndex = 7;
            this.Write_Programmerlbl.Text = "Programmer";
            // 
            // WRite_AgeNum
            // 
            this.WRite_AgeNum.Location = new System.Drawing.Point(17, 142);
            this.WRite_AgeNum.Name = "WRite_AgeNum";
            this.WRite_AgeNum.Size = new System.Drawing.Size(100, 26);
            this.WRite_AgeNum.TabIndex = 6;
            this.WRite_AgeNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Write_Agelbl
            // 
            this.Write_Agelbl.AutoSize = true;
            this.Write_Agelbl.Location = new System.Drawing.Point(38, 119);
            this.Write_Agelbl.Name = "Write_Agelbl";
            this.Write_Agelbl.Size = new System.Drawing.Size(38, 20);
            this.Write_Agelbl.TabIndex = 4;
            this.Write_Agelbl.Text = "Age";
            // 
            // Write_Nametxb
            // 
            this.Write_Nametxb.Location = new System.Drawing.Point(17, 58);
            this.Write_Nametxb.Name = "Write_Nametxb";
            this.Write_Nametxb.Size = new System.Drawing.Size(100, 26);
            this.Write_Nametxb.TabIndex = 3;
            // 
            // Write_Namelbl
            // 
            this.Write_Namelbl.AutoSize = true;
            this.Write_Namelbl.Location = new System.Drawing.Point(38, 35);
            this.Write_Namelbl.Name = "Write_Namelbl";
            this.Write_Namelbl.Size = new System.Drawing.Size(51, 20);
            this.Write_Namelbl.TabIndex = 2;
            this.Write_Namelbl.Text = "Name";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(455, 8);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(474, 406);
            this.dataGridView2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 491);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.ReadPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.WritePage.ResumeLayout(false);
            this.WritePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WRite_AgeNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ReadPage;
        private System.Windows.Forms.TabPage WritePage;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button ClearAllbtn;
        private System.Windows.Forms.Button Loadbtn;
        private System.Windows.Forms.Button Writebtn;
        private System.Windows.Forms.ComboBox Write_PRbool;
        private System.Windows.Forms.Label Write_Programmerlbl;
        private System.Windows.Forms.NumericUpDown WRite_AgeNum;
        private System.Windows.Forms.Label Write_Agelbl;
        private System.Windows.Forms.TextBox Write_Nametxb;
        private System.Windows.Forms.Label Write_Namelbl;
        private System.Windows.Forms.Button Readbtn;
    }
}

