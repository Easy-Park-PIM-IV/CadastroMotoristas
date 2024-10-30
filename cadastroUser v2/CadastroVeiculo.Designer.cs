namespace cadastroUser_v2
{
    partial class CadastroVeiculo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_motoristas = new System.Windows.Forms.ComboBox();
            this.placa_txt = new System.Windows.Forms.TextBox();
            this.modelo_txt = new System.Windows.Forms.TextBox();
            this.cor_txt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(418, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de veículos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Placa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(424, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Modelo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(424, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(424, 401);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Motorista";
            // 
            // comboBox_motoristas
            // 
            this.comboBox_motoristas.FormattingEnabled = true;
            this.comboBox_motoristas.Location = new System.Drawing.Point(428, 433);
            this.comboBox_motoristas.Name = "comboBox_motoristas";
            this.comboBox_motoristas.Size = new System.Drawing.Size(293, 28);
            this.comboBox_motoristas.TabIndex = 5;
            // 
            // placa_txt
            // 
            this.placa_txt.Location = new System.Drawing.Point(424, 226);
            this.placa_txt.Name = "placa_txt";
            this.placa_txt.Size = new System.Drawing.Size(297, 26);
            this.placa_txt.TabIndex = 6;
            // 
            // modelo_txt
            // 
            this.modelo_txt.Location = new System.Drawing.Point(424, 288);
            this.modelo_txt.Name = "modelo_txt";
            this.modelo_txt.Size = new System.Drawing.Size(297, 26);
            this.modelo_txt.TabIndex = 7;
            // 
            // cor_txt
            // 
            this.cor_txt.Location = new System.Drawing.Point(428, 352);
            this.cor_txt.Name = "cor_txt";
            this.cor_txt.Size = new System.Drawing.Size(293, 26);
            this.cor_txt.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(516, 511);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 42);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CadastroVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 667);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cor_txt);
            this.Controls.Add(this.modelo_txt);
            this.Controls.Add(this.placa_txt);
            this.Controls.Add(this.comboBox_motoristas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadastroVeiculo";
            this.Text = "Cadastro Veículo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_motoristas;
        private System.Windows.Forms.TextBox placa_txt;
        private System.Windows.Forms.TextBox modelo_txt;
        private System.Windows.Forms.TextBox cor_txt;
        private System.Windows.Forms.Button button1;
    }
}