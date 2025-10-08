using Personal.App.Database.Context;
using Personal.App.Database.Entities;

namespace Personal.App
{
    public partial class EditEmployee : Form
    {
        private bool _isEditMode;
        private readonly int? _id;

        public EditEmployee()
        {
            InitializeComponent();
        }

        private EditEmployee(int? id = null)
        {
            InitializeComponent();
            _id = id;
            _isEditMode = id != null;
            using var context = PersonalDbContextFactory.CreateDbContext();

            //Profession
            var professionList = context.Ppofeshionals.ToList();
            cbProfession.DataSource = professionList;

            //Office
            var officeList = context.Offices.ToList();
            cbOffice.DataSource = officeList;

            if (_isEditMode)
            {
                var entity = context.Employees.First(x => x.Id == id.Value);

                tbId.Text = entity.Id.ToString();
                tbName.Text = entity.Name;
                tbSerename.Text = entity.Serename;

                //Profession
                cbProfession.SelectedValue = entity.ProfessionId;

                //Office
                cbOffice.SelectedValue = entity.OfficeId;
            }
        }

        public static EditEmployee CreateForAdd()
        {
            return new EditEmployee(null);
        }

        public static EditEmployee CreateForEdit(int id)
        {
            return new EditEmployee(id);
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            //TODO: Check errors
            if (_isEditMode)
            {
                try
                {
                    using var context = PersonalDbContextFactory.CreateDbContext();
                    context.Employees.Update(new Employee()
                    {
                        Id = _id.Value,
                        Name = tbName.Text,
                        Serename = tbSerename.Text,
                        ProfessionId = (int)cbProfession.SelectedValue,
                        OfficeId = (int)cbOffice.SelectedValue
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
                    context.Employees.Add(new Employee()
                    {
                        Name = tbName.Text,
                        Serename = tbSerename.Text,
                        ProfessionId = (int)cbProfession.SelectedValue,
                        OfficeId = (int)cbOffice.SelectedValue
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