using System;

namespace Proyecto_5_Herencias
{
    public class User
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public User(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public override bool Equals(object obj)
        {
            if ( obj == null)       //Verificamos 1º que el objeto no sea Nulo
            {
                return false;
            }

            User p = obj as User;   //Verificamos que el objeto es de tipo "USER"

            if (p == null)          //Verificamos que el objeto "USER" no es Nulo
            {
                return false;
            }

            return (Nombre == p.Nombre) && (Edad == p.Edad);
        }

        public override int GetHashCode()
        {
            int hash = 15;
            hash = (hash * 7) + Nombre.GetHashCode();
            hash = (hash * 7) + Edad.GetHashCode();

            return hash;
        }
    }
}
