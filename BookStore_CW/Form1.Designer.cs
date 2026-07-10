namespace BookStore_CW
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
            dataGridViewBooks = new DataGridView();
            booksCriteria = new ComboBox();
            pictureBox1 = new PictureBox();
            textBoxSearch = new TextBox();
            buttonSearch = new Button();
            buttonRemove = new Button();
            labelNew = new Label();
            textBoxName = new TextBox();
            textBoxAuthor = new TextBox();
            textBoxPublish = new TextBox();
            numericUpDownPages = new NumericUpDown();
            labelPages = new Label();
            textBoxGenre = new TextBox();
            numericUpDownYear = new NumericUpDown();
            labelPublishment = new Label();
            numericUpDownCost = new NumericUpDown();
            numericUpDownPrice = new NumericUpDown();
            comboBoxType = new ComboBox();
            labelCost = new Label();
            labelPrice = new Label();
            buttonSave = new Button();
            buttonSales = new Button();
            numericUpDownSale = new NumericUpDown();
            labelSale = new Label();
            buttonSold = new Button();
            buttonDeffer = new Button();
            textBoxUser = new TextBox();
            button1 = new Button();
            buttonBack = new Button();
            textBoxURL = new TextBox();
            labelURL = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPages).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCost).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSale).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewBooks
            // 
            dataGridViewBooks.BackgroundColor = Color.RosyBrown;
            dataGridViewBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBooks.GridColor = Color.MistyRose;
            dataGridViewBooks.Location = new Point(45, 87);
            dataGridViewBooks.Name = "dataGridViewBooks";
            dataGridViewBooks.RowHeadersWidth = 51;
            dataGridViewBooks.Size = new Size(1116, 637);
            dataGridViewBooks.TabIndex = 0;
            dataGridViewBooks.CellMouseClick += dataGridViewBooks_CellMouseClick;
            // 
            // booksCriteria
            // 
            booksCriteria.BackColor = Color.MistyRose;
            booksCriteria.DropDownWidth = 400;
            booksCriteria.Font = new Font("SimSun-ExtB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            booksCriteria.FormattingEnabled = true;
            booksCriteria.Items.AddRange(new object[] { "All", "Sold out", "Sales", "Deffered", "News" });
            booksCriteria.Location = new Point(45, 26);
            booksCriteria.Name = "booksCriteria";
            booksCriteria.Size = new Size(313, 28);
            booksCriteria.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Cursor = Cursors.Cross;
            pictureBox1.Location = new Point(1233, 87);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(344, 365);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // textBoxSearch
            // 
            textBoxSearch.BackColor = Color.MistyRose;
            textBoxSearch.Cursor = Cursors.Help;
            textBoxSearch.Font = new Font("SimSun-ExtB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSearch.Location = new Point(1187, 526);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(390, 27);
            textBoxSearch.TabIndex = 3;
            textBoxSearch.Text = "Search...";
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.FromArgb(255, 255, 192);
            buttonSearch.Cursor = Cursors.Hand;
            buttonSearch.Font = new Font("SimSun-ExtB", 13.8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            buttonSearch.Location = new Point(1609, 517);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(149, 46);
            buttonSearch.TabIndex = 4;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.BackColor = Color.FromArgb(255, 128, 128);
            buttonRemove.Cursor = Cursors.Hand;
            buttonRemove.Font = new Font("SimSun-ExtB", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRemove.ForeColor = Color.FromArgb(192, 255, 255);
            buttonRemove.Location = new Point(1187, 622);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(225, 102);
            buttonRemove.TabIndex = 5;
            buttonRemove.Text = "Remove selected book";
            buttonRemove.UseVisualStyleBackColor = false;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // labelNew
            // 
            labelNew.AutoSize = true;
            labelNew.Font = new Font("SimSun-ExtB", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNew.ForeColor = SystemColors.Desktop;
            labelNew.Location = new Point(45, 769);
            labelNew.Name = "labelNew";
            labelNew.Size = new Size(192, 28);
            labelNew.TabIndex = 6;
            labelNew.Text = "Add new BOOK";
            // 
            // textBoxName
            // 
            textBoxName.BackColor = Color.WhiteSmoke;
            textBoxName.Font = new Font("SimSun-ExtB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxName.Location = new Point(45, 813);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(325, 27);
            textBoxName.TabIndex = 7;
            textBoxName.Text = "Name";
            // 
            // textBoxAuthor
            // 
            textBoxAuthor.BackColor = Color.WhiteSmoke;
            textBoxAuthor.Font = new Font("SimSun-ExtB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxAuthor.Location = new Point(45, 863);
            textBoxAuthor.Name = "textBoxAuthor";
            textBoxAuthor.Size = new Size(325, 27);
            textBoxAuthor.TabIndex = 8;
            textBoxAuthor.Text = "Author";
            // 
            // textBoxPublish
            // 
            textBoxPublish.BackColor = Color.WhiteSmoke;
            textBoxPublish.Font = new Font("SimSun-ExtB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPublish.Location = new Point(45, 921);
            textBoxPublish.Name = "textBoxPublish";
            textBoxPublish.Size = new Size(325, 27);
            textBoxPublish.TabIndex = 9;
            textBoxPublish.Text = "Publishing House";
            // 
            // numericUpDownPages
            // 
            numericUpDownPages.BackColor = Color.WhiteSmoke;
            numericUpDownPages.Font = new Font("SimSun-ExtB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDownPages.Location = new Point(45, 993);
            numericUpDownPages.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownPages.Name = "numericUpDownPages";
            numericUpDownPages.Size = new Size(117, 27);
            numericUpDownPages.TabIndex = 10;
            // 
            // labelPages
            // 
            labelPages.AutoSize = true;
            labelPages.Font = new Font("SimSun-ExtB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPages.Location = new Point(45, 970);
            labelPages.Name = "labelPages";
            labelPages.Size = new Size(59, 20);
            labelPages.TabIndex = 11;
            labelPages.Text = "Pages";
            // 
            // textBoxGenre
            // 
            textBoxGenre.BackColor = Color.WhiteSmoke;
            textBoxGenre.Font = new Font("SimSun-ExtB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxGenre.Location = new Point(45, 1045);
            textBoxGenre.Name = "textBoxGenre";
            textBoxGenre.Size = new Size(325, 27);
            textBoxGenre.TabIndex = 12;
            textBoxGenre.Text = "Genre";
            // 
            // numericUpDownYear
            // 
            numericUpDownYear.BackColor = Color.WhiteSmoke;
            numericUpDownYear.Font = new Font("SimSun-ExtB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDownYear.Location = new Point(45, 1119);
            numericUpDownYear.Maximum = new decimal(new int[] { 2026, 0, 0, 0 });
            numericUpDownYear.Name = "numericUpDownYear";
            numericUpDownYear.Size = new Size(199, 27);
            numericUpDownYear.TabIndex = 13;
            // 
            // labelPublishment
            // 
            labelPublishment.AutoSize = true;
            labelPublishment.Font = new Font("SimSun-ExtB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPublishment.Location = new Point(45, 1096);
            labelPublishment.Name = "labelPublishment";
            labelPublishment.Size = new Size(199, 20);
            labelPublishment.TabIndex = 14;
            labelPublishment.Text = "Year of Publishment";
            // 
            // numericUpDownCost
            // 
            numericUpDownCost.BackColor = Color.WhiteSmoke;
            numericUpDownCost.Font = new Font("SimSun-ExtB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDownCost.Location = new Point(45, 1184);
            numericUpDownCost.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownCost.Name = "numericUpDownCost";
            numericUpDownCost.Size = new Size(150, 27);
            numericUpDownCost.TabIndex = 15;
            // 
            // numericUpDownPrice
            // 
            numericUpDownPrice.BackColor = Color.WhiteSmoke;
            numericUpDownPrice.Location = new Point(258, 1184);
            numericUpDownPrice.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new Size(150, 27);
            numericUpDownPrice.TabIndex = 16;
            // 
            // comboBoxType
            // 
            comboBoxType.BackColor = Color.WhiteSmoke;
            comboBoxType.Font = new Font("SimSun-ExtB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "Sequel", "Prequel", "None" });
            comboBoxType.Location = new Point(44, 1247);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(364, 28);
            comboBoxType.TabIndex = 17;
            comboBoxType.Text = "Choose...";
            // 
            // labelCost
            // 
            labelCost.AutoSize = true;
            labelCost.Font = new Font("SimSun-ExtB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCost.Location = new Point(45, 1161);
            labelCost.Name = "labelCost";
            labelCost.Size = new Size(109, 20);
            labelCost.TabIndex = 18;
            labelCost.Text = "Cost Price";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("SimSun-ExtB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrice.Location = new Point(258, 1161);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(59, 20);
            labelPrice.TabIndex = 19;
            labelPrice.Text = "Price";
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.FromArgb(192, 255, 192);
            buttonSave.Cursor = Cursors.Hand;
            buttonSave.Font = new Font("SimSun-ExtB", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSave.ForeColor = SystemColors.Desktop;
            buttonSave.Location = new Point(1438, 622);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(215, 102);
            buttonSave.TabIndex = 20;
            buttonSave.Text = "Save Changes";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonSales
            // 
            buttonSales.BackColor = Color.FromArgb(255, 224, 192);
            buttonSales.Cursor = Cursors.Hand;
            buttonSales.Font = new Font("SimSun-ExtB", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSales.Location = new Point(821, 730);
            buttonSales.Name = "buttonSales";
            buttonSales.Size = new Size(340, 68);
            buttonSales.TabIndex = 21;
            buttonSales.Text = "Add to Sales";
            buttonSales.UseVisualStyleBackColor = false;
            buttonSales.Click += buttonSales_Click;
            // 
            // numericUpDownSale
            // 
            numericUpDownSale.BackColor = Color.WhiteSmoke;
            numericUpDownSale.Font = new Font("SimSun-ExtB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDownSale.Location = new Point(665, 730);
            numericUpDownSale.Name = "numericUpDownSale";
            numericUpDownSale.Size = new Size(150, 27);
            numericUpDownSale.TabIndex = 22;
            // 
            // labelSale
            // 
            labelSale.AutoSize = true;
            labelSale.Font = new Font("SimSun-ExtB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSale.Location = new Point(577, 732);
            labelSale.Name = "labelSale";
            labelSale.Size = new Size(69, 20);
            labelSale.TabIndex = 23;
            labelSale.Text = "Sale %";
            // 
            // buttonSold
            // 
            buttonSold.BackColor = Color.FromArgb(192, 192, 255);
            buttonSold.Cursor = Cursors.Hand;
            buttonSold.Font = new Font("SimSun-ExtB", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSold.Location = new Point(821, 823);
            buttonSold.Name = "buttonSold";
            buttonSold.Size = new Size(340, 67);
            buttonSold.TabIndex = 24;
            buttonSold.Text = "Sold";
            buttonSold.UseVisualStyleBackColor = false;
            buttonSold.Click += buttonSold_Click;
            // 
            // buttonDeffer
            // 
            buttonDeffer.BackColor = Color.LavenderBlush;
            buttonDeffer.Cursor = Cursors.Hand;
            buttonDeffer.Font = new Font("SimSun-ExtB", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDeffer.Location = new Point(821, 921);
            buttonDeffer.Name = "buttonDeffer";
            buttonDeffer.Size = new Size(340, 75);
            buttonDeffer.TabIndex = 25;
            buttonDeffer.Text = "Deffer to";
            buttonDeffer.UseVisualStyleBackColor = false;
            buttonDeffer.Click += buttonDeffer_Click;
            // 
            // textBoxUser
            // 
            textBoxUser.Font = new Font("SimSun-ExtB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxUser.Location = new Point(593, 948);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(208, 27);
            textBoxUser.TabIndex = 26;
            textBoxUser.Text = "User Name";
            // 
            // button1
            // 
            button1.BackColor = Color.PowderBlue;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("SimSun-ExtB", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(480, 1184);
            button1.Name = "button1";
            button1.Size = new Size(302, 92);
            button1.TabIndex = 27;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.Lavender;
            buttonBack.Cursor = Cursors.Hand;
            buttonBack.Font = new Font("SimSun-ExtB", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBack.Location = new Point(821, 1029);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(340, 75);
            buttonBack.TabIndex = 28;
            buttonBack.Text = "Back To General";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // textBoxURL
            // 
            textBoxURL.Font = new Font("SimSun-ExtB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxURL.Location = new Point(45, 1314);
            textBoxURL.Name = "textBoxURL";
            textBoxURL.Size = new Size(737, 27);
            textBoxURL.TabIndex = 29;
            // 
            // labelURL
            // 
            labelURL.AutoSize = true;
            labelURL.Font = new Font("SimSun-ExtB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelURL.Location = new Point(45, 1291);
            labelURL.Name = "labelURL";
            labelURL.Size = new Size(349, 20);
            labelURL.TabIndex = 30;
            labelURL.Text = "Enter picture URL(not necessarily)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1858, 1374);
            Controls.Add(labelURL);
            Controls.Add(textBoxURL);
            Controls.Add(buttonBack);
            Controls.Add(button1);
            Controls.Add(textBoxUser);
            Controls.Add(buttonDeffer);
            Controls.Add(buttonSold);
            Controls.Add(labelSale);
            Controls.Add(numericUpDownSale);
            Controls.Add(buttonSales);
            Controls.Add(buttonSave);
            Controls.Add(labelPrice);
            Controls.Add(labelCost);
            Controls.Add(comboBoxType);
            Controls.Add(numericUpDownPrice);
            Controls.Add(numericUpDownCost);
            Controls.Add(labelPublishment);
            Controls.Add(numericUpDownYear);
            Controls.Add(textBoxGenre);
            Controls.Add(labelPages);
            Controls.Add(numericUpDownPages);
            Controls.Add(textBoxPublish);
            Controls.Add(textBoxAuthor);
            Controls.Add(textBoxName);
            Controls.Add(labelNew);
            Controls.Add(buttonRemove);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxSearch);
            Controls.Add(pictureBox1);
            Controls.Add(booksCriteria);
            Controls.Add(dataGridViewBooks);
            ForeColor = SystemColors.Desktop;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPages).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCost).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSale).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewBooks;
        private ComboBox booksCriteria;
        private PictureBox pictureBox1;
        private TextBox textBoxSearch;
        private Button buttonSearch;
        private Button buttonRemove;
        private Label labelNew;
        private TextBox textBoxName;
        private TextBox textBoxAuthor;
        private TextBox textBoxPublish;
        private NumericUpDown numericUpDownPages;
        private Label labelPages;
        private TextBox textBoxGenre;
        private NumericUpDown numericUpDownYear;
        private Label labelPublishment;
        private NumericUpDown numericUpDownCost;
        private NumericUpDown numericUpDownPrice;
        private ComboBox comboBoxType;
        private Label labelCost;
        private Label labelPrice;
        private Button buttonSave;
        private Button buttonSales;
        private NumericUpDown numericUpDownSale;
        private Label labelSale;
        private Button buttonSold;
        private Button buttonDeffer;
        private TextBox textBoxUser;
        private Button button1;
        private Button buttonBack;
        private TextBox textBoxURL;
        private Label labelURL;
    }
}
