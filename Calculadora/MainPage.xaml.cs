namespace Calculadora;

public partial class MainPage : ContentPage
{
	int valoractual = 1;
	string operadorMath;
	double primernum, segundonum;
	double seno,coseno,tang,logar,logard,senohi,cosenohi,tanhi,rcuad,rcubi;

	public MainPage()
	{
		InitializeComponent();
		limpiar(this, null);
	}
	
	void limpiar(object sender,EventArgs e)
	{
		primernum = 0;
		segundonum = 0;
		this.resultado.Text = "0";	
	}
	void potdos(object sender, EventArgs e)
	{
		if (primernum == 0) return;
		primernum = primernum * primernum;
		this.resultado.Text=primernum.ToString();
	}
	void raizcuadrada(object sender, EventArgs e) 
	{
		rcuad = Math.Sqrt(primernum);
		this.resultado.Text=rcuad.ToString();
	}
	void raizcubica(object sender, EventArgs e)
	{
		rcubi=Math.Cbrt(primernum);
		this.resultado.Text=rcubi.ToString();
	}
   void operadortang(object sender, EventArgs e) 
	{
		tang=Math.Tan(primernum);
		this.resultado.Text=tang.ToString();
	}
	void pi(object sender,EventArgs e)
	{
		primernum = Math.PI;
		this.resultado.Text = primernum.ToString();
	}
	void operadorlogar(object sender,EventArgs e)
	{
		logar= Math.Log(primernum);
		this.resultado.Text=logar.ToString();
	}
	void logardiez(object sender,EventArgs e)
	{
		logard = Math.Log10(primernum);
		this.resultado.Text=logard.ToString();
	}
	void senohiper(object sender,EventArgs e)
	{
		senohi=Math.Sinh(primernum);
		this.resultado.Text=senohi.ToString();
	}
	void cosenohiper(object sender,EventArgs e)
	{
		cosenohi=Math.Cosh(primernum);
		this.resultado.Text=cosenohi.ToString();
	}
	void tanhiper(object sender,EventArgs e) 
	{
		tanhi=Math.Tanh(primernum);
		this.resultado.Text=tanhi.ToString();
	}
    void operadorseno(object sender,EventArgs e)
	{

		if(primernum!=0)
		{
			seno= Math.Sin(primernum);
			this.resultado.Text=seno.ToString();
        }
		else
		{
			return;
		}
    }
    void operadorcos(object sender, EventArgs e)
    {
            coseno = Math.Cos(primernum);
            this.resultado.Text = coseno.ToString();
    }

    void numeroseleccionado(object sender, EventArgs e)
	{
		Button button= (Button)sender;
		string btnPressed = button.Text;

		if(this.resultado.Text=="0" || valoractual<0)
		{
			this.resultado.Text=string.Empty;
			if(valoractual<0)
			{
				valoractual *= -1;
			}
		}
		this.resultado.Text += btnPressed;

		double number;
		if(double.TryParse(this.resultado.Text, out number))
		{
			this.resultado.Text= number.ToString();
			if(valoractual==1)
			{
                primernum = number;
			}
			else
			{
				segundonum= number;
			}
		}

	}

	void operadorseleccionado(object sender, EventArgs e)
	{
		valoractual = -2;
		Button button= (Button)sender;
		string btnPressed= button.Text;
		operadorMath=btnPressed;
	}
	void calcular(object sender, EventArgs e)
	{
		if(valoractual ==2)
		{
			var resultado = Calculate.HazCalculo(primernum, segundonum, operadorMath);
			this.resultado.Text = resultado.ToString();
			primernum=resultado;
			valoractual = -1;
		}
    }

}

