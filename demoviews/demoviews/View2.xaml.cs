using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace demoviews
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class View2 : ContentPage
	{
		public View2 ()
		{
			InitializeComponent ();
		}

        private void pickMusic_SelectedIndexChanged(object sender,System.EventArgs e)
        {
            var elementoSelecionado = pickMusic.SelectedItem.ToString();
            DisplayAlert("Genero Mùsica", elementoSelecionado, "Aceptar");
        }

        private void btnSimular_Clicked(object sender, EventArgs e)
        {
            var progreso = progressNum.Progress;
            if (progreso == 1)
            {
                progressNum.ProgressTo(.1, 250, Easing.SpringOut);
                
            }
            else
            {
                progressNum.ProgressTo(1, 300, Easing.Linear);
            }
        }

        private void searchBar_SearchButtonPressed(object sender, System.EventArgs e)
        {
            DisplayAlert("Buscado", "Buscando Resutados", "Aceptar");
        }

        private void searchBar_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            DisplayAlert("Cambiando", "Este textoesta cambiando", "Aceptar");
        }

        private void slider_ValueChanged(object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            labCambio.Text = slider.Value.ToString();
        }

        private void steeper_ValueChanged(object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            ldDisplay.Text = steeper.Value.ToString();
        }

        private void swtEstado_Toggled(object sender, ToggledEventArgs e)
        {
            var estado = this.swtEstado.IsToggled;
            if (this.swtEstado.IsToggled)
            {

                DisplayAlert("Switch", "Estoy encendido", "Aceptar");
            }
            else
            {

                DisplayAlert("Switch", "Estoy apagado", "Aceptar");
            }
        }
    }
}