namespace Proyecto_AAVD
{
    partial class Clientes
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
            this.DGV_Clientes = new System.Windows.Forms.DataGridView();
            this.B_Agregar = new System.Windows.Forms.Button();
            this.B_Eliminar = new System.Windows.Forms.Button();
            this.B_Modificar = new System.Windows.Forms.Button();
            this.TB_Nombre = new System.Windows.Forms.TextBox();
            this.L_Nombre = new System.Windows.Forms.Label();
            this.L_Calle = new System.Windows.Forms.Label();
            this.TB_Calle = new System.Windows.Forms.TextBox();
            this.L_NumeroExterior = new System.Windows.Forms.Label();
            this.TB_NumeroExterior = new System.Windows.Forms.TextBox();
            this.L_Colonia = new System.Windows.Forms.Label();
            this.TB_Colonia = new System.Windows.Forms.TextBox();
            this.DTP_FechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.L_FechaNacimiento = new System.Windows.Forms.Label();
            this.RB_Casado = new System.Windows.Forms.RadioButton();
            this.RB_Soltero = new System.Windows.Forms.RadioButton();
            this.RB_Viudo = new System.Windows.Forms.RadioButton();
            this.RB_Divorciado = new System.Windows.Forms.RadioButton();
            this.L_EstadoCivil = new System.Windows.Forms.Label();
            this.L_Apellidos = new System.Windows.Forms.Label();
            this.TB_Apellidos = new System.Windows.Forms.TextBox();
            this.L_Correo = new System.Windows.Forms.Label();
            this.TB_Correo = new System.Windows.Forms.TextBox();
            this.L_Celular = new System.Windows.Forms.Label();
            this.TB_Celular = new System.Windows.Forms.TextBox();
            this.L_Casa = new System.Windows.Forms.Label();
            this.TB_Casa = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_RFC = new System.Windows.Forms.TextBox();
            this.L_Referencia = new System.Windows.Forms.Label();
            this.TB_Referencia = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Clientes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_Clientes
            // 
            this.DGV_Clientes.AllowUserToAddRows = false;
            this.DGV_Clientes.AllowUserToDeleteRows = false;
            this.DGV_Clientes.AllowUserToResizeRows = false;
            this.DGV_Clientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = "No aplica";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Clientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_Clientes.Location = new System.Drawing.Point(16, 326);
            this.DGV_Clientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DGV_Clientes.MultiSelect = false;
            this.DGV_Clientes.Name = "DGV_Clientes";
            this.DGV_Clientes.ReadOnly = true;
            this.DGV_Clientes.RowHeadersWidth = 51;
            this.DGV_Clientes.RowTemplate.Height = 24;
            this.DGV_Clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Clientes.Size = new System.Drawing.Size(962, 136);
            this.DGV_Clientes.TabIndex = 2;
            this.DGV_Clientes.SelectionChanged += new System.EventHandler(this.DGV_Clientes_SelectionChanged);
            // 
            // B_Agregar
            // 
            this.B_Agregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Agregar.Location = new System.Drawing.Point(874, 59);
            this.B_Agregar.Name = "B_Agregar";
            this.B_Agregar.Size = new System.Drawing.Size(104, 41);
            this.B_Agregar.TabIndex = 4;
            this.B_Agregar.Text = "Agregar";
            this.B_Agregar.UseVisualStyleBackColor = true;
            this.B_Agregar.Click += new System.EventHandler(this.B_Agregar_Click);
            // 
            // B_Eliminar
            // 
            this.B_Eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Eliminar.Location = new System.Drawing.Point(874, 106);
            this.B_Eliminar.Name = "B_Eliminar";
            this.B_Eliminar.Size = new System.Drawing.Size(104, 41);
            this.B_Eliminar.TabIndex = 5;
            this.B_Eliminar.Text = "Eliminar";
            this.B_Eliminar.UseVisualStyleBackColor = true;
            this.B_Eliminar.Click += new System.EventHandler(this.B_Eliminar_Click);
            // 
            // B_Modificar
            // 
            this.B_Modificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Modificar.Location = new System.Drawing.Point(874, 153);
            this.B_Modificar.Name = "B_Modificar";
            this.B_Modificar.Size = new System.Drawing.Size(104, 41);
            this.B_Modificar.TabIndex = 6;
            this.B_Modificar.Text = "Modificar";
            this.B_Modificar.UseVisualStyleBackColor = true;
            this.B_Modificar.Click += new System.EventHandler(this.B_Modificar_Click);
            // 
            // TB_Nombre
            // 
            this.TB_Nombre.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Nombre.Location = new System.Drawing.Point(12, 35);
            this.TB_Nombre.Name = "TB_Nombre";
            this.TB_Nombre.Size = new System.Drawing.Size(214, 25);
            this.TB_Nombre.TabIndex = 8;
            // 
            // L_Nombre
            // 
            this.L_Nombre.AutoSize = true;
            this.L_Nombre.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Nombre.Location = new System.Drawing.Point(12, 9);
            this.L_Nombre.Name = "L_Nombre";
            this.L_Nombre.Size = new System.Drawing.Size(57, 17);
            this.L_Nombre.TabIndex = 9;
            this.L_Nombre.Text = "Nombre";
            // 
            // L_Calle
            // 
            this.L_Calle.AutoSize = true;
            this.L_Calle.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Calle.Location = new System.Drawing.Point(12, 250);
            this.L_Calle.Name = "L_Calle";
            this.L_Calle.Size = new System.Drawing.Size(36, 17);
            this.L_Calle.TabIndex = 11;
            this.L_Calle.Text = "Calle";
            // 
            // TB_Calle
            // 
            this.TB_Calle.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Calle.Location = new System.Drawing.Point(12, 276);
            this.TB_Calle.Name = "TB_Calle";
            this.TB_Calle.Size = new System.Drawing.Size(214, 25);
            this.TB_Calle.TabIndex = 10;
            // 
            // L_NumeroExterior
            // 
            this.L_NumeroExterior.AutoSize = true;
            this.L_NumeroExterior.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_NumeroExterior.Location = new System.Drawing.Point(12, 191);
            this.L_NumeroExterior.Name = "L_NumeroExterior";
            this.L_NumeroExterior.Size = new System.Drawing.Size(105, 17);
            this.L_NumeroExterior.TabIndex = 13;
            this.L_NumeroExterior.Text = "Numero exterior";
            // 
            // TB_NumeroExterior
            // 
            this.TB_NumeroExterior.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_NumeroExterior.Location = new System.Drawing.Point(12, 217);
            this.TB_NumeroExterior.Name = "TB_NumeroExterior";
            this.TB_NumeroExterior.Size = new System.Drawing.Size(214, 25);
            this.TB_NumeroExterior.TabIndex = 12;
            // 
            // L_Colonia
            // 
            this.L_Colonia.AutoSize = true;
            this.L_Colonia.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Colonia.Location = new System.Drawing.Point(12, 127);
            this.L_Colonia.Name = "L_Colonia";
            this.L_Colonia.Size = new System.Drawing.Size(52, 17);
            this.L_Colonia.TabIndex = 15;
            this.L_Colonia.Text = "Colonia";
            // 
            // TB_Colonia
            // 
            this.TB_Colonia.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Colonia.Location = new System.Drawing.Point(12, 153);
            this.TB_Colonia.Name = "TB_Colonia";
            this.TB_Colonia.Size = new System.Drawing.Size(214, 25);
            this.TB_Colonia.TabIndex = 14;
            // 
            // DTP_FechaNacimiento
            // 
            this.DTP_FechaNacimiento.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_FechaNacimiento.Location = new System.Drawing.Point(487, 95);
            this.DTP_FechaNacimiento.Name = "DTP_FechaNacimiento";
            this.DTP_FechaNacimiento.Size = new System.Drawing.Size(200, 25);
            this.DTP_FechaNacimiento.TabIndex = 18;
            // 
            // L_FechaNacimiento
            // 
            this.L_FechaNacimiento.AutoSize = true;
            this.L_FechaNacimiento.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_FechaNacimiento.Location = new System.Drawing.Point(483, 69);
            this.L_FechaNacimiento.Name = "L_FechaNacimiento";
            this.L_FechaNacimiento.Size = new System.Drawing.Size(127, 17);
            this.L_FechaNacimiento.TabIndex = 19;
            this.L_FechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // RB_Casado
            // 
            this.RB_Casado.AutoSize = true;
            this.RB_Casado.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Casado.Location = new System.Drawing.Point(254, 95);
            this.RB_Casado.Name = "RB_Casado";
            this.RB_Casado.Size = new System.Drawing.Size(73, 21);
            this.RB_Casado.TabIndex = 20;
            this.RB_Casado.TabStop = true;
            this.RB_Casado.Text = "Casado";
            this.RB_Casado.UseVisualStyleBackColor = true;
            // 
            // RB_Soltero
            // 
            this.RB_Soltero.AutoSize = true;
            this.RB_Soltero.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Soltero.Location = new System.Drawing.Point(254, 123);
            this.RB_Soltero.Name = "RB_Soltero";
            this.RB_Soltero.Size = new System.Drawing.Size(71, 21);
            this.RB_Soltero.TabIndex = 21;
            this.RB_Soltero.TabStop = true;
            this.RB_Soltero.Text = "Soltero";
            this.RB_Soltero.UseVisualStyleBackColor = true;
            // 
            // RB_Viudo
            // 
            this.RB_Viudo.AutoSize = true;
            this.RB_Viudo.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Viudo.Location = new System.Drawing.Point(342, 95);
            this.RB_Viudo.Name = "RB_Viudo";
            this.RB_Viudo.Size = new System.Drawing.Size(63, 21);
            this.RB_Viudo.TabIndex = 22;
            this.RB_Viudo.TabStop = true;
            this.RB_Viudo.Text = "Viudo";
            this.RB_Viudo.UseVisualStyleBackColor = true;
            // 
            // RB_Divorciado
            // 
            this.RB_Divorciado.AutoSize = true;
            this.RB_Divorciado.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Divorciado.Location = new System.Drawing.Point(342, 124);
            this.RB_Divorciado.Name = "RB_Divorciado";
            this.RB_Divorciado.Size = new System.Drawing.Size(92, 21);
            this.RB_Divorciado.TabIndex = 23;
            this.RB_Divorciado.TabStop = true;
            this.RB_Divorciado.Text = "Divorciado";
            this.RB_Divorciado.UseVisualStyleBackColor = true;
            // 
            // L_EstadoCivil
            // 
            this.L_EstadoCivil.AutoSize = true;
            this.L_EstadoCivil.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_EstadoCivil.Location = new System.Drawing.Point(250, 69);
            this.L_EstadoCivil.Name = "L_EstadoCivil";
            this.L_EstadoCivil.Size = new System.Drawing.Size(73, 17);
            this.L_EstadoCivil.TabIndex = 24;
            this.L_EstadoCivil.Text = "Estado civil";
            // 
            // L_Apellidos
            // 
            this.L_Apellidos.AutoSize = true;
            this.L_Apellidos.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Apellidos.Location = new System.Drawing.Point(12, 69);
            this.L_Apellidos.Name = "L_Apellidos";
            this.L_Apellidos.Size = new System.Drawing.Size(62, 17);
            this.L_Apellidos.TabIndex = 26;
            this.L_Apellidos.Text = "Apellidos";
            // 
            // TB_Apellidos
            // 
            this.TB_Apellidos.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Apellidos.Location = new System.Drawing.Point(12, 95);
            this.TB_Apellidos.Name = "TB_Apellidos";
            this.TB_Apellidos.Size = new System.Drawing.Size(214, 25);
            this.TB_Apellidos.TabIndex = 25;
            // 
            // L_Correo
            // 
            this.L_Correo.AutoSize = true;
            this.L_Correo.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Correo.Location = new System.Drawing.Point(250, 9);
            this.L_Correo.Name = "L_Correo";
            this.L_Correo.Size = new System.Drawing.Size(117, 17);
            this.L_Correo.TabIndex = 28;
            this.L_Correo.Text = "Correo Electrónico";
            // 
            // TB_Correo
            // 
            this.TB_Correo.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Correo.Location = new System.Drawing.Point(250, 35);
            this.TB_Correo.Name = "TB_Correo";
            this.TB_Correo.Size = new System.Drawing.Size(214, 25);
            this.TB_Correo.TabIndex = 27;
            // 
            // L_Celular
            // 
            this.L_Celular.AutoSize = true;
            this.L_Celular.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Celular.Location = new System.Drawing.Point(16, 26);
            this.L_Celular.Name = "L_Celular";
            this.L_Celular.Size = new System.Drawing.Size(48, 17);
            this.L_Celular.TabIndex = 30;
            this.L_Celular.Text = "Celular";
            // 
            // TB_Celular
            // 
            this.TB_Celular.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Celular.Location = new System.Drawing.Point(16, 52);
            this.TB_Celular.Name = "TB_Celular";
            this.TB_Celular.Size = new System.Drawing.Size(214, 25);
            this.TB_Celular.TabIndex = 29;
            // 
            // L_Casa
            // 
            this.L_Casa.AutoSize = true;
            this.L_Casa.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Casa.Location = new System.Drawing.Point(16, 80);
            this.L_Casa.Name = "L_Casa";
            this.L_Casa.Size = new System.Drawing.Size(36, 17);
            this.L_Casa.TabIndex = 32;
            this.L_Casa.Text = "Casa";
            // 
            // TB_Casa
            // 
            this.TB_Casa.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Casa.Location = new System.Drawing.Point(19, 105);
            this.TB_Casa.Name = "TB_Casa";
            this.TB_Casa.Size = new System.Drawing.Size(214, 25);
            this.TB_Casa.TabIndex = 31;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.L_Celular);
            this.groupBox1.Controls.Add(this.L_Casa);
            this.groupBox1.Controls.Add(this.TB_Celular);
            this.groupBox1.Controls.Add(this.TB_Casa);
            this.groupBox1.Location = new System.Drawing.Point(232, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 141);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Teléfonos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(486, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "RFC";
            // 
            // TB_RFC
            // 
            this.TB_RFC.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_RFC.Location = new System.Drawing.Point(486, 35);
            this.TB_RFC.Name = "TB_RFC";
            this.TB_RFC.Size = new System.Drawing.Size(214, 25);
            this.TB_RFC.TabIndex = 34;
            // 
            // L_Referencia
            // 
            this.L_Referencia.AutoSize = true;
            this.L_Referencia.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Referencia.Location = new System.Drawing.Point(486, 130);
            this.L_Referencia.Name = "L_Referencia";
            this.L_Referencia.Size = new System.Drawing.Size(69, 17);
            this.L_Referencia.TabIndex = 37;
            this.L_Referencia.Text = "Referencia";
            // 
            // TB_Referencia
            // 
            this.TB_Referencia.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Referencia.Location = new System.Drawing.Point(486, 156);
            this.TB_Referencia.Name = "TB_Referencia";
            this.TB_Referencia.Size = new System.Drawing.Size(214, 25);
            this.TB_Referencia.TabIndex = 36;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 475);
            this.Controls.Add(this.L_Referencia);
            this.Controls.Add(this.TB_Referencia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_RFC);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.L_Correo);
            this.Controls.Add(this.TB_Correo);
            this.Controls.Add(this.L_Apellidos);
            this.Controls.Add(this.TB_Apellidos);
            this.Controls.Add(this.L_EstadoCivil);
            this.Controls.Add(this.RB_Divorciado);
            this.Controls.Add(this.RB_Viudo);
            this.Controls.Add(this.RB_Soltero);
            this.Controls.Add(this.RB_Casado);
            this.Controls.Add(this.L_FechaNacimiento);
            this.Controls.Add(this.DTP_FechaNacimiento);
            this.Controls.Add(this.L_Colonia);
            this.Controls.Add(this.TB_Colonia);
            this.Controls.Add(this.L_NumeroExterior);
            this.Controls.Add(this.TB_NumeroExterior);
            this.Controls.Add(this.L_Calle);
            this.Controls.Add(this.TB_Calle);
            this.Controls.Add(this.L_Nombre);
            this.Controls.Add(this.TB_Nombre);
            this.Controls.Add(this.B_Modificar);
            this.Controls.Add(this.B_Eliminar);
            this.Controls.Add(this.B_Agregar);
            this.Controls.Add(this.DGV_Clientes);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Home_FormClosed);
            this.Load += new System.EventHandler(this.Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Clientes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DGV_Clientes;
        private System.Windows.Forms.Button B_Agregar;
        private System.Windows.Forms.Button B_Eliminar;
        private System.Windows.Forms.Button B_Modificar;
        private System.Windows.Forms.TextBox TB_Nombre;
        private System.Windows.Forms.Label L_Nombre;
        private System.Windows.Forms.Label L_Calle;
        private System.Windows.Forms.TextBox TB_Calle;
        private System.Windows.Forms.Label L_NumeroExterior;
        private System.Windows.Forms.TextBox TB_NumeroExterior;
        private System.Windows.Forms.Label L_Colonia;
        private System.Windows.Forms.TextBox TB_Colonia;
        private System.Windows.Forms.DateTimePicker DTP_FechaNacimiento;
        private System.Windows.Forms.Label L_FechaNacimiento;
        private System.Windows.Forms.RadioButton RB_Casado;
        private System.Windows.Forms.RadioButton RB_Soltero;
        private System.Windows.Forms.RadioButton RB_Viudo;
        private System.Windows.Forms.RadioButton RB_Divorciado;
        private System.Windows.Forms.Label L_EstadoCivil;
        private System.Windows.Forms.Label L_Apellidos;
        private System.Windows.Forms.TextBox TB_Apellidos;
        private System.Windows.Forms.Label L_Correo;
        private System.Windows.Forms.TextBox TB_Correo;
        private System.Windows.Forms.Label L_Celular;
        private System.Windows.Forms.TextBox TB_Celular;
        private System.Windows.Forms.Label L_Casa;
        private System.Windows.Forms.TextBox TB_Casa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_RFC;
        private System.Windows.Forms.Label L_Referencia;
        private System.Windows.Forms.TextBox TB_Referencia;
    }
}