
namespace DalApi;
using DO;
public interface Icrud<T>
{
    int Create(T item); 
    T? Read(int id); 
    List<T?> ReadAll(Func<T, bool>? filter = null);
    void Update(T item);
    void Delete(int id);
    T? Read(Func<T, bool> filter);
}