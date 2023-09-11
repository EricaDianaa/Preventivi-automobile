using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace w13_1
{
    public partial class Automobile : System.Web.UI.Page
    {
        public static List<double> listOptional = new List<double>();
        public static List<double> listTotal = new List<double>();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = DropDownList1.SelectedItem.Value;
            ImageMap1.ImageUrl = $"~/Content/Immagini/{selectedValue}";
            if(selectedValue=="Dacia.png")
            {
                result.InnerText = "Valore di partenza di 6000 €";
             
            }
             else if (selectedValue == "fiat.png")
            {
                result.InnerText = "Valore di partenza di 2000 €";
         
            }
            else
            {
                result.InnerText = "Valore di partenza di 17000,00 €";
            
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

           listOptional.Clear();
            listTotal.Clear();
            string optionale;
            string valore;
           
            //totale optional
            for (int i = 0; i <= CheckBoxList1.Items.Count - 1; i++)
            {
                if (CheckBoxList1.Items[i].Selected)
                {
                    optionale = $"{CheckBoxList1.Items[i].Text}, ";
                     valore = $"{CheckBoxList1.Items[i].Value} ";
                  double tot = Convert.ToDouble(valore);
                  
                    listOptional.Add(tot);
                    
                   
                }
            }
            double total = listOptional.Sum();
                    optional.InnerText = $"Totale optional:{ total} € ";
 listTotal.Add(total);
            string selectedValue = DropDownList1.SelectedItem.Value;
            //totale macchina
            double valoreMacchina1;
            double valoreMacchina2;
            double valoreMacchina3;
            if (selectedValue == "Dacia.png")
            {
                valoreMacchina1 = 6000;
                macchina.InnerText = $"Totale valore della macchina iniziale: {valoreMacchina1},00 €";
                listTotal.Add(valoreMacchina1);
            }
            else if (selectedValue == "fiat.png")
            {
                valoreMacchina2 = 2000;
                macchina.InnerText = $"Totale valore della macchina iniziale:  {valoreMacchina2} ,00 € €";
                listTotal.Add(valoreMacchina2);
            }
            else
            {
                valoreMacchina3 = 17000;
                macchina.InnerText = $"Totale valore della macchina iniziale:  {valoreMacchina3} ,00 € €";
                listTotal.Add(valoreMacchina3);
            }
            string selectedValue2 = DropDownList2.SelectedItem.Value;

            //totale garanzia
            double n1;
            double n2;
            double n3;
            double n4;
            if (selectedValue2 == "1")
            {
                n1 = 120;
                garanzia.InnerText = $" Totale garanzia: {n1} €";
                listTotal.Add(n1);
            }
            else if (selectedValue2 == "2")
            {
                 n2 = 120 * 2;
                garanzia.InnerText = $" Totale garanzia: {n2},00 €";
                listTotal.Add(n2);
            }
            else if (selectedValue2 == "3")
            {

                  n3 = 120 * 3;
                garanzia.InnerText = $" Totale garanzia: {n3},00 €";
                listTotal.Add(n3);
            }
            else
            {

                 n4 = 120 * 4;
                garanzia.InnerText = $"Totale garanzia: {n4},00 €";
                listTotal.Add(n4);
            }

         ;
            //Totale complessivo
            totale.InnerText = $"Totale complessivo: {listTotal.Sum()}";


        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = DropDownList2.SelectedItem.Value;

           

        }
    }


}