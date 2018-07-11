namespace frmAltaEmpleado
{
    partial class frmAltaEmpleado
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
            this.lblConsorcio = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCuil = new System.Windows.Forms.TextBox();
            this.txtValorHora = new System.Windows.Forms.TextBox();
            this.txtValorMes = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblCuil = new System.Windows.Forms.Label();
            this.lblValorHora = new System.Windows.Forms.Label();
            this.lblValorMes = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLista = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCalcularSueldo = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblresultado = new System.Windows.Forms.Label();
            this.cmbNombre = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblConsorcio
            // 
            this.lblConsorcio.AutoSize = true;
            this.lblConsorcio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsorcio.Location = new System.Drawing.Point(195, 9);
            this.lblConsorcio.Name = "lblConsorcio";
            this.lblConsorcio.Size = new System.Drawing.Size(86, 16);
            this.lblConsorcio.TabIndex = 3;
            this.lblConsorcio.Text = "Consorcios";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(195, 105);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(79, 16);
            this.lblEmpleado.TabIndex = 4;
            this.lblEmpleado.Text = "Empleado";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(165, 151);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(116, 21);
            this.txtApellido.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(165, 195);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(116, 21);
            this.txtNombre.TabIndex = 6;
            // 
            // txtCuil
            // 
            this.txtCuil.Location = new System.Drawing.Point(165, 241);
            this.txtCuil.Name = "txtCuil";
            this.txtCuil.Size = new System.Drawing.Size(116, 21);
            this.txtCuil.TabIndex = 7;
            // 
            // txtValorHora
            // 
            this.txtValorHora.Location = new System.Drawing.Point(165, 282);
            this.txtValorHora.Name = "txtValorHora";
            this.txtValorHora.Size = new System.Drawing.Size(116, 21);
            this.txtValorHora.TabIndex = 8;
            // 
            // txtValorMes
            // 
            this.txtValorMes.Location = new System.Drawing.Point(165, 330);
            this.txtValorMes.Name = "txtValorMes";
            this.txtValorMes.Size = new System.Drawing.Size(116, 21);
            this.txtValorMes.TabIndex = 9;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(12, 201);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 15);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(11, 151);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(63, 15);
            this.lblApellido.TabIndex = 11;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblCuil
            // 
            this.lblCuil.AutoSize = true;
            this.lblCuil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuil.Location = new System.Drawing.Point(11, 247);
            this.lblCuil.Name = "lblCuil";
            this.lblCuil.Size = new System.Drawing.Size(36, 15);
            this.lblCuil.TabIndex = 12;
            this.lblCuil.Text = "Cuil:";
            // 
            // lblValorHora
            // 
            this.lblValorHora.AutoSize = true;
            this.lblValorHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorHora.Location = new System.Drawing.Point(12, 288);
            this.lblValorHora.Name = "lblValorHora";
            this.lblValorHora.Size = new System.Drawing.Size(79, 15);
            this.lblValorHora.TabIndex = 13;
            this.lblValorHora.Text = "Valor Hora:";
            // 
            // lblValorMes
            // 
            this.lblValorMes.AutoSize = true;
            this.lblValorMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorMes.Location = new System.Drawing.Point(12, 336);
            this.lblValorMes.Name = "lblValorMes";
            this.lblValorMes.Size = new System.Drawing.Size(75, 15);
            this.lblValorMes.TabIndex = 14;
            this.lblValorMes.Text = "Valor Mes:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(360, 126);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(119, 46);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar Empleado";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLista
            // 
            this.btnLista.Location = new System.Drawing.Point(360, 186);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(119, 45);
            this.btnLista.TabIndex = 16;
            this.btnLista.Text = "Lista de Empleados";
            this.btnLista.UseVisualStyleBackColor = true;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(360, 247);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(119, 47);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.Text = "Buscar Empleado";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCalcularSueldo
            // 
            this.btnCalcularSueldo.Location = new System.Drawing.Point(360, 317);
            this.btnCalcularSueldo.Name = "btnCalcularSueldo";
            this.btnCalcularSueldo.Size = new System.Drawing.Size(119, 47);
            this.btnCalcularSueldo.TabIndex = 18;
            this.btnCalcularSueldo.Text = "Calcular Sueldo Total";
            this.btnCalcularSueldo.UseVisualStyleBackColor = true;
            this.btnCalcularSueldo.Click += new System.EventHandler(this.btnCalcularSueldo_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(114, 409);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(134, 24);
            this.lblTotal.TabIndex = 19;
            this.lblTotal.Text = "Sueldo Total:";
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultado.ForeColor = System.Drawing.Color.Red;
            this.lblresultado.Location = new System.Drawing.Point(271, 409);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(38, 24);
            this.lblresultado.TabIndex = 20;
            this.lblresultado.Text = "$ 0";
            // 
            // cmbNombre
            // 
            this.cmbNombre.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.cmbNombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNombre.FormattingEnabled = true;
            this.cmbNombre.Location = new System.Drawing.Point(165, 47);
            this.cmbNombre.Name = "cmbNombre";
            this.cmbNombre.Size = new System.Drawing.Size(140, 23);
            this.cmbNombre.TabIndex = 0;
            // 
            // frmAltaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 460);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnCalcularSueldo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnLista);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblValorMes);
            this.Controls.Add(this.lblValorHora);
            this.Controls.Add(this.lblCuil);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtValorMes);
            this.Controls.Add(this.txtValorHora);
            this.Controls.Add(this.txtCuil);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.lblConsorcio);
            this.Controls.Add(this.cmbNombre);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmAltaEmpleado";
            this.Text = "frmAltaEmpleado";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblConsorcio;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCuil;
        private System.Windows.Forms.TextBox txtValorHora;
        private System.Windows.Forms.TextBox txtValorMes;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblCuil;
        private System.Windows.Forms.Label lblValorHora;
        private System.Windows.Forms.Label lblValorMes;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCalcularSueldo;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.ComboBox cmbNombre;
    }
}

