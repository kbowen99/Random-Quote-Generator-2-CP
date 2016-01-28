using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandyQuoteGen
{
    public partial class frm_randyQuoteGenForm : Form
    {
        //random Number Generator Used to randomize Quotes
        Random rndGen = new Random();
        Image[] Pictures = {
                                   Properties.Resources.Ana_White_Quote_Inspirational_Quotes,
                                   Properties.Resources.patience,
                                   Properties.Resources.googleit,
                                   Properties.Resources.images,
                                   Properties.Resources.Quotation_Marc_Andreessen_magic_internet_Meetville_Quotes_2427,
                                   Properties.Resources.images__1_,
                                   Properties.Resources.Quotation_Kent_Conrad_society_computers_education_internet_Meetville_Quotes_43535,
                                   Properties.Resources.Quotation_D_M_Jarrett_media_listening_time_Meetville_Quotes_177522,
                                   Properties.Resources.Quotation_Michio_Kaku_wisdom_trying_people_ideas_internet_Meetville_Quotes_3513,
                                   Properties.Resources.Quotation_Andrew_Brown_life_people_technology_internet_Meetville_Quotes_188562
                               };
        string[] Quotes = {
                                  "1",
                                  "2",
                                  "3",
                                  "4",
                                  "5",
                                  "6",
                                  "7",
                                  "8",
                                  "9",
                                  "10"
                              };
        public frm_randyQuoteGenForm()
        {
            //Start Code
            InitializeComponent();
            // do not put "Random rndGen = new Random();" here, it wont work
        }

        private void btn_Randy_Click(object sender, EventArgs e)
        {
            //generate random number using generator above
            int rndNum = rndGen.Next(0, 10);
            //set random number to quotes using arrays
            pic_quotebox.Image = Pictures[rndNum];
            lbl_Num.Text = Quotes[rndNum];
        }

    }
}
