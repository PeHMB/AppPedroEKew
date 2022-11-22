namespace AppRegistroVeiculo.Formularios
{
    partial class FormConsultarVendas
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
            this.dgvTabela = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPlaca = new System.Windows.Forms.ComboBox();
            this.cbCpf = new System.Windows.Forms.ComboBox();
            this.btBuscarCliente = new System.Windows.Forms.Button();
            this.btBuscarPlaca = new System.Windows.Forms.Button();
            this.btClientePlaca = new System.Windows.Forms.Button();
            this.btNovaConsulta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabela)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTabela
            // 
            this.dgvTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabela.Location = new System.Drawing.Point(12, 199);
            this.dgvTabela.Name = "dgvTabela";
            this.dgvTabela.Size = new System.Drawing.Size(619, 280);
            this.dgvTabela.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 16);
            this.label2.TabIndex = 39;
            this.label2.Text = "SELECIONE O VEÍCULO (PLACA):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 16);
            this.label1.TabIndex = 38;
            this.label1.Text = "SELECIONE O CLIENTE(CPF):";
            // 
            // cbPlaca
            // 
            this.cbPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPlaca.FormattingEnabled = true;
            this.cbPlaca.Location = new System.Drawing.Point(12, 108);
            this.cbPlaca.Name = "cbPlaca";
            this.cbPlaca.Size = new System.Drawing.Size(386, 28);
            this.cbPlaca.TabIndex = 37;
            // 
            // cbCpf
            // 
            this.cbCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCpf.FormattingEnabled = true;
            this.cbCpf.Location = new System.Drawing.Point(12, 40);
            this.cbCpf.Name = "cbCpf";
            this.cbCpf.Size = new System.Drawing.Size(386, 28);
            this.cbCpf.TabIndex = 36;
            this.cbCpf.SelectedIndexChanged += new System.EventHandler(this.cbCpf_SelectedIndexChanged);
            // 
            // btBuscarCliente
            // 
            this.btBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscarCliente.Location = new System.Drawing.Point(416, 40);
            this.btBuscarCliente.Name = "btBuscarCliente";
            this.btBuscarCliente.Size = new System.Drawing.Size(215, 28);
            this.btBuscarCliente.TabIndex = 40;
            this.btBuscarCliente.Text = "BUSCAR POR CLIENTE ";
            this.btBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // btBuscarPlaca
            // 
            this.btBuscarPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscarPlaca.Location = new System.Drawing.Point(416, 77);
            this.btBuscarPlaca.Name = "btBuscarPlaca";
            this.btBuscarPlaca.Size = new System.Drawing.Size(215, 28);
            this.btBuscarPlaca.TabIndex = 41;
            this.btBuscarPlaca.Text = "BUSCAR POR VEÍCULO";
            this.btBuscarPlaca.UseVisualStyleBackColor = true;
            // 
            // btClientePlaca
            // 
            this.btClientePlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClientePlaca.Location = new System.Drawing.Point(416, 117);
            this.btClientePlaca.Name = "btClientePlaca";
            this.btClientePlaca.Size = new System.Drawing.Size(215, 28);
            this.btClientePlaca.TabIndex = 42;
            this.btClientePlaca.Text = "BUSCAR POR CLIENTE/VEÍCULO";
            this.btClientePlaca.UseVisualStyleBackColor = true;
            // 
            // btNovaConsulta
            // 
            this.btNovaConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovaConsulta.Location = new System.Drawing.Point(416, 151);
            this.btNovaConsulta.Name = "btNovaConsulta";
            this.btNovaConsulta.Size = new System.Drawing.Size(215, 28);
            this.btNovaConsulta.TabIndex = 43;
            this.btNovaConsulta.Text = "NOVA CONSULTA";
            this.btNovaConsulta.UseVisualStyleBackColor = true;
            // 
            // FormConsultarVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 500);
            this.Controls.Add(this.btNovaConsulta);
            this.Controls.Add(this.btClientePlaca);
            this.Controls.Add(this.btBuscarPlaca);
            this.Controls.Add(this.btBuscarCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPlaca);
            this.Controls.Add(this.cbCpf);
            this.Controls.Add(this.dgvTabela);
            this.Name = "FormConsultarVendas";
            this.Text = "FormConsultarVendas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTabela;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPlaca;
        private System.Windows.Forms.ComboBox cbCpf;
        private System.Windows.Forms.Button btBuscarCliente;
        private System.Windows.Forms.Button btBuscarPlaca;
        private System.Windows.Forms.Button btClientePlaca;
        private System.Windows.Forms.Button btNovaConsulta;
    }
}