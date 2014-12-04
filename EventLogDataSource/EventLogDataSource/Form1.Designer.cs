namespace EventLogDataSource
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
            this.label1 = new System.Windows.Forms.Label();
            this.numrows_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ok_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numrows_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Rows:";
            // 
            // numrows_numericUpDown
            // 
            this.numrows_numericUpDown.Location = new System.Drawing.Point(104, 19);
            this.numrows_numericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numrows_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numrows_numericUpDown.Name = "numrows_numericUpDown";
            this.numrows_numericUpDown.Size = new System.Drawing.Size(138, 20);
            this.numrows_numericUpDown.TabIndex = 1;
            this.numrows_numericUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(167, 68);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(75, 23);
            this.ok_button.TabIndex = 2;
            this.ok_button.Text = "OK";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 103);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.numrows_numericUpDown);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event Log Query Builder";
            ((System.ComponentModel.ISupportInitialize)(this.numrows_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numrows_numericUpDown;
        private System.Windows.Forms.Button ok_button;
    }
}

