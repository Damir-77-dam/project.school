using Personal.App.Database.Context;
using Personal.App.Database.Entities;

namespace Personal.App
{
    public partial class EditOffice : Form
    {
        private bool _isEditMode;
        private readonly int? _id;

        public EditOffice()
        {
            InitializeComponent();
        }

        private EditOffice(int? id = null)
        {
            InitializeComponent();
            _id = id;
            _isEditMode = id != null;
            if (_isEditMode)
            {
                using var context = PersonalDbContextFactory.CreateDbContext();
                var entity = context.Offices.First(x => x.Id == id.Value);
                tbId.Text = entity.Id.ToString();
                tbCountry.Text = entity.Country;
                tbCity.Text = entity.City;
                tbPostIndex.Text = entity.PostIndex;
                tbStreet.Text = entity.Street;
                tbMobileNumber.Text = entity.MobileNumber;
            }
        }

        public static EditOffice CreateForAdd()
        {
            return new EditOffice(null);
        }

        public static EditOffice CreateForEdit(int id)
        {
            return new EditOffice(id);
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            //TODO: Check errors
            if (_isEditMode)
            {
                try
                {
                    using var context = PersonalDbContextFactory.CreateDbContext();
                    context.Offices.Update(new Office()
                    {
                        Id = _id.Value,
                        Country = tbCountry.Text,
                        PostIndex = tbPostIndex.Text,
                        City = tbCity.Text,
                        Street = tbStreet.Text,
                        MobileNumber = tbMobileNumber.Text
                    });
                    context.SaveChanges();
                    DialogResult = DialogResult.OK;
                }
                catch (Exception)
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                try
                {
                    using var context = PersonalDbContextFactory.CreateDbContext();
                    context.Offices.Add(new Office()
                    {
                        Country = tbCountry.Text,
                        PostIndex = tbPostIndex.Text,
                        City = tbCity.Text,
                        Street = tbStreet.Text,
                        MobileNumber = tbMobileNumber.Text
                    });
                    context.SaveChanges();
                    DialogResult = DialogResult.OK;
                }
                catch (Exception)
                {
                    MessageBox.Show("Error");
                }
            }
        }
    }
}


    