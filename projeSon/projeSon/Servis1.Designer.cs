namespace projeSon
{
    partial class Servis1
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.servisCBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.oranL = new System.Windows.Forms.Label();
            this.dolulukL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "YATAN HASTALARIN BİLGİLERİ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(361, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(894, 226);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // servisCBox
            // 
            this.servisCBox.FormattingEnabled = true;
            this.servisCBox.Location = new System.Drawing.Point(123, 108);
            this.servisCBox.Margin = new System.Windows.Forms.Padding(4);
            this.servisCBox.Name = "servisCBox";
            this.servisCBox.Size = new System.Drawing.Size(160, 24);
            this.servisCBox.TabIndex = 5;
            this.servisCBox.SelectedIndexChanged += new System.EventHandler(this.ServisCBox_SelectedIndexChanged_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.oranL);
            this.groupBox1.Controls.Add(this.dolulukL);
            this.groupBox1.Location = new System.Drawing.Point(123, 141);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(160, 316);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Servis Bilgiler";
            // 
            // oranL
            // 
            this.oranL.AutoSize = true;
            this.oranL.Location = new System.Drawing.Point(8, 272);
            this.oranL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.oranL.Name = "oranL";
            this.oranL.Size = new System.Drawing.Size(26, 17);
            this.oranL.TabIndex = 1;
            this.oranL.Text = "x%";
            // 
            // dolulukL
            // 
            this.dolulukL.AutoSize = true;
            this.dolulukL.Location = new System.Drawing.Point(8, 256);
            this.dolulukL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dolulukL.Name = "dolulukL";
            this.dolulukL.Size = new System.Drawing.Size(94, 17);
            this.dolulukL.TabIndex = 0;
            this.dolulukL.Text = "Doluluk Oranı";
            this.dolulukL.Click += new System.EventHandler(this.DolulukL_Click);
            // 
            // Servis1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 565);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.servisCBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Servis1";
            this.Text = "Servis1";
            this.Load += new System.EventHandler(this.Servis1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox servisCBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label oranL;
        private System.Windows.Forms.Label dolulukL;
    }
}