using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoogleMaps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void search_Click(object sender, EventArgs e)
        {
            string street = streetTB.Text;
            string city = cityTB.Text;
            string state = stateTB.Text;
            string zip = zipTB.Text;


            try
            {

                StringBuilder queryAddress = new StringBuilder();
                queryAddress.Append("http://maps.google.com/maps?q=");
                if (street != string.Empty)
                {
                    queryAddress.Append(street + "," + "+");
                }
                if (city != string.Empty)
                {
                    queryAddress.Append(city + "," + "+");
                }
                if (state != string.Empty)
                {
                    queryAddress.Append(state + "," + "+");
                }
                if (zip != string.Empty)
                {
                    queryAddress.Append(zip + "," + "+");
                }

                webBrowser1.Navigate(queryAddress.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Erro");
            }

        }
    }
}
