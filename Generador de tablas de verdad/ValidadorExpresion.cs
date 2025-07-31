using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Generador_de_tablas_de_verdad
{
    class ValidadorExpresion
    {
        public static bool ParentesisBalanceados(string cadena)
        {
            return VerificarParentesis(cadena, 0, new Stack<char>());
        }

        private static bool VerificarParentesis(string cadena, int pos, Stack<char> pila)
        {
            if (pos >= cadena.Length)
                return pila.Count == 0;

            char c = cadena[pos];
            if (c == '(')
            {
                pila.Push(c);
            }
            else if (c == ')')
            {
                if (pila.Count == 0 || pila.Pop() != '(')
                    return false;
            }

            return VerificarParentesis(cadena, pos + 1, pila);
        }

        public static bool ValidarSintaxis(string exp)
        {
            for (int i = 0; i < exp.Length; i++)
            {
                char actual = exp[i];
                char? siguiente = (i < exp.Length - 1) ? exp[i + 1] : (char?)null;

                if ("∧∨→↔".Contains(actual) && siguiente != null && "∧∨→↔".Contains(siguiente.Value))
                    return false;

                if (actual == '(' && siguiente == ')')
                    return false;

                if (i == 0 && "∧∨→↔".Contains(actual)) return false;
                if (i == exp.Length - 1 && "∧∨→↔".Contains(actual)) return false;

                if (actual == '¬' && siguiente == null) return false;
            }

            return true;
        }

        public static List<char> ExtraerVariables(string expresion)
        {
            return expresion
                .Where(char.IsLetter)
                .Distinct()
                .OrderBy(c => c)
                .ToList();
        }

        public static List<Dictionary<char, bool>> GenerarCombinaciones(List<char> variables)
        {
            int total = (int)Math.Pow(2, variables.Count);
            List<Dictionary<char, bool>> combinaciones = new List<Dictionary<char, bool>>();

            for (int i = 0; i < total; i++)
            {
                Dictionary<char, bool> fila = new Dictionary<char, bool>();
                for (int j = 0; j < variables.Count; j++)
                {
                    bool valor = (i & (1 << (variables.Count - j - 1))) != 0;
                    fila[variables[j]] = valor;
                }
                combinaciones.Add(fila);
            }

            return combinaciones;
        }

        public static string Convertir(string expresion)
        {
            string exp = expresion;

            exp = exp.Replace("¬", "!");
            exp = exp.Replace("∧", "&");
            exp = exp.Replace("∨", "|");

            exp = Regex.Replace(exp, @"([a-z])\s*→\s*([a-z])", "!$1|$2");

            exp = Regex.Replace(exp, @"([a-z])\s*↔\s*([a-z])", "($1&$2)|(!$1&!$2)");

            return exp;
        }

        public static bool EvaluarExpresion(string expresionConvertida, Dictionary<char, bool> valores)
        {
            string exp = expresionConvertida;

            foreach (var variable in valores)
            {
                exp = Regex.Replace(exp, $@"\b{variable.Key}\b", variable.Value ? "1" : "0");
            }

            return Evaluar(exp);
        }

        private static bool Evaluar(string expr)
        {
            Stack<bool> valores = new Stack<bool>();
            Stack<char> operadores = new Stack<char>();

            int i = 0;
            while (i < expr.Length)
            {
                char c = expr[i];

                if (c == ' ')
                {
                    i++;
                    continue;
                }

                if (c == '0' || c == '1')
                {
                    valores.Push(c == '1');
                    i++;
                }
                else if (c == '(')
                {
                    operadores.Push(c);
                    i++;
                }
                else if (c == ')')
                {
                    while (operadores.Peek() != '(')
                    {
                        ProcesarOperacion(valores, operadores.Pop());
                    }
                    operadores.Pop(); 
                    i++;
                }
                else if ("!&|".Contains(c))
                {
                    while (operadores.Count > 0 && Prioridad(operadores.Peek()) >= Prioridad(c))
                    {
                        ProcesarOperacion(valores, operadores.Pop());
                    }
                    operadores.Push(c);
                    i++;
                }
                else
                {
                    i++;
                }
            }

            while (operadores.Count > 0)
            {
                ProcesarOperacion(valores, operadores.Pop());
            }

            return valores.Pop();
        }

        private static void ProcesarOperacion(Stack<bool> valores, char operador)
        {
            if (operador == '!')
            {
                bool a = valores.Pop();
                valores.Push(!a);
            }
            else
            {
                bool b = valores.Pop();
                bool a = valores.Pop();
                switch (operador)
                {
                    case '&': valores.Push(a && b); break;
                    case '|': valores.Push(a || b); break;
                }
            }
        }

        private static int Prioridad(char op)
        {
            switch (op)
            {
                case '!': return 3;
                case '&': return 2;
                case '|': return 1;
                default: return 0;
            }
        }
    }
}
