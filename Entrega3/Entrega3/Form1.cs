using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace Entrega3
{
    public partial class Form1 : Form
    {
        private static UserControl ucWelcome;
        private static UserControl ucLogin;
        private static UserControl ucRegister;
        private static UserControl ucPreferences;
        private static UserControl ucMailVerified;
        private static UCLoading ucLoading;
        private static UserControl ucMainmenu;

        UserControl Main_Menu = new UCMainMenu();
        UserControl Loading = new UCLoading();


        List<Panel> stackPanels = new List<Panel>();
        Dictionary<string, Panel> panels = new Dictionary<string, Panel>();

        public static UserControl UcWelcome { get => ucWelcome; set => ucWelcome = value; }
        public static UserControl UcRegister { get => ucRegister; set => ucRegister = value; }
        public static UserControl UcPreferences { get => ucPreferences; set => ucPreferences = value; }
        public static UserControl UcMailVerified { get => ucMailVerified; set => ucMailVerified = value; }
        public static UserControl UcLogin { get => ucLogin; set => ucLogin = value; }
        public static UCLoading UcLoading { get => ucLoading; set => ucLoading = value; }
        public static UserControl UcMainMenu { get => ucMainmenu; set => ucMainmenu = value; }




        //UCRegister UCRegister uCRegister = new UCRegister();
        public Form1()
        {
            InitializeComponent();
            //UCWelcome uCWelcome = new UCWelcome();
            //uCWelcome.BringToFront();
            //uCWelcome.Show();
            
        }
        
        private void ShowLastPanel()
        {
            foreach (Panel panel in panels.Values)
            {
                if (panel != stackPanels.Last())
                {
                    panel.Visible = false;
                }
                else
                {
                    panel.Visible = true;
                }
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UcMainMenu = ucMainMenu1;
            ucLogin = ucLoging1;        
            ucWelcome = ucWelcome1;
            ucPreferences = ucPreferencesRegister1;
            ucMailVerified = ucMailValidation1;
            ucLoading = ucLoading1;
            
            ucWelcome1.BringToFront();
            
            ucRegister = ucRegister1;
            ucLogin.Hide();
            ucPreferences.Hide();
            ucMailVerified.Hide();
            ucLoading.Hide();
            UcMainMenu.Hide();
            
        }

        private void ucRegister1_Load(object sender, EventArgs e)
        {

        }

        private void ucPreferencesRegister1_Load(object sender, EventArgs e)
        {

        }

        private void ucMainMenu1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void ucLoading1_Load(object sender, EventArgs e)
        {
            Thread.Sleep(2000);
            //this.UcLoading.Label_pause();
            Thread.Sleep(2000);
            UcLoading.Label_pause();
            
            //this.UcLoading.Hide();
            //UcMainMenu.Show();
            
        }

    }
}
