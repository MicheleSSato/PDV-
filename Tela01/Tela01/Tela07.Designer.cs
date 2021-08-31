
namespace Tela01
{
    partial class t0007Consulta
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
            this.bt012CstCliente = new System.Windows.Forms.Button();
            this.bt013CstProduto = new System.Windows.Forms.Button();
            this.bt014CstFornecedor = new System.Windows.Forms.Button();
            this.btu001Voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt012CstCliente
            // 
            this.bt012CstCliente.Location = new System.Drawing.Point(22, 79);
            this.bt012CstCliente.Name = "bt012CstCliente";
            this.bt012CstCliente.Size = new System.Drawing.Size(75, 23);
            this.bt012CstCliente.TabIndex = 0;
            this.bt012CstCliente.Text = "Cliente";
            this.bt012CstCliente.UseVisualStyleBackColor = true;
            // 
            // bt013CstProduto
            // 
            this.bt013CstProduto.Location = new System.Drawing.Point(22, 108);
            this.bt013CstProduto.Name = "bt013CstProduto";
            this.bt013CstProduto.Size = new System.Drawing.Size(75, 23);
            this.bt013CstProduto.TabIndex = 1;
            this.bt013CstProduto.Text = "Produto";
            this.bt013CstProduto.UseVisualStyleBackColor = true;
            // 
            // bt014CstFornecedor
            // 
            this.bt014CstFornecedor.Location = new System.Drawing.Point(22, 137);
            this.bt014CstFornecedor.Name = "bt014CstFornecedor";
            this.bt014CstFornecedor.Size = new System.Drawing.Size(75, 23);
            this.bt014CstFornecedor.TabIndex = 2;
            this.bt014CstFornecedor.Text = "Fornecedor";
            this.bt014CstFornecedor.UseVisualStyleBackColor = true;
            // 
            // btu001Voltar
            // 
            this.btu001Voltar.Location = new System.Drawing.Point(112, 198);
            this.btu001Voltar.Name = "btu001Voltar";
            this.btu001Voltar.Size = new System.Drawing.Size(75, 23);
            this.btu001Voltar.TabIndex = 3;
            this.btu001Voltar.Text = "Voltar";
            this.btu001Voltar.UseVisualStyleBackColor = true;
            this.btu001Voltar.Click += new System.EventHandler(this.btu001Voltar_Click);
            // 
            // t0007Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 244);
            this.Controls.Add(this.btu001Voltar);
            this.Controls.Add(this.bt014CstFornecedor);
            this.Controls.Add(this.bt013CstProduto);
            this.Controls.Add(this.bt012CstCliente);
            this.Name = "t0007Consulta";
            this.Text = "Consulta";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt012CstCliente;
        private System.Windows.Forms.Button bt013CstProduto;
        private System.Windows.Forms.Button bt014CstFornecedor;
        private System.Windows.Forms.Button btu001Voltar;
    }
}