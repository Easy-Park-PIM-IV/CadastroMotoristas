namespace cadastroUser_v2
{
    partial class VisualizarMotoristas
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
            this.button1 = new System.Windows.Forms.Button();
            this.listaMotoristas = new System.Windows.Forms.ListView();
            this.button2 = new System.Windows.Forms.Button();
            this.VoltarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Motoristas cadastrados:";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(437, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Atualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listaMotoristas
            // 
            this.listaMotoristas.HideSelection = false;
            this.listaMotoristas.Location = new System.Drawing.Point(41, 117);
            this.listaMotoristas.Name = "listaMotoristas";
            this.listaMotoristas.Size = new System.Drawing.Size(718, 259);
            this.listaMotoristas.TabIndex = 2;
            this.listaMotoristas.UseCompatibleStateImageBehavior = false;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(569, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 39);
            this.button2.TabIndex = 3;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // VoltarButton
            // 
            this.VoltarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.VoltarButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VoltarButton.Location = new System.Drawing.Point(41, 9);
            this.VoltarButton.Margin = new System.Windows.Forms.Padding(0);
            this.VoltarButton.Name = "VoltarButton";
            this.VoltarButton.Size = new System.Drawing.Size(107, 41);
            this.VoltarButton.TabIndex = 18;
            this.VoltarButton.Text = "<";
            this.VoltarButton.UseVisualStyleBackColor = true;
            this.VoltarButton.Click += new System.EventHandler(this.VoltarButton_Click);
            // 
            // VisualizarMotoristas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VoltarButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listaMotoristas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "VisualizarMotoristas";
            this.Text = "Motoristas cadastrados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listaMotoristas;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button VoltarButton;
    }
}