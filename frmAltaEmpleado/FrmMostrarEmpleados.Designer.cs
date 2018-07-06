namespace frmAltaEmpleado
{
    partial class FrmMostrarEmpleados
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
            this.lblLista = new System.Windows.Forms.Label();
            this.dtglistaEmpleados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtglistaEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLista.Location = new System.Drawing.Point(220, 31);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(167, 20);
            this.lblLista.TabIndex = 0;
            this.lblLista.Text = "Lista de Empleados";
            // 
            // dtglistaEmpleados
            // 
            this.dtglistaEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtglistaEmpleados.Location = new System.Drawing.Point(12, 95);
            this.dtglistaEmpleados.Name = "dtglistaEmpleados";
            this.dtglistaEmpleados.Size = new System.Drawing.Size(617, 150);
            this.dtglistaEmpleados.TabIndex = 1;
            this.dtglistaEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtglistaEmpleados_CellContentClick);
            // 
            // FrmMostrarEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 295);
            this.Controls.Add(this.dtglistaEmpleados);
            this.Controls.Add(this.lblLista);
            this.Name = "FrmMostrarEmpleados";
            this.Text = "FrmMostrarEmpleados";
            this.Load += new System.EventHandler(this.FrmMostrarEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtglistaEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.DataGridView dtglistaEmpleados;
    }
}