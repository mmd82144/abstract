using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace absteract
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vehicle myCar = new Car();
            myCar.Move();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vehicle myBicycle = new Bicycle();
            myBicycle.Move();
        }
    }
    abstract class Vehicle 
    { 
        public abstract void Move();
    }
    class Car : Vehicle 
    { public override void Move() 
        { MessageBox.Show("The car is driving");
        }
    }
    class Bicycle : Vehicle
    { public override void Move()
        { MessageBox.Show("The bike is moving"); 
        }
    }
}
