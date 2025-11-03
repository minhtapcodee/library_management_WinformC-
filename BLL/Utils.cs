using System.Data;
using System.Reflection;

namespace QUANLYTHUVIENC3.BLL
{
    public class Utils
    {
        public static List<T> DatatableToObjects<T>(DataTable dataTable) where T : new()
        {

            List<T> items = new List<T>();
            foreach (DataRow row in dataTable.Rows)
            {
                T item = new T();
                foreach (DataColumn col in dataTable.Columns)
                {
                    PropertyInfo prop = typeof(T).GetProperty(col.ColumnName);
                    if (prop != null && row[col] != DBNull.Value)
                    {
                        object obj = Convert.ChangeType(row[col], prop.PropertyType);
                        prop.SetValue(item, obj, null);
                    }
                }
                items.Add(item);
            }
            return items;
        }
    }
}
