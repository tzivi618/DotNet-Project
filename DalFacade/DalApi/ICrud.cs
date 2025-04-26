
namespace DalApi;
using DO;
public interface Icrud<T>
{
    int Create(T item); //Creates new entity object in DAL
    T? Read(int id); //Reads entity object by its ID 
    List<T?> ReadAll(Func<T, bool>? filter = null); //stage 1 only, Reads all entity objects
    void Update(T item); //Updates entity object
    void Delete(int id); //Deletes an object by its Id
    T? Read(Func<T, bool> filter);
}