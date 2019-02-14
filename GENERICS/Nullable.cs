namespace GENERICS
{
    public class Nullable<T> where T : struct
    {
        private object _Valeur;
        public bool HasValue
        {
            get
            {
                return _Valeur != null;
            }
        }
        public Nullable()
        {

        }
        public Nullable(T valeur)
        {
            _Valeur = valeur;
        }

        public T GetValueOrdeDefault()
        {
            if (HasValue)
                return (T)_Valeur;

            return default(T);
        }
        

    }
}

