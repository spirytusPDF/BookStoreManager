using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BookStore_CW
{
    public partial class Form1 : Form
    {
        private Handler DBHandler = new();
        public Form1()
        {
            InitializeComponent();

            dataGridViewBooks.AllowUserToAddRows = false;
            this.AutoScroll = true;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxAuthor.Tag = "Author";
            textBoxName.Tag = "Name";
            textBoxGenre.Tag = "Genre";
            textBoxPublish.Tag = "Publisher";
            textBoxUser.Tag = "User name";
            textBoxSearch.Tag = "Search...";

            DBHandler.Load();
            booksCriteria.DataSource = Enum.GetValues(typeof(ViewType));
            booksCriteria.SelectedIndex = 0;
            booksCriteria.SelectedIndexChanged += booksCriteria_SelectedIndexChanged;
            dataGridViewBooks.DataSource = DBHandler.context.Books.Local.ToBindingList();
            if (dataGridViewBooks.Columns.Contains("PictureURL"))
                dataGridViewBooks.Columns["PictureURL"].Visible = false;
            if (dataGridViewBooks.Columns.Contains("Id"))
                dataGridViewBooks.Columns["Id"].Visible = false;
            if (dataGridViewBooks.Columns.Contains("Type"))
            {
                dataGridViewBooks.Columns.Remove("Type");
            }

            var typeCol = new DataGridViewComboBoxColumn
            {
                Name = "Type",
                DataPropertyName = "Type",
                DataSource = Enum.GetValues(typeof(Type)),
                HeaderText = "Type"
            };
            dataGridViewBooks.Columns.Add(typeCol);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckFields() == false) return;

            Type type = (Type)comboBoxType.SelectedIndex;
            Book newBook = new Book()
            {
                Name = textBoxName.Text,
                Author = textBoxAuthor.Text,
                PublishName = textBoxPublish.Text,
                Pages = (int)numericUpDownPages.Value,
                Genre = textBoxGenre.Text,
                Cost = numericUpDownCost.Value,
                Price = numericUpDownPrice.Value,
                Type = type,
                YearofPublish = (int)numericUpDownYear.Value,
                PictureURL = textBoxURL.Text
            };

            DBHandler.context.Books.Add(newBook);
            DBHandler.context.SaveChanges();
            ClearFields(this);


        }


        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (GetActualSelected() is Book selected)
            {
                var result = MessageBox.Show("Do you really want to delete this record?",
                                             "Confirmation",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DBHandler.context.Books.Remove(selected);
                    DBHandler.context.SaveChanges();

                    dataGridViewBooks.Refresh();
                }
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            DBHandler.context.SaveChanges();
            dataGridViewBooks.Refresh();
        }

        private void buttonSold_Click(object sender, EventArgs e)
        {
            if (GetActualSelected() is Book selected)
            {
                var result = MessageBox.Show("Do you really want to sell this book?",
                                            "Confirmation",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    SoldBook soldbook = new SoldBook()
                    {
                        Id = selected.Id,
                        Name = selected.Name,
                        Author = selected.Author,
                        PublishName = selected.PublishName,
                        Genre = selected.Genre,
                        Price = selected.Price,
                        Cost = selected.Cost,
                        Type = selected.Type,
                        YearofPublish = selected.YearofPublish,
                        Pages = selected.Pages,
                        PictureURL = selected.PictureURL
                    };
                    DBHandler.context.Books.Remove(selected);
                    DBHandler.context.SaveChanges();
                    DBHandler.context.SoldBooks.Add(soldbook);
                    DBHandler.context.SaveChanges();

                    dataGridViewBooks.Refresh();
                }
            }
        }




        private void buttonSales_Click(object sender, EventArgs e)
        {
            if (numericUpDownSale.Value <= 0)
            {
                MessageBox.Show("The sale must be bigger than 0", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (GetActualSelected() is Book selected)
            {
                var result = MessageBox.Show("Do you really want to add a sale to this book?",
                                            "Confirmation",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    BookOnSale bookOnSale = new BookOnSale()
                    {
                        Id = selected.Id,
                        Name = selected.Name,
                        Author = selected.Author,
                        PublishName = selected.PublishName,
                        Genre = selected.Genre,
                        Price = selected.Price,
                        Cost = selected.Cost,
                        Type = selected.Type,
                        YearofPublish = selected.YearofPublish,
                        Pages = selected.Pages,
                        SalePercent = (int)numericUpDownSale.Value,
                        NewPrice = selected.Price * numericUpDownSale.Value / 100,
                        PictureURL = selected.PictureURL

                    };
                    DBHandler.context.Books.Remove(selected);
                    DBHandler.context.SaveChanges();
                    DBHandler.context.BooksOnSale.Add(bookOnSale);
                    DBHandler.context.SaveChanges();

                    dataGridViewBooks.Refresh();
                }
            }
        }

        private void buttonDeffer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxUser.Text))
            {
                MessageBox.Show("Enter any user name!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (GetActualSelected() is Book selected)
            {
                var result = MessageBox.Show($"Do you really want to deffer this book to {textBoxUser.Text}?",
                                            "Confirmation",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    var user = DBHandler.context.Costumers
                                .Local
                                .FirstOrDefault(u => string.Equals(u.Name, textBoxUser.Text, StringComparison.OrdinalIgnoreCase));

                    if (user == null)
                    {
                        user = new User { Name = textBoxUser.Text };
                        DBHandler.context.Costumers.Add(user);
                        DBHandler.context.SaveChanges(); 
                    }
                    
                    DefferedBooks bookdef = new DefferedBooks()
                    {
                        Id = selected.Id,
                        Name = selected.Name,
                        Author = selected.Author,
                        PublishName = selected.PublishName,
                        Genre = selected.Genre,
                        Price = selected.Price,
                        Cost = selected.Cost,
                        Type = selected.Type,
                        YearofPublish = selected.YearofPublish,
                        Pages = selected.Pages,
                        User = user,
                        PictureURL = selected.PictureURL

                    };
                    DBHandler.context.Books.Remove(selected);
                    DBHandler.context.SaveChanges();
                    DBHandler.context.DefferedBooks.Add(bookdef);
                    DBHandler.context.SaveChanges();

                    dataGridViewBooks.Refresh();
                    

                }
                ClearFields(this);
            }
        }


        private bool CheckFields()
        {

            var checks = new (Control ctrl, string msg, Func<Control, bool> validator)[]
            {
        (textBoxName, "Enter book name!", c => !string.IsNullOrWhiteSpace(((TextBox)c).Text)),
        (textBoxAuthor, "Enter author name!", c => !string.IsNullOrWhiteSpace(((TextBox)c).Text)),
        (textBoxPublish, "Enter publisher name!", c => !string.IsNullOrWhiteSpace(((TextBox)c).Text)),
        (numericUpDownPages, "Enter correct page amount!", c => ((NumericUpDown)c).Value > 0),
        (textBoxGenre, "Enter genre!", c => !string.IsNullOrWhiteSpace(((TextBox)c).Text)),
        (numericUpDownCost, "Enter correct cost!", c => ((NumericUpDown)c).Value > 0),
        (numericUpDownPrice, "Enter correct price!", c => ((NumericUpDown)c).Value > 0),
        (comboBoxType, "Enter book type!", c => ((ComboBox)c).SelectedIndex != -1),
        (numericUpDownYear, "Enter correct year!", c => ((NumericUpDown)c).Value > 0)
            };

            foreach (var (ctrl, msg, validator) in checks)
            {
                if (!validator(ctrl))
                {
                    MessageBox.Show(msg, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrl.Focus();
                    return false;
                }
            }

            return true;
        }

        private void ClearFields(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                switch (ctrl)
                {
                    case TextBox tb:
                        tb.Text = tb.Tag?.ToString() ?? "";
                        break;
                    case NumericUpDown nud:
                        nud.Value = nud.Minimum;
                        break;

                }



            }
        }

        private Book GetActualSelected() => (Book)dataGridViewBooks.CurrentRow?.DataBoundItem;

        private void booksCriteria_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDataGrid();
        }

        private void UpdateDataGrid()
        {
            var selectedView = (ViewType)booksCriteria.SelectedItem;

            switch (selectedView)
            {
                case ViewType.All:
                    DBHandler.context.Books.Load();
                    dataGridViewBooks.DataSource = DBHandler.context.Books.Local.ToBindingList();
                    dataGridViewBooks.BackgroundColor = Color.RosyBrown;
                    break;

                case ViewType.Sold_out:
                    DBHandler.context.SoldBooks.Load();
                    dataGridViewBooks.DataSource = DBHandler.context.SoldBooks.Local.ToBindingList();
                    dataGridViewBooks.BackgroundColor = Color.LightCoral;
                    break;

                case ViewType.Deffered:
                    DBHandler.context.DefferedBooks.Load();
                    dataGridViewBooks.DataSource = DBHandler.context.DefferedBooks.Local.ToBindingList();
                    dataGridViewBooks.Columns["User"].Visible = false;
                    dataGridViewBooks.BackgroundColor = Color.SlateBlue;
                    break;

                case ViewType.News:

                    DBHandler.context.Books.Load();
                    var lastBooks = DBHandler.context.Books.Local
                                       .OrderByDescending(b => b.YearofPublish)
                                       .Take(10)
                                       .ToList();
                    dataGridViewBooks.DataSource = lastBooks;
                    dataGridViewBooks.BackgroundColor = Color.MintCream;
                    break;

                case ViewType.Sales:
                    DBHandler.context.BooksOnSale.Load();
                    dataGridViewBooks.DataSource = DBHandler.context.BooksOnSale.Local.ToBindingList();
                    dataGridViewBooks.BackgroundColor = Color.Wheat;
                    break;
            }

            dataGridViewBooks.Refresh();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (GetActualSelected() is Book selected)
            {
                var selectedView = (ViewType)booksCriteria.SelectedItem;

                switch (selectedView)
                {
                    case ViewType.Deffered:
                        DBHandler.context.Books.Add(selected as Book);
                        DBHandler.context.DefferedBooks.Remove(selected as DefferedBooks);
                        

                        break;
                    case ViewType.Sales:
                        DBHandler.context.Books.Add(selected as Book);
                        DBHandler.context.BooksOnSale.Remove(selected as BookOnSale);
                        break;
                    case ViewType.Sold_out:
                        DBHandler.context.Books.Add(selected as Book);
                        DBHandler.context.SoldBooks.Remove(selected as SoldBook);
                        break;
                    default:
                        break;

                }
                DBHandler.context.SaveChanges();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            booksCriteria.SelectedIndex = default;
            dataGridViewBooks.ClearSelection();

            var books = DBHandler.context.Books.ToList();
            string pattern = textBoxSearch.Text;
            var result = books.Where(b => Regex.IsMatch(b.Name, pattern, RegexOptions.IgnoreCase) || Regex.IsMatch(b.Author, pattern, RegexOptions.IgnoreCase)).ToList();
            dataGridViewBooks.DataSource = result;
        }

        private void dataGridViewBooks_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            Book selected = GetActualSelected();
            pictureBox1.LoadAsync(selected.PictureURL);
        }
    }
}

