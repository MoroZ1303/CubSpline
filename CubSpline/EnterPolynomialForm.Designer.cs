﻿namespace WindowsFormsApp1
{
    partial class EnterPolynomialForm
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
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.xRangeBeginInput = new System.Windows.Forms.TextBox();
            this.xRangeEndInput = new System.Windows.Forms.TextBox();
            this.xRangeBeginLabel = new System.Windows.Forms.Label();
            this.xRangeEndLabel = new System.Windows.Forms.Label();
            this.xOffsetInput = new System.Windows.Forms.TextBox();
            this.xRangeOffsetLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.poverX,
            this.cofficient});
            this.dataGridView1.Location = new System.Drawing.Point(12, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(244, 413);
            this.dataGridView1.TabIndex = 0;
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
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(15, 470);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(108, 40);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(145, 470);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(108, 40);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // xRangeBeginInput
            // 
            this.xRangeBeginInput.Location = new System.Drawing.Point(15, 25);
            this.xRangeBeginInput.Name = "xRangeBeginInput";
            this.xRangeBeginInput.Size = new System.Drawing.Size(62, 20);
            this.xRangeBeginInput.TabIndex = 5;
            // 
            // xRangeEndInput
            // 
            this.xRangeEndInput.Location = new System.Drawing.Point(103, 25);
            this.xRangeEndInput.Name = "xRangeEndInput";
            this.xRangeEndInput.Size = new System.Drawing.Size(62, 20);
            this.xRangeEndInput.TabIndex = 6;
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
            this.xRangeEndLabel.Location = new System.Drawing.Point(100, 9);
            this.xRangeEndLabel.Name = "xRangeEndLabel";
            this.xRangeEndLabel.Size = new System.Drawing.Size(65, 13);
            this.xRangeEndLabel.TabIndex = 8;
            this.xRangeEndLabel.Text = "X range end";
            // 
            // xOffsetInput
            // 
            this.xOffsetInput.Location = new System.Drawing.Point(189, 25);
            this.xOffsetInput.Name = "xOffsetInput";
            this.xOffsetInput.Size = new System.Drawing.Size(62, 20);
            this.xOffsetInput.TabIndex = 6;
            // 
            // xRangeOffsetLabel
            // 
            this.xRangeOffsetLabel.AutoSize = true;
            this.xRangeOffsetLabel.Location = new System.Drawing.Point(186, 9);
            this.xRangeOffsetLabel.Name = "xRangeOffsetLabel";
            this.xRangeOffsetLabel.Size = new System.Drawing.Size(43, 13);
            this.xRangeOffsetLabel.TabIndex = 8;
            this.xRangeOffsetLabel.Text = "X offset";
            // 
            // EnterPolynomialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 522);
            this.Controls.Add(this.xRangeOffsetLabel);
            this.Controls.Add(this.xRangeEndLabel);
            this.Controls.Add(this.xOffsetInput);
            this.Controls.Add(this.xRangeBeginLabel);
            this.Controls.Add(this.xRangeEndInput);
            this.Controls.Add(this.xRangeBeginInput);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EnterPolynomialForm";
            this.Text = "Polynomial";
            this.Load += new System.EventHandler(this.EnterPolynomialForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cofficient;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox xRangeBeginInput;
        private System.Windows.Forms.TextBox xRangeEndInput;
        private System.Windows.Forms.Label xRangeBeginLabel;
        private System.Windows.Forms.Label xRangeEndLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn poverX;
        private System.Windows.Forms.TextBox xOffsetInput;
        private System.Windows.Forms.Label xRangeOffsetLabel;
    }
}