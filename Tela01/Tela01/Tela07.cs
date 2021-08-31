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
    public partial class t0007Consulta : Form
    {
        public t0007Consulta()
        {
            InitializeComponent();
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
