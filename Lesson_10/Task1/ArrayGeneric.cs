using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10
{
    internal class ArrayGeneric<T> : IEnumerable
    {
        T[] array;

        public ArrayGeneric(T[] array)
        {
            this.array = array;
        }

        /// <summary>
        /// Add element into end of array.
        /// </summary>
        /// <param name="element"></param>
        public void Add(T element)
        {
                var tempArray = new T[array.Length + 1];
                array.CopyTo(tempArray, 0);
                array = tempArray;
                array[array.Length - 1] = element;          
        }

        /// <summary>
        /// Delete all equals elements in array If array contains element. Array becomes shorter.
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public void Delete(T element)
        {

            var count = 0;
            foreach (var item in array)
            {
                if(item.Equals(element))
                {
                    count++;
                }
            }

            if(count > 0)
            {
                var tempArray = new T[array.Length - count];
                var index = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    if (!array[i].Equals(element))
                    {
                        tempArray[index] = array[i];
                        index++;
                    }
                }

                array = tempArray;
            }                                                             
        }

        /// <summary>
        /// Return lenght of array.
        /// </summary>
        /// <returns></returns>
        public int Lenght()
        {
            return array.Length;
        }

        /// <summary>
        /// Return elelment by index. Index of array start from 0.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public T Get(int index)
        {
            if((index > array.Length - 1) || index < 0)
            {
                throw new ArgumentOutOfRangeException("index");
            }
            else
            {
                return array[index];
            }            
        }

        public IEnumerator GetEnumerator()
        {
            return array.GetEnumerator();
        }
    }
}
