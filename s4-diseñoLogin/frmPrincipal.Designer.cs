namespace s4_diseñoLogin
{
    partial class frmPrincipal
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
            btnInscribir = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            btnSalir = new Button();
            lblIngreso = new Label();
            SuspendLayout();
            // 
            // btnInscribir
            // 
            btnInscribir.Location = new Point(94, 112);
            btnInscribir.Name = "btnInscribir";
            btnInscribir.Size = new Size(195, 85);
            btnInscribir.TabIndex = 0;
            btnInscribir.Text = "Inscribir Postulante";
            btnInscribir.UseVisualStyleBackColor = true;
            btnInscribir.Click += btnInscribir_Click;
            // 
            // button2
            // 
            button2.Location = new Point(488, 112);
            button2.Name = "button2";
            button2.Size = new Size(195, 85);
            button2.TabIndex = 1;
            button2.Text = "Asignar Curso";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(94, 271);
            button3.Name = "button3";
            button3.Size = new Size(195, 85);
            button3.TabIndex = 2;
            button3.Text = "Pagar Curso";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(488, 271);
            button4.Name = "button4";
            button4.Size = new Size(195, 85);
            button4.TabIndex = 3;
            button4.Text = "Emitir comprobante de Curso";
            button4.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(687, 27);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(101, 32);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblIngreso
            // 
            lblIngreso.AutoSize = true;
            lblIngreso.Location = new Point(30, 27);
            lblIngreso.Name = "lblIngreso";
            lblIngreso.Size = new Size(36, 20);
            lblIngreso.TabIndex = 5;
            lblIngreso.Text = "user";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblIngreso);
            Controls.Add(btnSalir);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnInscribir);
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            Load += frmPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInscribir;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button btnSalir;
        private Label lblIngreso;
    }
}