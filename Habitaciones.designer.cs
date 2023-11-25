namespace hoteleria
{
    partial class Habitaciones
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
            System.Windows.Forms.Label L_NumHabitacion;
            System.Windows.Forms.Label L_TipodeCama;
            System.Windows.Forms.Label L_NumCamas;
            this.TB_NumCamas = new System.Windows.Forms.TextBox();
            this.TB_NumHabitacion = new System.Windows.Forms.TextBox();
            this.TB_IDHotel = new System.Windows.Forms.TextBox();
            this.L_IDHotel = new System.Windows.Forms.Label();
            this.CB_NivelHabitacion = new System.Windows.Forms.ComboBox();
            this.CB_TipodeCama = new System.Windows.Forms.ComboBox();
            this.L_NivelHabitacion = new System.Windows.Forms.Label();
            this.TB_CantidadPersonas = new System.Windows.Forms.TextBox();
            this.L_CantidadPersonas = new System.Windows.Forms.Label();
            this.TB_Precio = new System.Windows.Forms.TextBox();
            this.L_Precio = new System.Windows.Forms.Label();
            this.TB_NomTipoHab = new System.Windows.Forms.TextBox();
            this.L_NomTipoHab = new System.Windows.Forms.Label();
            this.B_Agregar = new System.Windows.Forms.Button();
            this.GB_Caracteristicas = new System.Windows.Forms.GroupBox();
            this.CLB_Caracteristicas = new System.Windows.Forms.CheckedListBox();
            L_NumHabitacion = new System.Windows.Forms.Label();
            L_TipodeCama = new System.Windows.Forms.Label();
            L_NumCamas = new System.Windows.Forms.Label();
            this.GB_Caracteristicas.SuspendLayout();
            this.SuspendLayout();
            // 
            // TB_NumCamas
            // 
            this.TB_NumCamas.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.TB_NumCamas.Location = new System.Drawing.Point(207, 124);
            this.TB_NumCamas.Name = "TB_NumCamas";
            this.TB_NumCamas.Size = new System.Drawing.Size(250, 30);
            this.TB_NumCamas.TabIndex = 82;
            // 
            // TB_NumHabitacion
            // 
            this.TB_NumHabitacion.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.TB_NumHabitacion.Location = new System.Drawing.Point(260, 86);
            this.TB_NumHabitacion.Name = "TB_NumHabitacion";
            this.TB_NumHabitacion.Size = new System.Drawing.Size(197, 30);
            this.TB_NumHabitacion.TabIndex = 81;
            // 
            // L_NumHabitacion
            // 
            L_NumHabitacion.AutoSize = true;
            L_NumHabitacion.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            L_NumHabitacion.Location = new System.Drawing.Point(18, 89);
            L_NumHabitacion.Name = "L_NumHabitacion";
            L_NumHabitacion.Size = new System.Drawing.Size(202, 23);
            L_NumHabitacion.TabIndex = 80;
            L_NumHabitacion.Text = "Numero de la Habitacion";
            // 
            // TB_IDHotel
            // 
            this.TB_IDHotel.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.TB_IDHotel.Location = new System.Drawing.Point(255, 48);
            this.TB_IDHotel.Name = "TB_IDHotel";
            this.TB_IDHotel.Size = new System.Drawing.Size(197, 30);
            this.TB_IDHotel.TabIndex = 79;
            // 
            // L_IDHotel
            // 
            this.L_IDHotel.AutoSize = true;
            this.L_IDHotel.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.L_IDHotel.Location = new System.Drawing.Point(19, 51);
            this.L_IDHotel.Name = "L_IDHotel";
            this.L_IDHotel.Size = new System.Drawing.Size(210, 23);
            this.L_IDHotel.TabIndex = 78;
            this.L_IDHotel.Text = "ID del Hotel Perteneciente";
            // 
            // CB_NivelHabitacion
            // 
            this.CB_NivelHabitacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_NivelHabitacion.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.CB_NivelHabitacion.FormattingEnabled = true;
            this.CB_NivelHabitacion.Location = new System.Drawing.Point(230, 276);
            this.CB_NivelHabitacion.Name = "CB_NivelHabitacion";
            this.CB_NivelHabitacion.Size = new System.Drawing.Size(227, 31);
            this.CB_NivelHabitacion.TabIndex = 77;
            // 
            // CB_TipodeCama
            // 
            this.CB_TipodeCama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_TipodeCama.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.CB_TipodeCama.FormattingEnabled = true;
            this.CB_TipodeCama.Location = new System.Drawing.Point(168, 158);
            this.CB_TipodeCama.Name = "CB_TipodeCama";
            this.CB_TipodeCama.Size = new System.Drawing.Size(288, 31);
            this.CB_TipodeCama.TabIndex = 76;
            // 
            // L_NivelHabitacion
            // 
            this.L_NivelHabitacion.AutoSize = true;
            this.L_NivelHabitacion.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.L_NivelHabitacion.Location = new System.Drawing.Point(18, 284);
            this.L_NivelHabitacion.Name = "L_NivelHabitacion";
            this.L_NivelHabitacion.Size = new System.Drawing.Size(177, 23);
            this.L_NivelHabitacion.TabIndex = 75;
            this.L_NivelHabitacion.Text = "Nivel de la Habitacion";
            // 
            // TB_CantidadPersonas
            // 
            this.TB_CantidadPersonas.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.TB_CantidadPersonas.Location = new System.Drawing.Point(346, 235);
            this.TB_CantidadPersonas.Name = "TB_CantidadPersonas";
            this.TB_CantidadPersonas.Size = new System.Drawing.Size(111, 30);
            this.TB_CantidadPersonas.TabIndex = 74;
            // 
            // L_CantidadPersonas
            // 
            this.L_CantidadPersonas.AutoSize = true;
            this.L_CantidadPersonas.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.L_CantidadPersonas.Location = new System.Drawing.Point(18, 243);
            this.L_CantidadPersonas.Name = "L_CantidadPersonas";
            this.L_CantidadPersonas.Size = new System.Drawing.Size(293, 23);
            this.L_CantidadPersonas.TabIndex = 73;
            this.L_CantidadPersonas.Text = "Cantidad de Personas por Habitación";
            // 
            // TB_Precio
            // 
            this.TB_Precio.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.TB_Precio.Location = new System.Drawing.Point(292, 195);
            this.TB_Precio.Name = "TB_Precio";
            this.TB_Precio.Size = new System.Drawing.Size(165, 30);
            this.TB_Precio.TabIndex = 72;
            // 
            // L_Precio
            // 
            this.L_Precio.AutoSize = true;
            this.L_Precio.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.L_Precio.Location = new System.Drawing.Point(18, 203);
            this.L_Precio.Name = "L_Precio";
            this.L_Precio.Size = new System.Drawing.Size(239, 23);
            this.L_Precio.TabIndex = 71;
            this.L_Precio.Text = "Precio por Noche por Persona";
            // 
            // L_TipodeCama
            // 
            L_TipodeCama.AutoSize = true;
            L_TipodeCama.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            L_TipodeCama.Location = new System.Drawing.Point(17, 166);
            L_TipodeCama.Name = "L_TipodeCama";
            L_TipodeCama.Size = new System.Drawing.Size(116, 23);
            L_TipodeCama.TabIndex = 70;
            L_TipodeCama.Text = "Tipo de Cama";
            // 
            // L_NumCamas
            // 
            L_NumCamas.AutoSize = true;
            L_NumCamas.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            L_NumCamas.Location = new System.Drawing.Point(18, 127);
            L_NumCamas.Name = "L_NumCamas";
            L_NumCamas.Size = new System.Drawing.Size(153, 23);
            L_NumCamas.TabIndex = 69;
            L_NumCamas.Text = "Numero de Camas";
            // 
            // TB_NomTipoHab
            // 
            this.TB_NomTipoHab.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.TB_NomTipoHab.Location = new System.Drawing.Point(294, 12);
            this.TB_NomTipoHab.Name = "TB_NomTipoHab";
            this.TB_NomTipoHab.Size = new System.Drawing.Size(157, 30);
            this.TB_NomTipoHab.TabIndex = 68;
            // 
            // L_NomTipoHab
            // 
            this.L_NomTipoHab.AutoSize = true;
            this.L_NomTipoHab.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.L_NomTipoHab.Location = new System.Drawing.Point(12, 14);
            this.L_NomTipoHab.Name = "L_NomTipoHab";
            this.L_NomTipoHab.Size = new System.Drawing.Size(247, 23);
            this.L_NomTipoHab.TabIndex = 67;
            this.L_NomTipoHab.Text = "Nombre del tipo de Habitacion";
            // 
            // B_Agregar
            // 
            this.B_Agregar.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.B_Agregar.Location = new System.Drawing.Point(144, 499);
            this.B_Agregar.Name = "B_Agregar";
            this.B_Agregar.Size = new System.Drawing.Size(162, 41);
            this.B_Agregar.TabIndex = 66;
            this.B_Agregar.Text = "Agregar";
            this.B_Agregar.UseVisualStyleBackColor = true;
            this.B_Agregar.Click += new System.EventHandler(this.B_Agregar_Click);
            // 
            // GB_Caracteristicas
            // 
            this.GB_Caracteristicas.Controls.Add(this.CLB_Caracteristicas);
            this.GB_Caracteristicas.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.GB_Caracteristicas.Location = new System.Drawing.Point(17, 320);
            this.GB_Caracteristicas.Name = "GB_Caracteristicas";
            this.GB_Caracteristicas.Size = new System.Drawing.Size(435, 170);
            this.GB_Caracteristicas.TabIndex = 65;
            this.GB_Caracteristicas.TabStop = false;
            this.GB_Caracteristicas.Text = "Caracteristicas";
            // 
            // CLB_Caracteristicas
            // 
            this.CLB_Caracteristicas.FormattingEnabled = true;
            this.CLB_Caracteristicas.Items.AddRange(new object[] {
            "Frente a Piscina",
            "Frente a Playa",
            "Frente a Jardin",
            "Cama Cómoda",
            "Baño Privado",
            "Kit Aseo",
            "Television",
            "Aire Acondicionado/calefacción",
            "Wifi",
            "Cafetera y Té",
            "Escritorio y Silla",
            "Caja Fuerte",
            "Mini Bar",
            "Teléfono",
            "Plancha y Tabla de Planchar",
            "Espejo de Cuerpo Entero",
            "Batas y Zapatillas",
            "Servicio de Limpieza Diaria",
            "Vistas Escénicas",
            "Servicio a la Habitación"});
            this.CLB_Caracteristicas.Location = new System.Drawing.Point(6, 29);
            this.CLB_Caracteristicas.MultiColumn = true;
            this.CLB_Caracteristicas.Name = "CLB_Caracteristicas";
            this.CLB_Caracteristicas.Size = new System.Drawing.Size(423, 129);
            this.CLB_Caracteristicas.TabIndex = 40;
            // 
            // Habitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 553);
            this.Controls.Add(this.TB_NumCamas);
            this.Controls.Add(this.TB_NumHabitacion);
            this.Controls.Add(L_NumHabitacion);
            this.Controls.Add(this.TB_IDHotel);
            this.Controls.Add(this.L_IDHotel);
            this.Controls.Add(this.CB_NivelHabitacion);
            this.Controls.Add(this.CB_TipodeCama);
            this.Controls.Add(this.L_NivelHabitacion);
            this.Controls.Add(this.TB_CantidadPersonas);
            this.Controls.Add(this.L_CantidadPersonas);
            this.Controls.Add(this.TB_Precio);
            this.Controls.Add(this.L_Precio);
            this.Controls.Add(L_TipodeCama);
            this.Controls.Add(L_NumCamas);
            this.Controls.Add(this.TB_NomTipoHab);
            this.Controls.Add(this.L_NomTipoHab);
            this.Controls.Add(this.B_Agregar);
            this.Controls.Add(this.GB_Caracteristicas);
            this.Name = "Habitaciones";
            this.Text = "Habitaciones";
            this.Load += new System.EventHandler(this.Habitaciones_Load);
            this.GB_Caracteristicas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_NumCamas;
        private System.Windows.Forms.TextBox TB_NumHabitacion;
        private System.Windows.Forms.TextBox TB_IDHotel;
        private System.Windows.Forms.Label L_IDHotel;
        private System.Windows.Forms.ComboBox CB_NivelHabitacion;
        private System.Windows.Forms.ComboBox CB_TipodeCama;
        private System.Windows.Forms.Label L_NivelHabitacion;
        private System.Windows.Forms.TextBox TB_CantidadPersonas;
        private System.Windows.Forms.Label L_CantidadPersonas;
        private System.Windows.Forms.TextBox TB_Precio;
        private System.Windows.Forms.Label L_Precio;
        private System.Windows.Forms.TextBox TB_NomTipoHab;
        private System.Windows.Forms.Label L_NomTipoHab;
        private System.Windows.Forms.Button B_Agregar;
        private System.Windows.Forms.GroupBox GB_Caracteristicas;
        private System.Windows.Forms.CheckedListBox CLB_Caracteristicas;
    }
}