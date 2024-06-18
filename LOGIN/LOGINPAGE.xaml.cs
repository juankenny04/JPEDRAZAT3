using JPEDRAZAT3.GRADES;

namespace JPEDRAZAT3.LOGIN;

public partial class LOGINPAGE : ContentPage

{
    // Vectores de usuarios y contraseñas
    string[] users = { "Carlos", "Ana", "Jose" };
    string[] passwords = { "carlos123", "ana123", "jose123" };

    public LOGINPAGE()
	{
		InitializeComponent();
	}
    private async void OnLoginButtonClicked(object sender, EventArgs e)
    {
        string username = usernameEntry.Text;
        string password = passwordEntry.Text;

        for (int i = 0; i < users.Length; i++)
        {
            if (username == users[i] && password == passwords[i])
            {
                await DisplayAlert("Bienvenido", $"Bienvenido {username}!", "OK");
                await Navigation.PushAsync(new GRADESPAGES(username));
                return;
            }
        }
        await DisplayAlert("Error", "Invalid username or password", "OK");
    }
}

