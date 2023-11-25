namespace hoteleria
{
    partial class Cambiar_Contraseña
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
            this.T_pass = new System.Windows.Forms.TextBox();
            this.L_Contra = new System.Windows.Forms.Label();
            this.T_ContraConfirmada = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // T_pass
            // 
            this.T_pass.Location = new System.Drawing.Point(265, 90);
            this.T_pass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.T_pass.Name = "T_pass";
            this.T_pass.Size = new System.Drawing.Size(305, 22);
            this.T_pass.TabIndex = 5;
            // 
            // L_Contra
            // 
            this.L_Contra.AutoSize = true;
            this.L_Contra.Location = new System.Drawing.Point(176, 94);
            this.L_Contra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L_Contra.Name = "L_Contra";
            this.L_Contra.Size = new System.Drawing.Size(76, 16);
            this.L_Contra.TabIndex = 4;
            this.L_Contra.Text = "Contraseña";
            // 
            // T_ContraConfirmada
            // 
            this.T_ContraConfirmada.Location = new System.Drawing.Point(265, 148);
            this.T_ContraConfirmada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.T_ContraConfirmada.Name = "T_ContraConfirmada";
            this.T_ContraConfirmada.Size = new System.Drawing.Size(305, 22);
            this.T_ContraConfirmada.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 151);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Confirmar Constraseña";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(580, 252);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 42);
            this.button1.TabIndex = 8;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cambiar_Contraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 320);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.T_ContraConfirmada);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.T_pass);
            this.Controls.Add(this.L_Contra);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Cambiar_Contraseña";
            this.Text = "Cambiar Contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox T_pass;
        private System.Windows.Forms.Label L_Contra;
        private System.Windows.Forms.TextBox T_ContraConfirmada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}