using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;

namespace Frank.Libraries.Extensions
{
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
                        if (property.Name == column.ColumnName)
                            property.SetValue(item, row[column.ColumnName], null);
                    }
                }
                output.Add(item);
            }
            return output;
        }

        public static IEnumerable<TResult> Pivot<TResult, T, TColumn, TRow, TData>(this IEnumerable<T> source, Func<T, TColumn> columnSelector, Expression<Func<T, TRow>> rowSelector, Func<IEnumerable<T>, TData> dataSelector)
        {
            source = source.ToList();
            var table = new DataTable();
            var rowName = ((MemberExpression)rowSelector.Body).Member.Name;
            table.Columns.Add(new DataColumn(rowName));
            var columns = source.Select(columnSelector).Distinct().ToList();

            foreach (var column in columns.Where(column => column != null))
                if (column != null)
                    table.Columns.Add(new DataColumn(column.ToString()));

            var rows = source.GroupBy(rowSelector.Compile())
                .Select(rowGroup => new
                {
                    rowGroup.Key,
                    Values = columns.GroupJoin(
                        rowGroup,
                        c => c,
                        r => columnSelector(r)!,
                        (c, columnGroup) => dataSelector(columnGroup))
                }).ToList();

            foreach (var row in rows)
            {
                var dataRow = table.NewRow();
                var items = row.Values.Cast<object>().ToList();
                items.Insert(0, row.Key!);
                dataRow.ItemArray = items.ToArray();
                table.Rows.Add(dataRow);
            }

            return table.ToEnumerable<TResult>();
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
            var result = temp.DefaultView.ToTable(true, pkColumnNames).Copy();
            result.PrimaryKey = result.Columns.Cast<DataColumn>().ToArray();
            dt.AsEnumerable()
                .Select(r => r[pivotColumn.ColumnName].ToString())
                .Distinct().ToList()
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
                aggRow[row[pivotColumn.ColumnName].ToString()] = row[pivotValue.ColumnName];
            }

            return result;
        }
    }
}