namespace FirstAPI.INterface
{
    public interface IRepo<K,T>
    {
        T Get(K key);
        ICollection<T> GetAll();
        T Add(T item);//item object refferal , key - data type
        T Delete(K key);
        T update(T item);
    }
}
