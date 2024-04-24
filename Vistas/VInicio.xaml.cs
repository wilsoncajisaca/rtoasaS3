namespace rtoasaS2.Vistas;

public partial class VInicio : ContentPage
{
	public VInicio(string user)
	{
		InitializeComponent();
        DisplayAlert("Alerta", "Bienvenido: " + user, "Cerrar");
        lblUser.Text = "Usuario conectado: " + user;
	}
    private void btnPickerClik(object sender, EventArgs o)
    {
        if (pkCiudades.SelectedIndex == -1)
        {
            DisplayAlert("Alerta", "No existe dato", "Cerrar");
        }
        else
        {
            string dato = pkCiudades.Items[pkCiudades.SelectedIndex].ToString();
            DisplayAlert("Alerta", "Elemento seleccionado es: " + dato, "Cerrar");
        }
    }

    private void btnFechaClick(object sender, EventArgs o)
    {
        string fecha=dpFecha.Date.ToString("MM/dd/yyyy");
        lblFecha.Text = "La fecha es:" + fecha;
    }
}