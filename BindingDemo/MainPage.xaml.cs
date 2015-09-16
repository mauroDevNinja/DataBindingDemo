using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace BindingDemo
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void btn_Sumar_Click(object sender, RoutedEventArgs e)
        {
            int resultado = int.Parse(tb_valor1.Text) + int.Parse(tb_valor2.Text);

            tb_Resultado.Text = resultado.ToString();
        }
    }
}
