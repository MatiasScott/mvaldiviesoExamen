namespace mvaldiviesoExamen.Views;

public partial class Registro : ContentPage
{
    private string usuario;
	public Registro(String usuario)
	{
		InitializeComponent();
        this.usuario = usuario;
		lblconectado.Text = "Usuario Conectado: " + usuario;
    }

    private void btnRegistrar_Clicked(object sender, EventArgs e)
    {
        decimal montoinicial = decimal.Parse(txtmontoinicial.Text);
    }

    private void btnResumen_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Views.Resumen());
    }
}