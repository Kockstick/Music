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

namespace Music
{
    /// <summary>
    /// Логика взаимодействия для MusicItem.xaml
    /// </summary>
    public partial class MusicItem : Border
    {
        public string name
        {
            get
            {
                return nameLabel.Content.ToString();
            }
            set
            {
                nameLabel.Content = value;
            }
        }

        public MusicItem()
        {
            InitializeComponent();
        }

        public MusicItem(string name) : this()
        {
            this.name = name;
        }
    }
}
