using People.Models;
using System.Collections.Generic;

namespace People;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    public void OnNewButtonClicked(object sender, EventArgs args)
    {
        statusMessage.Text = "";

    App.PersonRepo.AddNewPerson(newPerson.Text);
    statusMessage.Text = App.PersonRepo.StatusMessage;

    if (!string.IsNullOrWhiteSpace(newPerson.Text))
    {
        DisplayAlert("Éxito", "¡Nombre guardado correctamente!", "OK");
    }

    newPerson.Text = ""; // Opcional: limpia el campo
    }

    public void OnGetButtonClicked(object sender, EventArgs args)
    {
        statusMessage.Text = "";

        List<Person> people = App.PersonRepo.GetAllPeople();
        peopleList.ItemsSource = people;
    }

}

