namespace appDaRoca
{
    partial class frmMotoristas
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
            this.components = new System.ComponentModel.Container();
            this.dgvMotoristas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motoristasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD23149DataSet = new appDaRoca.BD23149DataSet();
            this.txtPesquisaMotorista = new System.Windows.Forms.TextBox();
            this.btnPesquisaMotorista = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.motoristasTableAdapter = new appDaRoca.BD23149DataSetTableAdapters.MotoristasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMotoristas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motoristasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD23149DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMotoristas
            // 
            this.dgvMotoristas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMotoristas.AutoGenerateColumns = false;
            this.dgvMotoristas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMotoristas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvMotoristas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dgvMotoristas.DataSource = this.motoristasBindingSource;
            this.dgvMotoristas.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvMotoristas.Location = new System.Drawing.Point(35, 179);
            this.dgvMotoristas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvMotoristas.Name = "dgvMotoristas";
            this.dgvMotoristas.Size = new System.Drawing.Size(757, 303);
            this.dgvMotoristas.TabIndex = 0;
            /*this.dgvMotoristas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);*/
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idMotoristas";
            this.dataGridViewTextBoxColumn1.HeaderText = "idMotoristas";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "idCentro";
            this.dataGridViewTextBoxColumn2.HeaderText = "idCentro";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nome";
            this.dataGridViewTextBoxColumn3.HeaderText = "nome";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "horaInicio";
            this.dataGridViewTextBoxColumn4.HeaderText = "horaInicio";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "horaFim";
            this.dataGridViewTextBoxColumn5.HeaderText = "horaFim";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "inicioIntervalo";
            this.dataGridViewTextBoxColumn6.HeaderText = "inicioIntervalo";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "fimIntervalo";
            this.dataGridViewTextBoxColumn7.HeaderText = "fimIntervalo";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "velocidade";
            this.dataGridViewTextBoxColumn8.HeaderText = "velocidade";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // motoristasBindingSource
            // 
            this.motoristasBindingSource.DataMember = "Motoristas";
            this.motoristasBindingSource.DataSource = this.bD23149DataSet;
            // 
            // bD23149DataSet
            // 
            this.bD23149DataSet.DataSetName = "BD23149DataSet";
            this.bD23149DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtPesquisaMotorista
            // 
            this.txtPesquisaMotorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaMotorista.Location = new System.Drawing.Point(35, 125);
            this.txtPesquisaMotorista.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPesquisaMotorista.Multiline = true;
            this.txtPesquisaMotorista.Name = "txtPesquisaMotorista";
            this.txtPesquisaMotorista.Size = new System.Drawing.Size(490, 27);
            this.txtPesquisaMotorista.TabIndex = 1;
            this.txtPesquisaMotorista.Text = "Digite aqui o ID do motorista desejado";
            this.txtPesquisaMotorista.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPesquisaMotorista_MouseClick);
            /*this.txtPesquisaMotorista.TextChanged += new System.EventHandler(this.txtPesquisaMotorista_TextChanged);*/
            // 
            // btnPesquisaMotorista
            // 
            this.btnPesquisaMotorista.Location = new System.Drawing.Point(560, 125);
            this.btnPesquisaMotorista.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPesquisaMotorista.Name = "btnPesquisaMotorista";
            this.btnPesquisaMotorista.Size = new System.Drawing.Size(92, 27);
            this.btnPesquisaMotorista.TabIndex = 2;
            this.btnPesquisaMotorista.Text = "Pesquisar";
            this.btnPesquisaMotorista.UseVisualStyleBackColor = true;
            this.btnPesquisaMotorista.Click += new System.EventHandler(this.btnPesquisaMotorista_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(263, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 71);
            this.label1.TabIndex = 3;
            this.label1.Text = "Motoristas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(15, 14);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(88, 25);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // motoristasTableAdapter
            // 
            this.motoristasTableAdapter.ClearBeforeFill = true;
            // 
            // frmMotoristas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPesquisaMotorista);
            this.Controls.Add(this.txtPesquisaMotorista);
            this.Controls.Add(this.dgvMotoristas);
            this.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmMotoristas";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Motoristas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            /*this.Load += new System.EventHandler(this.FrmMotoristas_Load_1);*/
            ((System.ComponentModel.ISupportInitialize)(this.dgvMotoristas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motoristasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD23149DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMotoristas;
        private System.Windows.Forms.TextBox txtPesquisaMotorista;
        private System.Windows.Forms.Button btnPesquisaMotorista;
        private System.Windows.Forms.BindingSource bD23149DataSetBindingSource;
        //private BD23149DataSet bD23149DataSet;
        // private System.Windows.Forms./motoristasBindingSource;
        // private BD23149DataSetTableAdapters.MotoristasTableAdapter motoristasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMotoristasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCentroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaFimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inicioIntervaloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fimIntervaloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn velocidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoltar;
        private BD23149DataSet bD23149DataSet;
        private System.Windows.Forms.BindingSource motoristasBindingSource;
        private BD23149DataSetTableAdapters.MotoristasTableAdapter motoristasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }

}