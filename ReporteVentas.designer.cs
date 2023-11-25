namespace hoteleria
{
    partial class ReporteVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.B_Volver = new System.Windows.Forms.Button();
            this.DGV_Reporte = new System.Windows.Forms.DataGridView();
            this.L_Ventas = new System.Windows.Forms.Label();
            this.CB_Año = new System.Windows.Forms.ComboBox();
            this.L_Año = new System.Windows.Forms.Label();
            this.L_Pais = new System.Windows.Forms.Label();
            this.CB_Pais = new System.Windows.Forms.ComboBox();
            this.L_Hotel = new System.Windows.Forms.Label();
            this.CB_Hotel = new System.Windows.Forms.ComboBox();
            this.L_Ciudad = new System.Windows.Forms.Label();
            this.CB_Ciudad = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Reporte)).BeginInit();
            this.SuspendLayout();
            // 
            // B_Volver
            // 
            this.B_Volver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Volver.Location = new System.Drawing.Point(955, 12);
            this.B_Volver.Name = "B_Volver";
            this.B_Volver.Size = new System.Drawing.Size(104, 41);
            this.B_Volver.TabIndex = 7;
            this.B_Volver.Text = "Volver";
            this.B_Volver.UseVisualStyleBackColor = true;
            this.B_Volver.Click += new System.EventHandler(this.B_Volver_Click);
            // 
            // DGV_Reporte
            // 
            this.DGV_Reporte.AllowUserToAddRows = false;
            this.DGV_Reporte.AllowUserToDeleteRows = false;
            this.DGV_Reporte.AllowUserToResizeRows = false;
            this.DGV_Reporte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Reporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = "No aplica";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Reporte.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_Reporte.Location = new System.Drawing.Point(12, 104);
            this.DGV_Reporte.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DGV_Reporte.MultiSelect = false;
            this.DGV_Reporte.Name = "DGV_Reporte";
            this.DGV_Reporte.RowHeadersWidth = 51;
            this.DGV_Reporte.RowTemplate.Height = 24;
            this.DGV_Reporte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Reporte.Size = new System.Drawing.Size(1047, 374);
            this.DGV_Reporte.TabIndex = 26;
            // 
            // L_Ventas
            // 
            this.L_Ventas.AutoSize = true;
            this.L_Ventas.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Ventas.Location = new System.Drawing.Point(12, 83);
            this.L_Ventas.Name = "L_Ventas";
            this.L_Ventas.Size = new System.Drawing.Size(46, 17);
            this.L_Ventas.TabIndex = 27;
            this.L_Ventas.Text = "Ventas";
            // 
            // CB_Año
            // 
            this.CB_Año.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Año.FormattingEnabled = true;
            this.CB_Año.Location = new System.Drawing.Point(139, 31);
            this.CB_Año.Name = "CB_Año";
            this.CB_Año.Size = new System.Drawing.Size(121, 31);
            this.CB_Año.TabIndex = 28;
            this.CB_Año.SelectedIndexChanged += new System.EventHandler(this.CB_Año_SelectedIndexChanged);
            // 
            // L_Año
            // 
            this.L_Año.AutoSize = true;
            this.L_Año.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Año.Location = new System.Drawing.Point(139, 11);
            this.L_Año.Name = "L_Año";
            this.L_Año.Size = new System.Drawing.Size(31, 17);
            this.L_Año.TabIndex = 29;
            this.L_Año.Text = "Año";
            // 
            // L_Pais
            // 
            this.L_Pais.AutoSize = true;
            this.L_Pais.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Pais.Location = new System.Drawing.Point(12, 11);
            this.L_Pais.Name = "L_Pais";
            this.L_Pais.Size = new System.Drawing.Size(31, 17);
            this.L_Pais.TabIndex = 32;
            this.L_Pais.Text = "País";
            // 
            // CB_Pais
            // 
            this.CB_Pais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Pais.FormattingEnabled = true;
            this.CB_Pais.Location = new System.Drawing.Point(12, 31);
            this.CB_Pais.Name = "CB_Pais";
            this.CB_Pais.Size = new System.Drawing.Size(121, 31);
            this.CB_Pais.TabIndex = 31;
            this.CB_Pais.SelectedIndexChanged += new System.EventHandler(this.CB_Pais_SelectedIndexChanged);
            // 
            // L_Hotel
            // 
            this.L_Hotel.AutoSize = true;
            this.L_Hotel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Hotel.Location = new System.Drawing.Point(393, 11);
            this.L_Hotel.Name = "L_Hotel";
            this.L_Hotel.Size = new System.Drawing.Size(39, 17);
            this.L_Hotel.TabIndex = 34;
            this.L_Hotel.Text = "Hotel";
            // 
            // CB_Hotel
            // 
            this.CB_Hotel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Hotel.FormattingEnabled = true;
            this.CB_Hotel.Location = new System.Drawing.Point(393, 31);
            this.CB_Hotel.Name = "CB_Hotel";
            this.CB_Hotel.Size = new System.Drawing.Size(121, 31);
            this.CB_Hotel.TabIndex = 33;
            this.CB_Hotel.SelectedIndexChanged += new System.EventHandler(this.CB_Hotel_SelectedIndexChanged);
            // 
            // L_Ciudad
            // 
            this.L_Ciudad.AutoSize = true;
            this.L_Ciudad.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Ciudad.Location = new System.Drawing.Point(266, 11);
            this.L_Ciudad.Name = "L_Ciudad";
            this.L_Ciudad.Size = new System.Drawing.Size(49, 17);
            this.L_Ciudad.TabIndex = 36;
            this.L_Ciudad.Text = "Ciudad";
            // 
            // CB_Ciudad
            // 
            this.CB_Ciudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Ciudad.FormattingEnabled = true;
            this.CB_Ciudad.Location = new System.Drawing.Point(266, 31);
            this.CB_Ciudad.Name = "CB_Ciudad";
            this.CB_Ciudad.Size = new System.Drawing.Size(121, 31);
            this.CB_Ciudad.TabIndex = 35;
            this.CB_Ciudad.SelectedIndexChanged += new System.EventHandler(this.CB_Ciudad_SelectedIndexChanged);
            // 
            // ReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 491);
            this.ControlBox = false;
            this.Controls.Add(this.L_Ciudad);
            this.Controls.Add(this.CB_Ciudad);
            this.Controls.Add(this.L_Hotel);
            this.Controls.Add(this.CB_Hotel);
            this.Controls.Add(this.L_Pais);
            this.Controls.Add(this.CB_Pais);
            this.Controls.Add(this.L_Año);
            this.Controls.Add(this.CB_Año);
            this.Controls.Add(this.L_Ventas);
            this.Controls.Add(this.DGV_Reporte);
            this.Controls.Add(this.B_Volver);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "ReporteVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de ventas";
            this.Load += new System.EventHandler(this.ReporteVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Reporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button B_Volver;
        private System.Windows.Forms.DataGridView DGV_Reporte;
        private System.Windows.Forms.Label L_Ventas;
        private System.Windows.Forms.ComboBox CB_Año;
        private System.Windows.Forms.Label L_Año;
        private System.Windows.Forms.Label L_Pais;
        private System.Windows.Forms.ComboBox CB_Pais;
        private System.Windows.Forms.Label L_Hotel;
        private System.Windows.Forms.ComboBox CB_Hotel;
        private System.Windows.Forms.Label L_Ciudad;
        private System.Windows.Forms.ComboBox CB_Ciudad;
    }
}