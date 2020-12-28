using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NuBank.Apresentacao
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Slider2 : ContentPage
    {
        private string Texto = @"Nubank é uma empresa startup brasileira pioneira no segmento de serviços financeiros, atuando como operadora de cartões de crédito e fintech com operações no Brasil, sediada em São Paulo e fundada em 6 de maio de 2013 por David Vélez.[4][5][6] Em 2014, a empresa lançou o seu primeiro produto, um cartão de crédito internacional com a bandeira Mastercard, sem anuidade e completamente gerenciado por meio de um aplicativo.Em 2017, o Nubank também lançou seu programa de benefícios, o Nubank Rewards, e a anteriormente denominada NuConta, agora chamada conta digital do Nubank, que já é usada por mais de 12 milhões de brasileiros.[7] Em 2019, passou a oferecer empréstimos para alguns clientes.[8]"; 
        public Slider2()
        {
           
            InitializeComponent();
            lblTextoApresentacao.Text = Texto;
        }
    }
}