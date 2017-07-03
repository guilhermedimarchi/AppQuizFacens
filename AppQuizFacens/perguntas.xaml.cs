using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace AppQuizFacens
{
    public partial class perguntas : PhoneApplicationPage
    {
        public perguntas()
        {
            InitializeComponent();
        }

        private void btnFinal_Click(object sender, RoutedEventArgs e)
        {
            int pontos = 0;

            if (rb12.IsChecked == true)
                pontos++;
            if (rb21.IsChecked == true)
                pontos++;
            if (rb31.IsChecked == true)
                pontos++;
            if (rb43.IsChecked == true)
                pontos++;
            if (rb53.IsChecked == true)
                pontos++;
            if (rb61.IsChecked == true)
                pontos++;
            if (rb71.IsChecked == true)
                pontos++;
            if (rb81.IsChecked == true)
                pontos++;

            txtResultado.Text = "Vc fez " + pontos + " pontos!";

        }
    }
}