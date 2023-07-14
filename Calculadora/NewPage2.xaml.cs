namespace Calculadora;

public partial class NewPage2 : ContentPage
{
	public NewPage2()
	{
		InitializeComponent();
		limpiartodo(this, null);
	}
    //int valoractual = 1;
    string fx;
    double r,x;
    //double primernum, segundonum;
    Calc cal=new Calc();
    public void Entrada()
    {
        fx = datofx.Text;      
    }
    public void Salida(double r)
    {
        solucion.Text=r.ToString();
    }

	void limpiartodo (object sender, EventArgs e)
	{
        this.solucion.Text = "0";
        this.datofx.Text = " ";
    }
    void numerselect(object sender, EventArgs e)
	{
        Button button = (Button)sender;
        string btnPressed = button.Text;
		//this.solucion.Text = btnPressed;
        this.datofx.Text += btnPressed.ToString();
    }
    void operadorseleccionado(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        string btnPressed = button.Text;
        //this.solucion.Text = btnPressed;
        this.datofx.Text += btnPressed.ToString();
    }
    void calcular(object sender, EventArgs e)
    {
        try
        {
            Entrada();
            r=cal.Fun(x,fx);
            Salida(r);
        }
        catch
        {
            DisplayAlert("Syntax error", "error de datos", "OK");
        }
        
    }
    void deletetext(object sender, EventArgs e)
    {
        try
        {
            Entrada();
            String text = datofx.Text;
            datofx.Text=text.Substring(0,text.Length-1);
        }
        catch
        {
            DisplayAlert("Syntax error", "intenta de nuevo", "OK");
        }
        
    }
}