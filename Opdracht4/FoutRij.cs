using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht4
{
    internal class FoutRij<T>
    {
        internal List<T> container = new List<T>();

        public int Count;

        internal bool isLeeg;

        public T Huidig;

        public T HuidigElement;

        public T Toevoegen(T item)
        {
            container.Add(item);
            if(container.Count == 0)
            {
                return Huidig;
            }else
            {
                return default;
                
            }
        }

        public bool CheckIfLeeg()
        {
            if(container.Count == 0)
            {
                isLeeg = true;
                return isLeeg;
            }else
            {
                isLeeg= false;
                return false;
            }
        }

        public T Verwijder()
        {
            if (container.Count == 0)
                throw new StackOverflowException();

            T pos1 = container[0];
            container.RemoveAt(0);
            return pos1;
        }

        public void leegMaken()
        {
            container.Clear();
        }

        

        public void Volgende()
        {
            if (container.Count <= 0)
            {
                throw new StackOverflowException();
            }

            T pos = container[Count + 1];
            container.RemoveAt(Count + 1);

            container.Add(pos);
            Count++;

        }


        public void ZetAchteraan()
        {
            if (container.Count <= 0)
            {
                throw new StackOverflowException();
            }

            T pos = container[Count - 1];
            container.RemoveAt(Count - 1);

            container.Add(pos);
            Count--;

        }

        public List<T> copy()
        {
            List<T> newContainer = container.GetRange(0, container.Count);
            return newContainer;
        }



        public override string ToString()
        {
            string content = "";
            foreach (T s in container)
                content += s.ToString() + "/ ";
            return content;
        }

      



    }
}
