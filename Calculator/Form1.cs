using System.Linq;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public float number1, number2;
        char operation;

        public Form1()
        {
            InitializeComponent();
            Number.Text = "";
        }
        
        private void Reset_Click(object sender, EventArgs e){
            Number.Text = "";
        }
        
        private void One_Click(object sender, EventArgs e){
            Number.Text += "1";}

        private void Two_Click(object sender, EventArgs e){
            Number.Text += "2";}

        private void Three_Click(object sender, EventArgs e){
            Number.Text += "3";
        }

        private void Four_Click(object sender, EventArgs e){
            Number.Text += "4";
        }

        private void Five_Click(object sender, EventArgs e){
            Number.Text += "5";
        }

        private void Six_Click(object sender, EventArgs e){
            Number.Text += "6";
        }

        private void Seven_Click(object sender, EventArgs e){
            Number.Text += "7";
        }

        private void Eight_Click(object sender, EventArgs e){
            Number.Text += "8";
        }

        private void Nine_Click(object sender, EventArgs e){
            Number.Text += "9";
        }

        private void Zero_Click(object sender, EventArgs e){
            Number.Text += "0";
        }

        private void Times_Click(object sender, EventArgs e){
            if (number1 == 0)
            {
                float.TryParse(Number.Text, out number1);
                Number.Text = "";
                operation = 'X';
            }
        }

        private void Minus_Click(object sender, EventArgs e){
            if (number1 == 0)
            {
                float.TryParse(Number.Text, out number1);
                Number.Text = "";
                operation = '-';
            }
        }

        private void Add_Click(object sender, EventArgs e){
            if (number1 == 0)
            {
                float.TryParse(Number.Text, out number1);
                Number.Text = "";
                operation = '+';
            }
        }
        
        private void Devide_Click(object sender, EventArgs e){
            if (number1 == 0){
                float.TryParse(Number.Text,out number1);
                Number.Text = "";
                operation = '/';
            }
        }

        private void Percent_Click(object sender, EventArgs e){
            if (Number.Text != "0"){
                float number;
                
                float.TryParse(Number.Text, out number);

                Number.Text = (number/10).ToString();
            }
            
        }

        private void PlusMinus_Click(object sender, EventArgs e){
            if (Number.Text.Contains('-')){
                Number.Text = MathF.Abs(float.Parse(Number.Text)).ToString();
            }
            else{
                Number.Text = "-" + Number.Text;
            }
            
        }

        private void Equals_Click(object sender, EventArgs e){
            if(number1 != 0 && Number.Text != "0"){
                float.TryParse(Number.Text,out number2);

                if (operation == '+') { Number.Text = (number1 + number2).ToString(); }

                if (operation == '-') { Number.Text = (number1 - number2).ToString(); }

                if (operation == '/') { Number.Text = (number1 / number2).ToString(); }

                if (operation == 'X') { Number.Text = (number1 * number2).ToString(); }

                number1 = 0; number2 = 0;
            }
        }
    }
}