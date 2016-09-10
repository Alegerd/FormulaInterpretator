using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula
{
    class Executioner
    {
        //Поля
        private string _formula;
        private string _inputErrorDescription;
        Tree myTree = new Tree();
        List<char> Signs = new List<char>();//список приоритета операций





        //Методы

        private string MakeTree(string formula, Node currentNode)
        {
            string leftFormula = "";
            string rightFormula = "";
            string currentNodeValue = "";


            ParseFormula(formula, ref leftFormula, ref rightFormula, ref currentNodeValue);//парсинг формулы

            if (formula.Equals(currentNodeValue))// расставление флагов на операторы
                currentNode.IsOperator = false;
            else
                currentNode.IsOperator = true;

            if (leftFormula != "")//рекурсивно вызываем метод ParseFormula для левой и правой части от знака
            {
                currentNode.LeftNode = new Node();
                currentNode.LeftNode.Val = MakeTree(leftFormula, currentNode.LeftNode);
            }
            if (rightFormula != "")
            {
                currentNode.RightNode = new Node();
                currentNode.RightNode.Val = MakeTree(rightFormula, currentNode.RightNode);
            }
            return currentNodeValue;// Возвращает операцию либо операнд
        }//составление AST-дерева

        private void ParseFormula(string formula, ref string leftPart, ref string rightPart, ref string value)
        {
            for (int j = 0; j < Signs.Count(); j++)//проход по списку приоритетных операций
            {
                for (int i = 0; i < formula.Length; i++)
                {
                    if (formula[i] == Signs[j])
                    {
                        value = Signs[j] + "";
                        leftPart = formula.Substring(0, i);
                        rightPart = formula.Substring(i + 1, formula.Length - i - 1);
                        return;
                    }
                }
                
            }
            value = formula;//если не является ни одним из операторов, считает, что это операнд
            return;
        }//парсинг формулы

        public double Calculate(Node currentNode)
        {
            double solution = 0;
            string operation = "none";
            Node leftNode;
            Node rightNode;

            if (currentNode.LeftNode != null)
            {
                leftNode = new Node();
                leftNode = currentNode.LeftNode;
            }
            if (currentNode.RightNode != null)
            {
                rightNode = new Node();
                rightNode = currentNode.RightNode;
            }
            if (currentNode.IsOperator)
            {
                operation = currentNode.Val;
            }

            switch (operation)
            {
                case "+":

                    solution = Calculate(currentNode.LeftNode) + Calculate(currentNode.RightNode);
                    break;
                case "-":
                    solution = Calculate(currentNode.LeftNode) - Calculate(currentNode.RightNode);
                    break;
                case "^":
                    solution = Math.Pow (Calculate(currentNode.LeftNode),Calculate(currentNode.RightNode));
                    break;
                case "*":
                    solution = Calculate(currentNode.LeftNode) * Calculate(currentNode.RightNode);
                    break;
                case "/":
                    solution = Calculate(currentNode.LeftNode) / Calculate(currentNode.RightNode);
                    break;
                default:
                    solution = Convert.ToDouble(currentNode.Val);
                    break;
            }

            return solution;

        }//расчет формулы по AST-дереву

        public double FindSolution()
        {
            FillOperationList(); //вызов метода заполнения приоритета операций
            myTree.Root = new Node(); //создание корневого узла
            myTree.Root.Val = MakeTree(Formula, myTree.Root); //вызов метода создания дерева

            return Calculate(myTree.Root);

        }//главный метод

        public bool isInputCorrect(string input, string x, string y)
        {
            int test = 0;
            //проверка скобок
            for (int i = 0; i < input.Length; i++)
            {
                if (test >= 0)
                {
                    if (input[i] == '(')
                        test++;
                    else if (input[i] == ')')
                        test--;
                }
                else
                {
                    InputErrorDescription = "Проверьте скобки";
                    throw new Exception();
                }
            }
            if (test != 0)
            {
                InputErrorDescription = "Проверьте скобки";
                throw new Exception();
            }
            else return true;


        }//проверяет корректность введенных данных

        private void FillOperationList()
        {
            Signs.Add('+');
            Signs.Add('-');
            Signs.Add('^');
            Signs.Add('*');
            Signs.Add('/');
        }//заполнение списка приоритетов операций

        //Свойства
        public string Formula
        {
            get
            {
                return _formula;
            }

            set
            {
                _formula = value;
            }
        }
        public string InputErrorDescription
        {
            get
            {
                return _inputErrorDescription;
            }

            set
            {
                _inputErrorDescription = value;
            }
        }
    }
}
