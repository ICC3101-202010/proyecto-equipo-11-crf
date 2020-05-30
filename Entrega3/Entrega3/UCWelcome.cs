using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Entrega3
{
    public partial class UCWelcome : UserControl
    {
        UCRegister uCRegisterc = new UCRegister();
        //private static UCWelcome _UCWelcome;

        /*public static UCWelcome uCWelcome 
        {
            get 
            {
                if (_UCWelcome == null)
                    _UCWelcome = new UCWelcome();
                return _UCWelcome;


            }
        
        
        }*/
        public UCWelcome()
        {
            InitializeComponent();
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            Form1.UcWelcome.Hide();
            Form1.UcRegister.Show();
           
  
            
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {

        }
    }
}
