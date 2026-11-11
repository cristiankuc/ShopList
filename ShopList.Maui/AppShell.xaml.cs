using ShopList.Maui.Views;

namespace ShopList.Maui
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // registra las rutas de las paginas de la aplicacion
            Routing.RegisterRoute(nameof(EditItemPage),typeof(EditItemPage));
        }
    }
}
