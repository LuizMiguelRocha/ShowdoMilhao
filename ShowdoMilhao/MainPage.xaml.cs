namespace ShowdoMilhao
{
    public partial class MainPage : ContentPage
    {
        Gerenciador gerenciador;
        public MainPage()
        {
            InitializeComponent();
            gerenciador = new Gerenciador(LabelPergunta, ButtonResposta1, ButtonResposta2, ButtonResposta3, ButtonResposta4, ButtonResposta5);
            gerenciador.ProximaQuestao();
        }

        // Eventos para os botões do meio
        private void OnButton1Clicked(object sender, EventArgs e)
        {
            gerenciador.VerificarCorreto(1);
        }

        private void OnButton2Clicked(object sender, EventArgs e)
        {
            gerenciador.VerificarCorreto(2);
        }

        private void OnButton3Clicked(object sender, EventArgs e)
        {
           gerenciador.VerificarCorreto(3);
        }

        private void OnButton4Clicked(object sender, EventArgs e)
        {
            gerenciador.VerificarCorreto(4);
        }

        private void OnButton5Clicked(object sender, EventArgs e)
        {
            gerenciador.VerificarCorreto(5);
        }

        // Eventos para os botões na parte inferior
        private void OnButton6Clicked(object sender, EventArgs e)
        {
            // Ação do Botão 6
        }

        private void OnButton7Clicked(object sender, EventArgs e)
        {
            // Ação do Botão 7
        }

        private void OnButton8Clicked(object sender, EventArgs e)
        {
            // Ação do Botão 8
        }
    }
}
