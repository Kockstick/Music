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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Music
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<MusicItem> musics = new List<MusicItem>();

        public MainWindow()
        {
            InitializeComponent();
            AddItem("Pablo");
            AddItem("Frederiko");
            AddItem("Gamgamstyle");
            AddItem("Monro");
            AddItem("Dulo");
            AddItem("Lambada");
        }

        public void AddItem(string name)
        {
            MusicItem item = new MusicItem(name);
            StackPanel.Children.Add(item);
            musics.Add(item);
        }

        public void Search(string text)
        {
            List<MusicItem> list = new List<MusicItem>();

            if(text != null && text.Length > 0)
                list = musics.Where(u => u.name.ToLower().Contains(text.ToLower())).ToList();
            else
                list = musics;

            StackPanel.Children.Clear();
            foreach (var item in list)
            {
                StackPanel.Children.Add(item);
            }
        }

        private void searchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            Search(textBox.Text);
        }
    }
}
