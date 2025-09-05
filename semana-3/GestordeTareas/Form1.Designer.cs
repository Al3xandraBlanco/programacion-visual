namespace GestordeTareas
{
    partial class cmbEstado
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBienvenida = new System.Windows.Forms.Label();
            this.btnNombre = new System.Windows.Forms.Label();
            this.btnFecha = new System.Windows.Forms.Label();
            this.btnDescripcion = new System.Windows.Forms.Label();
            this.btnLugar = new System.Windows.Forms.Label();
            this.btnCodigo = new System.Windows.Forms.Label();
            this.btnEstado = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtLugar = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.cmb_Estado = new System.Windows.Forms.ComboBox();
            this.dgvTareas = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lugar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnMostrarTareas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBienvenida
            // 
            this.btnBienvenida.AutoSize = true;
            this.btnBienvenida.BackColor = System.Drawing.SystemColors.Control;
            this.btnBienvenida.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBienvenida.ForeColor = System.Drawing.Color.HotPink;
            this.btnBienvenida.Location = new System.Drawing.Point(548, 19);
            this.btnBienvenida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnBienvenida.Name = "btnBienvenida";
            this.btnBienvenida.Size = new System.Drawing.Size(260, 29);
            this.btnBienvenida.TabIndex = 0;
            this.btnBienvenida.Text = "MI GESTOR DE TAREAS";
            this.btnBienvenida.Click += new System.EventHandler(this.btnBienvenida_Click);
            // 
            // btnNombre
            // 
            this.btnNombre.AutoSize = true;
            this.btnNombre.BackColor = System.Drawing.SystemColors.Control;
            this.btnNombre.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNombre.ForeColor = System.Drawing.Color.HotPink;
            this.btnNombre.Location = new System.Drawing.Point(918, 212);
            this.btnNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnNombre.Name = "btnNombre";
            this.btnNombre.Size = new System.Drawing.Size(83, 22);
            this.btnNombre.TabIndex = 1;
            this.btnNombre.Text = "NOMBRE";
            this.btnNombre.Click += new System.EventHandler(this.btnNombre_Click);
            // 
            // btnFecha
            // 
            this.btnFecha.AutoSize = true;
            this.btnFecha.BackColor = System.Drawing.SystemColors.Control;
            this.btnFecha.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecha.ForeColor = System.Drawing.Color.HotPink;
            this.btnFecha.Location = new System.Drawing.Point(918, 323);
            this.btnFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnFecha.Name = "btnFecha";
            this.btnFecha.Size = new System.Drawing.Size(206, 22);
            this.btnFecha.TabIndex = 2;
            this.btnFecha.Text = "FECHA DE REALIZACION";
            // 
            // btnDescripcion
            // 
            this.btnDescripcion.AutoSize = true;
            this.btnDescripcion.BackColor = System.Drawing.SystemColors.Control;
            this.btnDescripcion.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescripcion.ForeColor = System.Drawing.Color.HotPink;
            this.btnDescripcion.Location = new System.Drawing.Point(720, 321);
            this.btnDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnDescripcion.Name = "btnDescripcion";
            this.btnDescripcion.Size = new System.Drawing.Size(121, 22);
            this.btnDescripcion.TabIndex = 3;
            this.btnDescripcion.Text = "DESCRIPCION";
            // 
            // btnLugar
            // 
            this.btnLugar.AutoSize = true;
            this.btnLugar.BackColor = System.Drawing.SystemColors.Control;
            this.btnLugar.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLugar.ForeColor = System.Drawing.Color.HotPink;
            this.btnLugar.Location = new System.Drawing.Point(1119, 212);
            this.btnLugar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnLugar.Name = "btnLugar";
            this.btnLugar.Size = new System.Drawing.Size(66, 22);
            this.btnLugar.TabIndex = 4;
            this.btnLugar.Text = "LUGAR";
            this.btnLugar.Click += new System.EventHandler(this.btnLugar_Click);
            // 
            // btnCodigo
            // 
            this.btnCodigo.AutoSize = true;
            this.btnCodigo.BackColor = System.Drawing.SystemColors.Control;
            this.btnCodigo.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCodigo.ForeColor = System.Drawing.Color.HotPink;
            this.btnCodigo.Location = new System.Drawing.Point(731, 212);
            this.btnCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnCodigo.Name = "btnCodigo";
            this.btnCodigo.Size = new System.Drawing.Size(77, 22);
            this.btnCodigo.TabIndex = 5;
            this.btnCodigo.Text = "CODIGO";
            // 
            // btnEstado
            // 
            this.btnEstado.AutoSize = true;
            this.btnEstado.BackColor = System.Drawing.SystemColors.Control;
            this.btnEstado.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstado.ForeColor = System.Drawing.Color.HotPink;
            this.btnEstado.Location = new System.Drawing.Point(780, 416);
            this.btnEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnEstado.Name = "btnEstado";
            this.btnEstado.Size = new System.Drawing.Size(77, 22);
            this.btnEstado.TabIndex = 6;
            this.btnEstado.Text = "ESTADO";
            this.btnEstado.Click += new System.EventHandler(this.btnEstado_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(721, 251);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(116, 22);
            this.txtCodigo.TabIndex = 7;
            // 
            // txtLugar
            // 
            this.txtLugar.Location = new System.Drawing.Point(1123, 251);
            this.txtLugar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(116, 22);
            this.txtLugar.TabIndex = 9;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(721, 360);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(130, 22);
            this.txtDescripcion.TabIndex = 11;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(922, 251);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(116, 22);
            this.txtNombre.TabIndex = 12;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.Control;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.HotPink;
            this.btnAgregar.Location = new System.Drawing.Point(825, 102);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(231, 71);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "AGREGAR TAREA";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.HotPink;
            this.btnEditar.Location = new System.Drawing.Point(1085, 105);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(231, 69);
            this.btnEditar.TabIndex = 14;
            this.btnEditar.Text = "EDITAR TAREA";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.HotPink;
            this.btnEliminar.Location = new System.Drawing.Point(279, 104);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(231, 68);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "ELIMINAR TAREA";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // cmb_Estado
            // 
            this.cmb_Estado.FormattingEnabled = true;
            this.cmb_Estado.Items.AddRange(new object[] {
            "NO REALIZADA",
            "EN PROCESO",
            "TERMINADA"});
            this.cmb_Estado.Location = new System.Drawing.Point(875, 416);
            this.cmb_Estado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_Estado.Name = "cmb_Estado";
            this.cmb_Estado.Size = new System.Drawing.Size(260, 24);
            this.cmb_Estado.TabIndex = 16;
            // 
            // dgvTareas
            // 
            this.dgvTareas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTareas.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dgvTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTareas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Descripcion,
            this.Fecha,
            this.Lugar,
            this.Estado});
            this.dgvTareas.Location = new System.Drawing.Point(25, 212);
            this.dgvTareas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvTareas.MultiSelect = false;
            this.dgvTareas.Name = "dgvTareas";
            this.dgvTareas.RowHeadersWidth = 51;
            this.dgvTareas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTareas.Size = new System.Drawing.Size(688, 228);
            this.dgvTareas.TabIndex = 17;
            this.dgvTareas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTareas_CellContentClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "CODIGO";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "NOMBRE";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "DESCRIPCION";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "FECHA";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            // 
            // Lugar
            // 
            this.Lugar.HeaderText = "LUGAR";
            this.Lugar.MinimumWidth = 6;
            this.Lugar.Name = "Lugar";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "ESTADO";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(922, 360);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(257, 22);
            this.dtpFecha.TabIndex = 18;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.HotPink;
            this.btnBuscar.Location = new System.Drawing.Point(553, 105);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(231, 69);
            this.btnBuscar.TabIndex = 19;
            this.btnBuscar.Text = "BUSCAR TAREA";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnMostrarTareas
            // 
            this.btnMostrarTareas.BackColor = System.Drawing.SystemColors.Control;
            this.btnMostrarTareas.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarTareas.ForeColor = System.Drawing.Color.HotPink;
            this.btnMostrarTareas.Location = new System.Drawing.Point(13, 104);
            this.btnMostrarTareas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMostrarTareas.Name = "btnMostrarTareas";
            this.btnMostrarTareas.Size = new System.Drawing.Size(231, 69);
            this.btnMostrarTareas.TabIndex = 20;
            this.btnMostrarTareas.Text = "MOSTRAR TAREAS";
            this.btnMostrarTareas.UseVisualStyleBackColor = false;
            this.btnMostrarTareas.Click += new System.EventHandler(this.btnMostrarTodas_Click);
            // 
            // cmbEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 469);
            this.Controls.Add(this.btnMostrarTareas);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.dgvTareas);
            this.Controls.Add(this.cmb_Estado);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtLugar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnEstado);
            this.Controls.Add(this.btnCodigo);
            this.Controls.Add(this.btnLugar);
            this.Controls.Add(this.btnDescripcion);
            this.Controls.Add(this.btnFecha);
            this.Controls.Add(this.btnNombre);
            this.Controls.Add(this.btnBienvenida);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "cmbEstado";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btnBienvenida;
        private System.Windows.Forms.Label btnNombre;
        private System.Windows.Forms.Label btnFecha;
        private System.Windows.Forms.Label btnDescripcion;
        private System.Windows.Forms.Label btnLugar;
        private System.Windows.Forms.Label btnCodigo;
        private System.Windows.Forms.Label btnEstado;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtLugar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox cmb_Estado;
        private System.Windows.Forms.DataGridView dgvTareas;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lugar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnMostrarTareas;
    }
}

