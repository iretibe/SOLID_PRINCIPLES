namespace Liskov_Substitution_Principle
{
    //Consider the following IMyCollection interface which can be implemented to create any type of collection class.
    public interface IMyCollection
    {
        void Add(int item);
        void Remove(int item);
        int Get(int item);
    }

    public class MyReadOnlyCollection : IMyCollection
    {
        private IList<int> _collection;

        public MyReadOnlyCollection(IList<int> collection)
        {
            _collection = collection;
        }

        public void Add(int item)
        {
            throw new NotImplementedException();
        }

        public int Get(int item)
        {
            return _collection.IndexOf(item);
        }

        public void Remove(int item)
        {
            throw new NotImplementedException();
        }
    }
}

/*
The above example violates the Liskov Substitution principle because the MyReadOnlyCollection class implements the IMyCollection interface 
but it throws NotImplementedException for two methods Add() and Remove() because the MyReadOnlyCollection class is for the read-only collection 
so you cannot add or remove any item. LSP suggests that the subtype must be substitutable for the base class or base interface. 
In the above example, we should create another interface for read-only collection without Add() and Remove() methods. 
*/
