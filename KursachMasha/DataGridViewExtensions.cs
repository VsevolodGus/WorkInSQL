﻿using KursachMasha.DAL;
using System.Reflection;

namespace KursachMasha;
internal static class DataGridViewExtensions
{
    public static void ConfigColumns<T>(this DataGridView table)
    {
        table.AutoGenerateColumns = false;
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
    }
}
