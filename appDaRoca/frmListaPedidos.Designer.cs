using System.Data;

namespace appDaRoca
{
    partial class frmListaPedidos
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
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedidosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bD23149DataSet = new appDaRoca.BD23149DataSet();
            this.btnGerarRota = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisarPedidos = new System.Windows.Forms.TextBox();
            this.btnPesquisarPedidos = new System.Windows.Forms.Button();
            this.pedidosTableAdapter = new appDaRoca.BD23149DataSetTableAdapters.PedidosTableAdapter();
            this.pedidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD23149DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLista
            // 
            this.dgvLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLista.AutoGenerateColumns = false;
            this.dgvLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgvLista.DataSource = this.pedidosBindingSource1;
            this.dgvLista.Location = new System.Drawing.Point(12, 278);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.Size = new System.Drawing.Size(810, 221);
            this.dgvLista.TabIndex = 0;
            this.dgvLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idPedidos";
            this.dataGridViewTextBoxColumn1.HeaderText = "idPedidos";
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "idCliente";
            this.dataGridViewTextBoxColumn3.HeaderText = "idCliente";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "horaFeito";
            this.dataGridViewTextBoxColumn4.HeaderText = "horaFeito";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "dataEstimada";
            this.dataGridViewTextBoxColumn5.HeaderText = "dataEstimada";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "status";
            this.dataGridViewTextBoxColumn6.HeaderText = "status";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
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
            // btnGerarRota
            // 
            this.btnGerarRota.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGerarRota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnGerarRota.Location = new System.Drawing.Point(724, 207);
            this.btnGerarRota.Name = "btnGerarRota";
            this.btnGerarRota.Size = new System.Drawing.Size(98, 45);
            this.btnGerarRota.TabIndex = 1;
            this.btnGerarRota.Text = "Gerar Rota";
            this.btnGerarRota.UseVisualStyleBackColor = false;
            this.btnGerarRota.Click += new System.EventHandler(this.btnGerarRota_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Cooper Black", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(169, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 57);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pedidos do Dia";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPesquisarPedidos
            // 
            this.txtPesquisarPedidos.BackColor = System.Drawing.SystemColors.Window;
            this.txtPesquisarPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtPesquisarPedidos.Location = new System.Drawing.Point(12, 227);
            this.txtPesquisarPedidos.Multiline = true;
            this.txtPesquisarPedidos.Name = "txtPesquisarPedidos";
            this.txtPesquisarPedidos.Size = new System.Drawing.Size(414, 25);
            this.txtPesquisarPedidos.TabIndex = 3;
            this.txtPesquisarPedidos.Text = "Digite aqui o ID completo do pedido";
            this.txtPesquisarPedidos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPesquisarPedidos_MouseClick);
            this.txtPesquisarPedidos.TextChanged += new System.EventHandler(this.txtPesquisarPedidos_TextChanged);
            // 
            // btnPesquisarPedidos
            // 
            this.btnPesquisarPedidos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnPesquisarPedidos.Location = new System.Drawing.Point(432, 227);
            this.btnPesquisarPedidos.Name = "btnPesquisarPedidos";
            this.btnPesquisarPedidos.Size = new System.Drawing.Size(75, 25);
            this.btnPesquisarPedidos.TabIndex = 4;
            this.btnPesquisarPedidos.Text = "Pesquisar";
            this.btnPesquisarPedidos.UseVisualStyleBackColor = false;
            this.btnPesquisarPedidos.Click += new System.EventHandler(this.btnPesquisarPedidos_Click);
            // 
            // pedidosTableAdapter
            // 
            this.pedidosTableAdapter.ClearBeforeFill = true;
            // 
            // pedidosBindingSource
            // 
            this.pedidosBindingSource.DataMember = "Pedidos";
            // 
            // frmListaPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.btnPesquisarPedidos);
            this.Controls.Add(this.txtPesquisarPedidos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGerarRota);
            this.Controls.Add(this.dgvLista);
            this.Name = "frmListaPedidos";
            this.Text = "DaRoça";
            this.Load += new System.EventHandler(this.FrmListaPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD23149DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Button btnGerarRota;
        private System.Windows.Forms.Label label1;
        private DataSet dataSet1;
        private System.Windows.Forms.BindingSource pedidosBindingSource;
        
        private System.Windows.Forms.DataGridViewTextBoxColumn idPedidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCentroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaFeitoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEstimadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtPesquisarPedidos;
        private System.Windows.Forms.Button btnPesquisarPedidos;
        private BD23149DataSet bD23149DataSet;
        private System.Windows.Forms.BindingSource pedidosBindingSource1;
        private BD23149DataSetTableAdapters.PedidosTableAdapter pedidosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}
