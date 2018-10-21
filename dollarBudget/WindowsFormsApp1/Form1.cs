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
    public partial class mainPaige : Form
    {
        public double totalIncome;
        double incomeLeftOver;
        bool enableFunds = false;
        public static string totalIncomeString;
        public static string message = "Error, please enter a valid monthly income.";
        detailedView paige2 = new detailedView();

        public mainPaige()
        {
            InitializeComponent();
        }

        //function to add elements sto the expence name and goal list box
        public void addExpenceElement(string name, double goal, double balance){
            expenceType.Items.Add(name);
            expenceAmount.Items.Add(goal);
            amountBalance.Items.Add(balance);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e){
            enableFunds = true;
            try
            {
                totalIncome = Convert.ToDouble(incomeTxt.Text);
                incomeLeft.Text = "$" + totalIncome.ToString();
                totalIncomeLbl.Text = "$" + totalIncome.ToString();
                incomeLeftOver = totalIncome;
            }
            catch (System.FormatException totalIncome)
            {
                MessageBox.Show(message);
                incomeTxt.Text = string.Empty;
                incomeTxt.Focus();
            }
            totalIncomeString = totalIncome.ToString();
        }

        public void button5_Click(object sender, EventArgs e)
        {
            string typeName = newType.Text;
            double typeAmount;
            if (enableFunds)
            {
                try
                {
                    typeAmount = Convert.ToDouble(newAmount.Text);
                    incomeLeftOver -= typeAmount;
                    addExpenceElement(typeName, typeAmount, typeAmount);
                    incomeLeft.Text = "$" + incomeLeftOver.ToString();
                }
                catch (System.FormatException error)
                {
                    MessageBox.Show(message);
                    newAmount.Text = string.Empty;
                    newAmount.Focus();
                }
                newType.Text = string.Empty;
                newAmount.Text = string.Empty;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e){
            StreamWriter saveType = new StreamWriter("savedType.txt");
            StreamWriter saveGoal = new StreamWriter("savedGoal.txt");
            StreamWriter saveBalance = new StreamWriter("savedBalance.txt");

            string[] expenceList = expenceType.Items.OfType<string>().ToArray();
            string[] goalList = expenceAmount.Items.OfType<string>().ToArray();
            string[] remainBalance = amountBalance.Items.OfType<string>().ToArray();

            for (int i = 0; i < expenceList.Count(); ++i)
            {
                saveType.WriteLine(expenceType.Items[i]);
                saveGoal.WriteLine(expenceAmount.Items[i]);
                saveBalance.WriteLine(amountBalance.Items[i]);
            }
            saveType.Close();
            saveGoal.Close();
            saveBalance.Close();
        }

        private void loadAnalytics_Click(object sender, EventArgs e)
        {
            detailedView frm2 = new detailedView();
            frm2.Left = this.Left;
            frm2.Top = this.Top;
            frm2.Show();
            this.Hide();
        }

        private void ldBudget_Click(object sender, EventArgs e){
            string[] expType = System.IO.File.ReadAllLines(@"savedType.txt");
            string[] expGoal = System.IO.File.ReadAllLines(@"savedGoal.txt");
            string[] expBalance = System.IO.File.ReadAllLines(@"savedBalance.txt");

            clearListBox();

            for (int i = 0; i < expType.Length; ++i)
            {
                addExpenceElement(expType[i], Convert.ToDouble(expGoal[i]), Convert.ToDouble(expBalance[i]));
            }
        }

        private void mainPaige_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void loadHome_Click(object sender, EventArgs e)
        {

        }

        private void clearListBox()
        {
            amountBalance.Items.Clear();
            expenceAmount.Items.Clear();
            expenceType.Items.Clear();
        }

        private void clearField_Click(object sender, EventArgs e)
        {
            clearListBox();
        }
    }
}
