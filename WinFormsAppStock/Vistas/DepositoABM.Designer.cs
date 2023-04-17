namespace WinFormsAppStock.Vistas
{
    partial class DepositoABM
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
            button1 = new Button();
            txtCapacidad = new TextBox();
            txtNombre = new TextBox();
            txtDireccion = new TextBox();
            txtId = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(324, 295);
            button1.Name = "button1";
            button1.Size = new Size(191, 30);
            button1.TabIndex = 25;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtCapacidad
            // 
            txtCapacidad.Location = new Point(324, 115);
            txtCapacidad.Name = "txtCapacidad";
            txtCapacidad.Size = new Size(191, 23);
            txtCapacidad.TabIndex = 24;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(324, 161);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(191, 23);
            txtNombre.TabIndex = 23;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(324, 210);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(191, 23);
            txtDireccion.TabIndex = 22;
            // 
            // txtId
            // 
            txtId.Location = new Point(324, 70);
            txtId.Name = "txtId";
            txtId.Size = new Size(191, 23);
            txtId.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(198, 218);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 16;
            label4.Text = "Direccion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(198, 169);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 15;
            label3.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(198, 123);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 14;
            label2.Text = "Capacidad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(198, 73);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 13;
            label1.Text = "ID";
            // 
            // DepositoABM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtCapacidad);
            Controls.Add(txtNombre);
            Controls.Add(txtDireccion);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DepositoABM";
            Text = "DepositoABM";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtCapacidad;
        private TextBox txtNombre;
        private TextBox txtDireccion;
        private TextBox txtId;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}