using Diversos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Armazem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadFornecedores();
            LoadCategorias();
            AtualizaGrid();
        }

        private void LoadFornecedores()
        {
            
            Conecta obj = new Conecta(); //INSTANCIAR A CLASSE FORNECIDA


            obj.strSQL = "select * from fornecedores";

            cbxFornecedores.DisplayMember = "NomeDaEmpresa";
            cbxFornecedores.ValueMember = "CódigoDoFornecedor";



            cbxFornecedores.DataSource = obj.BuscarDados();
            cbxFornecedores.SelectedValue = -1;
        }

        private void LoadCategorias()
        {
            
            Conecta obj = new Conecta(); //INSTANCIAR A CLASSE FORNECIDA

            obj.strSQL = "select * from Categorias";

            lstCategorias.DisplayMember = "NomeDaCategoria";
            lstCategorias.ValueMember = "CódigoDaCategoria";

            lstCategorias.DataSource = obj.BuscarDados();

        }

        private void AtualizaGrid()
        {
            Conecta obj = new Conecta(); //INSTANCIAR A CLASSE FORNECIDA                                            

            string categoria = Convert.ToString(lstCategorias.SelectedValue);
            string fornecedor = Convert.ToString(cbxFornecedores.SelectedValue);

            obj.strSQL = "select * from produtos where CódigoDaCategoria ='" + categoria + "'" + "AND CódigoDoFornecedor = '" + fornecedor + "';";

            dgvBD.DataSource = obj.BuscarDados();


        }

        private void lstCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizaGrid();
        }

        private void cbxFornecedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizaGrid();
        }
    }



    
}
