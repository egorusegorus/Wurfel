
namespace Wurfel

{
    public partial class Form1 : Form
    {int gespielt = 0;  
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Probe probe = new Probe();
            
            gespielt = gespielt + 1;
            statusbar.Text = "Gespielt: " + gespielt + " mal."; 
            
            int win = probe.GetDiceWert();

            probe.Animation(win, pictureBox1);
            Wieoft(win);


        }
        public void Wieoft(int win)
        {
            string? wert = "";
            switch (win)
            {
                case 1:
                    wert = one.Text;
                    wert = Convert.ToString(Convert.ToInt32(wert) + 1);
                    one.Text = wert;
                    break;
                case 2:
                    wert = two.Text;
                    wert = Convert.ToString(Convert.ToInt32(wert) + 1);
                    two.Text = wert;
                    break;
                case 3:
                    wert = three.Text;
                    wert = Convert.ToString(Convert.ToInt32(wert) + 1);
                    three.Text = wert;
                    break;
                case 4:
                    wert = four.Text;
                    wert = Convert.ToString(Convert.ToInt32(wert) + 1);
                    four.Text = wert;
                    break;
                case 5:
                    wert = five.Text;
                    wert = Convert.ToString(Convert.ToInt32(wert) + 1);
                    five.Text = wert;
                    break;
                case 6:
                    wert = six.Text;
                    wert = Convert.ToString(Convert.ToInt32(wert) + 1);
                    six.Text = wert;
                    break;
            }

        }
    }

}
