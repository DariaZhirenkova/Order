﻿

namespace Order1
{
    public class MyNode<T>
    {
        public T Data { get; set; } // сами данные 
        public MyNode<T> Next { get; set; }// ссылка на следующий элемент

        public MyNode(T data)
        {
            Data = data;
        }
    }
}
