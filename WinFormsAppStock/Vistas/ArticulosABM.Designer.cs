namespace WinFormsAppStock.Vistas
{
    partial class ArticulosABM
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtId = new TextBox();
            txtProveedor = new TextBox();
            txtPrecio = new TextBox();
            txtMinStock = new TextBox();
            txtMarca = new TextBox();
            txtNombre = new TextBox();
            button1 = new Button();
            label7 = new Label();
            txtCodigo = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(130, 35);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(130, 85);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(130, 131);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 2;
            label3.Text = "Marca";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(130, 180);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 3;
            label4.Text = "Minimo Stock";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(130, 226);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 4;
            label5.Text = "Proveedor";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(130, 269);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 5;
            label6.Text = "Precio";
            // 
            // txtId
            // 
            txtId.Location = new Point(256, 32);
            txtId.Name = "txtId";
            txtId.Size = new Size(191, 23);
            txtId.TabIndex = 6;
            // 
            // txtProveedor
            // 
            txtProveedor.Location = new Point(256, 218);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.Size = new Size(191, 23);
            txtProveedor.TabIndex = 7;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(256, 261);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(191, 23);
            txtPrecio.TabIndex = 8;
            // 
            // txtMinStock
            // 
            txtMinStock.Location = new Point(256, 172);
            txtMinStock.Name = "txtMinStock";
            txtMinStock.Size = new Size(191, 23);
            txtMinStock.TabIndex = 9;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(256, 123);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(191, 23);
            txtMarca.TabIndex = 10;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(256, 77);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(191, 23);
            txtNombre.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(256, 334);
            button1.Name = "button1";
            button1.Size = new Size(191, 30);
            button1.TabIndex = 12;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(130, 304);
            label7.Name = "label7";
            label7.Size = new Size(46, 15);
            label7.TabIndex = 13;
            label7.Text = "Codigo";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(256, 301);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(191, 23);
            txtCodigo.TabIndex = 14;
            // 
            // ArticulosABM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtCodigo);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(txtNombre);
            Controls.Add(txtMarca);
            Controls.Add(txtMinStock);
            Controls.Add(txtPrecio);
            Controls.Add(txtProveedor);
            Controls.Add(txtId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ArticulosABM";
            Text = "ArticulosABM";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtId;
        private TextBox txtProveedor;
        private TextBox txtPrecio;
        private TextBox txtMinStock;
        private TextBox txtMarca;
        private TextBox txtNombre;
        private Button button1;
        private Label label7;
        private TextBox txtCodigo;
    }
}