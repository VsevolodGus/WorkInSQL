namespace KursachMasha.DAL;

public interface ISqlWorkerEntityManipulation<T>
    where T : class
{
    void Update(T sponsor);
    void Delete(int id);
    void Delete(int[] ids);
    void Add(T sponsor);
}

public interface ISqlWorkerEntity<T, TFilter> : ISqlWorkerEntityManipulation<T>
    where T : class
{
    T[] GetArray(TFilter filter);
}
