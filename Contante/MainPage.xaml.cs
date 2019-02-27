using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Contante
{
    public partial class MainPage : ContentPage
    {
        int i = 1;
        public MainPage()
        {
            InitializeComponent();
        }

        void ClicadaDoBotao(object sender, EventArgs e){

            label_status.Text = "Voce clicou " + i + " Vezes";

            button_clique.Text = "Novo Botao";

            i++;
        }
    }
}
