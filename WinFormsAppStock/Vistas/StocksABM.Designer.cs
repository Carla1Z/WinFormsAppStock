namespace WinFormsAppStock.Vistas
{
    partial class StocksABM
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
            cbtIdArticulo = new ComboBox();
            cbIdDeposito = new ComboBox();
            txtCantidad = new TextBox();
            txtId = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(216, 79);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(216, 139);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 1;
            label2.Text = "Articulo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(216, 199);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 2;
            label3.Text = "Deposito";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(216, 258);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 3;
            label4.Text = "Cantidad";
            // 
            // cbtIdArticulo
            // 
            cbtIdArticulo.FormattingEnabled = true;
            cbtIdArticulo.Location = new Point(348, 131);
            cbtIdArticulo.Name = "cbtIdArticulo";
            cbtIdArticulo.Size = new Size(174, 23);
            cbtIdArticulo.TabIndex = 4;
            // 
            // cbIdDeposito
            // 
            cbIdDeposito.FormattingEnabled = true;
            cbIdDeposito.Location = new Point(348, 191);
            cbIdDeposito.Name = "cbIdDeposito";
            cbIdDeposito.Size = new Size(174, 23);
            cbIdDeposito.TabIndex = 5;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(348, 250);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(174, 23);
            txtCantidad.TabIndex = 6;
            // 
            // txtId
            // 
            txtId.Location = new Point(348, 79);
            txtId.Name = "txtId";
            txtId.Size = new Size(174, 23);
            txtId.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(348, 324);
            button1.Name = "button1";
            button1.Size = new Size(174, 23);
            button1.TabIndex = 8;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // StocksABM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtId);
            Controls.Add(txtCantidad);
            Controls.Add(cbIdDeposito);
            Controls.Add(cbtIdArticulo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "StocksABM";
            Text = "StocksABM";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cbtIdArticulo;
        private ComboBox cbIdDeposito;
        private TextBox txtCantidad;
        private TextBox txtId;
        private Button button1;
    }
}