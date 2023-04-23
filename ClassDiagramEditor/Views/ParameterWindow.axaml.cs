using Avalonia.Controls;
using ClassDiagramEditor.ViewModels;

namespace ClassDiagramEditor.Views
{
    public partial class ParameterWindow : Window
    {
        public ParameterWindow()
        {
            InitializeComponent();
            DataContext = new ParameterWindowViewModel();
        }
    }
}
