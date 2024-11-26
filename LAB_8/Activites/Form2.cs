using System;
using System.Windows.Forms;

namespace Practice_233534
{
    public partial class Form2 : Form
    {
        public Form2(string customerName, string country, string gender, string hobbies, string maritalStatus)
        {
            InitializeComponent();
            // Set the labels or text boxes with the received data
            label1.Text = $"Customer Name: {customerName}";
            label2.Text = $"Country: {country}";
            label3.Text = $"Gender: {gender}";
            label4.Text = $"Hobbies: {hobbies}";
            label5.Text = $"Marital Status: {maritalStatus}";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Additional initialization if needed
        }
    }
}