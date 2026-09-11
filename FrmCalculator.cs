namespace CalculatorApplication
{
    public partial class FrmCalculator : Form
    {
        private CalculatorClass cal;

        private double num1;
        private double num2;

        public FrmCalculator()
        {
            InitializeComponent();
            cal = new CalculatorClass();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtBoxInput1.Text);
            num2 = Convert.ToDouble(txtBoxInput2.Text);

            switch (cbOperator.SelectedItem.ToString())
            {
                case "+":
                    cal.CalculateEvent += cal.getSum;
                    break;
                case "-":
                    cal.CalculateEvent += cal.getDifference;
                    break;
                case "*":
                    cal.CalculateEvent += cal.getProduct;
                    break;
                case "/":
                    cal.CalculateEvent += cal.getQuotient;
                    break;
            }

            var total = cal.info(num1, num2);
            lblDisplayTotal.Text = total.ToString();

            cal.CalculateEvent -= cal.getSum;
            cal.CalculateEvent -= cal.getDifference;
            cal.CalculateEvent -= cal.getProduct;
            cal.CalculateEvent -= cal.getQuotient;
        }
    }
}
