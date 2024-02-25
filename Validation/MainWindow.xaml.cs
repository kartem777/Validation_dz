using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Validation
{
    public partial class MainWindow : Window
    {
        Student student;
        public MainWindow()
        {
            InitializeComponent();
            student = new Student("", "", 0, "+380123456789");
            this.DataContext = student;
        }

    }
}