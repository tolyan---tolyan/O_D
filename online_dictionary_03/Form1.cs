using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace online_dictionary_03
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Operations operations = new Operations();

            string name = textBox5.Text;
            string email = textBox3.Text;
            string password = textBox4.Text;

            if (operations.Registration(name, email, password))
                MessageBox.Show(name + " ви успішно зареєстровані!");
            else
                MessageBox.Show(name + ", вибачте сталась помилка, перевірте дані!");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string passsword = textBox2.Text;

            Operations operations = new Operations();
            string auth = operations.Authorization(email, passsword);
            if (auth != null)
            {
                User.id = auth;
                Form2 form2 = new Form2(auth);
                this.Hide();
                form2.Show();
            }
            else
                MessageBox.Show("Помилка, перевірте дані");
        }
    }
}
