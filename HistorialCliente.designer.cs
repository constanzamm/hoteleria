namespace hoteleria
{
    partial class HistorialCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.L_RFC = new System.Windows.Forms.Label();
            this.DGV_Historial = new System.Windows.Forms.DataGridView();
            this.Historial = new System.Windows.Forms.Label();
            this.CB_Año = new System.Windows.Forms.ComboBox();
            this.L_Año = new System.Windows.Forms.Label();
            this.CB_RFC = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Historial)).BeginInit();
            this.SuspendLayout();
            // 
            // L_RFC
            // 
            this.L_RFC.AutoSize = true;
            this.L_RFC.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_RFC.Location = new System.Drawing.Point(12, 12);
            this.L_RFC.Name = "L_RFC";
            this.L_RFC.Size = new System.Drawing.Size(30, 17);
            this.L_RFC.TabIndex = 9;
            this.L_RFC.Text = "RFC";
            // 
            // DGV_Historial
            // 
            this.DGV_Historial.AllowUserToAddRows = false;
            this.DGV_Historial.AllowUserToDeleteRows = false;
            this.DGV_Historial.AllowUserToResizeRows = false;
            this.DGV_Historial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.NullValue = "No aplica";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Historial.DefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Historial.Location = new System.Drawing.Point(12, 104);
            this.DGV_Historial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DGV_Historial.MultiSelect = false;
            this.DGV_Historial.Name = "DGV_Historial";
            this.DGV_Historial.RowHeadersWidth = 51;
            this.DGV_Historial.RowTemplate.Height = 24;
            this.DGV_Historial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Historial.Size = new System.Drawing.Size(602, 374);
            this.DGV_Historial.TabIndex = 26;
            // 
            // Historial
            // 
            this.Historial.AutoSize = true;
            this.Historial.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Historial.Location = new System.Drawing.Point(12, 83);
            this.Historial.Name = "Historial";
            this.Historial.Size = new System.Drawing.Size(56, 17);
            this.Historial.TabIndex = 27;
            this.Historial.Text = "Historial";
            // 
            // CB_Año
            // 
            this.CB_Año.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Año.FormattingEnabled = true;
            this.CB_Año.Location = new System.Drawing.Point(244, 32);
            this.CB_Año.Name = "CB_Año";
            this.CB_Año.Size = new System.Drawing.Size(121, 31);
            this.CB_Año.TabIndex = 28;
            this.CB_Año.SelectedIndexChanged += new System.EventHandler(this.CB_Año_SelectedIndexChanged);
            // 
            // L_Año
            // 
            this.L_Año.AutoSize = true;
            this.L_Año.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Año.Location = new System.Drawing.Point(241, 12);
            this.L_Año.Name = "L_Año";
            this.L_Año.Size = new System.Drawing.Size(121, 17);
            this.L_Año.TabIndex = 29;
            this.L_Año.Text = "Año de reservación";
            // 
            // CB_RFC
            // 
            this.CB_RFC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_RFC.FormattingEnabled = true;
            this.CB_RFC.Location = new System.Drawing.Point(12, 32);
            this.CB_RFC.Name = "CB_RFC";
            this.CB_RFC.Size = new System.Drawing.Size(226, 31);
            this.CB_RFC.TabIndex = 30;
            this.CB_RFC.SelectedIndexChanged += new System.EventHandler(this.CB_RFC_SelectedIndexChanged);
            // 
            // HistorialCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 491);
            this.Controls.Add(this.CB_RFC);
            this.Controls.Add(this.L_Año);
            this.Controls.Add(this.CB_Año);
            this.Controls.Add(this.Historial);
            this.Controls.Add(this.DGV_Historial);
            this.Controls.Add(this.L_RFC);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "HistorialCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Home_FormClosed);
            this.Load += new System.EventHandler(this.Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Historial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label L_RFC;
        private System.Windows.Forms.DataGridView DGV_Historial;
        private System.Windows.Forms.Label Historial;
        private System.Windows.Forms.ComboBox CB_Año;
        private System.Windows.Forms.Label L_Año;
        private System.Windows.Forms.ComboBox CB_RFC;
    }
}