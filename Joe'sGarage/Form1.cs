namespace Joe_sGarage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private decimal parts = 0;
        private decimal labor = 0;
        private const decimal OIL_CHANGE = 26.00m;
        private const decimal LUBE_JOB = 18.00m;
        private const decimal RADIATOR_FLUSH = 30.00m;
        private const decimal TRANSMISSION_FLUSH = 80.00m;
        private const decimal INSPECTION = 15.00m;
        private const decimal REPLACE_MUFFLER = 100.00m;
        private const decimal TIRE_ROTATION = 20.00m;
        
        private bool InputValid(ref decimal parts, ref decimal labor)
        {
            bool validInput = false;

            if ((decimal.TryParse(textBoxParts.Text, out parts) && parts >= 0m) || (textBoxParts.Text == "")) { 
            
                textBoxParts.Text = parts.ToString("n");
                
                if ((decimal.TryParse(textBoxLabor.Text, out labor) && labor >= 0m) || (textBoxLabor.Text == "")) {

                    textBoxLabor.Text = labor.ToString("n");
                    validInput = true;
                }
                else { 
                
                    MessageBox.Show("Re-enter Labor Cost.");
                    textBoxLabor.Clear();
                }
            }
            else { 
           
                MessageBox.Show("Re-enter Parts Cost.");
                textBoxParts.Clear();
            }  
            return validInput;
        }
        private decimal OilLubeCharges()
        {
            decimal oilLubeCost = 0;

            if (checkBoxOilChange.Checked)
            {
                oilLubeCost += OIL_CHANGE;
            }
            if (checkBoxLubeJob.Checked)
            {
                oilLubeCost += LUBE_JOB;
            }

            return oilLubeCost;
        }

        private decimal FlushCharges()
        {
            decimal flushCost = 0m;

            if (checkBoxRadiatorFlush.Checked)
            {
                flushCost += RADIATOR_FLUSH;
            }
            if (checkBoxTransFlush.Checked)
            {
                flushCost += TRANSMISSION_FLUSH;
            }

            return flushCost;
        }

        private decimal MiscCharges()
        {
            decimal miscCost = 0m;

            if (checkBoxInspection.Checked)
            {
                miscCost += INSPECTION;
            }
            if (checkBoxMuffler.Checked)
            {
                miscCost += REPLACE_MUFFLER;
            }
            if (checkBoxTire.Checked)
            {
                miscCost += TIRE_ROTATION;
            }

            return miscCost;
        }
        private decimal OtherCharges()
        {

            decimal otherCharges = parts + labor;

            return otherCharges;
        }
        private decimal TaxCharges()
        {
            const decimal SALES_TAX = 0.06m;
            decimal taxCost = parts * SALES_TAX;

            return taxCost;
        }

        private decimal TotalCost()
        {
            decimal total = OilLubeCharges() + FlushCharges() + MiscCharges() + OtherCharges() + TaxCharges();
            return total;
        }

     
        private void ClearOilLube()
        {
            checkBoxOilChange.Checked = false;
            checkBoxLubeJob.Checked = false;
        }

        private void ClearFlushes()
        {
            checkBoxRadiatorFlush.Checked = false;
            checkBoxTransFlush.Checked = false;
        }

        private void ClearMisc()
        {
            checkBoxInspection.Checked = false;
            checkBoxMuffler.Checked = false;
            checkBoxTire.Checked = false;
        }

        private void ClearOther()
        {
            textBoxParts.Clear();
            textBoxLabor.Clear();
        }

        private void ClearFees()
        {
            serviceAndLaborOutput.Text = "";
            partsOutput.Text = "";
            taxOutput.Text = "";
            totalOutput.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ClearOilLube();
            ClearFlushes();
            ClearMisc();
            ClearOther();
            ClearFees();

            groupBoxOilLube.Focus();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (InputValid(ref parts, ref labor))
            {
                decimal costService = FlushCharges() + MiscCharges() + OilLubeCharges();
                decimal serviceLaborCost = costService + labor;

                serviceAndLaborOutput.Text = serviceLaborCost.ToString("c");

                partsOutput.Text = parts.ToString("c");
                taxOutput.Text = TaxCharges().ToString("c");
                totalOutput.Text = TotalCost().ToString("c");

            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
