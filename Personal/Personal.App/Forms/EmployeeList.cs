using Microsoft.EntityFrameworkCore;
using Personal.App.Database.Context;
using Personal.App.Database.Entities;

namespace Personal.App;

public partial class EmployeeList : Form
{
    public EmployeeList()
    {
        InitializeComponent();
        dgvList.AutoGenerateColumns = false;
    }

    private void EmployeeList_Load(object sender, EventArgs e)
    {
        using var context = PersonalDbContextFactory.CreateDbContext();
        var list = context.Employees
            .Include(x => x.Office)
            .Include(x => x.Profession)
            .Select(x => new
            {
                Id = x.Id,
                Name = x.Name,
                Serename = x.Serename,
                ProfessionId = x.ProfessionId,
                Position = x.Profession.Position,
                OfficeId = x.OfficeId,
                Office = x.Office.FullInfo,
                CardCode = x.CardCode
            })
            .ToList();
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
                context.Employees.Remove(new Employee() { Id = id });
                context.SaveChanges();
                //refresh data
                var list = context.Employees
                    .Include(x => x.Office)
                    .Include(x => x.Profession)
                    .Select(x => new
                    {
                        Id = x.Id,
                        Name = x.Name,
                        Serename = x.Serename,
                        ProfessionId = x.ProfessionId,
                        Position = x.Profession.Position,
                        OfficeId = x.OfficeId,
                        Office = x.Office.FullInfo,
                        CardCode = x.CardCode
                    })
                    .ToList();
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
        if (EditEmployee.CreateForAdd().ShowDialog() == DialogResult.OK)
        {
            //refresh data
            using var context = PersonalDbContextFactory.CreateDbContext();
            var list = context.Employees
                .Include(x => x.Office)
                .Include(x => x.Profession)
                .Select(x => new
                {
                    Id = x.Id,
                    Name = x.Name,
                    Serename = x.Serename,
                    ProfessionId = x.ProfessionId,
                    Position = x.Profession.Position,
                    OfficeId = x.OfficeId,
                    Office = x.Office.FullInfo,
                    CardCode = x.CardCode
                })
                .ToList();
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
        if (EditEmployee.CreateForEdit(id).ShowDialog() == DialogResult.OK)
        {
            //refresh data
            using var context = PersonalDbContextFactory.CreateDbContext();
            var list = context.Employees
                .Include(x => x.Office)
                .Include(x => x.Profession)
                .Select(x => new
                {
                    Id = x.Id,
                    Name = x.Name,
                    Serename = x.Serename,
                    ProfessionId = x.ProfessionId,
                    Position = x.Profession.Position,
                    OfficeId = x.OfficeId,
                    Office = x.Office.FullInfo,
                    CardCode = x.CardCode
                })
                .ToList();
            dgvList.DataSource = list;
        }
    }

    private void bRefresh_Click(object sender, EventArgs e)
    {
        using var context = PersonalDbContextFactory.CreateDbContext();
        var list = context.Employees
            .Include(x => x.Office)
            .Include(x => x.Profession)
            .Select(x => new
            {
                Id = x.Id,
                Name = x.Name,
                Serename = x.Serename,
                ProfessionId = x.ProfessionId,
                Position = x.Profession.Position,
                OfficeId = x.OfficeId,
                Office = x.Office.FullInfo,
                CardCode = x.CardCode
            })
            .ToList();
        dgvList.DataSource = list;
    }
}