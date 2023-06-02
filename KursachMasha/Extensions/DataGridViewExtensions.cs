using KursachMasha.DAL;
using System.Reflection;

namespace KursachMasha.Extensions;
internal static class DataGridViewExtensions
{
    public static void Configuration<T>(this DataGridView table)
    {
        table.AutoGenerateColumns = false;
        table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        var properties = typeof(T).GetProperties();
        foreach (var column in properties)
        {
            var attributes = column.GetCustomAttribute<ColumnHeadrAttribute>();
            if (attributes is not null || !column.PropertyType.IsClass)
            {
                string columnsName = column.Name;
                if (attributes is not null)
                    columnsName = attributes.Name;

                table.Columns.Add(column.Name, columnsName);

                if (column.Name.ToLower().Contains("id"))
                    table.Columns[column.Name].Visible = false;
            }
        }
        table.ReadOnly = true;
    }

    public static void DeleteObject<T>(this DataGridView dataGridView, ISqlWorkerEntityManipulation<T> repository)
        where T : class
    {
        var countDeleteObjects = dataGridView.SelectedRows.Count;
        var objectsID = new List<int>(countDeleteObjects);
        for (int i = 0; i < countDeleteObjects; i++)
        {
            var id = (int)dataGridView.SelectedRows[i].Cells[0].Value;
            objectsID.Add(id);
        }

        if (objectsID.Count != 0)
            repository.Delete(objectsID.ToArray());
    }
}
