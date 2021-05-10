using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication6
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGiris_Click(object sender, EventArgs e)
        {
            int flag=0;
            DigitControl digitcontrol1 = new DigitControl();
            LuhnControl denemeler = new LuhnControl();
            if (digitcontrol1.checkdigit(txtCardNo.Text))  // A)Digit 16 kontrol
            {

                if (denemeler.checkLuhn(txtCardNo.Text)) // A dogru ise Luhn controlu: dogru
                {
                    
                    CardTypeControl cardtypecontrol1 = new CardTypeControl();
                    lblDigitControl.Text = " ";
                    lblLuhnControl.Text = (" ");
                   
                    if (DropDownList1.SelectedIndex == 0)// Luhn Dogru MasterCard Kontrol
                    {
                        if (cardtypecontrol1.checkcardmaster(txtCardNo.Text))
                        {
                            lblCardTypeControl.Text = " "; 
                            flag++;
                        }
                        else
                        {
                            lblCardTypeControl.Text = "Mastercard degil.Geçerli Kart No Girin.";
                        }
                    }
                    if (DropDownList1.SelectedIndex == 1)// Luhn Dogru Visa Kontrol
                    {

                        if (cardtypecontrol1.checkcardvisa(txtCardNo.Text))
                        {
                            lblCardTypeControl.Text = " "; 
                            flag++;
                        }
                        else
                        {
                            lblCardTypeControl.Text = "Visa degil. Geçerli Kart No Girin..";
                        }
                    }
                }

                else //A dogru ise Luhn controlu: Yanlış
                    lblLuhnControl.Text = ("Bu bir kredi kartı değil.");
            }

            else// 16Haneli Digit : Degil
                lblDigitControl.Text = "16Haneli Kart No Girin Lütfen.";

            //CCV Control
            CCVandDateControl ccvanddate = new CCVandDateControl();
            if (ccvanddate.checkCCV(txtCCV.Text))
            {
                lblCCVControl.Text = " ";
                flag++; //2
            }
            else
            {
                lblCCVControl.Text = "CCV'yi 3 Haneli Giriniz";
            }
            //Date control
            if (ccvanddate.checkmonth(txtMonth.Text))
            {
                lblMonth.Text = " "; 
                flag++; //3
            }
            else
            {
                lblMonth.Text = "Geçerli Ay Giriniz.";
            }
            //
            if (ccvanddate.checkyear(txtYear.Text))
            {
                lblYear.Text = " "; 
                flag++;//4
            }
            else
            {
                lblYear.Text = "4 Haneli Geçerli Yıl Giriniz.";
            }
            //Kart Sahibi İsim
            if (txtCardOwner.Text.Length == 0)
            {
                lblCardOwner.Text = "Kart Sahibi ismini giriniz.";
            }
            else
            {
                lblCardOwner.Text = " ";
                flag++;
            }

            ///// Giris 
            if (flag == 5)
            {
                lblLogin.Text = "Giris Basarili";
            }
            else
            {
                lblLogin.Text = "Hataları Düzeltin Lütfen";
            }

        }

       
    }
}