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
            if (_isEditMode)
            {
                using var context = PersonalDbContextFactory.CreateDbContext();
                var entity = context.Employees.First(x => x.Id == id.Value);
                tbId.Text = entity.Id.ToString();
                tbName.Text = entity.Name;
                tbSerename.Text = entity.Serename;
                //tbProffesionId.Text = entity.ProfessionId;
               // tbOfficeId.Text = entity.OfficeId;
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
                        //ProfessionId = tbProfessionId.Text,
                        //OfficeId = tbOfficeId.Text,
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
                        //ProfessionId = tbProfessionId.Text,
                        //OfficeId = tbOfficeId.Text,
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