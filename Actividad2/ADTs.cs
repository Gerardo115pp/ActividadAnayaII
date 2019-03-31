using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad2
{
    class Nodo_simple<T>
    {
        Nodo_simple<T> next;
        double prioridad;
        T data;

        public Nodo_simple(T data, Nodo_simple<T> next = null, double prioridad = 0)
        {
            this.next = next;
            this.prioridad = prioridad;
            this.data = data;
        }

        public override string ToString()
        {
            return data.ToString();
        }

        public Nodo_simple<T> Next
        {
            get { return this.next; }
            set { this.next = value; }
        }

        public double Prioridad
        {
            get { return this.prioridad; }
        }

        public T Data
        {
            get { return this.data; }
            set { this.data = value; }
        }

        public Nodo_simple<T> Clone()
        {
            if (this.next != null)
            {
                return new Nodo_simple<T>(this.data, this.next.Clone(), this.prioridad);
            }
            return new Nodo_simple<T>(this.data,prioridad:this.prioridad);
        }

    }

    class Pqueue<T>
    {
        Nodo_simple<T> root;
        int len;

        public Pqueue()
        {
            this.len = 0;
            this.root = null;
        }

        public override string ToString()
        {
            if(len == 0)
            {
                return "Vacio";
            }
            string self_str = $"{this.root}";
            Nodo_simple<T> this_node = this.root.Next;
            while(this_node != null)
            {
                self_str += $" => {this_node}";
                this_node = this_node.Next;
            }
            return self_str;
        }

        public int Count
        {
            get { return this.len; }
        }

        public Nodo_simple<T> Peek()
        {
            return this.root;
        }

        public void Enqueue(T data,double p)
        {
            this.len++;
            if(this.root == null)
            {
                this.root = new Nodo_simple<T>(data, prioridad: p);
            }
            else
            {
                Nodo_simple<T> new_node; 
                if(this.root.Prioridad > p)
                {
                    new_node = new Nodo_simple<T>(data, this.root, p);
                    this.root = new_node;
                    return;
                }
                Nodo_simple<T> this_node = this.root;
                while (this_node.Next != null)
                {
                    if(this_node.Next.Prioridad > p)
                    {
                        new_node = new Nodo_simple<T>(data, this_node.Next, p);
                        this_node.Next = new_node;
                        return;
                    }
                    this_node = this_node.Next;
                }
                this_node.Next = new Nodo_simple<T>(data, prioridad: p);
            }
        }

        public Nodo_simple<T> Dequeue()
        {
            if(this.len > 0)
            {
                Nodo_simple<T> ret_node = this.root;
                this.root = this.root.Next;
                this.len--;

                return ret_node;
            }
            return null;
        }

    }

    class UnionFindSet<T>
    {
        int len;
        List<HashSet<T>> sets;
        public UnionFindSet()
        {
            this.len = 0;
            this.sets = new List<HashSet<T>>();
        }

        public HashSet<T> MakeSet(T elemento)
        {
            HashSet<T> new_set = new HashSet<T>();
            new_set.Add(elemento);
            this.sets.Add(new_set);
            this.len++;
            return new_set;
        }

        public HashSet<T> Find(T elemento)
        {
            foreach (HashSet<T> set in this.sets)
            {
                if (set.Contains(elemento))
                {
                    return set;
                }
            }
            return null;

        }

        public bool AddTo(T nuevo,T miembro)
        {
            /*
             * busca el set al que pertenece "miembro" y agrega a "nuevo"
             * a ese set, despues retorna true. Si no pudo encontrar el set
             * retorna falso
             */
            HashSet<T> Componente_conexo = this.Find(miembro);
            if(Componente_conexo != null)
            {
                Componente_conexo.Add(nuevo);
                return true;
            }
            return false;

        }

        public bool Union(T miembroA, T miembroB)
        {
            HashSet<T> setA, setB;
            setA = this.Find(miembroA);
            setB = this.Find(miembroB);
            if((setA != setB) && (setA != null || setB != null))
            {
                this.sets.Remove(setB);

                setA.UnionWith(setB);

                return true;
            }
            return false;


        }

        public bool Joined(T A, T B)
        {
            HashSet<T> setA, setB;

            setA = this.Find(A);
            setB = this.Find(B);

            if(setA == setB && setB != null)
            {
                return true;
            }
            return false;

        }

        public int Count
        {
            /*
             * Devuelve el numero de componentes conexos que excisten
             */
            get { return this.sets.Count; }
        }

        public HashSet<T> GlobalSet
        {
            get {
                HashSet<T> global_set = new HashSet<T>();
                foreach (HashSet<T> item in this.sets)
                {
                    global_set.UnionWith(item);
                }
                return global_set;
            }
        }
    }
}
