namespace WindowsFormsApp1
{
    partial class Polynomial
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.poverX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cofficient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ok = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.xRangeBegin = new System.Windows.Forms.TextBox();
            this.xRangeEnd = new System.Windows.Forms.TextBox();
            this.xRangeBeginLabel = new System.Windows.Forms.Label();
            this.xRangeEndLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.poverX,
            this.cofficient});
            this.dataGridView1.Location = new System.Drawing.Point(12, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(244, 381);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // poverX
            // 
            this.poverX.HeaderText = "power of x ";
            this.poverX.Name = "poverX";
            // 
            // cofficient
            // 
            this.cofficient.HeaderText = "cofficient";
            this.cofficient.Name = "cofficient";
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(15, 470);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(108, 40);
            this.ok.TabIndex = 4;
            this.ok.Text = "Ok";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(145, 470);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(108, 40);
            this.cancel.TabIndex = 3;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // xRangeBegin
            // 
            this.xRangeBegin.Location = new System.Drawing.Point(15, 25);
            this.xRangeBegin.Name = "xRangeBegin";
            this.xRangeBegin.Size = new System.Drawing.Size(111, 20);
            this.xRangeBegin.TabIndex = 5;
            // 
            // xRangeEnd
            // 
            this.xRangeEnd.Location = new System.Drawing.Point(142, 25);
            this.xRangeEnd.Name = "xRangeEnd";
            this.xRangeEnd.Size = new System.Drawing.Size(111, 20);
            this.xRangeEnd.TabIndex = 6;
            // 
            // xRangeBeginLabel
            // 
            this.xRangeBeginLabel.AutoSize = true;
            this.xRangeBeginLabel.Location = new System.Drawing.Point(12, 9);
            this.xRangeBeginLabel.Name = "xRangeBeginLabel";
            this.xRangeBeginLabel.Size = new System.Drawing.Size(73, 13);
            this.xRangeBeginLabel.TabIndex = 7;
            this.xRangeBeginLabel.Text = "X range begin";
            // 
            // xRangeEndLabel
            // 
            this.xRangeEndLabel.AutoSize = true;
            this.xRangeEndLabel.Location = new System.Drawing.Point(139, 9);
            this.xRangeEndLabel.Name = "xRangeEndLabel";
            this.xRangeEndLabel.Size = new System.Drawing.Size(65, 13);
            this.xRangeEndLabel.TabIndex = 8;
            this.xRangeEndLabel.Text = "X range end";
            // 
            // Polynomial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 522);
            this.Controls.Add(this.xRangeEndLabel);
            this.Controls.Add(this.xRangeBeginLabel);
            this.Controls.Add(this.xRangeEnd);
            this.Controls.Add(this.xRangeBegin);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Polynomial";
            this.Text = "Polynomial";
            this.Load += new System.EventHandler(this.Polinome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn poverX;
        private System.Windows.Forms.DataGridViewTextBoxColumn cofficient;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.TextBox xRangeBegin;
        private System.Windows.Forms.TextBox xRangeEnd;
        private System.Windows.Forms.Label xRangeBeginLabel;
        private System.Windows.Forms.Label xRangeEndLabel;
    }
}