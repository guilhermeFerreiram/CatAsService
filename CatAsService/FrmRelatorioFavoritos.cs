using CatAsService.APIService;
using Newtonsoft.Json;
using RestSharp;
using System.Net;
using System.Windows.Forms;

namespace CatAsService
{
    public partial class FrmRelatorioFavoritos : Form
    {
        private ClsCatAsService ApiCatAsService;

        public FrmRelatorioFavoritos()
        {
            InitializeComponent();
            ApiCatAsService = new ClsCatAsService();
        }

        private void FrmRelatorioFavoritos_Load(object sender, EventArgs e)
        {
            listBoxFavourites.Items.AddRange(ApiCatAsService.GetNomesGatosFavoritos().ToArray());
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ApiCatAsService.DeletarFavoritoPorNome(listBoxFavourites.SelectedItem.ToString());
            listBoxFavourites.Items.Clear();
            listBoxFavourites.Items.AddRange(ApiCatAsService.GetNomesGatosFavoritos().ToArray());
        }
    }
}
