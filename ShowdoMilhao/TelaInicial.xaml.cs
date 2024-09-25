namespace ShowdoMilhao
{
    public partial class TelaInicial : ContentPage
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void OnStartGameClicked(object sender, EventArgs e)
        {
            DisplayAlert("Iniciar", "O jogo vai começar!", "OK");
             Application.Current.MainPage = new MainPage();
        }
    }
}
