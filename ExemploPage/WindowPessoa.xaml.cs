using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ExemploPage
{
    /// <summary>
    /// Lógica interna para WindowPessoa.xaml
    /// </summary>
    public partial class WindowPessoa : Window
    {

        public ViewModelPessoa vmPessoa {get; set; }
        public WindowPessoa()
        {
            vmPessoa = new ViewModelPessoa();
            InitializeComponent();            
            this.DataContext = vmPessoa;

            
        }

        private void PessoasDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Pessoa p = vmPessoa.PessoaSelecionada;
            UserControl page = PessoaViewFactory.VisualizarPessoa(p);
            while (PessoaContent.Children.Count > 0)
            {
                PessoaContent.Children.RemoveAt(0);
            }
            PessoaContent.Children.Add(page);

        }
   
    }

    public class PessoaViewFactory
    {
        static public UserControl VisualizarPessoa(Pessoa pessoa)
        {

            if(pessoa is PessoaFisica)
            {
                var pg = new PessoaFisicaUC();
                pg.Pessoa = (PessoaFisica)pessoa;
                return pg;
               
            }else if (pessoa is PessoaJuridica)
            {
                var pg = new PessoaJuridicaUC();
                pg.Pessoa = (PessoaJuridica)pessoa;
                return pg;
            }
            return null;
        }
    }
}
