public interface IJar<T>
{
    void Add(T item);
    T Remove();
    int Count{ get;}
}