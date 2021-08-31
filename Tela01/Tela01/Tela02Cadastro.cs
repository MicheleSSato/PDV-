using System;
using System.Windows.Forms;

namespace Tela01
{
    public partial class t0002Cadastro : Form
    {
        public t0002Cadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        //    this.Hide();
        //    cadastro_ novoForm = new t0001PDVSystem();
        //    novoForm.Closed += (s, args) => this.Close();
        //    novoForm.Show();
        }

        private void btu001Voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            t0001PDVSystem novoForm = new t0001PDVSystem();
            novoForm.Closed += (s, args) => this.Close();
            novoForm.Show();
        }
    }
}
