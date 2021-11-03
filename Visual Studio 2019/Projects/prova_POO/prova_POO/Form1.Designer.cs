namespace prova_POO
{
    partial class Form1
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
            this.nome_txt = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.desc_txt = new System.Windows.Forms.TextBox();
            this.qnt_txt = new System.Windows.Forms.TextBox();
            this.valun_txt = new System.Windows.Forms.TextBox();
            this.cod_txt = new System.Windows.Forms.TextBox();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dataFab_txt = new System.Windows.Forms.TextBox();
            this.dataVal_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_listar = new System.Windows.Forms.Button();
            this.dtgProduto = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // nome_txt
            // 
            this.nome_txt.Location = new System.Drawing.Point(50, 36);
            this.nome_txt.Name = "nome_txt";
            this.nome_txt.Size = new System.Drawing.Size(100, 20);
            this.nome_txt.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descricao";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(399, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(536, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Valor Unitario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(706, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Codigo";
            // 
            // desc_txt
            // 
            this.desc_txt.Location = new System.Drawing.Point(209, 36);
            this.desc_txt.Name = "desc_txt";
            this.desc_txt.Size = new System.Drawing.Size(100, 20);
            this.desc_txt.TabIndex = 7;
            // 
            // qnt_txt
            // 
            this.qnt_txt.Location = new System.Drawing.Point(376, 36);
            this.qnt_txt.Name = "qnt_txt";
            this.qnt_txt.Size = new System.Drawing.Size(100, 20);
            this.qnt_txt.TabIndex = 8;
            // 
            // valun_txt
            // 
            this.valun_txt.Location = new System.Drawing.Point(523, 36);
            this.valun_txt.Name = "valun_txt";
            this.valun_txt.Size = new System.Drawing.Size(100, 20);
            this.valun_txt.TabIndex = 9;
            // 
            // cod_txt
            // 
            this.cod_txt.Location = new System.Drawing.Point(676, 36);
            this.cod_txt.Name = "cod_txt";
            this.cod_txt.Size = new System.Drawing.Size(100, 20);
            this.cod_txt.TabIndex = 10;
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(45, 287);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(100, 39);
            this.btn_cadastrar.TabIndex = 11;
            this.btn_cadastrar.Text = "cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Data de fabricacao";
            // 
            // dataFab_txt
            // 
            this.dataFab_txt.Location = new System.Drawing.Point(50, 198);
            this.dataFab_txt.Name = "dataFab_txt";
            this.dataFab_txt.Size = new System.Drawing.Size(100, 20);
            this.dataFab_txt.TabIndex = 13;
            // 
            // dataVal_txt
            // 
            this.dataVal_txt.Location = new System.Drawing.Point(209, 198);
            this.dataVal_txt.Name = "dataVal_txt";
            this.dataVal_txt.Size = new System.Drawing.Size(100, 20);
            this.dataVal_txt.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(206, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Data de validade";
            // 
            // btn_listar
            // 
            this.btn_listar.Location = new System.Drawing.Point(209, 287);
            this.btn_listar.Name = "btn_listar";
            this.btn_listar.Size = new System.Drawing.Size(85, 39);
            this.btn_listar.TabIndex = 16;
            this.btn_listar.Text = "listar";
            this.btn_listar.UseVisualStyleBackColor = true;
            this.btn_listar.Click += new System.EventHandler(this.btn_listar_Click);
            // 
            // dtgProduto
            // 
            this.dtgProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProduto.Location = new System.Drawing.Point(421, 162);
            this.dtgProduto.Name = "dtgProduto";
            this.dtgProduto.Size = new System.Drawing.Size(325, 255);
            this.dtgProduto.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgProduto);
            this.Controls.Add(this.btn_listar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataVal_txt);
            this.Controls.Add(this.dataFab_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.cod_txt);
            this.Controls.Add(this.valun_txt);
            this.Controls.Add(this.qnt_txt);
            this.Controls.Add(this.desc_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nome_txt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nome_txt;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox desc_txt;
        private System.Windows.Forms.TextBox qnt_txt;
        private System.Windows.Forms.TextBox valun_txt;
        private System.Windows.Forms.TextBox cod_txt;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox dataFab_txt;
        private System.Windows.Forms.TextBox dataVal_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_listar;
        private System.Windows.Forms.DataGridView dtgProduto;
    }
}

