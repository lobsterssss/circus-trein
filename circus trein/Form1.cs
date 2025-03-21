using System.Linq;

namespace CircusTrein
{
    public partial class Form1 : Form
    {
        Circus circus = new Circus();
        List<Animal> animals = new List<Animal>();
        List<Cart> train;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            train = circus.moveAnimals(animals);
            lblCartCount.Text = train.Count().ToString();
            string show = "";
            foreach (Cart item in train)
            {
                show = show + item.ToString() + "\n";
            }
            lblTrein.Text = show;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            animals.Add(new Animal(Animal.ESize.small, false));
            lblSH.Text = (int.Parse(lblSH.Text) + 1).ToString();
        }

        private void btnMH_Click(object sender, EventArgs e)
        {
            animals.Add(new Animal(Animal.ESize.medium, false));
            lblMH.Text = (int.Parse(lblMH.Text) + 1).ToString();
        }

        private void btnLH_Click(object sender, EventArgs e)
        {
            animals.Add(new Animal(Animal.ESize.large, false));
            lblLH.Text = (int.Parse(lblLH.Text) + 1).ToString();
        }

        private void btnSC_Click(object sender, EventArgs e)
        {
            animals.Add(new Animal(Animal.ESize.small, true));
            lblSC.Text = (int.Parse(lblSC.Text) + 1).ToString();
        }

        private void btnMC_Click(object sender, EventArgs e)
        {
            animals.Add(new Animal(Animal.ESize.medium, true));
            lblMC.Text = (int.Parse(lblMC.Text) + 1).ToString();
        }

        private void btnLC_Click(object sender, EventArgs e)
        {
            animals.Add(new Animal(Animal.ESize.large, true));
            lblLC.Text = (int.Parse(lblLC.Text) + 1).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Animal refAnimal = new Animal(Animal.ESize.small, false);
            if (removeAnimal(refAnimal)) 
            {
                lblSH.Text = (int.Parse(lblSH.Text) - 1).ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Animal refAnimal = new Animal(Animal.ESize.medium, false);
            if (removeAnimal(refAnimal))
            {
                lblMH.Text = (int.Parse(lblMH.Text) - 1).ToString();
            }
        }

        private bool removeAnimal(Animal refAnimal)
        {
            if (animals.Count() > 0) {
                animals.Remove(animals.First(animal => animal == refAnimal));
                return true;
            }
            return false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Animal refAnimal = new Animal(Animal.ESize.large, false);
            if (removeAnimal(refAnimal))
            {
                lblLH.Text = (int.Parse(lblLH.Text) - 1).ToString();
            }

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            Animal refAnimal = new Animal(Animal.ESize.small, true);
            if (removeAnimal(refAnimal))
            {
                lblSC.Text = (int.Parse(lblSC.Text) - 1).ToString();
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Animal refAnimal = new Animal(Animal.ESize.medium, true);
            if (removeAnimal(refAnimal))
            {
                lblMC.Text = (int.Parse(lblMC.Text) - 1).ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Animal refAnimal = new Animal(Animal.ESize.large, true);
            if (removeAnimal(refAnimal))
            {
                lblLC.Text = (int.Parse(lblLC.Text) - 1).ToString();
            }
        }
    }
}
