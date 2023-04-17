namespace WinFormsAppStock.Vistas
{
    partial class StocksForm
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
            gvStocks = new DataGridView();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            txtIdStock = new TextBox();
            IdDeposito = new Label();
            ((System.ComponentModel.ISupportInitialize)gvStocks).BeginInit();
            SuspendLayout();
            // 
            // gvStocks
            // 
            gvStocks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvStocks.Location = new Point(114, 217);
            gvStocks.Name = "gvStocks";
            gvStocks.RowTemplate.Height = 25;
            gvStocks.Size = new Size(590, 165);
            gvStocks.TabIndex = 11;
            // 
            // button3
            // 
            button3.Location = new Point(546, 56);
            button3.Name = "button3";
            button3.Size = new Size(158, 55);
            button3.TabIndex = 10;
            button3.Text = "Agregar Stock";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(323, 99);
            button2.Name = "button2";
            button2.Size = new Size(118, 23);
            button2.TabIndex = 9;
            button2.Text = "Eliminar Stock";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(323, 57);
            button1.Name = "button1";
            button1.Size = new Size(118, 23);
            button1.TabIndex = 8;
            button1.Text = "Modificar Stock";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtIdStock
            // 
            txtIdStock.Location = new Point(114, 56);
            txtIdStock.Name = "txtIdStock";
            txtIdStock.Size = new Size(183, 23);
            txtIdStock.TabIndex = 7;
            // 
            // IdDeposito
            // 
            IdDeposito.AutoSize = true;
            IdDeposito.Location = new Point(44, 61);
            IdDeposito.Name = "IdDeposito";
            IdDeposito.Size = new Size(46, 15);
            IdDeposito.TabIndex = 6;
            IdDeposito.Text = "IdStock";
            // 
            // StocksForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gvStocks);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtIdStock);
            Controls.Add(IdDeposito);
            Name = "StocksForm";
            Text = "StocksForm";
            ((System.ComponentModel.ISupportInitialize)gvStocks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gvStocks;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox txtIdStock;
        private Label IdDeposito;
    }
}