using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backprop;

namespace Bobskie_Backpropagation
{
    public partial class Form1 : Form
    {
        NeuralNet nn;
        public Form1()
        {
            InitializeComponent();
            nn = new NeuralNet(4, 10, 1);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            double[ , ] data = { { 35, 3, 5, 4, 1 },
                                 { 27, 20, 2, 5, 1 },
                                 { 3, 0, 5, 2, 0 },
                                 { 28, 0, 8, 1, 0 },
                                 { 68, 4, 5, 6, 1 },
                                 { 34, 0, 10, 0, 0 },
                                 { 58, 15, 10, 0, 0 },
                                 { 22, 12, 5, 2, 0 },
                                 { 45, 2, 6, 0, 0 },
                                 { 52, 18, 4, 5, 1 },
                                 { 33, 4, 8, 0, 0 },
                                 { 18, 10, 6, 3, 0 },
                                 { 25, 2, 5, 1, 0 },
                                 { 28, 20, 2, 8, 1 },
                                 { 34, 25, 4, 8, 1 },
                                 { 39, 18, 8, 1, 0 },
                                 { 42, 22, 3, 5, 1 },
                                 { 19, 12, 8, 0, 0 },
                                 { 62, 5, 4, 3, 1 },
                                 { 73, 10, 7, 6, 1 },
                                 { 55, 15, 1, 3, 1 },
                                 { 33, 8, 8, 1, 0 },
                                 { 22, 20, 6, 2, 0 },
                                 { 44, 5, 8, 1, 0 },
                                 { 77, 3, 2, 6, 1 },
                                 { 21, 20, 5, 3, 0 },
                                 { 37, 15, 6, 2, 0 },
                                 { 34, 12, 8, 0, 0 },
                                 { 55, 20, 1, 4, 1 },
                                 { 4, 20, 2, 7, 1 },
                                 { 36, 13, 5, 2, 0 },
                                 { 56, 20, 3, 3, 1 },
                                 { 47, 15, 1, 8, 1 },
                                 { 62, 25, 3, 4, 1 },
                                 { 26, 10, 7, 2, 0 },
                                 { 25, 20, 8, 2, 0 },
                                 { 59, 20, 3, 4, 1 },
                                 { 62, 15, 5, 5, 1 },
                                 { 33, 25, 8, 2, 0 },
                                 { 37, 10, 5, 3, 0 },
                                 { 5, 20, 2, 4, 1 },
                                 { 47, 12, 8, 0, 0 },
                                 { 69, 20, 5, 4, 1 },
                                 { 63, 20, 4, 5, 1 },
                                 { 39, 15, 7, 2, 0 },
                            };

            for (int x = 0; x < Convert.ToInt32(textBox4.Text); x++)
            {
               for(int i = 0; i< data.GetLength(0); i++)
                {
                    nn.setInputs(0, data[i, 0]);
                    nn.setInputs(1, data[i, 1]);
                    nn.setInputs(2, data[i, 2]);
                    nn.setInputs(3, data[i, 3]);
                   
                    nn.setDesiredOutput(0, data[i, 4]);
                    nn.learn();
                } 
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nn.setInputs(0, Convert.ToDouble(textBox1.Text));
            nn.setInputs(1, Convert.ToDouble(textBox2.Text));
            nn.setInputs(2, Convert.ToDouble(textBox5.Text));
            nn.setInputs(3, Convert.ToDouble(textBox6.Text));
            
            nn.run();
            textBox3.Text = "" + nn.getOuputData(0);
            label13.Text = "-->";

            if(Math.Round(nn.getOuputData(0)) == 1){
                label15.Text = "Most likely to have ";
            }
            else
            {
                label15.Text = "Less likely to have ";
            }
            label14.Text = "lung cancer.";
        }
    }
}