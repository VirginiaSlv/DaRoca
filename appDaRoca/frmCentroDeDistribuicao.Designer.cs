namespace appDaRoca
{
    partial class frmCentroDeDistribuicao
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCompartilharCentros = new System.Windows.Forms.Button();
            this.Apoiam = new System.Windows.Forms.ListBox();
            this.btnVoltarInicial = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Apoiados = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDesfazerCompartilhamento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCompartilharCentros
            // 
            this.btnCompartilharCentros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompartilharCentros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCompartilharCentros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompartilharCentros.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCompartilharCentros.Location = new System.Drawing.Point(564, 421);
            this.btnCompartilharCentros.Name = "btnCompartilharCentros";
            this.btnCompartilharCentros.Size = new System.Drawing.Size(145, 55);
            this.btnCompartilharCentros.TabIndex = 0;
            this.btnCompartilharCentros.Text = "Compartilhar Serviços";
            this.btnCompartilharCentros.UseVisualStyleBackColor = false;
            this.btnCompartilharCentros.Click += new System.EventHandler(this.btnCompartilharCentros_Click);
            // 
            // Apoiam
            // 
            this.Apoiam.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apoiam.FormattingEnabled = true;
            this.Apoiam.ItemHeight = 37;
            this.Apoiam.Location = new System.Drawing.Point(68, 145);
            this.Apoiam.Name = "Apoiam";
            this.Apoiam.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.Apoiam.Size = new System.Drawing.Size(260, 189);
            this.Apoiam.TabIndex = 4;
            this.Apoiam.SelectedIndexChanged += new System.EventHandler(this.Apoiam_SelectedIndexChanged);
            // 
            // btnVoltarInicial
            // 
            this.btnVoltarInicial.ForeColor = System.Drawing.Color.Black;
            this.btnVoltarInicial.Location = new System.Drawing.Point(12, 12);
            this.btnVoltarInicial.Name = "btnVoltarInicial";
            this.btnVoltarInicial.Size = new System.Drawing.Size(75, 23);
            this.btnVoltarInicial.TabIndex = 2;
            this.btnVoltarInicial.Text = "Voltar";
            this.btnVoltarInicial.UseVisualStyleBackColor = true;
            this.btnVoltarInicial.Click += new System.EventHandler(this.btnVoltarInicial_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(210, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Centros de Distribuição";
            // 
            // Apoiados
            // 
            this.Apoiados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Apoiados.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apoiados.FormattingEnabled = true;
            this.Apoiados.ItemHeight = 37;
            this.Apoiados.Location = new System.Drawing.Point(509, 145);
            this.Apoiados.Name = "Apoiados";
            this.Apoiados.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.Apoiados.Size = new System.Drawing.Size(250, 189);
            this.Apoiados.TabIndex = 5;
            this.Apoiados.SelectedIndexChanged += new System.EventHandler(this.Apoiados_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(520, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Centros que Compartilham:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(38, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(350, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Centros que recebem compartlhamento:";
            // 
            // btnDesfazerCompartilhamento
            // 
            this.btnDesfazerCompartilhamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDesfazerCompartilhamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnDesfazerCompartilhamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesfazerCompartilhamento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDesfazerCompartilhamento.Location = new System.Drawing.Point(123, 420);
            this.btnDesfazerCompartilhamento.Name = "btnDesfazerCompartilhamento";
            this.btnDesfazerCompartilhamento.Size = new System.Drawing.Size(153, 56);
            this.btnDesfazerCompartilhamento.TabIndex = 8;
            this.btnDesfazerCompartilhamento.Text = "Desfazer Compartilhamento";
            this.btnDesfazerCompartilhamento.UseVisualStyleBackColor = false;
            this.btnDesfazerCompartilhamento.Click += new System.EventHandler(this.btnDesfazerCompartilhamento_Click_1);
            // 
            // frmCentroDeDistribuicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.btnDesfazerCompartilhamento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Apoiados);
            this.Controls.Add(this.Apoiam);
            this.Controls.Add(this.btnCompartilharCentros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVoltarInicial);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.Name = "frmCentroDeDistribuicao";
            this.Text = "Centros de Distribuição";
            this.Load += new System.EventHandler(this.frmCentroDeDistribuicao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCompartilharCentros;
        private System.Windows.Forms.Button btnVoltarInicial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Apoiam;
        private System.Windows.Forms.ListBox Apoiados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDesfazerCompartilhamento;
    }
}
