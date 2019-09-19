using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int height = 10;
        int width = 10;
        int distanseBetweenButton = 40;
        ButtonExtended[,] allButtons;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rng = new Random();
            for (int x = 10; (x-10) < width*distanseBetweenButton; x+= distanseBetweenButton) 
            {
                for (int y = 10; (y-10) < height*distanseBetweenButton; y+= distanseBetweenButton) 
                {
                 
                    ButtonExtended button = new ButtonExtended();
                    button.Location = new Point(x, y);
                    button.Size = new Size(30, 30);

                    if (rng.Next (0,101)<20)
                    {
                        button.isBoomb = true;
                    }

                    Controls.Add(button);
                    button.Click += new EventHandler(FieldClick);
                }
                
            } 

          
        }

        void FieldClick(object sender, EventArgs e)
        {
            ButtonExtended button = (ButtonExtended)sender;
            if(button.isBoomb)
            {
                Explode(button);
            }
            else
            {
                EmptyFieldClick(button); 
            }

        }

        void Explode (ButtonExtended button)
        {
            MessageBox.Show("Вы проиграли");
            button.Text = "*";
        }

        void EmptyFieldClick(ButtonExtended button)
        {

        }

    }
    
    class ButtonExtended:Button
    {
        public bool isBoomb;
    }
}
