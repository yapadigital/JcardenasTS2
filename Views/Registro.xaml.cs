namespace JcardenasTS2.Views;

public partial class Registro : ContentPage
{
	public Registro()
	{
		InitializeComponent();
	}

    private void btnGuardar_Clicked(object sender, EventArgs e)
    {
       string usuario = txtUsuario.Text;
       string contrasena = txtContrase�a.Text;
       
        Navigation.PushAsync(new Views.Login(usuario, contrasena));

    }
}