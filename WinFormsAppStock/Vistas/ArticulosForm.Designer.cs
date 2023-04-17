namespace WinFormsAppStock.Vistas
{
    partial class ArticulosForm
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
            IdArticulo = new Label();
            txtIdArticulo = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            gvArticulos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gvArticulos).BeginInit();
            SuspendLayout();
            // 
            // IdArticulo
            // 
            IdArticulo.AutoSize = true;
            IdArticulo.Location = new Point(11, 46);
            IdArticulo.Name = "IdArticulo";
            IdArticulo.Size = new Size(59, 15);
            IdArticulo.TabIndex = 0;
            IdArticulo.Text = "IdArticulo";
            // 
            // txtIdArticulo
            // 
            txtIdArticulo.Location = new Point(76, 42);
            txtIdArticulo.Name = "txtIdArticulo";
            txtIdArticulo.Size = new Size(165, 23);
            txtIdArticulo.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(247, 42);
            button1.Name = "button1";
            button1.Size = new Size(132, 23);
            button1.TabIndex = 2;
            button1.Text = "Modificar Articulo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(247, 85);
            button2.Name = "button2";
            button2.Size = new Size(132, 23);
            button2.TabIndex = 3;
            button2.Text = "Eliminar Articulo";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(444, 42);
            button3.Name = "button3";
            button3.Size = new Size(155, 47);
            button3.TabIndex = 4;
            button3.Text = "Agregar Articulo";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // gvArticulos
            // 
            gvArticulos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvArticulos.Location = new Point(12, 128);
            gvArticulos.Name = "gvArticulos";
            gvArticulos.RowTemplate.Height = 25;
            gvArticulos.Size = new Size(776, 310);
            gvArticulos.TabIndex = 5;
            // 
            // ArticulosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gvArticulos);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtIdArticulo);
            Controls.Add(IdArticulo);
            Name = "ArticulosForm";
            Text = "ArticulosForm";
            ((System.ComponentModel.ISupportInitialize)gvArticulos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label IdArticulo;
        private TextBox txtIdArticulo;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView gvArticulos;
    }
}