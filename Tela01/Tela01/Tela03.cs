using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class cadastro_produto : Form
    {
        SqlConnection conexao = new SqlConnection(@"Data Source =(localdb)\MSSQLLocalDB; Initial Catalog=PDV; User Id=admin;Password=admin");
        SqlCommand comando;
        string strSQL;

        public cadastro_produto()
        {
            InitializeComponent();
        }

        private void cod_barras_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                strSQL = "INSERT INTO Produto (nome, cod_barras, cod_interno, preco_compra, preco_venda, margem_lucro, imposto, id_fabricante) " +
                    "VALUES(@NOME, @CODIGO_BARRAS, @CODIGO_INTERNO, @PRECO_DE_COMPRA, @PRECO_DE_VENDA, @MARGEM_DE_LUCRO, @IMPOSTO, @FABRICANTE)";

                comando = new SqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@NOME", txtNome.Text);
                comando.Parameters.AddWithValue("@CODIGO_BARRAS", txtCod_barras.Text);
                comando.Parameters.AddWithValue("@CODIGO_INTERNO", txtCod_interno.Text);
                comando.Parameters.AddWithValue("@PRECO_DE_COMPRA", txtPreco_compra.Text);
                comando.Parameters.AddWithValue("@PRECO_DE_VENDA", txtPreco_venda.Text);
                comando.Parameters.AddWithValue("@MARGEM_DE_LUCRO", txtMargem_lucro.Text);
                comando.Parameters.AddWithValue("@IMPOSTO", txtImposto.Text);
                comando.Parameters.AddWithValue("@FABRICANTE", txtFabricante.Text);

                conexao.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lbFabricante_Click(object sender, EventArgs e)
        {

        }

    
    }
}

