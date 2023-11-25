namespace hoteleria
{
    partial class CheckIn
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
            this.button1 = new System.Windows.Forms.Button();
            this.CodResvTx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DTP_CheckIn = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Realizar Check In";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CodResvTx
            // 
            this.CodResvTx.Location = new System.Drawing.Point(61, 139);
            this.CodResvTx.Name = "CodResvTx";
            this.CodResvTx.Size = new System.Drawing.Size(230, 22);
            this.CodResvTx.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código de reservación:";
            // 
            // DTP_CheckIn
            // 
            this.DTP_CheckIn.Enabled = false;
            this.DTP_CheckIn.Location = new System.Drawing.Point(12, 12);
            this.DTP_CheckIn.Name = "DTP_CheckIn";
            this.DTP_CheckIn.Size = new System.Drawing.Size(279, 22);
            this.DTP_CheckIn.TabIndex = 3;
            // 
            // CheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 331);
            this.Controls.Add(this.DTP_CheckIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CodResvTx);
            this.Controls.Add(this.button1);
            this.Name = "CheckIn";
            this.Text = "Check In";
            this.Load += new System.EventHandler(this.CheckIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox CodResvTx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DTP_CheckIn;
    }
}