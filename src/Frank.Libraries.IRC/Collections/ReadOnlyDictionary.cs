using System.Collections;
using System.Diagnostics;
using System.Runtime.Serialization;
#if !NETSTANDARD1_5

#endif

namespace Frank.Libraries.IRC.Collections
{
    /// <summary>
    ///     Represents a read-only collection of keys and values.
    /// </summary>
    /// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
    /// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
#if !SILVERLIGHT && !NETSTANDARD1_5
    [Serializable]
#endif
    [DebuggerDisplay("Count = {Count}")]
    public class ReadOnlyDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>,
        IEnumerable<KeyValuePair<TKey, TValue>>, IDictionary, ICollection, IEnumerable
#if !SILVERLIGHT && !NETSTANDARD1_5
        , ISerializable, IDeserializationCallback
#endif
    {
        // Dictionary to expose as read-only.
        private IDictionary<TKey, TValue> dictionary;

        /// <summary>
        ///     Initializes a new instance of the <see cref="ReadOnlyDictionary{TKey, TValue}" /> class.
        /// </summary>
        /// <param name="dictionary">The dictionary to wrap.</param>
        /// <exception cref="ArgumentNullException"><paramref name="dictionary" /> is <see langword="null" />.</exception>
        public ReadOnlyDictionary(IDictionary<TKey, TValue> dictionary)
        {
            if (dictionary == null)
            {
                throw new ArgumentNullException("dictionary");
            }

            this.dictionary = dictionary;
        }

        ICollection IDictionary.Keys => ((IDictionary)dictionary).Keys;

        ICollection IDictionary.Values => ((IDictionary)dictionary).Values;

        bool IDictionary.IsFixedSize => ((IDictionary)dictionary).IsFixedSize;

        bool IDictionary.IsReadOnly => true;

        object IDictionary.this[object key]
        {
            get => ((IDictionary)dictionary)[key];
            set => throw new NotSupportedException();
        }

        void IDictionary.Add(object key, object value) => throw new NotSupportedException();

        void IDictionary.Remove(object key) => throw new NotSupportedException();

        void IDictionary.Clear() => throw new NotSupportedException();

        bool IDictionary.Contains(object key) => ((IDictionary)dictionary).Contains(key);

        IDictionaryEnumerator IDictionary.GetEnumerator() => ((IDictionary)dictionary).GetEnumerator();

        void ICollection.CopyTo(Array array, int index) => ((ICollection)dictionary).CopyTo(array, index);

        int ICollection.Count => ((ICollection)dictionary).Count;

        bool ICollection.IsSynchronized => ((ICollection)dictionary).IsSynchronized;

        object ICollection.SyncRoot => ((ICollection)dictionary).SyncRoot;

        /// <summary>
        ///     Gets a collection containing the keys in the dictionary.
        /// </summary>
        /// <value>A collection containing the keys in the dictionary.</value>
        public ICollection<TKey> Keys => dictionary.Keys;

        /// <summary>
        ///     Gets a collection containing the values in the dictionary.
        /// </summary>
        /// <value>A collection containing the values in the dictionary.</value>
        public ICollection<TValue> Values => dictionary.Values;

        /// <summary>
        ///     Gets or sets the element with the specified key.
        /// </summary>
        /// <value>The element with the specified key.</value>
        /// <exception cref="NotSupportedException">
        ///     This operation is not supported on a read-only dictionary.
        /// </exception>
        public TValue this[TKey key]
        {
            get => dictionary[key];
            set => throw new NotSupportedException();
        }

        /// <summary>
        ///     Determines whether the dictionary contains the specified key.
        /// </summary>
        /// <param name="key">The key to locate in the dictionary.</param>
        /// <returns>
        ///     <see langword="true" /> if the dictionary contains an element with the specified key;
        ///     <see langword="false" />, otherwise.
        /// </returns>
        /// <exception cref="ArgumentNullException"><paramref name="key" /> is <see langword="null" />.</exception>
        public bool ContainsKey(TKey key)
        {
            if (key == null)
            {
                throw new ArgumentNullException("key");
            }

            return dictionary.ContainsKey(key);
        }

        /// <summary>
        ///     Gets the value associated with the specified key.
        /// </summary>
        /// <param name="key">The key of the value to get.</param>
        /// <param name="value">
        ///     When this method returns, contains the value associated with the specified key, if the
        ///     key is found; otherwise, the default value for the type of the value parameter. This parameter is passed
        ///     uninitialized.
        /// </param>
        /// <returns>
        ///     <see langword="true" /> if the dictionary contains an element with the specified key;
        ///     <see langword="false" />, otherwise.
        /// </returns>
        /// <exception cref="ArgumentNullException"><paramref name="key" /> is <see langword="null" />.</exception>
        public bool TryGetValue(TKey key, out TValue value)
        {
            if (key == null)
            {
                throw new ArgumentNullException("key");
            }

            return dictionary.TryGetValue(key, out value);
        }

        void IDictionary<TKey, TValue>.Add(TKey key, TValue value) => throw new NotSupportedException();

        bool IDictionary<TKey, TValue>.Remove(TKey key) => throw new NotSupportedException();

        /// <summary>
        ///     Gets the number of key/value pairs contained in the dictionary.
        /// </summary>
        /// <value>The number of key/value pairs contained in the dictionary.</value>
        public int Count => dictionary.Count;

        bool ICollection<KeyValuePair<TKey, TValue>>.IsReadOnly => true;

        void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> item) => throw new NotSupportedException();

        bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> item) => throw new NotSupportedException();

        void ICollection<KeyValuePair<TKey, TValue>>.Clear() => throw new NotSupportedException();

        bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> item) => dictionary.Contains(item);

        void ICollection<KeyValuePair<TKey, TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex) => dictionary.CopyTo(array, arrayIndex);

        /// <summary>
        ///     Returns an enumerator that iterates through the dictionary.
        /// </summary>
        /// <returns>An enumerator for the dictionary.</returns>
        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() => dictionary.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)dictionary).GetEnumerator();

#if !SILVERLIGHT && !NETSTANDARD1_5

        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) => ((ISerializable)dictionary).GetObjectData(info, context);

        void IDeserializationCallback.OnDeserialization(object sender) => ((IDeserializationCallback)dictionary).OnDeserialization(sender);

#endif
    }
}