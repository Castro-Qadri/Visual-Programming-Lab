using System.Windows;
using InventoryApp.Views;

namespace _01Project_InventoryManagementSystem
{
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            // Show the Login page
            var loginPage = new LoginPage(); // Updated to match class name
            if (loginPage.ShowDialog() == true) // Login successful
            {
                // Open the Dashboard inside a Window
                var dashboardWindow = new Window
                {
                    Title = "Dashboard",
                    Content = new DashboardPage(), // Embed the UserControl
                    Width = 800,
                    Height = 600
                };
                dashboardWindow.Show();
            }
            else
            {
                // Exit the application if login fails or is canceled
                Shutdown();
            }
        }
    }
}
