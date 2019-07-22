using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.CalculatorServiceRef;

namespace Client
{
    public partial class Form1 : Form
    {


        CalculatorServiceClient host;
        User ServiceUser;
        public Form1()
        {

            InitializeComponent();
            host = new CalculatorServiceClient("NetTcpBinding_ICalculatorService");
            host.addUser();



        }      

       

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btn_login_ClickAsync(object sender, EventArgs e)
        {
            
                ServiceUser = await host.CheckAuthenticationsAsync(nameTXT.Text, passTxt.Text);
            if(ServiceUser==null)

            MessageBox.Show("Either user name or password is wrong" );
            else { 
                CalculatorPage page = new CalculatorPage(ServiceUser, host);
            page.Show();
            this.Hide();
            }


        }
    }
}
