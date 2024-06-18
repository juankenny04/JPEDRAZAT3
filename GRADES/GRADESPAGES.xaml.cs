namespace JPEDRAZAT3.GRADES;

public partial class GRADESPAGES : ContentPage
{
    private string _username;

    public GRADESPAGES(string username)
    {
		InitializeComponent();
        _username = username;
    }
    private async void OnCalculateButtonClicked(object sender, EventArgs e)
    {
        try
        {
            double seguimiento1 = Convert.ToDouble(seguimiento1Entry.Text);
            double examen1 = Convert.ToDouble(examen1Entry.Text);
            double parcial1 = seguimiento1 * 0.3 + examen1 * 0.2;

            double seguimiento2 = Convert.ToDouble(seguimiento2Entry.Text);
            double examen2 = Convert.ToDouble(examen2Entry.Text);
            double parcial2 = seguimiento2 * 0.3 + examen2 * 0.2;

            double notaFinal = parcial1 + parcial2;
            string estado;

            if (notaFinal >= 7)
            {
                estado = "APROBADO";
            }
            else if (notaFinal >= 5)
            {
                estado = "COMPLEMENTARIO";
            }
            else
            {
                estado = "REPROBADO";
            }

            string message = $"Nombre: {studentsPicker.SelectedItem}\n" +
                             $"Fecha: {datePicker.Date.ToString("d")}\n" +
                             $"Nota Parcial 1: {parcial1:F2}\n" +
                             $"Nota Parcial 2: {parcial2:F2}\n" +
                             $"Nota Final: {notaFinal:F2}\n" +
                             $"Estado: {estado}";

            await DisplayAlert("Resultados", message, "OK");
        }
        catch (Exception)
        {
            await DisplayAlert("Error", "Por favor, ingrese valores válidos.", "OK");
        }
    }
}
