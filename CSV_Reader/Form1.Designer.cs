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
            this.WritePage = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.ReadPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // WritePage
            // 
            this.WritePage.Location = new System.Drawing.Point(4, 29);
            this.WritePage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.WritePage.Name = "WritePage";
            this.WritePage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.WritePage.Size = new System.Drawing.Size(936, 422);
            this.WritePage.TabIndex = 1;
            this.WritePage.Text = "Write";
            this.WritePage.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(455, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(474, 406);
            this.dataGridView1.TabIndex = 0;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ReadPage;
        private System.Windows.Forms.TabPage WritePage;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

