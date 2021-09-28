using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Frank.Libraries.Extensions
{
    public static class EnumerableExtensions
    {
        //public static void InnerJoin<T>(this IEnumerable<T> innerSource, IEnumerable<T> outerSource, Func<T, T> innerSelector, Func<T, T> outerSelector, Func<>)
        //{
        //    // Query to find the name and the department of the employees Using Join Method
        //    var res = innerSource.Join(outerSource,
        //        outerSelector,
        //        innerSelector,
        //        (e1, e2) => );
        //}

        public static IEnumerable<IEnumerable<T>> Batch<T>(this IEnumerable<T> items, int maxItems = 256)
        {
            return items.Select((item, inx) => new { item, inx })
                .GroupBy(x => x.inx / maxItems)
                .Select(g => g.Select(x => x.item));
        }

        public static Stack<T> ToStack<T>(this IEnumerable<T> enumerable)
        {
            return new Stack<T>(enumerable);
        }

        public static Queue<T> ToQueue<T>(this IEnumerable<T> enumerable)
        {
            return new Queue<T>(enumerable);
        }

        public static IEnumerable<TResult> RightJoin<TSource, TInner, TKey, TResult>(
                this IEnumerable<TSource> source,
                IEnumerable<TInner> inner,
                Func<TSource, TKey> pk,
                Func<TInner, TKey> fk,
                Func<TSource, TInner, TResult> result) where TSource : class where TInner : class
        {
            IEnumerable<TResult> _result = Enumerable.Empty<TResult>();

            _result = from i in inner
                      join s in source
                          on fk(i) equals pk(s) into joinData
                      from right in joinData.DefaultIfEmpty()
                      select result(right, i);

            return _result;
        }

        public static IEnumerable<TResult>
            FulltExcludingJoin<TSource, TInner, TKey, TResult>(this IEnumerable<TSource> source,
                IEnumerable<TInner> inner,
                Func<TSource, TKey> pk,
                Func<TInner, TKey> fk,
                Func<TSource, TInner, TResult> result)
            where TSource : class where TInner : class
        {
            var left = source.LeftExcludingJoin(inner, pk, fk, result).ToList();
            var right = source.RightExcludingJoin(inner, pk, fk, result).ToList();

            return left.Union(right);
        }

        public static IEnumerable<TResult>
            RightExcludingJoin<TSource, TInner, TKey, TResult>(this IEnumerable<TSource> source,
                IEnumerable<TInner> inner,
                Func<TSource, TKey> pk,
                Func<TInner, TKey> fk,
                Func<TSource, TInner, TResult> result)
            where TSource : class where TInner : class
        {
            IEnumerable<TResult> _result = Enumerable.Empty<TResult>();

            _result = from i in inner
                      join s in source
                          on fk(i) equals pk(s) into joinData
                      from right in joinData.DefaultIfEmpty()
                      where right == null
                      select result(right, i);

            return _result;
        }

        public static IEnumerable<TResult>
            LeftExcludingJoin<TSource, TInner, TKey, TResult>(this IEnumerable<TSource> source,
                IEnumerable<TInner> inner,
                Func<TSource, TKey> pk,
                Func<TInner, TKey> fk,
                Func<TSource, TInner, TResult> result)
            where TSource : class where TInner : class
        {
            IEnumerable<TResult> _result = Enumerable.Empty<TResult>();

            _result = from s in source
                      join i in inner
                          on pk(s) equals fk(i) into joinData
                      from left in joinData.DefaultIfEmpty()
                      where left == null
                      select result(s, left);

            return _result;
        }

        public static IEnumerable<TResult>
            FullOuterJoin<TSource, TInner, TKey, TResult>(this IEnumerable<TSource> source,
                IEnumerable<TInner> inner,
                Func<TSource, TKey> pk,
                Func<TInner, TKey> fk,
                Func<TSource, TInner, TResult> result)
            where TSource : class where TInner : class
        {
            var left = source.LeftJoin(inner, pk, fk, result).ToList();
            var right = source.RightJoin(inner, pk, fk, result).ToList();

            return left.Union(right);
        }

        public static IEnumerable<TResult> LeftJoin<TOuter, TInner, TKey, TResult>(
            this IEnumerable<TOuter> outer,
            IEnumerable<TInner> inner,
            Func<TOuter, TKey> outerKeySelector,
            Func<TInner, TKey> innerKeySelector,
            Func<TOuter, TInner, TResult> resultSelector)
        {
            return outer
                .GroupJoin(inner, outerKeySelector, innerKeySelector, (outerObj, inners) =>
                    new
                    {
                        outerObj,
                        inners = inners.DefaultIfEmpty()
                    })
                .SelectMany(a => a.inners.Select(innerObj => resultSelector(a.outerObj, innerObj)));
        }

        public static IEnumerable<TResult> LeftOuterJoin<TLeft, TRight, TKey, TResult>(this IEnumerable<TLeft> left, IEnumerable<TRight> right, Func<TLeft, TKey> leftKey, Func<TRight, TKey> rightKey,
            Func<TLeft, TRight, TResult> result)
        {
            return left.GroupJoin(right, leftKey, rightKey, (l, r) => new { l, r })
                .SelectMany(
                    o => o.r.DefaultIfEmpty(),
                    (l, r) => new { lft = l.l, rght = r })
                .Select(o => result.Invoke(o.lft, o.rght));
        }

        public static T Random<T>(this IEnumerable<T> items)
        {
            items = items.ToList();
            var random = new Random();
            var count = items.Count();

            var index = random.Next(0, count);

            return items.ElementAt(index);
        }

        public static DataTable ToDataTable<T>(this IEnumerable<T> items)
        {
            var tb = new DataTable(typeof(T).Name);

            var props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (var prop in props)
            {
                tb.Columns.Add(prop.Name, prop.PropertyType);
            }

            foreach (var item in items)
            {
                var values = new object[props.Length];
                for (var i = 0; i < props.Length; i++)
                {
                    values[i] = props[i].GetValue(item, null)!;
                }

                tb.Rows.Add(values);
            }

            return tb;
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
    }
}