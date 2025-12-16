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

                tbCardCode.Text = entity.CardCode;
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
            string input = tbCardCode.Text;

            // 2. Проверяем, не пустое ли поле
            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Поле Card Code не может быть пустым!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Останавливаем код, ничего не сохраняем
            }

            // 3. Проверяем, что введены только цифры
            foreach (char c in input)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("Ошибка: В поле Card Code должны быть только цифры!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Останавливаем код, если нашли не цифру
                }
            }

            // --- КОНЕЦ БЛОКА ПРОВЕРКИ ---
            // Если код дошел сюда, значит всё в порядке, выполняем сохранение:

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
                        OfficeId = (int)cbOffice.SelectedValue,
                        CardCode = tbCardCode.Text
                    });
                    context.SaveChanges();
                    DialogResult = DialogResult.OK;
                }
                catch (Exception)
                {
                    MessageBox.Show("Error while updating employee.");
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
                        OfficeId = (int)cbOffice.SelectedValue,
                        CardCode = tbCardCode.Text
                    });
                    context.SaveChanges();
                    DialogResult = DialogResult.OK;
                }
                catch (Exception)
                {
                    MessageBox.Show("Error while adding employee.");
                }
            }
        }

        private void tbCardCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}