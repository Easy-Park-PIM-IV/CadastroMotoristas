namespace cadastroUser_v2
{
    partial class CadastroMotoristaView
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
            this.cadastrar_button = new System.Windows.Forms.Button();
            this.placa_label = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.nome_label = new System.Windows.Forms.Label();
            this.tel_textbox = new System.Windows.Forms.TextBox();
            this.email_textbox = new System.Windows.Forms.TextBox();
            this.nome_textbox = new System.Windows.Forms.TextBox();
            this.Cadastro = new System.Windows.Forms.Label();
            this.voltarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cadastrar_button
            // 
            this.cadastrar_button.Location = new System.Drawing.Point(574, 520);
            this.cadastrar_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cadastrar_button.Name = "cadastrar_button";
            this.cadastrar_button.Size = new System.Drawing.Size(94, 43);
            this.cadastrar_button.TabIndex = 16;
            this.cadastrar_button.Text = "Cadastrar";
            this.cadastrar_button.UseVisualStyleBackColor = true;
            this.cadastrar_button.Click += new System.EventHandler(this.cadastrar_button_Click);
            // 
            // placa_label
            // 
            this.placa_label.AutoSize = true;
            this.placa_label.Location = new System.Drawing.Point(516, 430);
            this.placa_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.placa_label.Name = "placa_label";
            this.placa_label.Size = new System.Drawing.Size(75, 20);
            this.placa_label.TabIndex = 15;
            this.placa_label.Text = "Telefone:";
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Location = new System.Drawing.Point(516, 326);
            this.email_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(52, 20);
            this.email_label.TabIndex = 14;
            this.email_label.Text = "Email:";
            // 
            // nome_label
            // 
            this.nome_label.AutoSize = true;
            this.nome_label.Location = new System.Drawing.Point(516, 230);
            this.nome_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nome_label.Name = "nome_label";
            this.nome_label.Size = new System.Drawing.Size(120, 20);
            this.nome_label.TabIndex = 13;
            this.nome_label.Text = "Nome completo";
            // 
            // tel_textbox
            // 
            this.tel_textbox.Location = new System.Drawing.Point(521, 454);
            this.tel_textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tel_textbox.Name = "tel_textbox";
            this.tel_textbox.Size = new System.Drawing.Size(216, 26);
            this.tel_textbox.TabIndex = 12;
            // 
            // email_textbox
            // 
            this.email_textbox.Location = new System.Drawing.Point(521, 351);
            this.email_textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.Size = new System.Drawing.Size(216, 26);
            this.email_textbox.TabIndex = 11;
            // 
            // nome_textbox
            // 
            this.nome_textbox.Location = new System.Drawing.Point(521, 254);
            this.nome_textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nome_textbox.Name = "nome_textbox";
            this.nome_textbox.Size = new System.Drawing.Size(216, 26);
            this.nome_textbox.TabIndex = 10;
            // 
            // Cadastro
            // 
            this.Cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.Cadastro.Location = new System.Drawing.Point(473, 156);
            this.Cadastro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Cadastro.Name = "Cadastro";
            this.Cadastro.Size = new System.Drawing.Size(346, 43);
            this.Cadastro.TabIndex = 9;
            this.Cadastro.Text = "Cadastro de motorista";
            // 
            // voltarBtn
            // 
            this.voltarBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.voltarBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltarBtn.Location = new System.Drawing.Point(123, 59);
            this.voltarBtn.Margin = new System.Windows.Forms.Padding(0);
            this.voltarBtn.Name = "voltarBtn";
            this.voltarBtn.Size = new System.Drawing.Size(107, 41);
            this.voltarBtn.TabIndex = 17;
            this.voltarBtn.Text = "<";
            this.voltarBtn.UseVisualStyleBackColor = true;
            this.voltarBtn.Click += new System.EventHandler(this.voltarBtn_Click);
            // 
            // CadastroMotoristaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 770);
            this.Controls.Add(this.voltarBtn);
            this.Controls.Add(this.cadastrar_button);
            this.Controls.Add(this.placa_label);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.nome_label);
            this.Controls.Add(this.tel_textbox);
            this.Controls.Add(this.email_textbox);
            this.Controls.Add(this.nome_textbox);
            this.Controls.Add(this.Cadastro);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CadastroMotoristaView";
            this.Text = "Cadastro de motoristas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cadastrar_button;
        private System.Windows.Forms.Label placa_label;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Label nome_label;
        private System.Windows.Forms.TextBox tel_textbox;
        private System.Windows.Forms.TextBox email_textbox;
        private System.Windows.Forms.TextBox nome_textbox;
        private System.Windows.Forms.Label Cadastro;
        private System.Windows.Forms.Button voltarBtn;
    }
}

