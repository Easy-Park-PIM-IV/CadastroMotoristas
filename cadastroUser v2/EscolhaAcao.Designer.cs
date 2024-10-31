namespace cadastroUser_v2
{
    partial class Form1
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
            this.VisuMotoBtn = new System.Windows.Forms.Button();
            this.CadMotoBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cadVeiculosBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(428, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 36);
            this.label1.TabIndex = 0;
            // 
            // VisuMotoBtn
            // 
            this.VisuMotoBtn.Location = new System.Drawing.Point(231, 283);
            this.VisuMotoBtn.Name = "VisuMotoBtn";
            this.VisuMotoBtn.Size = new System.Drawing.Size(142, 113);
            this.VisuMotoBtn.TabIndex = 1;
            this.VisuMotoBtn.Text = "Visualizar motoristas";
            this.VisuMotoBtn.UseVisualStyleBackColor = true;
            this.VisuMotoBtn.Click += new System.EventHandler(this.VisuMotoBtn_Click);
            // 
            // CadMotoBtn
            // 
            this.CadMotoBtn.Location = new System.Drawing.Point(467, 283);
            this.CadMotoBtn.Name = "CadMotoBtn";
            this.CadMotoBtn.Size = new System.Drawing.Size(142, 113);
            this.CadMotoBtn.TabIndex = 2;
            this.CadMotoBtn.Text = "Cadastrar motoristas";
            this.CadMotoBtn.UseVisualStyleBackColor = true;
            this.CadMotoBtn.Click += new System.EventHandler(this.CadMotoBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(429, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "O que deseja fazer?";
            // 
            // cadVeiculosBtn
            // 
            this.cadVeiculosBtn.Location = new System.Drawing.Point(708, 283);
            this.cadVeiculosBtn.Name = "cadVeiculosBtn";
            this.cadVeiculosBtn.Size = new System.Drawing.Size(142, 113);
            this.cadVeiculosBtn.TabIndex = 4;
            this.cadVeiculosBtn.Text = "Cadastrar veículos";
            this.cadVeiculosBtn.UseVisualStyleBackColor = true;
            this.cadVeiculosBtn.Click += new System.EventHandler(this.cadVeiculosBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 642);
            this.Controls.Add(this.cadVeiculosBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CadMotoBtn);
            this.Controls.Add(this.VisuMotoBtn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button VisuMotoBtn;
        private System.Windows.Forms.Button CadMotoBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cadVeiculosBtn;
    }
}