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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace practical_task_18_Animals
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window,IAnimal
    {
        
        Presenter presenter;
        public MainWindow()
        {
            InitializeComponent();
            presenter = new Presenter(this);
            presenter.Load();
            buttonSave.Click += (s, e) => presenter.AddAnimal();
            buttonDeleteBirds.Click += (s, e) => presenter.Delete();
            buttonDeleteAmphibians.Click += (s, e) => presenter.Delete();
            buttonDeleteMammals.Click += (s, e) => presenter.Delete();
            buttonUpdateBirds.Click += (s, e) => presenter.Update();
            buttonUpdateMammals.Click += (s, e) => presenter.Update();
            buttonUpdateAmphibians.Click += (s, e) => presenter.Update();
            buttonSaveFile.Click += (s, e) => presenter.SaveFile(formatIbdex);
        }
        public int formatIbdex { get => comboBoxformatFail.SelectedIndex + 1; }
        public Birds Birds { get => (Birds)gridViewBirds.SelectedItem;  }
        public Mammals Mammals { get => (Mammals)gridViewMammals.SelectedItem; }
        public Amphibians Amphibians { get => (Amphibians)gridViewAmphibians.SelectedItem; }
        public int Id { get => comboBox.SelectedIndex + 1; }
        public string Family { get => textBoxFamily.Text; }
        public string Detachment { get => textBoxSquad.Text; }
        public string ViweAnimal { get => textBoxTipe.Text; }
        public void LoadData(List<Birds> birds, List<Amphibians> amphibians, List<Mammals> mammals)
        {
            gridViewBirds.ItemsSource = birds;
            gridViewAmphibians.ItemsSource = amphibians;
            gridViewMammals.ItemsSource = mammals;
        }
    }
}
