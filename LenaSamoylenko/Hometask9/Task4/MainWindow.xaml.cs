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
using Microsoft.Win32;
using Task4.IsolatedStorage;


namespace Task4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string file;
        private string storage;


        public MainWindow()
        {
            InitializeComponent();
            CreateStorage createStorage = new CreateStorage();
        }

        private void open_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (openFileDialog.ShowDialog() == true)
            {
                file = openFileDialog.FileName;
                textBox.Text = file;
            }
        }

        private void Storage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Storage (*.set)|*set";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            if (openFileDialog.ShowDialog() == true)
            {
                storage = openFileDialog.SafeFileName;
                textBox1.Text = storage;
            }
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            IsolatedStorage.UseStorage useStorage = new UseStorage(storage);
            WriteToStorage write = new WriteToStorage(useStorage, file);
            FileInStorage file1 = new FileInStorage();
            file1.Show();
            
        }
    }
}
