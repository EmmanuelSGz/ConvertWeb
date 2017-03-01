using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cmain : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }
    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        double onza, libra, kilogramo;
        double kilometros, pulgadas, pies;
        double pesos, euros;
        double valor, resultado;

        onza = 28.38; libra = 16.00;kilogramo=1.62;
        pies = 0.305; kilometros = 100.00; pulgadas = 2.54; 
        pesos = 0.0226; euros = 59.15;
        valor = double.Parse(TextBox1.Text);
        
        if(RadioButton1.Checked == true){
            resultado = valor / libra;
            TextBox2.Text = resultado.ToString();

                RadioButton2.Checked = false;RadioButton3.Checked = false;RadioButton4.Checked = false;
                RadioButton5.Checked = false;RadioButton6.Checked = false;RadioButton7.Checked = false;
                RadioButton8.Checked = false;RadioButton9.Checked = false;RadioButton10.Checked = false;
                RadioButton11.Checked = false;RadioButton12.Checked = false;
            
        }

        if (RadioButton2.Checked == true){
            resultado = valor / kilogramo;
            TextBox2.Text = resultado.ToString();

            RadioButton1.Checked = false; RadioButton3.Checked = false; RadioButton4.Checked = false;
            RadioButton5.Checked = false; RadioButton6.Checked = false; RadioButton7.Checked = false;
            RadioButton8.Checked = false; RadioButton9.Checked = false; RadioButton10.Checked = false;
            RadioButton11.Checked = false; RadioButton12.Checked = false;
        }

        if (RadioButton3.Checked == true){
            resultado = valor * libra;
            TextBox2.Text = resultado.ToString();

            RadioButton2.Checked = false; RadioButton1.Checked = false; RadioButton4.Checked = false;
            RadioButton5.Checked = false; RadioButton6.Checked = false; RadioButton7.Checked = false;
            RadioButton8.Checked = false; RadioButton9.Checked = false; RadioButton10.Checked = false;
            RadioButton11.Checked = false; RadioButton12.Checked = false;
        }

        if (RadioButton4.Checked == true){
            resultado = (valor * libra) * onza;
            TextBox2.Text = resultado.ToString();

            RadioButton2.Checked = false; RadioButton3.Checked = false; RadioButton1.Checked = false;
            RadioButton5.Checked = false; RadioButton6.Checked = false; RadioButton7.Checked = false;
            RadioButton8.Checked = false; RadioButton9.Checked = false; RadioButton10.Checked = false;
            RadioButton11.Checked = false; RadioButton12.Checked = false;
        }

        if (RadioButton5.Checked == true ){
            resultado = (valor * kilogramo) * onza;
            TextBox2.Text = resultado.ToString();

            RadioButton2.Checked = false; RadioButton3.Checked = false; RadioButton4.Checked = false;
            RadioButton1.Checked = false; RadioButton6.Checked = false; RadioButton7.Checked = false;
            RadioButton8.Checked = false; RadioButton9.Checked = false; RadioButton10.Checked = false;
            RadioButton11.Checked = false; RadioButton12.Checked = false;
        }

        if (RadioButton6.Checked == true){
            resultado = valor / pies;
            TextBox2.Text = resultado.ToString();

            RadioButton2.Checked = false; RadioButton3.Checked = false; RadioButton4.Checked = false;
            RadioButton5.Checked = false; RadioButton1.Checked = false; RadioButton7.Checked = false;
            RadioButton8.Checked = false; RadioButton9.Checked = false; RadioButton10.Checked = false;
            RadioButton11.Checked = false; RadioButton12.Checked = false;
        }

        if (RadioButton7.Checked == true){
            resultado = (valor * pies) * pulgadas;
            TextBox2.Text = resultado.ToString();

            RadioButton2.Checked = false; RadioButton3.Checked = false; RadioButton4.Checked = false;
            RadioButton5.Checked = false; RadioButton6.Checked = false; RadioButton1.Checked = false;
            RadioButton8.Checked = false; RadioButton9.Checked = false; RadioButton10.Checked = false;
            RadioButton11.Checked = false; RadioButton12.Checked = false;
        }

        if (RadioButton8.Checked == true){
            resultado = valor / kilometros;
            TextBox2.Text = resultado.ToString();

            RadioButton2.Checked = false; RadioButton3.Checked = false; RadioButton4.Checked = false;
            RadioButton5.Checked = false; RadioButton6.Checked = false; RadioButton7.Checked = false;
            RadioButton1.Checked = false; RadioButton9.Checked = false; RadioButton10.Checked = false;
            RadioButton11.Checked = false; RadioButton12.Checked = false;
        }

        if (RadioButton9.Checked == true){
            resultado = (valor * kilometros) * (pulgadas * kilometros);
            TextBox2.Text = resultado.ToString();

            RadioButton2.Checked = false; RadioButton3.Checked = false; RadioButton4.Checked = false;
            RadioButton5.Checked = false; RadioButton6.Checked = false; RadioButton7.Checked = false;
            RadioButton8.Checked = false; RadioButton1.Checked = false; RadioButton10.Checked = false;
            RadioButton11.Checked = false; RadioButton12.Checked = false;
        }

        if (RadioButton10.Checked == true)
        {
            resultado = valor * pesos;
            TextBox2.Text = resultado.ToString();
            RadioButton2.Checked = false; RadioButton3.Checked = false; RadioButton4.Checked = false;
            RadioButton5.Checked = false; RadioButton6.Checked = false; RadioButton7.Checked = false;
            RadioButton8.Checked = false; RadioButton9.Checked = false; RadioButton1.Checked = false;
            RadioButton11.Checked = false; RadioButton12.Checked = false;
        }

        if (RadioButton11.Checked == true)
        {
            resultado = valor * 59.15;
            TextBox2.Text = resultado.ToString();

            RadioButton2.Checked = false; RadioButton3.Checked = false; RadioButton4.Checked = false;
            RadioButton5.Checked = false; RadioButton6.Checked = false; RadioButton7.Checked = false;
            RadioButton8.Checked = false; RadioButton9.Checked = false; RadioButton10.Checked = false;
            RadioButton1.Checked = false; RadioButton12.Checked = false;
        }

        if (RadioButton12.Checked == true)
        {
            resultado = valor * 44.25;
            TextBox2.Text = resultado.ToString();

            RadioButton2.Checked = false; RadioButton3.Checked = false; RadioButton4.Checked = false;
            RadioButton5.Checked = false; RadioButton6.Checked = false; RadioButton7.Checked = false;
            RadioButton8.Checked = false; RadioButton9.Checked = false; RadioButton10.Checked = false;
            RadioButton11.Checked = false; RadioButton1.Checked = false;
        }

    }
}