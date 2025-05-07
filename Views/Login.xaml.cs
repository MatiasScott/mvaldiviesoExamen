using System.Threading.Tasks;

namespace mvaldiviesoExamen.Views;

public partial class Login : ContentPage
{
	private Dictionary<string, string> users = new Dictionary<string, string>
	{
		{"estudiantes", "moviles"},
		{"uisrael", "2024" }
	};

	public Login()
	{
		InitializeComponent();
	}
	String usuario;
    public Login(String usuario)
    {
        InitializeComponent();
		this.usuario = usuario;
    }

    private void btnIniciar_Clicked(object sender, EventArgs e)
    {
		string user = txtusuario.Text;
		string pass = txtpassword.Text;

		if (user.Contains(user) && users[user] == pass) {
			Navigation.PushAsync(new Views.Registro(usuario));
		}
		else
		{
			DisplayAlert("Error", "Dato incorrecto", "Ok");
		}
    }
}