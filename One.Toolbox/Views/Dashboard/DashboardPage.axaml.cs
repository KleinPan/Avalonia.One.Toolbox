using Avalonia.Controls;

using Microsoft.Extensions.DependencyInjection;

using One.Toolbox.ViewModels.Dashboard;

namespace One.Toolbox.Views.Dashboard
{
    public partial class DashboardPage : UserControl
    {
        // public DashboardVM ViewModel { get; }

        public DashboardPage()
        {
            // DataContext = ViewModel = App.Current.Services.GetService<DashboardVM>();
            InitializeComponent();
        }
    }
}