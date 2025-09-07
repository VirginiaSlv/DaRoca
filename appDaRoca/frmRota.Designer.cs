namespace appDaRoca
{
    partial class frmRota
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbCentro = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtCentro = new System.Windows.Forms.TextBox();
            this.lbRotas = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(40)))));
            this.label1.Font = new System.Drawing.Font("Georgia", 16F);
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(31, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data:";
            // 
            // lbCentro
            // 
            this.lbCentro.AutoSize = true;
            this.lbCentro.Font = new System.Drawing.Font("Georgia", 16F);
            this.lbCentro.ForeColor = System.Drawing.Color.Coral;
            this.lbCentro.Location = new System.Drawing.Point(26, 344);
            this.lbCentro.Name = "lbCentro";
            this.lbCentro.Size = new System.Drawing.Size(86, 27);
            this.lbCentro.TabIndex = 1;
            this.lbCentro.Text = "Centro:";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(118, 221);
            this.txtData.Name = "txtData";
            this.txtData.ReadOnly = true;
            this.txtData.Size = new System.Drawing.Size(200, 26);
            this.txtData.TabIndex = 3;
            // 
            // txtCentro
            // 
            this.txtCentro.Location = new System.Drawing.Point(118, 345);
            this.txtCentro.Name = "txtCentro";
            this.txtCentro.ReadOnly = true;
            this.txtCentro.Size = new System.Drawing.Size(200, 26);
            this.txtCentro.TabIndex = 4;
            // 
            // lbRotas
            // 
            this.lbRotas.FormattingEnabled = true;
            this.lbRotas.ItemHeight = 20;
            this.lbRotas.Location = new System.Drawing.Point(374, 47);
            this.lbRotas.Name = "lbRotas";
            this.lbRotas.ScrollAlwaysVisible = true;
            this.lbRotas.Size = new System.Drawing.Size(427, 424);
            this.lbRotas.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(17, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "< Inicio";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(40)))));
            this.label2.Font = new System.Drawing.Font("Cooper Black", 30F);
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(132, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 46);
            this.label2.TabIndex = 8;
            this.label2.Text = "Rotas:";
            // 
            // frmRota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbRotas);
            this.Controls.Add(this.txtCentro);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.lbCentro);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmRota";
            this.Text = "DaRoca";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCentro;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtCentro;
        private System.Windows.Forms.ListBox lbRotas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}
