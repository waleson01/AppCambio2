using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppCambio2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try {

                decimal cotacao = Convert.ToDecimal(txt_cotacao.Text);
                decimal dolares = Convert.ToDecimal(txt_quantia_usd);

                decimal reais = cotacao * dolares;


            
            }
        }
    }
}
