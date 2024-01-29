namespace MiniMarket.Presentacion
{
    partial class Frm_Categorias
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
            tabPage2 = new TabPage();
            btnGuardar = new Button();
            btnCancelar = new Button();
            txtCategoria = new TextBox();
            lblCategoria = new Label();
            tabPage1 = new TabPage();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            dgvPrincipal = new DataGridView();
            label1 = new Label();
            tbcPrincipal = new TabControl();
            btnSalir = new Button();
            btnReporte = new Button();
            btnEliminar = new Button();
            btnUpdate = new Button();
            btnNuevo = new Button();
            tabPage2.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrincipal).BeginInit();
            tbcPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnGuardar);
            tabPage2.Controls.Add(btnCancelar);
            tabPage2.Controls.Add(txtCategoria);
            tabPage2.Controls.Add(lblCategoria);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(732, 222);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Mantenimiento";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(195, 89);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(32, 89);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(85, 16);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(212, 23);
            txtCategoria.TabIndex = 1;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(21, 19);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(58, 15);
            lblCategoria.TabIndex = 0;
            lblCategoria.Text = "Categoria";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnBuscar);
            tabPage1.Controls.Add(txtBuscar);
            tabPage1.Controls.Add(dgvPrincipal);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(732, 222);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Listado";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(182, 24);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 8;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(76, 24);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(100, 23);
            txtBuscar.TabIndex = 7;
            // 
            // dgvPrincipal
            // 
            dgvPrincipal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrincipal.Location = new Point(25, 53);
            dgvPrincipal.Name = "dgvPrincipal";
            dgvPrincipal.RowTemplate.Height = 25;
            dgvPrincipal.Size = new Size(521, 150);
            dgvPrincipal.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 27);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 3;
            label1.Text = "Buscar:";
            // 
            // tbcPrincipal
            // 
            tbcPrincipal.Controls.Add(tabPage1);
            tbcPrincipal.Controls.Add(tabPage2);
            tbcPrincipal.Location = new Point(12, 12);
            tbcPrincipal.Name = "tbcPrincipal";
            tbcPrincipal.SelectedIndex = 0;
            tbcPrincipal.Size = new Size(740, 250);
            tbcPrincipal.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(355, 305);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 10;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnReporte
            // 
            btnReporte.Location = new Point(274, 305);
            btnReporte.Name = "btnReporte";
            btnReporte.Size = new Size(75, 23);
            btnReporte.TabIndex = 9;
            btnReporte.Text = "Reporte";
            btnReporte.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(193, 305);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(112, 305);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(31, 305);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 6;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // Frm_Categorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 361);
            Controls.Add(btnSalir);
            Controls.Add(btnReporte);
            Controls.Add(btnEliminar);
            Controls.Add(btnUpdate);
            Controls.Add(btnNuevo);
            Controls.Add(tbcPrincipal);
            Name = "Frm_Categorias";
            Text = "Categorias";
            Load += Frm_Categorias_Load;
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrincipal).EndInit();
            tbcPrincipal.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage2;
        private TabPage tabPage1;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private DataGridView dgvPrincipal;
        private Label label1;
        private TabControl tbcPrincipal;
        private Button btnSalir;
        private Button btnReporte;
        private Button btnEliminar;
        private Button btnUpdate;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnCancelar;
        private TextBox txtCategoria;
        private Label lblCategoria;
    }
}