using CatAsService.APIService;

namespace CatAsService
{
    public partial class FrmTelaPrincipal : Form
    {
        private ClsCatAsService ApiCatAsService;

        public FrmTelaPrincipal()
        {
            InitializeComponent();
            ApiCatAsService = new ClsCatAsService();
            ApiCatAsService.DeletarTodosFavoritos();
        }

        private void buscarRacasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBuscarRacas frmBuscaRacas = new FrmBuscarRacas();
            frmBuscaRacas.ShowDialog();
        }

        private void meusFavoritosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRelatorioFavoritos frmRelatorioFavoritos = new FrmRelatorioFavoritos();
            frmRelatorioFavoritos.ShowDialog();
        }
    }
}
