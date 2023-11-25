namespace hoteleria
{
    partial class Form4
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
            this.TB_RFC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_Nombre = new System.Windows.Forms.TextBox();
            this.TB_Apellidos = new System.Windows.Forms.TextBox();
            this.CB_CantidadPersonas = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CB_MetodoPago = new System.Windows.Forms.ComboBox();
            this.btn_Reservar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_Anticipo = new System.Windows.Forms.TextBox();
            this.TB_Total = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(76, 216);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(698, 338);
            this.dataGridView1.TabIndex = 0;
            // 
            // TB_RFC
            // 
            this.TB_RFC.Location = new System.Drawing.Point(58, 52);
            this.TB_RFC.Name = "TB_RFC";
            this.TB_RFC.Size = new System.Drawing.Size(160, 22);
            this.TB_RFC.TabIndex = 1;
            this.TB_RFC.TextChanged += new System.EventHandler(this.TB_RFC_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "RFC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(486, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellidos";
            // 
            // TB_Nombre
            // 
            this.TB_Nombre.Location = new System.Drawing.Point(291, 52);
            this.TB_Nombre.Name = "TB_Nombre";
            this.TB_Nombre.ReadOnly = true;
            this.TB_Nombre.Size = new System.Drawing.Size(131, 22);
            this.TB_Nombre.TabIndex = 5;
            // 
            // TB_Apellidos
            // 
            this.TB_Apellidos.Location = new System.Drawing.Point(489, 52);
            this.TB_Apellidos.Name = "TB_Apellidos";
            this.TB_Apellidos.ReadOnly = true;
            this.TB_Apellidos.Size = new System.Drawing.Size(131, 22);
            this.TB_Apellidos.TabIndex = 6;
            // 
            // CB_CantidadPersonas
            // 
            this.CB_CantidadPersonas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_CantidadPersonas.FormattingEnabled = true;
            this.CB_CantidadPersonas.Location = new System.Drawing.Point(58, 136);
            this.CB_CantidadPersonas.Name = "CB_CantidadPersonas";
            this.CB_CantidadPersonas.Size = new System.Drawing.Size(160, 24);
            this.CB_CantidadPersonas.TabIndex = 7;
            this.CB_CantidadPersonas.SelectedIndexChanged += new System.EventHandler(this.CB_CantidadPersonas_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cantidad de personas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(433, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Método de pago";
            // 
            // CB_MetodoPago
            // 
            this.CB_MetodoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_MetodoPago.FormattingEnabled = true;
            this.CB_MetodoPago.Location = new System.Drawing.Point(436, 136);
            this.CB_MetodoPago.Name = "CB_MetodoPago";
            this.CB_MetodoPago.Size = new System.Drawing.Size(184, 24);
            this.CB_MetodoPago.TabIndex = 10;
            this.CB_MetodoPago.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // btn_Reservar
            // 
            this.btn_Reservar.Location = new System.Drawing.Point(661, 124);
            this.btn_Reservar.Name = "btn_Reservar";
            this.btn_Reservar.Size = new System.Drawing.Size(104, 36);
            this.btn_Reservar.TabIndex = 11;
            this.btn_Reservar.Text = "Reservar";
            this.btn_Reservar.UseVisualStyleBackColor = true;
            this.btn_Reservar.Click += new System.EventHandler(this.btn_Reservar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(693, 577);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 37);
            this.button2.TabIndex = 12;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Anticipo";
            // 
            // TB_Anticipo
            // 
            this.TB_Anticipo.Location = new System.Drawing.Point(262, 136);
            this.TB_Anticipo.Name = "TB_Anticipo";
            this.TB_Anticipo.ReadOnly = true;
            this.TB_Anticipo.Size = new System.Drawing.Size(160, 22);
            this.TB_Anticipo.TabIndex = 13;
            // 
            // TB_Total
            // 
            this.TB_Total.Location = new System.Drawing.Point(661, 52);
            this.TB_Total.Name = "TB_Total";
            this.TB_Total.ReadOnly = true;
            this.TB_Total.Size = new System.Drawing.Size(131, 22);
            this.TB_Total.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(658, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Total";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 640);
            this.Controls.Add(this.TB_Total);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TB_Anticipo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_Reservar);
            this.Controls.Add(this.CB_MetodoPago);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CB_CantidadPersonas);
            this.Controls.Add(this.TB_Apellidos);
            this.Controls.Add(this.TB_Nombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_RFC);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TB_RFC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_Nombre;
        private System.Windows.Forms.TextBox TB_Apellidos;
        private System.Windows.Forms.ComboBox CB_CantidadPersonas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CB_MetodoPago;
        private System.Windows.Forms.Button btn_Reservar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_Anticipo;
        private System.Windows.Forms.TextBox TB_Total;
        private System.Windows.Forms.Label label8;
    }
}