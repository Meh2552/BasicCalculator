using CalculatorPrivateAssembly;

namespace CalculatorApplication
{
    public partial class FrmCalculator : Form
    {
        private event Information<double> CalculateEvent;

        private double num1;
        private double num2;

        public FrmCalculator()
        {
            InitializeComponent();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = Convert.ToDouble(txtBoxInput1.Text);
                num2 = Convert.ToDouble(txtBoxInput2.Text);
                switch (cbOperator.SelectedItem.ToString())
                {
                    case "+":
                        CalculateEvent += BasicComputation.getSum;
                        break;
                    case "-":
                        CalculateEvent += BasicComputation.getDifference;
                        break;
                    case "*":
                        CalculateEvent += BasicComputation.getProduct;
                        break;
                    case "/":
                        CalculateEvent += BasicComputation.getQuotient;
                        break;
                }
                var total = CalculateEvent(num1, num2);
                lblDisplayTotal.Text = total.ToString();
                CalculateEvent -= BasicComputation.getSum;
                CalculateEvent -= BasicComputation.getDifference;
                CalculateEvent -= BasicComputation.getProduct;
                CalculateEvent -= BasicComputation.getQuotient;

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
