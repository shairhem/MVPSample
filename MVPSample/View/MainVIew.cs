using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVPSample.Presenter;

namespace MVPSample
{
    public partial class MainView : Form
    {
        public Presenter1 presenter { get; set; }

        public MainView()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                presenter.onOperand1Changed(int.Parse(textBox1.Text));
            }
            catch(Exception)
            {
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                presenter.onOperand2Changed(int.Parse(textBox2.Text));
            }
            catch (Exception)
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                presenter.onClick();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.ToString());
            }
           
        }

        public void updateView(int operand1, int operand2,int result)
        {
            textBox1.Text = operand1.ToString();
            textBox2.Text = operand2.ToString();
            textBox3.Text = result.ToString();
        }
    }
}
