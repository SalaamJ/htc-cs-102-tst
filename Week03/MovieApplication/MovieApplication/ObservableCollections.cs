using System;
using System.Collections.Generic;

namespace MovieApplication
{
    internal class ObservableCollections<T>
    {
        public static implicit operator ObservableCollections<T>(List<Movie> v)
        {
            throw new NotImplementedException();
        }
    }
}