namespace Machine_Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtName = new TextBox();
            Address = new TextBox();
            City = new TextBox();
            ZipCode = new MaskedTextBox();
            State = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            Description = new TextBox();
            Price = new TextBox();
            Quantity = new TextBox();
            label10 = new Label();
            Weight = new TextBox();
            label11 = new Label();
            USP = new RadioButton();
            FEA = new RadioButton();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            Item_Cost = new TextBox();
            Sales_Tax = new TextBox();
            Shipping = new TextBox();
            Handling = new TextBox();
            Total = new TextBox();
            groupBox1 = new GroupBox();
            Tax_Exempt = new CheckBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            Compute = new Button();
            Next_Order = new Button();
            Exit = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            actionsToolStripMenuItem = new ToolStripMenuItem();
            computeToolStripMenuItem = new ToolStripMenuItem();
            nextOrderToolStripMenuItem = new ToolStripMenuItem();
            colorToolStripMenuItem = new ToolStripMenuItem();
            whiteToolStripMenuItem = new ToolStripMenuItem();
            blueToolStripMenuItem = new ToolStripMenuItem();
            greenToolStripMenuItem = new ToolStripMenuItem();
            redToolStripMenuItem = new ToolStripMenuItem();
            fontToolStripMenuItem = new ToolStripMenuItem();
            rOGFontsSTRIXSCARToolStripMenuItem = new ToolStripMenuItem();
            arialRoundedMTToolStripMenuItem = new ToolStripMenuItem();
            timesNewRomanToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 23);
            label1.Name = "label1";
            label1.Size = new Size(154, 20);
            label1.TabIndex = 0;
            label1.Text = "Customer Information";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 59);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 1;
            label2.Text = "Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 99);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 2;
            label3.Text = "Address :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 144);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 3;
            label4.Text = "City/State :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 186);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 4;
            label5.Text = "Zip Code :";
            // 
            // txtName
            // 
            txtName.Location = new Point(146, 56);
            txtName.Name = "txtName";
            txtName.Size = new Size(220, 27);
            txtName.TabIndex = 5;
            txtName.TextChanged += txtName_TextChanged;
            txtName.KeyDown += txtName_KeyDown;
            // 
            // Address
            // 
            Address.Location = new Point(146, 96);
            Address.Name = "Address";
            Address.Size = new Size(220, 27);
            Address.TabIndex = 6;
            Address.TextChanged += Address_TextChanged;
            // 
            // City
            // 
            City.Location = new Point(146, 141);
            City.Name = "City";
            City.Size = new Size(154, 27);
            City.TabIndex = 7;
            City.TextChanged += City_TextChanged;
            // 
            // ZipCode
            // 
            ZipCode.Location = new Point(146, 183);
            ZipCode.Mask = "00000-9999";
            ZipCode.Name = "ZipCode";
            ZipCode.PromptChar = ' ';
            ZipCode.Size = new Size(125, 27);
            ZipCode.TabIndex = 8;
            ZipCode.MaskInputRejected += ZipCode_MaskInputRejected;
            ZipCode.TextChanged += ZipCode_TextChanged;
            // 
            // State
            // 
            State.Location = new Point(322, 141);
            State.Name = "State";
            State.Size = new Size(44, 27);
            State.TabIndex = 9;
            State.TextChanged += State_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 22);
            label6.Name = "label6";
            label6.Size = new Size(109, 20);
            label6.TabIndex = 10;
            label6.Text = "Golf Sales Item";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(36, 48);
            label7.Name = "label7";
            label7.Size = new Size(92, 20);
            label7.TabIndex = 11;
            label7.Text = "Description :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(36, 87);
            label8.Name = "label8";
            label8.Size = new Size(48, 20);
            label8.TabIndex = 12;
            label8.Text = "Price :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(36, 124);
            label9.Name = "label9";
            label9.Size = new Size(72, 20);
            label9.TabIndex = 13;
            label9.Text = "Quantity :";
            // 
            // Description
            // 
            Description.Location = new Point(142, 45);
            Description.Name = "Description";
            Description.Size = new Size(220, 27);
            Description.TabIndex = 14;
            Description.TextChanged += description;
            // 
            // Price
            // 
            Price.Location = new Point(142, 84);
            Price.Name = "Price";
            Price.Size = new Size(125, 27);
            Price.TabIndex = 15;
            Price.Click += cost;
            Price.TextChanged += price;
            // 
            // Quantity
            // 
            Quantity.Location = new Point(142, 121);
            Quantity.Name = "Quantity";
            Quantity.Size = new Size(67, 27);
            Quantity.TabIndex = 16;
            Quantity.TextChanged += quantity;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(233, 124);
            label10.Name = "label10";
            label10.Size = new Size(63, 20);
            label10.TabIndex = 17;
            label10.Text = "Weight :";
            // 
            // Weight
            // 
            Weight.Location = new Point(302, 124);
            Weight.Name = "Weight";
            Weight.Size = new Size(65, 27);
            Weight.TabIndex = 18;
            Weight.TextChanged += weight;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(35, 23);
            label11.Name = "label11";
            label11.Size = new Size(124, 20);
            label11.TabIndex = 19;
            label11.Text = "Shipping Method";
            // 
            // USP
            // 
            USP.AutoSize = true;
            USP.Location = new Point(35, 56);
            USP.Name = "USP";
            USP.Size = new Size(168, 24);
            USP.TabIndex = 20;
            USP.TabStop = true;
            USP.Text = "United Parcel Service";
            USP.UseVisualStyleBackColor = true;
            USP.CheckedChanged += USP_CheckedChanged;
            // 
            // FEA
            // 
            FEA.AutoSize = true;
            FEA.Location = new Point(35, 96);
            FEA.Name = "FEA";
            FEA.Size = new Size(155, 24);
            FEA.TabIndex = 21;
            FEA.TabStop = true;
            FEA.Text = "Federal Express Air";
            FEA.UseVisualStyleBackColor = true;
            FEA.CheckedChanged += FEA_CheckedChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(25, 13);
            label12.Name = "label12";
            label12.Size = new Size(125, 20);
            label12.TabIndex = 22;
            label12.Text = "Sales Information";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(25, 49);
            label13.Name = "label13";
            label13.Size = new Size(79, 20);
            label13.TabIndex = 23;
            label13.Text = "Item Cost :";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(25, 84);
            label14.Name = "label14";
            label14.Size = new Size(75, 20);
            label14.TabIndex = 24;
            label14.Text = "Sales Tax :";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(25, 117);
            label15.Name = "label15";
            label15.Size = new Size(75, 20);
            label15.TabIndex = 25;
            label15.Text = "Shipping :";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(25, 158);
            label16.Name = "label16";
            label16.Size = new Size(77, 20);
            label16.TabIndex = 26;
            label16.Text = "Handling :";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(25, 197);
            label17.Name = "label17";
            label17.Size = new Size(49, 20);
            label17.TabIndex = 27;
            label17.Text = "Total :";
            // 
            // Item_Cost
            // 
            Item_Cost.Location = new Point(110, 46);
            Item_Cost.Name = "Item_Cost";
            Item_Cost.Size = new Size(125, 27);
            Item_Cost.TabIndex = 28;
            // 
            // Sales_Tax
            // 
            Sales_Tax.Location = new Point(110, 81);
            Sales_Tax.Name = "Sales_Tax";
            Sales_Tax.Size = new Size(125, 27);
            Sales_Tax.TabIndex = 29;
            Sales_Tax.TextChanged += tax;
            // 
            // Shipping
            // 
            Shipping.Location = new Point(110, 117);
            Shipping.Name = "Shipping";
            Shipping.Size = new Size(125, 27);
            Shipping.TabIndex = 30;
            Shipping.TextChanged += shipping;
            // 
            // Handling
            // 
            Handling.Location = new Point(108, 155);
            Handling.Name = "Handling";
            Handling.Size = new Size(125, 27);
            Handling.TabIndex = 31;
            Handling.TextChanged += handling;
            // 
            // Total
            // 
            Total.Location = new Point(108, 194);
            Total.Name = "Total";
            Total.Size = new Size(125, 27);
            Total.TabIndex = 32;
            Total.TextChanged += total;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Crimson;
            groupBox1.Controls.Add(Tax_Exempt);
            groupBox1.Controls.Add(State);
            groupBox1.Controls.Add(ZipCode);
            groupBox1.Controls.Add(City);
            groupBox1.Controls.Add(Address);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(420, 255);
            groupBox1.TabIndex = 33;
            groupBox1.TabStop = false;
            // 
            // Tax_Exempt
            // 
            Tax_Exempt.AutoSize = true;
            Tax_Exempt.Location = new Point(146, 216);
            Tax_Exempt.Name = "Tax_Exempt";
            Tax_Exempt.Size = new Size(152, 24);
            Tax_Exempt.TabIndex = 40;
            Tax_Exempt.Text = "Tax Exempt (Y/N)?";
            Tax_Exempt.UseVisualStyleBackColor = true;
            Tax_Exempt.CheckedChanged += TaxExempt;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Crimson;
            groupBox2.Controls.Add(Weight);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(Quantity);
            groupBox2.Controls.Add(Price);
            groupBox2.Controls.Add(Description);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(12, 301);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(420, 169);
            groupBox2.TabIndex = 34;
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Crimson;
            groupBox3.Controls.Add(FEA);
            groupBox3.Controls.Add(USP);
            groupBox3.Controls.Add(label11);
            groupBox3.Location = new Point(438, 40);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(319, 138);
            groupBox3.TabIndex = 35;
            groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.Crimson;
            groupBox4.Controls.Add(Total);
            groupBox4.Controls.Add(Handling);
            groupBox4.Controls.Add(Shipping);
            groupBox4.Controls.Add(Sales_Tax);
            groupBox4.Controls.Add(Item_Cost);
            groupBox4.Controls.Add(label17);
            groupBox4.Controls.Add(label16);
            groupBox4.Controls.Add(label15);
            groupBox4.Controls.Add(label14);
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(label12);
            groupBox4.Location = new Point(438, 184);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(319, 286);
            groupBox4.TabIndex = 36;
            groupBox4.TabStop = false;
            // 
            // Compute
            // 
            Compute.BackColor = Color.Crimson;
            Compute.Location = new Point(190, 476);
            Compute.Name = "Compute";
            Compute.Size = new Size(137, 47);
            Compute.TabIndex = 37;
            Compute.Text = "Compute";
            Compute.UseVisualStyleBackColor = false;
            Compute.Click += Compute_Click;
            // 
            // Next_Order
            // 
            Next_Order.BackColor = Color.Crimson;
            Next_Order.Location = new Point(375, 476);
            Next_Order.Name = "Next_Order";
            Next_Order.Size = new Size(137, 47);
            Next_Order.TabIndex = 38;
            Next_Order.Text = "Next Order";
            Next_Order.UseVisualStyleBackColor = false;
            Next_Order.Click += Next_Order_Click;
            // 
            // Exit
            // 
            Exit.BackColor = Color.Crimson;
            Exit.Location = new Point(552, 476);
            Exit.Name = "Exit";
            Exit.Size = new Size(137, 45);
            Exit.TabIndex = 39;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += Exit_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Crimson;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, actionsToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(918, 28);
            menuStrip1.TabIndex = 40;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            exitToolStripMenuItem.Size = new Size(167, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // actionsToolStripMenuItem
            // 
            actionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { computeToolStripMenuItem, nextOrderToolStripMenuItem, colorToolStripMenuItem, fontToolStripMenuItem });
            actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            actionsToolStripMenuItem.Size = new Size(72, 24);
            actionsToolStripMenuItem.Text = "Actions";
            // 
            // computeToolStripMenuItem
            // 
            computeToolStripMenuItem.Name = "computeToolStripMenuItem";
            computeToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            computeToolStripMenuItem.Size = new Size(218, 26);
            computeToolStripMenuItem.Text = "Compute";
            computeToolStripMenuItem.Click += computeToolStripMenuItem_Click;
            // 
            // nextOrderToolStripMenuItem
            // 
            nextOrderToolStripMenuItem.Name = "nextOrderToolStripMenuItem";
            nextOrderToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            nextOrderToolStripMenuItem.Size = new Size(218, 26);
            nextOrderToolStripMenuItem.Text = "Next Order";
            nextOrderToolStripMenuItem.Click += nextOrderToolStripMenuItem_Click;
            // 
            // colorToolStripMenuItem
            // 
            colorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { whiteToolStripMenuItem, blueToolStripMenuItem, greenToolStripMenuItem, redToolStripMenuItem });
            colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            colorToolStripMenuItem.Size = new Size(218, 26);
            colorToolStripMenuItem.Text = "Color";
            colorToolStripMenuItem.Click += colorToolStripMenuItem_Click;
            // 
            // whiteToolStripMenuItem
            // 
            whiteToolStripMenuItem.Name = "whiteToolStripMenuItem";
            whiteToolStripMenuItem.Size = new Size(131, 26);
            whiteToolStripMenuItem.Text = "White";
            whiteToolStripMenuItem.Click += whiteToolStripMenuItem_Click;
            // 
            // blueToolStripMenuItem
            // 
            blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            blueToolStripMenuItem.Size = new Size(131, 26);
            blueToolStripMenuItem.Text = "Blue";
            blueToolStripMenuItem.Click += blueToolStripMenuItem_Click;
            // 
            // greenToolStripMenuItem
            // 
            greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            greenToolStripMenuItem.Size = new Size(131, 26);
            greenToolStripMenuItem.Text = "Green";
            greenToolStripMenuItem.Click += greenToolStripMenuItem_Click;
            // 
            // redToolStripMenuItem
            // 
            redToolStripMenuItem.Name = "redToolStripMenuItem";
            redToolStripMenuItem.Size = new Size(131, 26);
            redToolStripMenuItem.Text = "Red";
            redToolStripMenuItem.Click += redToolStripMenuItem_Click;
            // 
            // fontToolStripMenuItem
            // 
            fontToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { rOGFontsSTRIXSCARToolStripMenuItem, arialRoundedMTToolStripMenuItem, timesNewRomanToolStripMenuItem });
            fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            fontToolStripMenuItem.Size = new Size(218, 26);
            fontToolStripMenuItem.Text = "Font";
            // 
            // rOGFontsSTRIXSCARToolStripMenuItem
            // 
            rOGFontsSTRIXSCARToolStripMenuItem.Name = "rOGFontsSTRIXSCARToolStripMenuItem";
            rOGFontsSTRIXSCARToolStripMenuItem.Size = new Size(243, 26);
            rOGFontsSTRIXSCARToolStripMenuItem.Text = "ROG Fonts STRIX SCAR";
            rOGFontsSTRIXSCARToolStripMenuItem.Click += rOGFontsSTRIXSCARToolStripMenuItem_Click;
            // 
            // arialRoundedMTToolStripMenuItem
            // 
            arialRoundedMTToolStripMenuItem.Name = "arialRoundedMTToolStripMenuItem";
            arialRoundedMTToolStripMenuItem.Size = new Size(243, 26);
            arialRoundedMTToolStripMenuItem.Text = "Arial Rounded MT";
            arialRoundedMTToolStripMenuItem.Click += arialRoundedMTToolStripMenuItem_Click;
            // 
            // timesNewRomanToolStripMenuItem
            // 
            timesNewRomanToolStripMenuItem.Name = "timesNewRomanToolStripMenuItem";
            timesNewRomanToolStripMenuItem.Size = new Size(243, 26);
            timesNewRomanToolStripMenuItem.Text = "Times New Roman";
            timesNewRomanToolStripMenuItem.Click += timesNewRomanToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(224, 26);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(918, 605);
            Controls.Add(Exit);
            Controls.Add(Next_Order);
            Controls.Add(Compute);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Bock Golf Store -  Telephonic Sales Processing";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtName;
        private TextBox Address;
        private TextBox City;
        private MaskedTextBox ZipCode;
        private TextBox State;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox Description;
        private TextBox Price;
        private TextBox Quantity;
        private Label label10;
        private TextBox Weight;
        private Label label11;
        private RadioButton USP;
        private RadioButton FEA;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private TextBox Item_Cost;
        private TextBox Sales_Tax;
        private TextBox Shipping;
        private TextBox Handling;
        private TextBox Total;
        private GroupBox groupBox1;
        private CheckBox Tax_Exempt;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Button Compute;
        private Button Next_Order;
        private Button Exit;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem actionsToolStripMenuItem;
        private ToolStripMenuItem computeToolStripMenuItem;
        private ToolStripMenuItem nextOrderToolStripMenuItem;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ToolStripMenuItem fontToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem rOGFontsSTRIXSCARToolStripMenuItem;
        private ToolStripMenuItem arialRoundedMTToolStripMenuItem;
        private ToolStripMenuItem timesNewRomanToolStripMenuItem;
        private ToolStripMenuItem whiteToolStripMenuItem;
        private ToolStripMenuItem blueToolStripMenuItem;
        private ToolStripMenuItem greenToolStripMenuItem;
        private ToolStripMenuItem redToolStripMenuItem;
    }
}
