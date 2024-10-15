//using static Android.Provider.ContactsContract.CommonDataKinds;

using static System.Net.Mime.MediaTypeNames;

namespace JcardenasTS2.Views;

public partial class Calificaciones : ContentPage
{
	public Calificaciones()
	{
		InitializeComponent();
	}

	

    private void btnCalculo_Clicked(object sender, EventArgs e)
    {

        string fec = dpFecha.ToString();


        //calFecha.Text = fec;
        //var dia = DateTime(calFecha.Text);



        DisplayAlert("Calculo", "Estudiante: " + selPk.Text + "\n"+
            "Fecha: " + calFecha.Text  + "\n"+
            "Nota Parcial 1: "+parcial1.Text+"\n"+
            "Nota Parcial 2: " + parcial2.Text + "\n" +
            "Nota Final " + notaFinal.Text + "\n"+
            "Estatus: " + Estado.Text + "\n",
            "OK");


      
    }

    private void notaE1_Unfocused(object sender, FocusEventArgs e)
    {
        var E1= Int32.Parse(notaE1.Text);
        
        if (E1 >= 10)
        {

            DisplayAlert("ALERTA", "Solo puede ingresar valor entre 1 y 10", "OK");
            
            return;

        }

        var CalS1= Int32.Parse(notaS1.Text)*0.3;
        var Cal_E1 = Int32.Parse(notaE1.Text) * 0.2;
        var totalM1=CalS1 + Cal_E1;
        parcial1.Text = totalM1.ToString();



    }

    private void notaE2_Unfocused(object sender, FocusEventArgs e)
    {

        var CalS2 = Int32.Parse(notaS2.Text) * 0.3;
        var Cal_E2 = Int32.Parse(notaE2.Text) * 0.2;
        var totalM2 = CalS2 + Cal_E2;
        parcial2.Text = totalM2.ToString();
        
        var CalS1 = Int32.Parse(notaS1.Text) * 0.3;
        var Cal_E1 = Int32.Parse(notaE1.Text) * 0.2;
        var totalM1 = CalS1 + Cal_E1;
       





        var valorFinal = totalM1 + totalM2;



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

    private void notaS1_Unfocused(object sender, FocusEventArgs e)
    {
        var NotaS1 = Int32.Parse(notaS1.Text);

        if (NotaS1 >= 10)
        {

            DisplayAlert("ALERTA", "Solo puede ingresar valor entre 1 y 10", "OK");
            return;
            }
    }
}