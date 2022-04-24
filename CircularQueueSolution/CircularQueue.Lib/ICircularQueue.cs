namespace CircularQueue.Lib
{
    /// <summary>
    /// A CircularQueue is a fixed-size FIFO data structure. 
    /// </summary>
    /// <remarks>
    /// The CircularQueue must know its size up front. Must support
    /// standard FIFO operations and must wrap-around to utilize the space
    /// of the underlying structure.
    /// </remarks>
    public interface ICircularQueue<T>
    {
        /// <summary>
        /// Enqueue inserts an item into the front of the queue.
        /// </summary>
        /// <remarks>
        /// Pre-conditions:
        /// <list type="number">
        /// <item>
        /// <description> Queue has a size with front and back</description>
        /// </item>
        /// <item>
        /// <description> Verified that the queue has capacity</description>
        /// </item>
        /// </list>
        /// Post-conditions:
        /// <list type="number">
        /// <item>
        /// <description> Count is incremented by one </description>
        /// </item>
        /// <item>
        /// <description> Front and back are affected if data is present </description>
        /// </item>
        /// <item>
        /// <description> IsEmpty property will return false </description> 
        /// </item>
        /// </list>
        /// Invariants:
        /// <list type="number">
        /// <item>
        /// <description> Queue is full - should throw an exception </description>
        /// </item>
        /// <item>
        /// <description> Item given is not the same type as T </description>
        /// </item>
        /// <item>
        /// <description> Queue doesn't exist </description>
        /// </item>
        /// <item>
        /// <description> Enqueuing requires wrap-around to the front of the structure
        /// as needed </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="item">The item to enqueue</param>
        void Enqueue(T item);

        /// <summary>
        /// Dequeue removes an item from the front of the queue.
        /// </summary>
        /// <remarks>
        /// Pre-conditions:
        /// <list type="number">
        /// <item>
        /// <description> The list is not empty </description>
        /// </item>
        /// <item>
        /// <description> The container size of the list is greater than 0 </description>
        /// </item>
        /// </list>
        /// Post-conditions:
        /// <list type="number">
        /// <item>
        /// <description> Count is decremented by one </description>
        /// </item>
        /// <item>
        /// <description> An item is returned </description>
        /// </item>
        /// <item>
        /// <description> Front is updated to new value for front </description>
        /// </item>
        /// </list>
        /// Invariants:
        /// <list type="number">
        /// <item>
        /// <description> Throw an exception if the list is empty </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <returns>The item at the front</returns>
        T Dequeue();

        /// <summary>
        /// Returns an item from the front of the queue.
        /// </summary>
        /// <remarks>
        /// Pre-conditions:
        /// <list type="number">
        /// <item>
        /// <description> The list is not empty </description>
        /// </item>
        /// <item>
        /// <description> The container size of the list is greater than 0 </description>
        /// </item>
        /// </list>
        /// Post-conditions:
        /// <list type="number">
        /// <item>
        /// <description> An item is returned </description>
        /// </item>
        /// </list>
        /// Invariants:
        /// <list type="number">
        /// <item>
        /// <description> Throw an exception if the list is empty </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <returns>The item at the front</returns>
        T Front { get; }

        /// <summary>
        /// Returns an item from the back of the queue.
        /// </summary>
        /// <remarks>
        /// Pre-conditions:
        /// <list type="number">
        /// <item>
        /// <description> The list is not empty </description>
        /// </item>
        /// <item>
        /// <description> The container size of the list is greater than 0 </description>
        /// </item>
        /// </list>
        /// Post-conditions:
        /// <list type="number">
        /// <item>
        /// <description> An item is returned </description>
        /// </item>
        /// </list>
        /// Invariants:
        /// <list type="number">
        /// <item>
        /// <description> Throw an exception if the list is empty </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <returns>The item at the back</returns>
        T Back { get; }

        /// <summary>
        /// Resize the max size of the queue.
        /// </summary>
        /// <remarks>
        /// Pre-conditions:
        /// <list type="number">
        /// <item>
        /// <description> The queue is full </description>
        /// </item>
        /// </list>
        /// Post-conditions:
        /// <list type="number">
        /// <item>
        /// <description> newSize is the new maxSize </description>
        /// </item>
        /// <item>
        /// <description> Data retains its order </description>
        /// </item>
        /// </list>
        /// Invariants:
        /// <list type="number">
        /// <item>
        /// <description> If the new size is smaller than the weight of the queue
        ///    data truncation will occur </description>
        /// </item>
        /// <item>
        /// <description> If newSize == current size, the operation doesn't make sense </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="newSize">The new desired size of the queue</param>
        void Resize(int newSize);

        /// <summary>
        /// Returns whether the queue is empty
        /// </summary>
        /// <remarks>
        /// Pre-conditions:
        /// <list type="number">
        /// <item>
        /// <description> A queue exists </description>
        /// </item>
        /// </list>
        /// Post-conditions:
        /// <list type="number">
        /// <item>
        /// <description> The value is true if it's empty, false otherwise </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <returns>Whether queue is empty</returns>
        bool IsEmpty { get; }

        /// <summary>
        /// Returns whether the queue has capacity
        /// </summary>
        /// <remarks>
        /// Pre-conditions:
        /// <list type="number">
        /// <item>
        /// <description> A queue exists </description>
        /// </item>
        /// </list>
        /// Post-conditions:
        /// <list type="number">
        /// <item>
        /// <description> The value is true if it is at capacity, false otherwise </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <returns>Whether the queue is full</returns>
        bool IsFull { get; }

        /// <summary>
        /// Returns the current size of the queue (the number of items in the queue)
        /// </summary>
        /// <remarks>
        /// Pre-conditions:
        /// <list type="number">
        /// <item>
        /// <description> Front and Back are tracked </description>
        /// </item>
        /// <item>
        /// <description> Tracking the number of elements </description>
        /// </item>
        /// </list>
        /// Post-conditions:
        /// <list type="number">
        /// <item>
        /// <description> A valid integer integer is returns </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <returns>The size of the queue</returns>
        int Count { get; }
    }
}