using System;

namespace SingletonDemo
{
    /// <summary>
    /// 每个不同的T,都会生产一份不同的副本,适用不同的类型
    /// 适合不同类型，需要缓存一份数据的场景，效率高
    /// （效率高于静态字典的缓存）
    /// 不能清除缓存
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GenericCache<T>
    {
        private static string TypeTime = "";
        static GenericCache()
        {
            Console.WriteLine("This is generic cache construct.");
            TypeTime = string.Format("{0}_{1}",typeof(T).FullName, DateTime.Now.ToString("yyyyMMddHHmmssss"));
        }

        public static string GetCache()
        {
            return TypeTime;
        }
    }
    
    /*
    public class EFPreHeating
    {
        using (var dbcontext = new CnblogsDbContext())
        {
            var objectContext = ((IObjectContextAdapter)dbcontext).ObjectContext;
            var mappingCollection = (StorageMappingItemCollection)objectContext.MetadataWorkspace.GetItemCollection(DataSpace.CSSpace);
            mappingCollection.GenerateViews(new List<EdmSchemaError>());
        }
    }
    */
}
