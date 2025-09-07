namespace appDaRoca
{
    partial class frmInicio
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
            this.gpHistorico = new System.Windows.Forms.GroupBox();
            this.btnNovaProg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvHistorico = new System.Windows.Forms.DataGridView();
            this.pedidosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bD23149DataSet = new appDaRoca.BD23149DataSet();
            this.pedidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD23149DataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motoristasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centrosDeDistribuiçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosTableAdapter = new appDaRoca.BD23149DataSetTableAdapters.PedidosTableAdapter();
            this.bD23149DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.centroDeDistribuicaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.centroDeDistribuicaoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.centroDeDistribuicaoTableAdapter = new appDaRoca.BD23149DataSetTableAdapters.CentroDeDistribuicaoTableAdapter();
            this.gpHistorico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD23149DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD23149DataSetBindingSource1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bD23149DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.centroDeDistribuicaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.centroDeDistribuicaoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // gpHistorico
            // 
            this.gpHistorico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpHistorico.Controls.Add(this.btnNovaProg);
            this.gpHistorico.Controls.Add(this.label1);
            this.gpHistorico.Controls.Add(this.dgvHistorico);
            this.gpHistorico.Font = new System.Drawing.Font("Georgia", 15F);
            this.gpHistorico.ForeColor = System.Drawing.Color.Coral;
            this.gpHistorico.Location = new System.Drawing.Point(12, 57);
            this.gpHistorico.Name = "gpHistorico";
            this.gpHistorico.Size = new System.Drawing.Size(810, 442);
            this.gpHistorico.TabIndex = 0;
            this.gpHistorico.TabStop = false;
            this.gpHistorico.Text = "Histórico de Entregas";
            // 
            // btnNovaProg
            // 
            this.btnNovaProg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovaProg.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnNovaProg.Location = new System.Drawing.Point(712, 365);
            this.btnNovaProg.Name = "btnNovaProg";
            this.btnNovaProg.Size = new System.Drawing.Size(65, 65);
            this.btnNovaProg.TabIndex = 1;
            this.btnNovaProg.Text = "+";
            this.btnNovaProg.UseVisualStyleBackColor = true;
            this.btnNovaProg.Click += new System.EventHandler(this.btnNovaProg_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Criar Nova Programação:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvHistorico
            // 
            this.dgvHistorico.AllowUserToAddRows = false;
            this.dgvHistorico.AllowUserToDeleteRows = false;
            this.dgvHistorico.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHistorico.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorico.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvHistorico.Location = new System.Drawing.Point(6, 66);
            this.dgvHistorico.Name = "dgvHistorico";
            this.dgvHistorico.ReadOnly = true;
            this.dgvHistorico.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvHistorico.Size = new System.Drawing.Size(786, 270);
            this.dgvHistorico.TabIndex = 1;
            this.dgvHistorico.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistorico_CellContentClick);
            // 
            // pedidosBindingSource1
            // 
            this.pedidosBindingSource1.DataMember = "Pedidos";
            this.pedidosBindingSource1.DataSource = this.bD23149DataSet;
            // 
            // bD23149DataSet
            // 
            this.bD23149DataSet.DataSetName = "BD23149DataSet";
            this.bD23149DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pedidosBindingSource
            // 
            this.pedidosBindingSource.DataMember = "Pedidos";
            this.pedidosBindingSource.DataSource = this.bD23149DataSetBindingSource1;
            // 
            // bD23149DataSetBindingSource1
            // 
            this.bD23149DataSetBindingSource1.DataSource = this.bD23149DataSet;
            this.bD23149DataSetBindingSource1.Position = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.motoristasToolStripMenuItem,
            this.centrosDeDistribuiçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(834, 29);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(59, 25);
            this.inicioToolStripMenuItem.Text = "Início";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // motoristasToolStripMenuItem
            // 
            this.motoristasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.motoristasToolStripMenuItem.Name = "motoristasToolStripMenuItem";
            this.motoristasToolStripMenuItem.Size = new System.Drawing.Size(96, 25);
            this.motoristasToolStripMenuItem.Text = "Motoristas";
            this.motoristasToolStripMenuItem.Click += new System.EventHandler(this.motoristasToolStripMenuItem_Click);
            // 
            // centrosDeDistribuiçõesToolStripMenuItem
            // 
            this.centrosDeDistribuiçõesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.centrosDeDistribuiçõesToolStripMenuItem.Name = "centrosDeDistribuiçõesToolStripMenuItem";
            this.centrosDeDistribuiçõesToolStripMenuItem.Size = new System.Drawing.Size(191, 25);
            this.centrosDeDistribuiçõesToolStripMenuItem.Text = "Centros de Distribuições";
            this.centrosDeDistribuiçõesToolStripMenuItem.Click += new System.EventHandler(this.centrosDeDistribuiçõesToolStripMenuItem_Click);
            // 
            // pedidosTableAdapter
            // 
            this.pedidosTableAdapter.ClearBeforeFill = true;
            // 
            // centroDeDistribuicaoBindingSource
            // 
            this.centroDeDistribuicaoBindingSource.DataMember = "CentroDeDistribuicao";
            // 
            // centroDeDistribuicaoBindingSource1
            // 
            this.centroDeDistribuicaoBindingSource1.DataMember = "CentroDeDistribuicao";
            this.centroDeDistribuicaoBindingSource1.DataSource = this.bD23149DataSet;
            // 
            // centroDeDistribuicaoTableAdapter
            // 
            this.centroDeDistribuicaoTableAdapter.ClearBeforeFill = true;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gpHistorico);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmInicio";
            this.Text = "DaRoça";
            this.Load += new System.EventHandler(this.FrmInicio_Load);
            this.gpHistorico.ResumeLayout(false);
            this.gpHistorico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD23149DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD23149DataSetBindingSource1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bD23149DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.centroDeDistribuicaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.centroDeDistribuicaoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpHistorico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNovaProg;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motoristasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centrosDeDistribuiçõesToolStripMenuItem;
        private System.Windows.Forms.BindingSource bD23149DataSetBindingSource;
        /*private BD23149DataSet bD23149DataSet;
        private BD23149DataSet1 bD23149DataSet1;*/
        private System.Windows.Forms.BindingSource centroDeDistribuicaoBindingSource;
        //private BD23149DataSet1TableAdapters.CentroDeDistribuicaoTableAdapter centroDeDistribuicaoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCentroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn cidadeDataGridViewButtonColumn;
        private System.Windows.Forms.DataGridView dgvHistorico;
        private System.Windows.Forms.BindingSource bD23149DataSetBindingSource1;
        private BD23149DataSet bD23149DataSet;
        private System.Windows.Forms.BindingSource pedidosBindingSource;
        private BD23149DataSetTableAdapters.PedidosTableAdapter pedidosTableAdapter;
        private System.Windows.Forms.BindingSource centroDeDistribuicaoBindingSource1;
        private BD23149DataSetTableAdapters.CentroDeDistribuicaoTableAdapter centroDeDistribuicaoTableAdapter;
        private System.Windows.Forms.BindingSource pedidosBindingSource1;
    }
}
