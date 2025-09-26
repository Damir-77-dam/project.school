using Personal.App.Database.Context;
using Personal.App.Database.Entities;

namespace Personal.App
{
    public partial class ProfessionList : Form
    {
        public ProfessionList()
        {
            InitializeComponent();
            dgvList.AutoGenerateColumns = false;
        }

        private void ProfessionList_Load(object sender, EventArgs e)
        {
            using var context = PersonalDbContextFactory.CreateDbContext();
            var list = context.Ppofeshionals.ToList();
            dgvList.DataSource = list;
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvList.SelectedRows.Count != 1)
                {
                    MessageBox.Show("ЛОШАРА. Выдели рядок!");
                    return;
                }
                if (MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //delete
                    using var context = PersonalDbContextFactory.CreateDbContext();
                    var id = (int)dgvList.SelectedRows[0].Cells["cId"].Value;
                    context.Ppofeshionals.Remove(new Profession() { Id = id });
                    context.SaveChanges();
                    //refresh data
                    var list = context.Ppofeshionals.ToList();
                    dgvList.DataSource = list;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            if (EditProfession.CreateForAdd().ShowDialog() == DialogResult.OK)
            {
                //refresh data
                using var context = PersonalDbContextFactory.CreateDbContext();
                var list = context.Ppofeshionals.ToList();
                dgvList.DataSource = list;
            }
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            if (dgvList.SelectedRows.Count != 1)
            {
                MessageBox.Show("ЛОШАРА. Выдели рядок!");
                return;
            }
            var id = (int)dgvList.SelectedRows[0].Cells["cId"].Value;
            if (EditProfession.CreateForEdit(id).ShowDialog() == DialogResult.OK)
            {
                //refresh data
                using var context = PersonalDbContextFactory.CreateDbContext();
                var list = context.Ppofeshionals.ToList();
                dgvList.DataSource = list;
            }
        }

        private void bRefresh_Click(object sender, EventArgs e)
        {
            using var context = PersonalDbContextFactory.CreateDbContext();
            var list = context.Ppofeshionals.ToList();
            dgvList.DataSource = list;
        }
    }
}
