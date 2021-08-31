
namespace Tela01
{
    partial class t0001PDVSystem
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
            this.bt000Cadastro = new System.Windows.Forms.Button();
            this.bt001Consulta = new System.Windows.Forms.Button();
            this.bt002Caixa = new System.Windows.Forms.Button();
            this.bt003Venda = new System.Windows.Forms.Button();
            this.bt004Relatorio = new System.Windows.Forms.Button();
            this.btu000TrocarUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt000Cadastro
            // 
            this.bt000Cadastro.Location = new System.Drawing.Point(49, 92);
            this.bt000Cadastro.Name = "bt000Cadastro";
            this.bt000Cadastro.Size = new System.Drawing.Size(75, 23);
            this.bt000Cadastro.TabIndex = 0;
            this.bt000Cadastro.Text = "Cadastro";
            this.bt000Cadastro.UseVisualStyleBackColor = true;
            this.bt000Cadastro.Click += new System.EventHandler(this.bt000Cadastro_Click);
            // 
            // bt001Consulta
            // 
            this.bt001Consulta.Location = new System.Drawing.Point(168, 92);
            this.bt001Consulta.Name = "bt001Consulta";
            this.bt001Consulta.Size = new System.Drawing.Size(75, 23);
            this.bt001Consulta.TabIndex = 1;
            this.bt001Consulta.Text = "Consulta";
            this.bt001Consulta.UseVisualStyleBackColor = true;
            this.bt001Consulta.Click += new System.EventHandler(this.bt001Consulta_Click);
            // 
            // bt002Caixa
            // 
            this.bt002Caixa.Location = new System.Drawing.Point(49, 137);
            this.bt002Caixa.Name = "bt002Caixa";
            this.bt002Caixa.Size = new System.Drawing.Size(75, 23);
            this.bt002Caixa.TabIndex = 2;
            this.bt002Caixa.Text = "Caixa";
            this.bt002Caixa.UseVisualStyleBackColor = true;
            // 
            // bt003Venda
            // 
            this.bt003Venda.Location = new System.Drawing.Point(168, 137);
            this.bt003Venda.Name = "bt003Venda";
            this.bt003Venda.Size = new System.Drawing.Size(75, 23);
            this.bt003Venda.TabIndex = 3;
            this.bt003Venda.Text = "Venda";
            this.bt003Venda.UseVisualStyleBackColor = true;
            // 
            // bt004Relatorio
            // 
            this.bt004Relatorio.Location = new System.Drawing.Point(108, 180);
            this.bt004Relatorio.Name = "bt004Relatorio";
            this.bt004Relatorio.Size = new System.Drawing.Size(75, 23);
            this.bt004Relatorio.TabIndex = 4;
            this.bt004Relatorio.Text = "Relatório";
            this.bt004Relatorio.UseVisualStyleBackColor = true;
            // 
            // btu000TrocarUsuario
            // 
            this.btu000TrocarUsuario.Location = new System.Drawing.Point(108, 233);
            this.btu000TrocarUsuario.Name = "btu000TrocarUsuario";
            this.btu000TrocarUsuario.Size = new System.Drawing.Size(75, 42);
            this.btu000TrocarUsuario.TabIndex = 5;
            this.btu000TrocarUsuario.Text = "Trocar Usuário";
            this.btu000TrocarUsuario.UseVisualStyleBackColor = true;
            // 
            // t0001PDVSystem
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 287);
            this.Controls.Add(this.btu000TrocarUsuario);
            this.Controls.Add(this.bt004Relatorio);
            this.Controls.Add(this.bt003Venda);
            this.Controls.Add(this.bt002Caixa);
            this.Controls.Add(this.bt001Consulta);
            this.Controls.Add(this.bt000Cadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "t0001PDVSystem";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDV System";
            this.Load += new System.EventHandler(this.t0001PDVSystem_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt000Cadastro;
        private System.Windows.Forms.Button bt001Consulta;
        private System.Windows.Forms.Button bt002Caixa;
        private System.Windows.Forms.Button bt003Venda;
        private System.Windows.Forms.Button bt004Relatorio;
        private System.Windows.Forms.Button btu000TrocarUsuario;
    }
}

