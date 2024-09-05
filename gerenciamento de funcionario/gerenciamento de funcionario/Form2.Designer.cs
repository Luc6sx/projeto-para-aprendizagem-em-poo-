namespace gerenciamento_de_funcionario
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.salario_btn = new System.Windows.Forms.Button();
            this.emplyee_btn = new System.Windows.Forms.Button();
            this.DashBoard_btn = new System.Windows.Forms.Button();
            this.bnv_user = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.salario1 = new gerenciamento_de_funcionario.salario();
            this.dashboard1 = new gerenciamento_de_funcionario.dashboard();
            this.addfunc1 = new gerenciamento_de_funcionario.addfunc();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 35);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gerenciamento de funcionarios";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1057, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(0)))), ((int)(((byte)(138)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.salario_btn);
            this.panel2.Controls.Add(this.emplyee_btn);
            this.panel2.Controls.Add(this.DashBoard_btn);
            this.panel2.Controls.Add(this.bnv_user);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(268, 526);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(82, 491);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "DESLOGAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // salario_btn
            // 
            this.salario_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salario_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salario_btn.Location = new System.Drawing.Point(15, 321);
            this.salario_btn.Name = "salario_btn";
            this.salario_btn.Size = new System.Drawing.Size(237, 46);
            this.salario_btn.TabIndex = 5;
            this.salario_btn.Text = "Salario";
            this.salario_btn.UseVisualStyleBackColor = true;
            this.salario_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // emplyee_btn
            // 
            this.emplyee_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emplyee_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emplyee_btn.Location = new System.Drawing.Point(15, 269);
            this.emplyee_btn.Name = "emplyee_btn";
            this.emplyee_btn.Size = new System.Drawing.Size(237, 46);
            this.emplyee_btn.TabIndex = 4;
            this.emplyee_btn.Text = "Add Emplyee";
            this.emplyee_btn.UseVisualStyleBackColor = true;
            this.emplyee_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // DashBoard_btn
            // 
            this.DashBoard_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DashBoard_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashBoard_btn.Location = new System.Drawing.Point(15, 217);
            this.DashBoard_btn.Name = "DashBoard_btn";
            this.DashBoard_btn.Size = new System.Drawing.Size(237, 46);
            this.DashBoard_btn.TabIndex = 3;
            this.DashBoard_btn.Text = "DashBoard";
            this.DashBoard_btn.UseVisualStyleBackColor = true;
            this.DashBoard_btn.Click += new System.EventHandler(this.DashBoard_Click);
            // 
            // bnv_user
            // 
            this.bnv_user.AutoSize = true;
            this.bnv_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnv_user.ForeColor = System.Drawing.Color.White;
            this.bnv_user.Location = new System.Drawing.Point(66, 116);
            this.bnv_user.Name = "bnv_user";
            this.bnv_user.Size = new System.Drawing.Size(120, 16);
            this.bnv_user.TabIndex = 2;
            this.bnv_user.Text = "Bem-Vindo User";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.addfunc1);
            this.panel3.Controls.Add(this.dashboard1);
            this.panel3.Controls.Add(this.salario1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(268, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(816, 526);
            this.panel3.TabIndex = 2;
            // 
            // salario1
            // 
            this.salario1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.salario1.Location = new System.Drawing.Point(0, 0);
            this.salario1.Name = "salario1";
            this.salario1.Size = new System.Drawing.Size(816, 526);
            this.salario1.TabIndex = 0;
            // 
            // dashboard1
            // 
            this.dashboard1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dashboard1.Location = new System.Drawing.Point(0, 0);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(816, 526);
            this.dashboard1.TabIndex = 1;
            // 
            // addfunc1
            // 
            this.addfunc1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.addfunc1.Location = new System.Drawing.Point(0, 0);
            this.addfunc1.Name = "addfunc1";
            this.addfunc1.Size = new System.Drawing.Size(816, 526);
            this.addfunc1.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button salario_btn;
        private System.Windows.Forms.Button emplyee_btn;
        private System.Windows.Forms.Button DashBoard_btn;
        private System.Windows.Forms.Label bnv_user;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private salario salario1;
        private addfunc addfunc1;
        private dashboard dashboard1;
    }
}