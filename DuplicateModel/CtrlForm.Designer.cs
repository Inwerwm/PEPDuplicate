namespace DuplicateModel
{
    partial class CtrlForm
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
            this.labelDupNum = new System.Windows.Forms.Label();
            this.numericDupNum = new System.Windows.Forms.NumericUpDown();
            this.labelInterval = new System.Windows.Forms.Label();
            this.numericInterval = new System.Windows.Forms.NumericUpDown();
            this.buttonRun = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericDupNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDupNum
            // 
            this.labelDupNum.AutoSize = true;
            this.labelDupNum.Location = new System.Drawing.Point(8, 9);
            this.labelDupNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDupNum.Name = "labelDupNum";
            this.labelDupNum.Size = new System.Drawing.Size(62, 20);
            this.labelDupNum.TabIndex = 0;
            this.labelDupNum.Text = "並べる数";
            // 
            // numericDupNum
            // 
            this.numericDupNum.Location = new System.Drawing.Point(12, 32);
            this.numericDupNum.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericDupNum.Name = "numericDupNum";
            this.numericDupNum.Size = new System.Drawing.Size(120, 27);
            this.numericDupNum.TabIndex = 1;
            this.numericDupNum.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // labelInterval
            // 
            this.labelInterval.AutoSize = true;
            this.labelInterval.Location = new System.Drawing.Point(168, 9);
            this.labelInterval.Name = "labelInterval";
            this.labelInterval.Size = new System.Drawing.Size(69, 20);
            this.labelInterval.TabIndex = 2;
            this.labelInterval.Text = "設置間隔";
            // 
            // numericInterval
            // 
            this.numericInterval.DecimalPlaces = 5;
            this.numericInterval.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericInterval.Location = new System.Drawing.Point(172, 32);
            this.numericInterval.Name = "numericInterval";
            this.numericInterval.Size = new System.Drawing.Size(120, 27);
            this.numericInterval.TabIndex = 3;
            this.numericInterval.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(12, 65);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(280, 36);
            this.buttonRun.TabIndex = 4;
            this.buttonRun.Text = "実行";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // CtrlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 113);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.numericInterval);
            this.Controls.Add(this.labelInterval);
            this.Controls.Add(this.numericDupNum);
            this.Controls.Add(this.labelDupNum);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CtrlForm";
            this.Text = "DuplicateModel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CtrlForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numericDupNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDupNum;
        private System.Windows.Forms.NumericUpDown numericDupNum;
        private System.Windows.Forms.Label labelInterval;
        private System.Windows.Forms.NumericUpDown numericInterval;
        private System.Windows.Forms.Button buttonRun;
    }
}