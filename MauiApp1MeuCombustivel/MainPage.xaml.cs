
using Microsoft.VisualBasic;
using Windows.Media.Audio;

namespace MauiApp1MeuCombustivel
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {

                double etanol = Convert.ToDouble(txt_etanol.Text);
                double gasolina = Convert.ToDouble(txt_gasolina.Text);
                string marca = txt_marca_veiculo.Text;
                string modelo = txt_modelo_veiculo.Text;

                string msg = "";

                if (etanol <= (gasolina * 0.7))
                {
                    msg = "O Etanol está compensando para o seu " + marca + " e " + modelo;
                }else
                {
                    msg = "A gasolina esta compensando para o seu " + marca + " e " + modelo;
                }

                DisplayAlert("Calculado", msg, "OK");
            }catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Fechar");
            }
     
        } //Fecha metodo
    }//Fecha Class
}//Fecha namespace
