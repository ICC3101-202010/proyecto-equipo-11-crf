using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace Entrega3
{
    public partial class UCPreferencesRegister : UserControl
    {
        
        UCMailValidation uCMailValidation = new UCMailValidation();
        
        public UCPreferencesRegister()
        {
            InitializeComponent();
            this.BringToFront();
            this.Show();
        }

        private void btnSubmitPreferencesRegister_Click(object sender, EventArgs e)
        {
            //this.Hide();
            uCMailValidation.BringToFront();
        }
    }
}
