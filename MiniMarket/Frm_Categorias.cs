using Minimarket.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniMarket.Presentacion
{
    public partial class Frm_Categorias : Form
    {
        public Frm_Categorias()
        {
            InitializeComponent();
        }

        #region Metodos
        private void Formato_ca()
        {
            dgvPrincipal.Columns[0].Width = 100;
            dgvPrincipal.Columns[0].HeaderText = "Codigo Categoria";

            dgvPrincipal.Columns[1].Width = 300;
            dgvPrincipal.Columns[1].HeaderText = "Categoria";
        }

        private void ListadoCategorias(string cTexto)
        {
            try
            {
                dgvPrincipal.DataSource = N_Categorias.GetDatosCategorias(cTexto);
                this.Formato_ca();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        #endregion

        private void Frm_Categorias_Load(object sender, EventArgs e)
        {
            this.ListadoCategorias("%C");
        }
    }
}
