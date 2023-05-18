namespace KursachMasha.DAL;
public interface ISqlWorkerEntity<T, TFilter>
    where T : class
{
    void Update(T sponsor);
    void Delete(int id);
    void Add(T sponsor);
    T[] GetArray(TFilter filter);
}
