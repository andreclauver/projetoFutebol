
namespace ControleDeCursos
{
    partial class FrmTurmas
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
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTime_Inicio = new System.Windows.Forms.DateTimePicker();
            this.dateTime_Termino = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.btn_Listar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_HoraInicio = new System.Windows.Forms.TextBox();
            this.txt_HoraTerimino = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_Curso = new System.Windows.Forms.ComboBox();
            this.comboBox_Professor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Location = new System.Drawing.Point(116, 6);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(100, 20);
            this.txt_Codigo.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Código da Turma:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Data de Término:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Data de Início:";
            // 
            // dateTime_Inicio
            // 
            this.dateTime_Inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime_Inicio.Location = new System.Drawing.Point(116, 40);
            this.dateTime_Inicio.Name = "dateTime_Inicio";
            this.dateTime_Inicio.Size = new System.Drawing.Size(100, 20);
            this.dateTime_Inicio.TabIndex = 15;
            // 
            // dateTime_Termino
            // 
            this.dateTime_Termino.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime_Termino.Location = new System.Drawing.Point(347, 40);
            this.dateTime_Termino.Name = "dateTime_Termino";
            this.dateTime_Termino.Size = new System.Drawing.Size(100, 20);
            this.dateTime_Termino.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Hora de Início:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Hora: de Término:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_cadastrar);
            this.panel1.Controls.Add(this.btn_Alterar);
            this.panel1.Controls.Add(this.btn_Listar);
            this.panel1.Controls.Add(this.btn_Excluir);
            this.panel1.Location = new System.Drawing.Point(15, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 57);
            this.panel1.TabIndex = 21;
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(27, 13);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(90, 30);
            this.btn_cadastrar.TabIndex = 6;
            this.btn_cadastrar.Text = "CADASTRAR ";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.Location = new System.Drawing.Point(123, 13);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(90, 30);
            this.btn_Alterar.TabIndex = 7;
            this.btn_Alterar.Text = "ALTERAR";
            this.btn_Alterar.UseVisualStyleBackColor = true;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // btn_Listar
            // 
            this.btn_Listar.Location = new System.Drawing.Point(318, 13);
            this.btn_Listar.Name = "btn_Listar";
            this.btn_Listar.Size = new System.Drawing.Size(90, 30);
            this.btn_Listar.TabIndex = 9;
            this.btn_Listar.Text = "LISTAR";
            this.btn_Listar.UseVisualStyleBackColor = true;
            this.btn_Listar.Click += new System.EventHandler(this.btn_Listar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Location = new System.Drawing.Point(222, 13);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(90, 30);
            this.btn_Excluir.TabIndex = 8;
            this.btn_Excluir.Text = "EXCLUIR";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 228);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(432, 150);
            this.dataGridView1.TabIndex = 22;
            // 
            // txt_HoraInicio
            // 
            this.txt_HoraInicio.Location = new System.Drawing.Point(116, 78);
            this.txt_HoraInicio.Name = "txt_HoraInicio";
            this.txt_HoraInicio.Size = new System.Drawing.Size(100, 20);
            this.txt_HoraInicio.TabIndex = 23;
            // 
            // txt_HoraTerimino
            // 
            this.txt_HoraTerimino.Location = new System.Drawing.Point(347, 78);
            this.txt_HoraTerimino.Name = "txt_HoraTerimino";
            this.txt_HoraTerimino.Size = new System.Drawing.Size(100, 20);
            this.txt_HoraTerimino.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(291, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Curso:";
            // 
            // comboBox_Curso
            // 
            this.comboBox_Curso.FormattingEnabled = true;
            this.comboBox_Curso.Location = new System.Drawing.Point(347, 5);
            this.comboBox_Curso.Name = "comboBox_Curso";
            this.comboBox_Curso.Size = new System.Drawing.Size(100, 21);
            this.comboBox_Curso.TabIndex = 26;
            // 
            // comboBox_Professor
            // 
            this.comboBox_Professor.FormattingEnabled = true;
            this.comboBox_Professor.Location = new System.Drawing.Point(116, 114);
            this.comboBox_Professor.Name = "comboBox_Professor";
            this.comboBox_Professor.Size = new System.Drawing.Size(100, 21);
            this.comboBox_Professor.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Professor(a):";
            // 
            // FrmTurmas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(460, 394);
            this.Controls.Add(this.comboBox_Professor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox_Curso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_HoraTerimino);
            this.Controls.Add(this.txt_HoraInicio);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTime_Termino);
            this.Controls.Add(this.dateTime_Inicio);
            this.Controls.Add(this.txt_Codigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Name = "FrmTurmas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Protótipo - TURMAS";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTime_Inicio;
        private System.Windows.Forms.DateTimePicker dateTime_Termino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.Button btn_Listar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_HoraInicio;
        private System.Windows.Forms.TextBox txt_HoraTerimino;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_Curso;
        private System.Windows.Forms.ComboBox comboBox_Professor;
        private System.Windows.Forms.Label label7;
    }
}