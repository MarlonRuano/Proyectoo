﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void btnActualizarUsuario_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();

            
            form5.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            Form3 form3 = new Form3(); 
            form3.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        
            {
               
                Form4 form4 = new Form4();
                form4.Show();

                this.Hide();
            }
        
    }
}
