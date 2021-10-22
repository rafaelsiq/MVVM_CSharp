using System;
using System.Collections.Generic;
using System.Text;
using Projeto_OO.View.Pages;

namespace Projeto_OO.ViewModel.UseCases
{
    class AcessarHomePage
    {
        public AcessarHomePage() {
            Home home = new Home();
            home.Show();

        }

    }
}
