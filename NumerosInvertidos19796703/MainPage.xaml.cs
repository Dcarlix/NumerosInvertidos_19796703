namespace NumerosInvertidos19796703
{
    public partial class MainPage : ContentPage
    {
        /// <summary>
        /// En este programa hacemos que el usurio tenga la opcion de ingresar numeros en unos entry, los cuales despues de darle click al boton de invertir, mostrara lo numeros que ingreso el usuario pero en un orden inverso
        /// </summary>
        public MainPage()
        {
            InitializeComponent();
        }

		private void Button_Clicked(object sender, EventArgs e)
		{
            var num1 = numero1.Text;
            var num2 = numero2.Text;
            var num3 = numero3.Text;
            var num4 = numero4.Text;

            string invertidos = string.Concat(num4,num3,num2,num1);

            numInvertidos.Text = invertidos;
		}
    }

}
