namespace gerenciamento_de_funcionario
{
    partial class addfunc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.status_adddunc = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.limparbtn_adddunc = new System.Windows.Forms.Button();
            this.deletebtn_adddunc = new System.Windows.Forms.Button();
            this.updatebtn_adddunc = new System.Windows.Forms.Button();
            this.addbtn_adddunc = new System.Windows.Forms.Button();
            this.importar_adddunc = new System.Windows.Forms.Button();
            this.fotos_adddunc = new System.Windows.Forms.PictureBox();
            this.telefone_adddunc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.genero_adddunc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nome_completo_adddunc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.id_func_adddunc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.posisao_addfunc = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotos_adddunc)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(19, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 257);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Location = new System.Drawing.Point(17, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(744, 204);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Funcionarios";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.posisao_addfunc);
            this.panel2.Controls.Add(this.status_adddunc);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.limparbtn_adddunc);
            this.panel2.Controls.Add(this.deletebtn_adddunc);
            this.panel2.Controls.Add(this.updatebtn_adddunc);
            this.panel2.Controls.Add(this.addbtn_adddunc);
            this.panel2.Controls.Add(this.importar_adddunc);
            this.panel2.Controls.Add(this.fotos_adddunc);
            this.panel2.Controls.Add(this.telefone_adddunc);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.genero_adddunc);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.nome_completo_adddunc);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.id_func_adddunc);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(19, 302);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(778, 206);
            this.panel2.TabIndex = 1;
            // 
            // status_adddunc
            // 
            this.status_adddunc.FormattingEnabled = true;
            this.status_adddunc.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outro"});
            this.status_adddunc.Location = new System.Drawing.Point(413, 71);
            this.status_adddunc.Name = "status_adddunc";
            this.status_adddunc.Size = new System.Drawing.Size(164, 21);
            this.status_adddunc.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(365, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Status";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // limparbtn_adddunc
            // 
            this.limparbtn_adddunc.Location = new System.Drawing.Point(494, 152);
            this.limparbtn_adddunc.Name = "limparbtn_adddunc";
            this.limparbtn_adddunc.Size = new System.Drawing.Size(83, 36);
            this.limparbtn_adddunc.TabIndex = 13;
            this.limparbtn_adddunc.Text = "Limpar";
            this.limparbtn_adddunc.UseVisualStyleBackColor = true;
            // 
            // deletebtn_adddunc
            // 
            this.deletebtn_adddunc.Location = new System.Drawing.Point(405, 152);
            this.deletebtn_adddunc.Name = "deletebtn_adddunc";
            this.deletebtn_adddunc.Size = new System.Drawing.Size(83, 36);
            this.deletebtn_adddunc.TabIndex = 12;
            this.deletebtn_adddunc.Text = "Delete";
            this.deletebtn_adddunc.UseVisualStyleBackColor = true;
            // 
            // updatebtn_adddunc
            // 
            this.updatebtn_adddunc.Location = new System.Drawing.Point(287, 152);
            this.updatebtn_adddunc.Name = "updatebtn_adddunc";
            this.updatebtn_adddunc.Size = new System.Drawing.Size(83, 36);
            this.updatebtn_adddunc.TabIndex = 11;
            this.updatebtn_adddunc.Text = "Update";
            this.updatebtn_adddunc.UseVisualStyleBackColor = true;
            // 
            // addbtn_adddunc
            // 
            this.addbtn_adddunc.Location = new System.Drawing.Point(198, 152);
            this.addbtn_adddunc.Name = "addbtn_adddunc";
            this.addbtn_adddunc.Size = new System.Drawing.Size(83, 36);
            this.addbtn_adddunc.TabIndex = 10;
            this.addbtn_adddunc.Text = "ADD";
            this.addbtn_adddunc.UseVisualStyleBackColor = true;
            this.addbtn_adddunc.Click += new System.EventHandler(this.addbtn_adddunc_Click);
            // 
            // importar_adddunc
            // 
            this.importar_adddunc.Location = new System.Drawing.Point(661, 139);
            this.importar_adddunc.Name = "importar_adddunc";
            this.importar_adddunc.Size = new System.Drawing.Size(100, 23);
            this.importar_adddunc.TabIndex = 9;
            this.importar_adddunc.Text = "Importar";
            this.importar_adddunc.UseVisualStyleBackColor = true;
            this.importar_adddunc.Click += new System.EventHandler(this.button1_Click);
            // 
            // fotos_adddunc
            // 
            this.fotos_adddunc.BackColor = System.Drawing.Color.Silver;
            this.fotos_adddunc.Location = new System.Drawing.Point(661, 33);
            this.fotos_adddunc.Name = "fotos_adddunc";
            this.fotos_adddunc.Size = new System.Drawing.Size(100, 100);
            this.fotos_adddunc.TabIndex = 8;
            this.fotos_adddunc.TabStop = false;
            this.fotos_adddunc.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // telefone_adddunc
            // 
            this.telefone_adddunc.Location = new System.Drawing.Point(413, 33);
            this.telefone_adddunc.Name = "telefone_adddunc";
            this.telefone_adddunc.Size = new System.Drawing.Size(164, 20);
            this.telefone_adddunc.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(358, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Telefone";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // genero_adddunc
            // 
            this.genero_adddunc.FormattingEnabled = true;
            this.genero_adddunc.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outro"});
            this.genero_adddunc.Location = new System.Drawing.Point(117, 114);
            this.genero_adddunc.Name = "genero_adddunc";
            this.genero_adddunc.Size = new System.Drawing.Size(164, 21);
            this.genero_adddunc.TabIndex = 5;
            this.genero_adddunc.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Gênero";
            // 
            // nome_completo_adddunc
            // 
            this.nome_completo_adddunc.Location = new System.Drawing.Point(117, 72);
            this.nome_completo_adddunc.Name = "nome_completo_adddunc";
            this.nome_completo_adddunc.Size = new System.Drawing.Size(164, 20);
            this.nome_completo_adddunc.TabIndex = 3;
            this.nome_completo_adddunc.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome Completo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // id_func_adddunc
            // 
            this.id_func_adddunc.Location = new System.Drawing.Point(117, 33);
            this.id_func_adddunc.Name = "id_func_adddunc";
            this.id_func_adddunc.Size = new System.Drawing.Size(164, 20);
            this.id_func_adddunc.TabIndex = 1;
            this.id_func_adddunc.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID Funcionarios";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outro"});
            this.comboBox1.Location = new System.Drawing.Point(413, 98);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(164, 21);
            this.comboBox1.TabIndex = 17;
            // 
            // posisao_addfunc
            // 
            this.posisao_addfunc.AutoSize = true;
            this.posisao_addfunc.Location = new System.Drawing.Point(365, 101);
            this.posisao_addfunc.Name = "posisao_addfunc";
            this.posisao_addfunc.Size = new System.Drawing.Size(43, 13);
            this.posisao_addfunc.TabIndex = 16;
            this.posisao_addfunc.Text = "posisão";
            // 
            // addfunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "addfunc";
            this.Size = new System.Drawing.Size(816, 526);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotos_adddunc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox id_func_adddunc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox nome_completo_adddunc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox genero_adddunc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox telefone_adddunc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox fotos_adddunc;
        private System.Windows.Forms.Button importar_adddunc;
        private System.Windows.Forms.ComboBox status_adddunc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button limparbtn_adddunc;
        private System.Windows.Forms.Button deletebtn_adddunc;
        private System.Windows.Forms.Button updatebtn_adddunc;
        private System.Windows.Forms.Button addbtn_adddunc;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label posisao_addfunc;
    }
}
