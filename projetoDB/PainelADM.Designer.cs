namespace projetoDB
{
    partial class PainelADM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PainelADM));
            this.label3 = new System.Windows.Forms.Label();
            this.usuario = new System.Windows.Forms.TextBox();
            this.deletar = new System.Windows.Forms.Button();
            this.deletarTudo = new System.Windows.Forms.Button();
            this.voltar = new System.Windows.Forms.Button();
            this.Consultar = new System.Windows.Forms.TextBox();
            this.buscarusuario = new System.Windows.Forms.Button();
            this.Ferramentas = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Listar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Adicionar = new System.Windows.Forms.Button();
            this.Ferramentas.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "LOGIN OU EMAIL";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // usuario
            // 
            this.usuario.Location = new System.Drawing.Point(26, 70);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(181, 22);
            this.usuario.TabIndex = 3;
            // 
            // deletar
            // 
            this.deletar.Location = new System.Drawing.Point(26, 120);
            this.deletar.Name = "deletar";
            this.deletar.Size = new System.Drawing.Size(181, 23);
            this.deletar.TabIndex = 4;
            this.deletar.Text = "Deletar";
            this.deletar.UseVisualStyleBackColor = true;
            this.deletar.Click += new System.EventHandler(this.deletar_Click);
            // 
            // deletarTudo
            // 
            this.deletarTudo.Location = new System.Drawing.Point(6, 32);
            this.deletarTudo.Name = "deletarTudo";
            this.deletarTudo.Size = new System.Drawing.Size(230, 23);
            this.deletarTudo.TabIndex = 5;
            this.deletarTudo.Text = "Deletar tudo";
            this.deletarTudo.UseVisualStyleBackColor = true;
            this.deletarTudo.Click += new System.EventHandler(this.deletarTudo_Click);
            // 
            // voltar
            // 
            this.voltar.Location = new System.Drawing.Point(24, 570);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(75, 23);
            this.voltar.TabIndex = 6;
            this.voltar.Text = "Voltar";
            this.voltar.UseVisualStyleBackColor = true;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // Consultar
            // 
            this.Consultar.Location = new System.Drawing.Point(16, 60);
            this.Consultar.Name = "Consultar";
            this.Consultar.Size = new System.Drawing.Size(181, 22);
            this.Consultar.TabIndex = 9;
            // 
            // buscarusuario
            // 
            this.buscarusuario.Location = new System.Drawing.Point(16, 106);
            this.buscarusuario.Name = "buscarusuario";
            this.buscarusuario.Size = new System.Drawing.Size(181, 23);
            this.buscarusuario.TabIndex = 10;
            this.buscarusuario.Text = "Buscar";
            this.buscarusuario.UseVisualStyleBackColor = true;
            this.buscarusuario.Click += new System.EventHandler(this.buscarusuario_Click);
            // 
            // Ferramentas
            // 
            this.Ferramentas.Controls.Add(this.groupBox5);
            this.Ferramentas.Controls.Add(this.groupBox4);
            this.Ferramentas.Controls.Add(this.groupBox3);
            this.Ferramentas.Controls.Add(this.groupBox2);
            this.Ferramentas.Controls.Add(this.groupBox1);
            this.Ferramentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ferramentas.Location = new System.Drawing.Point(24, 21);
            this.Ferramentas.Name = "Ferramentas";
            this.Ferramentas.Size = new System.Drawing.Size(1027, 543);
            this.Ferramentas.TabIndex = 11;
            this.Ferramentas.TabStop = false;
            this.Ferramentas.Text = "Ferramentas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.deletar);
            this.groupBox1.Controls.Add(this.usuario);
            this.groupBox1.Location = new System.Drawing.Point(525, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 165);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Remover Usuario";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Consultar);
            this.groupBox2.Controls.Add(this.buscarusuario);
            this.groupBox2.Location = new System.Drawing.Point(39, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 165);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "LOGIN OU EMAIL";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(23, 205);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(985, 320);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lista de clientes";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(939, 283);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.Listar);
            this.groupBox4.Controls.Add(this.deletarTudo);
            this.groupBox4.Location = new System.Drawing.Point(277, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(242, 165);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Listar Usuarios";
            // 
            // Listar
            // 
            this.Listar.Location = new System.Drawing.Point(6, 106);
            this.Listar.Name = "Listar";
            this.Listar.Size = new System.Drawing.Size(230, 23);
            this.Listar.TabIndex = 0;
            this.Listar.Text = "Listar";
            this.Listar.UseVisualStyleBackColor = true;
            this.Listar.Click += new System.EventHandler(this.Listar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Buscar Todos";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.Adicionar);
            this.groupBox5.Location = new System.Drawing.Point(771, 21);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(226, 165);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Cadastra Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Adicionar  Novo Usuario";
            // 
            // Adicionar
            // 
            this.Adicionar.Location = new System.Drawing.Point(26, 91);
            this.Adicionar.Name = "Adicionar";
            this.Adicionar.Size = new System.Drawing.Size(181, 23);
            this.Adicionar.TabIndex = 4;
            this.Adicionar.Text = "Adicionar";
            this.Adicionar.UseVisualStyleBackColor = true;
            this.Adicionar.Click += new System.EventHandler(this.Adicionar_Click);
            // 
            // PainelADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1070, 605);
            this.Controls.Add(this.Ferramentas);
            this.Controls.Add(this.voltar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PainelADM";
            this.Text = "Painel administrador";
            this.Load += new System.EventHandler(this.PainelADM_Load);
            this.Ferramentas.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.Button deletar;
        private System.Windows.Forms.Button deletarTudo;
        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.TextBox Consultar;
        private System.Windows.Forms.Button buscarusuario;
        private System.Windows.Forms.GroupBox Ferramentas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Listar;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Adicionar;
    }
}