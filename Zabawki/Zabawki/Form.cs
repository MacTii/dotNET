using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zabawki
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            listOfObjects.Items.Add("Car");
            listOfObjects.Items.Add("Plane");
            listOfObjects.Items.Add("Submarine");
            listOfObjects.Items.Add("Computer");
        }

        private void AddObject(object sender, EventArgs e)
        {
            var item = listOfObjects.SelectedItem;
            if (item == null)
                return;
            switch(item.ToString())
            {
                case "Car":
                    addedObjects.Items.Add(new Car(0));
                    break;
                case "Plane":
                    addedObjects.Items.Add(new Plane(0, 0));
                    break;
                case "Submarine":
                    addedObjects.Items.Add(new Submarine(0, 0));
                    break;
                case "Computer":
                    addedObjects.Items.Add(new Computer());
                    break;
            }
        }

        private void DeleteObject(object sender, EventArgs e)
        {
            var item = addedObjects.SelectedItem;
            if (item == null)
                return;
            addedObjects.Items.Remove(item);
        }

        private void AddedObjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(addedObjects.SelectedIndex != -1)
            {
                if(addedObjects.SelectedItem is IRise)
                {
                    riseBox.Visible = true;

                    IRise rise = addedObjects.SelectedItem as IRise;
                    riseTextBox.Text = rise.Rise.ToString();
                }
                else
                    riseBox.Visible = false;
                if (addedObjects.SelectedItem is IDive)
                {
                    depthBox.Visible = true;

                    IDive dive = addedObjects.SelectedItem as IDive;
                    depthTextBox.Text = dive.Depth.ToString();
                }
                else
                    depthBox.Visible = false;
                if (addedObjects.SelectedItem is IAccelerate)
                {
                    speedBox.Visible = true;

                    IAccelerate accelerate = addedObjects.SelectedItem as IAccelerate;
                    speedTextBox.Text = accelerate.Speed.ToString();
                }
                else
                    speedBox.Visible = false;
            }
            else
            {
                speedBox.Visible = false;
                depthBox.Visible = false;
                riseBox.Visible = false;
            }
        }

        private void DecreaseSpeed_Click(object sender, EventArgs e)
        {
            IAccelerate accelerate = addedObjects.SelectedItem as IAccelerate;
            if(accelerate != null)
            {
                accelerate.Speed -= 1;
                speedTextBox.Text = accelerate.Speed.ToString();
            }
        }

        private void IncreaseSpeed_Click(object sender, EventArgs e)
        {
            IAccelerate accelerate = addedObjects.SelectedItem as IAccelerate;
            if(accelerate != null)
            {
                accelerate.Speed += 1;
                speedTextBox.Text = accelerate.Speed.ToString();
            }
        }

        private void DecreaseDepth_Click(object sender, EventArgs e)
        {
            IDive dive = addedObjects.SelectedItem as IDive;
            if(dive != null)
            {
                dive.Depth -= 1;
                depthTextBox.Text = dive.Depth.ToString();
            }
        }

        private void IncreaseDepth_Click(object sender, EventArgs e)
        {
            IDive dive = addedObjects.SelectedItem as IDive;
            if(dive != null)
            {
                dive.Depth += 1;
                depthTextBox.Text = dive.Depth.ToString();
            }
        }

        private void DecreaseRise_Click(object sender, EventArgs e)
        {
            IRise rise = addedObjects.SelectedItem as IRise;
            if(rise != null)
            {
                rise.Rise -= 1;
                riseTextBox.Text = rise.Rise.ToString();
            }
        }

        private void IncreaseRise_Click(object sender, EventArgs e)
        {
            IRise rise = addedObjects.SelectedItem as IRise;
            if(rise != null)
            {
                rise.Rise += 1;
                riseTextBox.Text = rise.Rise.ToString();
            }
        }
    }
}
