namespace Moeda
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void CoinFlipButton_Clicked(object sender, EventArgs e)
        {

            //Joga a moeda onde 0 é coroa e 1 é cara
            //Primeiro desafio: Utiliza uma enumeração para Cara ou Coroa
            int coin = new Random().Next(2);
            string selectedSide = Convert.ToString(HeadTailsPicker.SelectedItem);

            if (coin == 0) {
                CoinImage.Source = "coroa.png";
            }
            if (coin == 1)
            {
                CoinImage.Source = "cara.png";
            }
            if (coin == 0 && selectedSide == "Coroa")
            {
                ResultLabel.Text = "PARABÉNS, VOCÊ GANHOU ";
            }
            if (coin == 0 && selectedSide == "Coroa")
            {
                ResultLabel.Text = "QUE PENA, VOCÊ PERDEU ";
            }
            if (coin == 0 && selectedSide == "Cara")
            {
                ResultLabel.Text = "PARABÉNS, VOCÊ GANHOU ";
            }
            if (coin == 0 && selectedSide == "Cara")
            {
                ResultLabel.Text = "QUE PENA, VOCÊ PERDEU ";
            }
            //Verifica o que o usuário selecionou
            // Se o usuário selecionou a mesma coisa, exibe uma mensagem de "vitória"
            // Se o usuário selecionou a mesma coisa errada, exibe uma mensagem de "derrota"
        }
    }

}
