using static System.Windows.Forms.AxHost;
using System.Globalization;
using System.ComponentModel;

namespace Machine_Project
{
    public partial class Form1 : Form
    {
        private ErrorProvider errorProvider;
        private bool exiting;
        private bool updatingCalculations = false;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //ErrorProvider
            errorProvider = new ErrorProvider();
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider.ContainerControl = this;

            //handlers
            txtName.Validating += ValidateName;
            Address.Validating += ValidateAddress;
            City.Validating += ValidateCity;
            State.Validating += ValidateState;
            ZipCode.Validating += ValidateZipCode;
            Description.Validating += ValidateDescription;
            Price.Validating += ValidatePrice;
            Quantity.Validating += ValidateQuantity;
            Weight.Validating += ValidateWeight;


            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;

            Exit.CausesValidation = false;

            WireAutoCalculations();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                GoNext();
            }
        }

        private void GoNext()
        {

            Control current = this.ActiveControl;

            if (current is TextBox tb && tb.Multiline)
                return;

            bool moved = this.SelectNextControl(current, forward: true, tabStopOnly: true, nested: true, wrap: true);
            if (!moved)
            {

                var first = this.GetNextControl(null, true);
                first?.Focus();
            }
        }





        private void Compute_Click(object sender, EventArgs e)
        {

            if (!ValidateChildren())
                return;

            try
            {

                decimal price = decimal.Parse(Price.Text, NumberStyles.Number | NumberStyles.AllowCurrencySymbol, CultureInfo.CurrentCulture);
                int qty = int.Parse(Quantity.Text, NumberStyles.Integer, CultureInfo.CurrentCulture);
                decimal weight = decimal.Parse(Weight.Text, NumberStyles.Number | NumberStyles.AllowDecimalPoint, CultureInfo.CurrentCulture);


                decimal subtotal = price * qty;


                decimal salesTax = 0m;
                decimal.TryParse(Sales_Tax.Text, NumberStyles.Number | NumberStyles.AllowCurrencySymbol, CultureInfo.CurrentCulture, out salesTax);

                decimal shipping = 0m;
                decimal.TryParse(Shipping.Text, NumberStyles.Number | NumberStyles.AllowCurrencySymbol, CultureInfo.CurrentCulture, out shipping);

                decimal handlingCost = 0m;
                decimal.TryParse(Handling.Text, NumberStyles.Number | NumberStyles.AllowCurrencySymbol, CultureInfo.CurrentCulture, out handlingCost);


                decimal total = subtotal + shipping + handlingCost + salesTax;

                if (Tax_Exempt.Checked)
                {
                    total -= salesTax;
                }

                Total.Text = total.ToString("C", CultureInfo.CurrentCulture);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for price, quantity, and weight.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Next_Order_Click(object sender, EventArgs e)
        {
            this.AutoValidate = AutoValidate.Disable;
            this.CausesValidation = false;
            txtName.Text = string.Empty;
            Address.Text = string.Empty;
            City.Text = string.Empty;
            State.Text = string.Empty;
            ZipCode.Text = string.Empty;
            Description.Text = string.Empty;
            Price.Text = string.Empty;
            Quantity.Text = string.Empty;
            Weight.Text = string.Empty;
            Item_Cost.Text = string.Empty;
            Sales_Tax.Text = string.Empty;
            Shipping.Text = string.Empty;
            Handling.Text = string.Empty;
            Total.Text = string.Empty;
            Tax_Exempt.Checked = false;
            errorProvider.Clear();
            txtName.Focus();

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.AutoValidate = AutoValidate.Disable;
            exiting = true;
            Close();
            this.CausesValidation = false;
        }

        private void description(object sender, EventArgs e)
        {

        }

        private void price(object sender, EventArgs e)
        {

        }

        private void quantity(object sender, EventArgs e)
        {

        }

        private void weight(object sender, EventArgs e)
        {

        }

        private void tax(object sender, EventArgs e)
        {

            if (Tax_Exempt.Checked)
            {
                Sales_Tax.Text = 0m.ToString("F2");
                return;
            }


            string state = (State?.Text ?? string.Empty).Trim().ToUpperInvariant();


            if (!decimal.TryParse(Item_Cost.Text, NumberStyles.Number | NumberStyles.AllowCurrencySymbol, CultureInfo.CurrentCulture, out decimal cost))
            {

                Sales_Tax.Text = string.Empty;
                return;
            }

            decimal taxRate = state switch
            {
                "CA" => 0.07m,
                "NY" => 0.08m,
                _ => 0.06m
            };

            decimal taxAmount = Math.Round(cost * taxRate, 2);
            Sales_Tax.Text = taxAmount.ToString("F2");
        }

        private void TaxExempt(object sender, EventArgs e)
        {

        }

        private void cost(object sender, EventArgs e)
        {
            if (decimal.TryParse(Price.Text, NumberStyles.Number | NumberStyles.AllowCurrencySymbol, CultureInfo.CurrentCulture, out decimal price)
                && int.TryParse(Quantity.Text, NumberStyles.Integer, CultureInfo.CurrentCulture, out int qty))
            {
                decimal itemCost = price * qty;
                Item_Cost.Text = itemCost.ToString("C", CultureInfo.CurrentCulture);
            }
            else
            {
                Item_Cost.Text = string.Empty;
            }
        }

        private void shipping(object sender, EventArgs e)
        {
            // validate weight
            if (!decimal.TryParse(Weight.Text, NumberStyles.Number | NumberStyles.AllowDecimalPoint, CultureInfo.CurrentCulture, out decimal weight))
            {
                Shipping.Text = string.Empty;
                return;
            }

            // validate quantity
            if (!int.TryParse(Quantity.Text, NumberStyles.Integer, CultureInfo.CurrentCulture, out int qty) || qty < 0)
            {
                Shipping.Text = string.Empty;
                return;
            }

            // per-item shipping based on weight and carrier
            decimal unitCost = USP.Checked
                ? ((weight <= 50m) ? 8.50m : 17.00m)
                : ((weight <= 50m) ? 11.25m : 22.50m);

            // multiply by quantity and show currency (adds dollar sign)
            decimal shippingTotal = unitCost * qty;
            Shipping.Text = shippingTotal.ToString("C", CultureInfo.CurrentCulture);
        }

        private void handling(object sender, EventArgs e)
        {

            if (!int.TryParse(Quantity.Text, NumberStyles.Integer, CultureInfo.CurrentCulture, out int qty) || qty < 0)
            {
                Handling.Text = string.Empty;
                return;
            }


            if (!decimal.TryParse(Weight.Text, NumberStyles.Number | NumberStyles.AllowDecimalPoint, CultureInfo.CurrentCulture, out decimal weightPerItem))
            {
                Handling.Text = string.Empty;
                return;
            }

            const decimal handlingPerItem = 4.75m;
            const decimal costPerPound = 0.10m;

            decimal handlingCost = (handlingPerItem * qty) + (costPerPound * qty * weightPerItem);
            handlingCost = Math.Round(handlingCost, 2, MidpointRounding.AwayFromZero);

            Handling.Text = handlingCost.ToString("F2");
        }


        private void ValidateName(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errorProvider.SetError(txtName, "Customer name cannot be missing.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtName, string.Empty);
            }
        }

        private void ValidateAddress(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Address.Text))
            {
                errorProvider.SetError(Address, "Address cannot be missing.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(Address, string.Empty);
            }
        }

        private void ValidateCity(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(City.Text))
            {
                errorProvider.SetError(City, "City cannot be missing.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(City, string.Empty);
            }
        }

        private void ValidateState(object sender, CancelEventArgs e)
        {
            string s = (State.Text ?? string.Empty).Trim();
            State.Text = s.ToUpperInvariant();
            if (s.Length != 2 || !char.IsLetter(s[0]) || !char.IsLetter(s[1]))
            {
                errorProvider.SetError(State, "State code must be two capital letters.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(State, string.Empty);
            }
        }

        private void ValidateZipCode(object sender, CancelEventArgs e)
        {

            // If ZipCode is a MaskedTextBox require the mask to be completed
            if (ZipCode is MaskedTextBox mtb)
            {
                if (!(mtb.MaskCompleted || mtb.MaskFull))
                {
                    errorProvider.SetError(ZipCode, "Zip code cannot be missing.");
                    e.Cancel = true;
                }
                else
                {
                    errorProvider.SetError(ZipCode, string.Empty);
                }
            }
            else
            {
                // fallback for TextBox
                if (string.IsNullOrWhiteSpace(ZipCode.Text) || ZipCode.Text == "     -")
                {
                    errorProvider.SetError(ZipCode, "Zip code cannot be missing.");
                    e.Cancel = true;
                }
                else
                {
                    errorProvider.SetError(ZipCode, string.Empty);
                }
            }
        }

        private void ValidateDescription(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Description.Text))
            {
                errorProvider.SetError(Description, "Description cannot be missing.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(Description, string.Empty);
            }
        }

        private void ValidatePrice(object sender, CancelEventArgs e)
        {
            if (!decimal.TryParse(Price.Text, NumberStyles.Number | NumberStyles.AllowCurrencySymbol, CultureInfo.CurrentCulture, out decimal p) || p <= 0m)
            {
                errorProvider.SetError(Price, "Price must be a number greater than zero.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(Price, string.Empty);
            }
        }

        private void ValidateQuantity(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(Quantity.Text, NumberStyles.Integer, CultureInfo.CurrentCulture, out int q) || q <= 0)
            {
                errorProvider.SetError(Quantity, "Quantity must be a number greater than zero.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(Quantity, string.Empty);
            }
        }

        private void ValidateWeight(object sender, CancelEventArgs e)
        {
            if (!decimal.TryParse(Weight.Text, NumberStyles.Number | NumberStyles.AllowDecimalPoint, CultureInfo.CurrentCulture, out decimal w) || w <= 0m)
            {
                errorProvider.SetError(Weight, "Weight must be a number greater than zero.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(Weight, string.Empty);
            }
        }

        private void total(object sender, EventArgs e)
        {

        }

        private void USP_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FEA_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exit_Click(sender, e);
        }

        private void computeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Compute_Click(sender, e);
        }

        private void nextOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Next_Order_Click(sender, e);
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void ZipCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rOGFontsSTRIXSCARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Font = new System.Drawing.Font("ROG Fonts STRIX SCAR", 12f, System.Drawing.FontStyle.Regular);




        }

        private void arialRoundedMTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12f, System.Drawing.FontStyle.Regular);
        }

        private void timesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Font = new System.Drawing.Font("Times New Roman", 12f, System.Drawing.FontStyle.Regular);
        }

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.White;
            groupBox1.BackColor = System.Drawing.Color.Silver;
            groupBox2.BackColor = System.Drawing.Color.Silver;
            groupBox3.BackColor = System.Drawing.Color.Silver;
            groupBox4.BackColor = System.Drawing.Color.Silver;
            menuStrip1.BackColor = System.Drawing.Color.Silver;
            Compute.BackColor = System.Drawing.Color.Silver;
            Next_Order.BackColor = System.Drawing.Color.Silver;
            Exit.BackColor = System.Drawing.Color.Silver;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.RoyalBlue;
            groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            groupBox2.BackColor = System.Drawing.Color.LightSteelBlue;
            groupBox3.BackColor = System.Drawing.Color.LightSteelBlue;
            groupBox4.BackColor = System.Drawing.Color.LightSteelBlue;
            menuStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            Compute.BackColor = System.Drawing.Color.LightSteelBlue;
            Next_Order.BackColor = System.Drawing.Color.LightSteelBlue;
            Exit.BackColor = System.Drawing.Color.LightSteelBlue;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            groupBox1.BackColor = System.Drawing.Color.Aquamarine;
            groupBox2.BackColor = System.Drawing.Color.Aquamarine;
            groupBox3.BackColor = System.Drawing.Color.Aquamarine;
            groupBox4.BackColor = System.Drawing.Color.Aquamarine;
            menuStrip1.BackColor = System.Drawing.Color.Aquamarine;
            Compute.BackColor = System.Drawing.Color.Aquamarine;
            Next_Order.BackColor = System.Drawing.Color.Aquamarine;
            Exit.BackColor = System.Drawing.Color.Aquamarine;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.IndianRed;
            groupBox1.BackColor = System.Drawing.Color.Crimson;
            groupBox2.BackColor = System.Drawing.Color.Crimson;
            groupBox3.BackColor = System.Drawing.Color.Crimson;
            groupBox4.BackColor = System.Drawing.Color.Crimson;
            menuStrip1.BackColor = System.Drawing.Color.Crimson;
            Compute.BackColor = System.Drawing.Color.Crimson;
            Next_Order.BackColor = System.Drawing.Color.Crimson;
            Exit.BackColor = System.Drawing.Color.Crimson;
        }

        private void Address_TextChanged(object sender, EventArgs e)
        {

        }

        private void City_TextChanged(object sender, EventArgs e)
        {

        }

        private void State_TextChanged(object sender, EventArgs e)
        {

        }

        private void WireAutoCalculations()
        {
            Price.TextChanged += (s, e) => UpdateCalculations();
            Quantity.TextChanged += (s, e) => UpdateCalculations();
            Weight.TextChanged += (s, e) => UpdateCalculations();
            State.TextChanged += (s, e) => UpdateCalculations();
            Tax_Exempt.CheckedChanged += (s, e) => UpdateCalculations();
            USP.CheckedChanged += (s, e) => UpdateCalculations();
            FEA.CheckedChanged += (s, e) => UpdateCalculations();
        }

        private void UpdateCalculations()
        {
            if (updatingCalculations) return;
            updatingCalculations = true;
            try
            {
                decimal price = 0m; int qty = 0; decimal weight = 0m;
                decimal.TryParse(Price.Text, NumberStyles.Number | NumberStyles.AllowCurrencySymbol, CultureInfo.CurrentCulture, out price);
                int.TryParse(Quantity.Text, NumberStyles.Integer, CultureInfo.CurrentCulture, out qty);
                decimal.TryParse(Weight.Text, NumberStyles.Number | NumberStyles.AllowDecimalPoint, CultureInfo.CurrentCulture, out weight);


                decimal itemCost = price * qty;
                // show currency symbol (uses current culture)
                Item_Cost.Text = itemCost.ToString("C", CultureInfo.CurrentCulture);


                decimal salesTax = 0m;
                if (!Tax_Exempt.Checked)
                {
                    string state = (State?.Text ?? string.Empty).Trim().ToUpperInvariant();
                    decimal taxRate = state switch { "CA" => 0.07m, "NY" => 0.08m, _ => 0.06m };
                    salesTax = Math.Round(itemCost * taxRate, 2);
                }
                Sales_Tax.Text = salesTax.ToString("F2");


                decimal shippingCost = USP.Checked
                    ? ((weight <= 50m) ? 8.50m : 17.00m)
                    : ((weight <= 50m) ? 11.25m : 22.50m);
                Shipping.Text = shippingCost.ToString("F2");


                decimal handlingCost = Math.Round((4.75m * qty) + (0.10m * qty * weight), 2, MidpointRounding.AwayFromZero);
                Handling.Text = handlingCost.ToString("F2");

                /*
                decimal total = itemCost + salesTax + shippingCost + handlingCost;
                if (Tax_Exempt.Checked) total -= salesTax;
                Total.Text = total.ToString("C", CultureInfo.CurrentCulture);
                */
            }
            finally { updatingCalculations = false; }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (!exiting && !ValidateChildren())
            {
                e.Cancel = true;
                return;
            }
            base.OnFormClosing(e);
        }

        private void ZipCode_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bock Golf Store\n\nCreated by: Nicholas T. Maamo\nGwen Erick Lavarias\nDate: March 2026\n\n", "About Order Calculator", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
