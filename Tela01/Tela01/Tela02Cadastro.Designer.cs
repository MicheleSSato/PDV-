
namespace Tela01
{
    partial class t0002Cadastro
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
            this.bt005Produto = new System.Windows.Forms.Button();
            this.bt006Funcionario = new System.Windows.Forms.Button();
            this.bt007Cliente = new System.Windows.Forms.Button();
            this.bt008Fornecedor = new System.Windows.Forms.Button();
            this.btu001Voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt005Produto
            // 
            this.bt005Produto.Location = new System.Drawing.Point(12, 50);
            this.bt005Produto.Name = "bt005Produto";
            this.bt005Produto.Size = new System.Drawing.Size(75, 23);
            this.bt005Produto.TabIndex = 0;
            this.bt005Produto.Text = "Produto";
            this.bt005Produto.UseVisualStyleBackColor = true;
            this.bt005Produto.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt006Funcionario
            // 
            this.bt006Funcionario.Location = new System.Drawing.Point(113, 50);
            this.bt006Funcionario.Name = "bt006Funcionario";
            this.bt006Funcionario.Size = new System.Drawing.Size(75, 23);
            this.bt006Funcionario.TabIndex = 2;
            this.bt006Funcionario.Text = "Funcionário";
            this.bt006Funcionario.UseVisualStyleBackColor = true;
            // 
            // bt007Cliente
            // 
            this.bt007Cliente.Location = new System.Drawing.Point(12, 95);
            this.bt007Cliente.Name = "bt007Cliente";
            this.bt007Cliente.Size = new System.Drawing.Size(75, 23);
            this.bt007Cliente.TabIndex = 3;
            this.bt007Cliente.Text = "Cliente";
            this.bt007Cliente.UseVisualStyleBackColor = true;
            // 
            // bt008Fornecedor
            // 
            this.bt008Fornecedor.Location = new System.Drawing.Point(113, 95);
            this.bt008Fornecedor.Name = "bt008Fornecedor";
            this.bt008Fornecedor.Size = new System.Drawing.Size(75, 23);
            this.bt008Fornecedor.TabIndex = 4;
            this.bt008Fornecedor.Text = "Fornecedor";
            this.bt008Fornecedor.UseVisualStyleBackColor = true;
            // 
            // btu001Voltar
            // 
            this.btu001Voltar.Location = new System.Drawing.Point(113, 164);
            this.btu001Voltar.Name = "btu001Voltar";
            this.btu001Voltar.Size = new System.Drawing.Size(75, 23);
            this.btu001Voltar.TabIndex = 5;
            this.btu001Voltar.Text = "Voltar";
            this.btu001Voltar.UseVisualStyleBackColor = true;
            this.btu001Voltar.Click += new System.EventHandler(this.btu001Voltar_Click);
            // 
            // t0002Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 205);
            this.Controls.Add(this.btu001Voltar);
            this.Controls.Add(this.bt008Fornecedor);
            this.Controls.Add(this.bt007Cliente);
            this.Controls.Add(this.bt006Funcionario);
            this.Controls.Add(this.bt005Produto);
            this.Name = "t0002Cadastro";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt005Produto;
        private System.Windows.Forms.Button bt006Funcionario;
        private System.Windows.Forms.Button bt007Cliente;
        private System.Windows.Forms.Button bt008Fornecedor;
        private System.Windows.Forms.Button btu001Voltar;
    }
}