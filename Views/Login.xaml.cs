namespace JcardenasTS2.Views;

public partial class Login : ContentPage
{

    //string user, password;

    private string[] user = { "Carlos", "Ana", "Jose" };
    private string[] password = { "carlos123", "ana123", "jose123" };


    public Login()
    {
        InitializeComponent();
    }

   public Login(string usuario, string contrasena)
   {
      InitializeComponent();
        
     

   }
    private void btnIniciar_Clicked(object sender, EventArgs e)
    {
        string usuario = txtUsuario.Text;
        string contrasena = txtContraseña.Text;
        int index = Array.IndexOf(user, usuario);

        //Generar condicional

        // if (usuario == user && contrasena == password)
        // {
        //   Navigation.PushAsync(new Views.Calificaciones());
        // }
        // else
        // {

        //  DisplayAlert("Error", "Usuario/Contraseña no validos", "Cerrar");
        // }

        if (index >= 0 && password[index] == contrasena)
        {
            // Mensaje
            DisplayAlert("Bienvenido", $"Hola, {usuario} un gusto tenerte aquí", "Cerrar");
            //Llama a la carpeta y Operaciones.xaml
            Navigation.PushAsync(new Views.Calificaciones());
            //
        }
        else
        {
            DisplayAlert("ERROR", "Usuario/Contraseña Incorrectos", "Cerrar");
        }


    }


    private void btnRegistro_Clicked(object sender, EventArgs e)

    {
        Navigation.PushAsync(new Views.Registro());

    }
}