using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tela01
{
    public partial class t0001PDVSystem : Form
    {
        string pasta_imagens = "";
        public t0001PDVSystem()
        {
            InitializeComponent();
            pasta_imagens = Application.StartupPath + @"\imagens\";
            this.BackgroundImage = Image.FromFile(pasta_imagens + "LogoPDV.png");
        }
        
        private void bt000Cadastro_Click(object sender, EventArgs e)
        {
            this.Hide();
            t0002Cadastro novoForm = new t0002Cadastro();
            novoForm.Closed += (s, args) => this.Close();
            novoForm.Show();
        }

        private void t0001PDVSystem_Load(object sender, EventArgs e)
        {
            ///
        }

        private void bt001Consulta_Click(object sender, EventArgs e)
        {
            this.Hide();
            t0007Consulta novoForm = new t0007Consulta();
            novoForm.Closed += (s, args) => this.Close();
            novoForm.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
