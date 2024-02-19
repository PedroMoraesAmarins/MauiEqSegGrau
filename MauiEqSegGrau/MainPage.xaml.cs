using Microsoft.UI.Xaml.Controls.Primitives;

namespace MauiEqSegGrau
{
    public partial class MainPage : ContentPage
    {
        double delta = 0;
        double x1 = 0, x2 = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txt_a.Text);
            double b = Convert.ToDouble(txt_b.Text);
            double c = Convert.ToDouble(txt_c.Text);

            delta = Math.Pow(b,2) - 4 * a * c;
            x1 = (((-1) * b) + Math.Pow(delta, 0.5)) / (2 * a);
            x2 = (((-1) * b) - Math.Pow(delta, 0.5)) / (2 * a);

            string msg = $"O resultado é {x1} e {x2}";

            DisplayAlert("Resultado", msg, "Fechar");
        }
    }

}
