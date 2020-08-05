using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Notes
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        string _nomeArquivo = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Notas.txt");

        public MainPage()
        {
            InitializeComponent();

            if (File.Exists(_nomeArquivo))
                txtEditorArquivo.Text = File.ReadAllText(_nomeArquivo);            
        }

        void BotaoSalvar(object sender, EventArgs e)
        {
            File.WriteAllText(_nomeArquivo, txtEditorArquivo.Text);
        }

        void BotaoApagar(object sender, EventArgs e)
        {
            if (File.Exists(_nomeArquivo))
                File.Delete(_nomeArquivo);

            txtEditorArquivo.Text = string.Empty;
        }
    }
}
