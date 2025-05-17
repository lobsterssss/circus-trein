using CircusTrain;
using CircusTrain.Carts;
using System.Linq;

namespace CircusTrain
{
    public partial class Form1 : Form
    {
        Circus circus = new Circus();
        List<Animal> animals = new List<Animal>();
        Train train;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            train = circus.MoveAnimals(int.Parse(lblSH.Text), int.Parse(lblMH.Text), int.Parse(lblLH.Text), int.Parse(lblSC.Text), int.Parse(lblMC.Text), int.Parse(lblLC.Text));

            lblCartCount.Text = train.GetCount().ToString();

            lblTrein.Text = train.ShowTrain();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblSH.Text = (int.Parse(lblSH.Text) + 1).ToString();
        }

        private void btnMH_Click(object sender, EventArgs e)
        {
            lblMH.Text = (int.Parse(lblMH.Text) + 1).ToString();
        }

        private void btnLH_Click(object sender, EventArgs e)
        {
            lblLH.Text = (int.Parse(lblLH.Text) + 1).ToString();
        }

        private void btnSC_Click(object sender, EventArgs e)
        {
            lblSC.Text = (int.Parse(lblSC.Text) + 1).ToString();
        }

        private void btnMC_Click(object sender, EventArgs e)
        {
            lblMC.Text = (int.Parse(lblMC.Text) + 1).ToString();
        }

        private void btnLC_Click(object sender, EventArgs e)
        {
            lblLC.Text = (int.Parse(lblLC.Text) + 1).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (int.Parse(lblSH.Text) > 0) 
            {
                lblSH.Text = (int.Parse(lblSH.Text) - 1).ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (int.Parse(lblMH.Text) > 0)
            {
                lblMH.Text = (int.Parse(lblMH.Text) - 1).ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (int.Parse(lblLH.Text) > 0)
            {
                lblLH.Text = (int.Parse(lblLH.Text) - 1).ToString();
            }

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            if (int.Parse(lblSC.Text) > 0)
            {
                lblSC.Text = (int.Parse(lblSC.Text) - 1).ToString();
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (int.Parse(lblMC.Text) > 0)
            {
                lblMC.Text = (int.Parse(lblMC.Text) - 1).ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (int.Parse(lblLC.Text) > 0)
            {
                lblLC.Text = (int.Parse(lblLC.Text) - 1).ToString();
            }
        }
    }
}
