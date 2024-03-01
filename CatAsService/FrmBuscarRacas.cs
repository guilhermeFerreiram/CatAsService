using CatAsService.APIService;

namespace CatAsService
{
    public partial class FrmBuscarRacas : Form
    {
        private ClsCatAsService ApiCatAsService;

        public FrmBuscarRacas()
        {
            InitializeComponent();
            ApiCatAsService = new ClsCatAsService();
        }

        private void FrmBuscarRacas_Load(object sender, EventArgs e)
        {
            cbListaRacas.SelectedIndex = 0;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbListaRacas.SelectedIndex > 0)
            {
                string idRaca = cbListaRacas.Text;
                CarregaResultadoTela(ApiCatAsService.GetCaracteristicasPorNome(idRaca));
                btnFavoritar.Visible = true;
            }
            else
            {
                MessageBox.Show("Selecione uma Raça para Buscar");
                LimpaResultados();
            }
        }

        private void CarregaResultadoTela(CatModel Resultado)
        {
            lblDescricao.Text = Resultado.description;
            lblOrigem.Text = Resultado.origin;
            lblTemperamento.Text = Resultado.temperament;
            pictureCatImage.ImageLocation = ApiCatAsService.GetImagemPorImageID(Resultado.reference_image_id);
            pictureCatImage.SizeMode = PictureBoxSizeMode.Zoom;

        }

        private void LimpaResultados()
        {
            lblDescricao.Text = "Resultado";
            lblOrigem.Text = "Resultado";
            lblTemperamento.Text = "Resultado";
        }

        private void btnFavoritar_Click(object sender, EventArgs e)
        {
            if (cbListaRacas.SelectedIndex > 0)
            {
                string idRaca = cbListaRacas.Text;
                CatModel racaEscolhida = ApiCatAsService.GetCaracteristicasPorNome(idRaca);
                ApiCatAsService.FavoritarCat(racaEscolhida.reference_image_id);
                MessageBox.Show($"Raça {racaEscolhida.name} favoritada com sucesso!");

                //Adicioanr condicional se favouriting ocorreu com sucesso, exception
            }
            else
            {
                MessageBox.Show("Selecione uma Raça para Favoritar");
                LimpaResultados();
            }
        }
    }
}