namespace Ejercicio1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            tbNombre = new TextBox();
            btnAgregar = new Button();
            cmbNombres = new ComboBox();
            cmbNombre2 = new ComboBox();
            btMover = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 37);
            label1.Name = "label1";
            label1.Size = new Size(81, 21);
            label1.TabIndex = 0;
            label1.Text = "Nombre: ";
            // 
            // tbNombre
            // 
            tbNombre.ForeColor = Color.Blue;
            tbNombre.Location = new Point(110, 39);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(323, 23);
            tbNombre.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.Control;
            btnAgregar.Image = Properties.Resources.agregar_usuario__1_;
            btnAgregar.Location = new Point(483, 23);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(76, 53);
            btnAgregar.TabIndex = 2;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // cmbNombres
            // 
            cmbNombres.FormattingEnabled = true;
            cmbNombres.Location = new Point(110, 117);
            cmbNombres.Name = "cmbNombres";
            cmbNombres.Size = new Size(323, 23);
            cmbNombres.TabIndex = 3;
            // 
            // cmbNombre2
            // 
            cmbNombre2.FormattingEnabled = true;
            cmbNombre2.Location = new Point(110, 253);
            cmbNombre2.Name = "cmbNombre2";
            cmbNombre2.Size = new Size(323, 23);
            cmbNombre2.TabIndex = 4;
            // 
            // btMover
            // 
            btMover.Location = new Point(211, 166);
            btMover.Name = "btMover";
            btMover.Size = new Size(113, 60);
            btMover.TabIndex = 5;
            btMover.Text = "Remover";
            btMover.UseVisualStyleBackColor = true;
            btMover.Click += btMover_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btMover);
            Controls.Add(cmbNombre2);
            Controls.Add(cmbNombres);
            Controls.Add(btnAgregar);
            Controls.Add(tbNombre);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbNombre;
        private Button btnAgregar;
        private ComboBox cmbNombres;
        private ComboBox cmbNombre2;
        private Button btMover;
    }
}
