namespace s4_diseñoLogin
{
    partial class frmInscripcion
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtDocumento = new TextBox();
            cboTipo = new ComboBox();
            conexionBindingSource1 = new BindingSource(components);
            conexionBindingSource = new BindingSource(components);
            btnIngresar = new Button();
            btnLimpiar = new Button();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)conexionBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)conexionBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(427, 57);
            label1.Name = "label1";
            label1.Size = new Size(220, 20);
            label1.TabIndex = 0;
            label1.Text = "INSCRIPCION DEL POSTULANTE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(360, 106);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(360, 166);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 2;
            label3.Text = "Apellido";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(461, 107);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(210, 27);
            txtNombre.TabIndex = 3;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(461, 166);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(210, 27);
            txtApellido.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(347, 247);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 5;
            label4.Text = "Tipo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(521, 247);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 6;
            label5.Text = "Documento";
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(624, 244);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(141, 27);
            txtDocumento.TabIndex = 7;
            // 
            // cboTipo
            // 
            cboTipo.DataSource = conexionBindingSource;
            cboTipo.FormattingEnabled = true;
            cboTipo.Location = new Point(392, 246);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(108, 28);
            cboTipo.TabIndex = 8;
            // 
            // conexionBindingSource1
            // 
            conexionBindingSource1.DataSource = typeof(Datos.Conexion);
            // 
            // conexionBindingSource
            // 
            conexionBindingSource.DataSource = typeof(Datos.Conexion);
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(285, 380);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(139, 35);
            btnIngresar.TabIndex = 9;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(469, 380);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(139, 35);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(649, 380);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(139, 35);
            btnVolver.TabIndex = 11;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // frmInscripcion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolver);
            Controls.Add(btnLimpiar);
            Controls.Add(btnIngresar);
            Controls.Add(cboTipo);
            Controls.Add(txtDocumento);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmInscripcion";
            Text = "frmInscripcion";
            ((System.ComponentModel.ISupportInitialize)conexionBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)conexionBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label label4;
        private Label label5;
        private TextBox txtDocumento;
        private ComboBox cboTipo;
        private BindingSource conexionBindingSource;
        private BindingSource conexionBindingSource1;
        private Button btnIngresar;
        private Button btnLimpiar;
        private Button btnVolver;
    }
}