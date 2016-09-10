using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formula
{
    class Node
    {
        //Поля
        private Node _leftNode;
        private Node _rightNode;
        private string _val;
        private bool _isOperator;

        //Методы
        public bool isSheet()
        {
            return (LeftNode != null || RightNode != null);
        }//проверка на то, что узел является листом дерева.

        //Свойства
        public string Val
        {
            get
            {
                return _val;
            }

            set
            {
                _val = value;
            }
        }
        public Node RightNode
        {
            get
            {
                return _rightNode;
            }

            set
            {
                _rightNode = value;
            }
        }
        public Node LeftNode
        {
            get
            {
                return _leftNode;
            }

            set
            {
                _leftNode = value;
            }
        }
        public bool IsOperator
        {
            get
            {
                return _isOperator;
            }

            set
            {
                _isOperator = value;
            }
        }
    }
}
