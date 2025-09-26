using Personal.App.Database.Context;
using Personal.App.Database.Entities;

namespace Personal.App
{
    public partial class EditProfession : Form
    {
        private bool _isEditMode;
        private readonly int? _id;

        public EditProfession()
        {
            InitializeComponent();
        }

        private EditProfession(int? id = null)
        {
            InitializeComponent();
            _id = id;
            _isEditMode = id != null;
            if (_isEditMode)
            {
                using var context = PersonalDbContextFactory.CreateDbContext();
                var entity = context.Ppofeshionals.First(x => x.Id == id.Value);
                tbId.Text = entity.Id.ToString();
                tbPosition.Text = entity.Position;
                tbPositionCategory.Text = entity.PositionCategory;
                tbPositionDescription.Text = entity.PositionDescription;
            }
        }

        public static EditProfession CreateForAdd()
        {
            return new EditProfession(null);
        }

        public static EditProfession CreateForEdit(int id)
        {
            return new EditProfession(id);
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            //TODO: Check errors
            if (_isEditMode)
            {
                try
                {
                    using var context = PersonalDbContextFactory.CreateDbContext();
                    context.Ppofeshionals.Update(new Profession()
                    {
                        Id = _id.Value,
                        Position = tbPosition.Text,
                        PositionCategory = tbPositionCategory.Text,
                        PositionDescription = tbPositionDescription.Text
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
                    context.Ppofeshionals.Add(new Profession()
                    {
                        Position = tbPosition.Text,
                        PositionCategory = tbPositionCategory.Text,
                        PositionDescription = tbPositionDescription.Text
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
