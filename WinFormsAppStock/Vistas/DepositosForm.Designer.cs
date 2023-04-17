namespace WinFormsAppStock.Vistas
{
    partial class DepositosForm
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
            IdDeposito = new Label();
            txtIdDeposito = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            gvDepositos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gvDepositos).BeginInit();
            SuspendLayout();
            // 
            // IdDeposito
            // 
            IdDeposito.AutoSize = true;
            IdDeposito.Location = new Point(6, 50);
            IdDeposito.Name = "IdDeposito";
            IdDeposito.Size = new Size(64, 15);
            IdDeposito.TabIndex = 0;
            IdDeposito.Text = "IdDeposito";
            // 
            // txtIdDeposito
            // 
            txtIdDeposito.Location = new Point(76, 45);
            txtIdDeposito.Name = "txtIdDeposito";
            txtIdDeposito.Size = new Size(183, 23);
            txtIdDeposito.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(285, 46);
            button1.Name = "button1";
            button1.Size = new Size(118, 23);
            button1.TabIndex = 2;
            button1.Text = "Modificar Deposito";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(285, 88);
            button2.Name = "button2";
            button2.Size = new Size(118, 23);
            button2.TabIndex = 3;
            button2.Text = "Eliminar Deposito";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(508, 45);
            button3.Name = "button3";
            button3.Size = new Size(158, 55);
            button3.TabIndex = 4;
            button3.Text = "Agregar Deposito";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // gvDepositos
            // 
            gvDepositos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvDepositos.Location = new Point(12, 134);
            gvDepositos.Name = "gvDepositos";
            gvDepositos.RowTemplate.Height = 25;
            gvDepositos.Size = new Size(776, 304);
            gvDepositos.TabIndex = 5;
            // 
            // DepositosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gvDepositos);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtIdDeposito);
            Controls.Add(IdDeposito);
            Name = "DepositosForm";
            Text = "DepositosForm";
            ((System.ComponentModel.ISupportInitialize)gvDepositos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label IdDeposito;
        private TextBox txtIdDeposito;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView gvDepositos;
    }
}