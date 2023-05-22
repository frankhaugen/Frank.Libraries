using System.Data;

namespace Frank.Libraries.Extensions;

public static class DataTableExtensions
{
    public static IEnumerable<T> ToEnumerable<T>(this DataTable dataTable)
    {
        var output = new List<T>();
        foreach (DataRow row in dataTable.Rows)
        {
            var item = Activator.CreateInstance<T>();

            foreach (DataColumn column in row.Table.Columns)
            {
                foreach (var property in typeof(T).GetProperties())
                {
                    if (property.Name == column.ColumnName && property.PropertyType == column.DataType)
                    {
                        property.SetValue(item, row[column.ColumnName], null);
                    }
                }
            }

            output.Add(item);
        }

        return output;
    }

    public static DataTable Pivot(this DataTable dt, DataColumn pivotColumn, DataColumn pivotValue)
    {
        // find primary key columns
        //(i.e. everything but pivot column and pivot value)
        var temp = dt.Copy();
        temp.Columns.Remove(pivotColumn.ColumnName);
        temp.Columns.Remove(pivotValue.ColumnName);
        var pkColumnNames = temp.Columns.Cast<DataColumn>()
                                .Select(c => c.ColumnName)
                                .ToArray();

        // prep results table
        var result = temp.DefaultView.ToTable(true, pkColumnNames)
                         .Copy();
        result.PrimaryKey = result.Columns.Cast<DataColumn>()
                                  .ToArray();
        dt.AsEnumerable()
          .Select(r => r[pivotColumn.ColumnName]
                      .ToString())
          .Distinct()
          .ToList()
          .ForEach(c => result.Columns.Add(c, pivotColumn.DataType));

        // load it
        foreach (DataRow row in dt.Rows)
        {
            // find row to update
            var aggRow = result.Rows.Find(
                pkColumnNames
                    .Select(c => row[c])
                    .ToArray());
            // the aggregate used here is LATEST
            // adjust the next line if you want (SUM, MAX, etc...)
            aggRow![row[pivotColumn.ColumnName]
                        .ToString()
                    ?? string.Empty] = row[pivotValue.ColumnName];
        }

        return result;
    }
}