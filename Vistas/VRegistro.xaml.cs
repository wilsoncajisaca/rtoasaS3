namespace rtoasaS2.Vistas;

public partial class VRegistro : ContentPage
{
	public VRegistro()
	{
        InitializeComponent();
	}

    private void btnGuardar_Clicked(object sender, EventArgs e)
    {
        string userReg = txtUser.Text;
        string contReg = txtContraseña.Text;

        objetos.INPDatos.Usuarios.Add(new objetos.INPLogin(userReg, contReg));

        Navigation.PushAsync(new VGrid());
    }
}