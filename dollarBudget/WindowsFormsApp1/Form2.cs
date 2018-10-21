using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class detailedView : Form
    {
        RadioButton rbSelected;
        public string[] expenceGoal;
        public string[] expenceType;
        public string[] expenceBalance;
        public string income;

        public detailedView(){
            InitializeComponent();
            expenceType = System.IO.File.ReadAllLines(@"savedType.txt");
            expenceGoal = System.IO.File.ReadAllLines(@"savedGoal.txt");
            expenceBalance = System.IO.File.ReadAllLines(@"savedBalance.txt");
            RadioButton[] btnRadio = new RadioButton[expenceType.Length];

            for (int i = 0; i < expenceType.Length; ++i)
            {
                btnRadio[i] = new RadioButton();
                btnRadio[i].Text = expenceType[i];
                btnRadio[i].Tag = i;
                btnRadio[i].CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
                radioHolder.Controls.Add(btnRadio[i]);
            }

            //string tmp = mainPaige.totalIncomeString;
            //monthIncome.Text = tmp;
        }

        private int checkButtonIndex(){
            rbSelected = radioHolder.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            return Convert.ToInt32(rbSelected.Tag);
        }

        private void radioButtons_CheckedChanged(object sender, EventArgs e){
            expenceName.Text = expenceType[checkButtonIndex()];
            balance.Text = expenceBalance[checkButtonIndex()];
            checkButtonIndex();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e){
            StreamWriter saveBalance = new StreamWriter("savedBalance.txt");
            double deduction;
            double balanceValue;
            try
            {
                deduction = Convert.ToDouble(moneySpent.Text);
                balanceValue = Convert.ToDouble(expenceBalance[checkButtonIndex()]);
                balanceValue -= deduction;

                balance.Text = balanceValue.ToString();
                moneySpent.Text = string.Empty;

                expenceBalance[checkButtonIndex()] = balanceValue.ToString();
                for (int i = 0; i < expenceBalance.Count(); ++i)
                {
                    saveBalance.WriteLine(expenceBalance[i]);
                }
                saveBalance.Close();
            }
            catch (System.FormatException error)
            {
                MessageBox.Show(mainPaige.message);
                moneySpent.Text = string.Empty;
                moneySpent.Focus();
                saveBalance.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainPaige home = new mainPaige();
            home.Left = this.Left;
            home.Top = this.Top;
            home.Show();
            this.Close();

        }

        private void detailedView_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
