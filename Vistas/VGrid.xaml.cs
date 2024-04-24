namespace rtoasaS2.Vistas;

public partial class VGrid : ContentPage
{
    public VGrid()
    {
        InitializeComponent();
        objetos.INPDatos.Usuarios.Add(new objetos.INPLogin("admin", "admin"));
    }

    private void Button_Clicked(object sender, EventArgs e)
    {

    }

    private void btnInicio_Clicked(object sender, EventArgs e)
    {
        bool usuarioEncontrado = false;
        foreach (var usuario in objetos.INPDatos.Usuarios)
        {
            if (usuario.User == txtNombre.Text && usuario.Password == txtContraseña.Text)
            {
                Navigation.PushAsync(new VInicio(usuario.User));
                usuarioEncontrado = true;
                break;
            }
        }
        if (!usuarioEncontrado)
        {
            DisplayAlert("Alerta", "Alerta usuario y/o contraseña incorrectos", "Cerrar");
        }
    }

    private void btnRegistro_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new VRegistro());
    }
}