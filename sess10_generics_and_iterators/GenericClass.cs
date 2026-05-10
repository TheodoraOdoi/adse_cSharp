using System.Collections;

namespace sess10_generics_and_iterators
{
    /// <summary>
    /// Represents a generic collection of items with a specified capacity.
    /// </summary>
    /// <typeparam name="T">The type of the elements in the collection</typeparam>
    public class GenericClass<T> : IEnumerable<T>
    {
        private readonly List<T> _items;

        /// <summary>
        /// Gets the number of items in the collection
        /// </summary>
        public int Count => _items.Count;

        /// <summary>
        /// Initialises a new instance of <see cref="GenericClass{T}"/> class with an optional capacity
        /// </summary>
        /// <param name="capacity">The initial capacity of the collection. Defaults to 10 if not specified.</param>
        /// <exception cref="ArgumentException">Thrown when the capacity is less than 1.</exception>
        public GenericClass(int capacity = 10)
        {
            if capacity < 1)
                throw new ArgumentException("Capacity must be at least 1", nameof(capacity));
            _items = new List<T>(capacity);
        }

        /// <summary>
        /// Adds an item to the collection
        /// </summary>
        /// <param name="inputValue">The item to be added to the collection</param>
        public void AddItem(T inputValue)
        {
            _items.Add(inputValue);
        }

        /// <summary>
        /// Determines whether the collection contains a specific item.
        /// </summary>
        /// <param name="item">The item to locate in the collection</param>
        /// <returns>when the item is found; else <c>false</c>.</returns>
        public bool ContainsItem(T item)
        {
            return _items.Contains(item);
        }

        /// <summary>
        /// Removes the item at the specified index
        /// </summary>
        /// <param name="index">The zero-based index of the item to remove from the collection.</param>
        /// <returns><c>when the item is successfully removed; else</c></returns>
        public bool RemoveItemAt(int index)
        {
            if (index < 0 || index >= _items.Count)
                return false; // index is out of range, removal failed
            _items.RemoveAt(index);
            return true;
        }

        /// <summary>
        /// Removes all items from the collection
        /// </summary>
        public void Clear()
        {
            _items.Clear();
        }

        /// <summary>
        /// Retrieves(gets) or assigns(sets) the item at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index of the item to get or set</param>
        /// <returns> The item at the specified index</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the index is out of range</exception>
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= _items.Count)
                    throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
                return _items[index];
            }
            set
            {
                if (index < 0 || index >= _items.Count)
                    throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
                _items[index] = value;
            }
        }

        /// <summary>
        /// Returns a string representation of the collection, including the type of <typeparam name="T"/> and the 
        /// items in the collection.
        /// </summary>
        /// <returns>A formatted string containing the collection details</returns>
        public override string  ToString()
        {
            return $"The <T> parameter is a type of {typeof(T).Name}" +
                   $"\nThe collection contains {_items.Count} items:" +
                   $"\n" + string.Join("\n", _items);
        }

        /// <summary>
        /// Returns an enumerator that iterates through the collection.
        /// </summary>
        /// <returns>An enumerator for the collection.</returns>
        public IEnumerator<T> GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
    }
}
