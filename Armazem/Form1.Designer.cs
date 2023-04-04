namespace Armazem
{
    partial class Form1
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
            this.cbxFornecedores = new System.Windows.Forms.ComboBox();
            this.lstCategorias = new System.Windows.Forms.ListBox();
            this.dgvBD = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBD)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxFornecedores
            // 
            this.cbxFornecedores.FormattingEnabled = true;
            this.cbxFornecedores.Location = new System.Drawing.Point(12, 62);
            this.cbxFornecedores.Name = "cbxFornecedores";
            this.cbxFornecedores.Size = new System.Drawing.Size(188, 24);
            this.cbxFornecedores.TabIndex = 0;
            this.cbxFornecedores.SelectedIndexChanged += new System.EventHandler(this.cbxFornecedores_SelectedIndexChanged);
            // 
            // lstCategorias
            // 
            this.lstCategorias.FormattingEnabled = true;
            this.lstCategorias.ItemHeight = 16;
            this.lstCategorias.Location = new System.Drawing.Point(206, 36);
            this.lstCategorias.Name = "lstCategorias";
            this.lstCategorias.Size = new System.Drawing.Size(188, 84);
            this.lstCategorias.TabIndex = 1;
            this.lstCategorias.SelectedIndexChanged += new System.EventHandler(this.lstCategorias_SelectedIndexChanged);
            // 
            // dgvBD
            // 
            this.dgvBD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBD.Location = new System.Drawing.Point(12, 142);
            this.dgvBD.Name = "dgvBD";
            this.dgvBD.RowHeadersWidth = 51;
            this.dgvBD.RowTemplate.Height = 24;
            this.dgvBD.Size = new System.Drawing.Size(776, 296);
            this.dgvBD.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(452, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "GESTÃO DE ARMAZÉM";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBD);
            this.Controls.Add(this.lstCategorias);
            this.Controls.Add(this.cbxFornecedores);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxFornecedores;
        private System.Windows.Forms.ListBox lstCategorias;
        private System.Windows.Forms.DataGridView dgvBD;
        private System.Windows.Forms.Label label1;
    }
}

