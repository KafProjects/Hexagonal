using System;
using System.Collections.Generic;

namespace Hexagonal.Persistance
{
    public sealed class DataContext
    {
        private static readonly Lazy<DataContext> _lazy = new Lazy<DataContext>
        (() => new DataContext());

        public static DataContext Instance { get { return DataContext._lazy.Value; } }

        public DataContext()
        {
            Brands = new List<Brand>
            {
                new Brand(){Id =1, Name="Domogran 45"},
                new Brand(){Id =2, Name="Domolen"},
                new Brand(){Id =3, Name="Econamid"},
                new Brand(){Id =4, Name="Thermec"},
                new Brand(){Id =5, Name="Nyleen"},
                new Brand(){Id =6, Name="Filmon"},

            };
            Employees = new List<Employee>
            {
                 new Employee(){Id =1, Name="De Witte Jules"},
                 new Employee(){Id =2, Name="De Bruine Marc"},
                 new Employee(){Id =3, Name="De Gryse Eric"},
                 new Employee(){Id =4, Name="De Zwarte Evelyn"},
            };
        }
        public static List<Brand> Brands { get; set; }
        public static List<Employee> Employees { get; set; }

        public List<T> GetListInMemory<T>()
        {
            if (typeof(T) == typeof(Brand))
            {
                return Brands as List<T>;
            }
            if (typeof(T) == typeof(Employee))
            {
                return Employees as List<T>;
            }
            return null;
        }
    }
}
