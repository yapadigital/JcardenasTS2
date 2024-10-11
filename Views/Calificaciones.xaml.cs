//using static Android.Provider.ContactsContract.CommonDataKinds;

using static System.Net.Mime.MediaTypeNames;

namespace JcardenasTS2.Views;

public partial class Calificaciones : ContentPage
{
	public Calificaciones()
	{
		InitializeComponent();
	}

	private void notaS1_Completed(object sender, EventArgs e)
	{
		var nota1 = Int32.Parse(notaS1.Text);

		if (nota1 >= 10)
		{

			DisplayAlert("ALERTA", "Solo puede ingresar valor entre 1 y 10", "OK");
			return;
					
		}
        
    }

    private void notaE1_Completed(object sender, EventArgs e)
    {
        var notaEx1 = Int32.Parse(notaE1.Text);

		if (notaEx1 >= 10)
		{

			DisplayAlert("ALERTA", "Solo puede ingresar valor entre 1 y 10", "OK");
			return;

		}

        
        
    }

  

    private void notaS2_Completed(object sender, EventArgs e)
    {

        var nota2 = Int32.Parse(notaS2.Text);

            if (nota2 >= 10)
            {
            DisplayAlert("ALERTA", "Solo puede ingresar valor entre 1 y 10", "OK");
            return;
             }

    }

    private void notaE2_Completed(object sender, EventArgs e)
    {
        var notaEx2 = Int32.Parse(notaE2.Text);

        if (notaEx2 >= 10)
        {

            DisplayAlert("ALERTA", "Solo puede ingresar valor entre 1 y 10", "OK");
            return;

        }
    }





    private void btnCalculo_Clicked(object sender, EventArgs e)
    {

        string fec = dpFecha.ToString();

        
        calFecha.Text = fec;



        DisplayAlert("Calculo", "Estudiante: " + selPk.Text + "\n"+
            "Fecha: " + calFecha.Text + "\n"+
            "Nota Parcial 1: "+parcial1.Text+"\n"+
            "Nota Parcial 2: " + parcial2.Text + "\n" +
            "Nota Final " + notaFinal.Text + "\n"+
            "Estatus: " + Estado.Text + "\n",
            "OK");


      
    }

    private void notaE1_Unfocused(object sender, FocusEventArgs e)
    {
        var nota_parcial1 = (Int32.Parse(notaE1.Text) + Int32.Parse(notaS1.Text)) * 0.3;

        parcial1.Text = nota_parcial1.ToString();

    }

    private void notaE2_Unfocused(object sender, FocusEventArgs e)
    {
        var nota_parcial1 = (Int32.Parse(notaE1.Text) + Int32.Parse(notaS1.Text)) * 0.3;
        var nota_parcial2 = (Int32.Parse(notaE2.Text) + Int32.Parse(notaS2.Text)) * 0.3;
       

        parcial2.Text = nota_parcial2.ToString();

        //notaFinal.Text = Int32.Parse(parcial1.Text) + Int32.Parse(parcial2.Text);
        var valorFinal = nota_parcial1 + nota_parcial2;

        notaFinal.Text= valorFinal.ToString();
        
        if (valorFinal <= 5)
        {
            Estado.Text = "Reprobado";
        }
        else
            if (valorFinal <= 6.99)
        {
            Estado.Text = "Complementario";
        }
        else
            Estado.Text = "Aprobado";
    }

    private void pkNombre_SelectedIndexChanged(object sender, EventArgs e)
    {
        var picker = (Picker)sender;
        var seleccion = picker.SelectedItem.ToString();
        selPk.Text = seleccion;

        
    }

    private void dpFecha_DateSelected(object sender, DateChangedEventArgs e)
    {
       //var fechaSeleccionada = e.NewDateTime;

        var FechaSel = e.NewDate;
        calFecha.Text=FechaSel.ToString();

    }
}