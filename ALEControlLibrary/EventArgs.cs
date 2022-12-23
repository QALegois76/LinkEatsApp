namespace ALEControlLibrary
{
    public class EventArgs<T> : EventArgs
    {
        protected readonly T _value;

        public T Value => _value;

        public EventArgs(T value)
        {
            _value = value;
        }
    }
}