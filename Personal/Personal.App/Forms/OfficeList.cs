using Personal.App.Database.Context;
using Personal.App.Database.Entities;

namespace Personal.App;

public partial class OfficeList : Form
{
    public OfficeList()
    {
        InitializeComponent();
        dgvList.AutoGenerateColumns = false;
    }

    private void OfficeList_Load(object sender, EventArgs e)
    {
        using var context = PersonalDbContextFactory.CreateDbContext();
        var list = context.Offices.ToList();
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
                context.Offices.Remove(new Office() { Id = id });
                context.SaveChanges();
                //refresh data
                var list = context.Offices.ToList();
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
        if (EditOffice.CreateForAdd().ShowDialog() == DialogResult.OK)
        {
            //refresh data
            using var context = PersonalDbContextFactory.CreateDbContext();
            var list = context.Offices.ToList();
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
        if (EditOffice.CreateForEdit(id).ShowDialog() == DialogResult.OK)
        {
            //refresh data
            using var context = PersonalDbContextFactory.CreateDbContext();
            var list = context.Offices.ToList();
            dgvList.DataSource = list;
        }
    }

    private void bRefresh_Click(object sender, EventArgs e)
    {
        using var context = PersonalDbContextFactory.CreateDbContext();
        var list = context.Offices.ToList();
        dgvList.DataSource = list;
    }
}



