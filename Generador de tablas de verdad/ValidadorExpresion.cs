using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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

                // Doble operador binario
                if ("∧∨→↔".Contains(actual) && siguiente != null && "∧∨→↔".Contains(siguiente.Value))
                    return false;

                // Paréntesis vacíos
                if (actual == '(' && siguiente == ')')
                    return false;

                // Operador binario al principio o final
                if (i == 0 && "∧∨→↔".Contains(actual)) return false;
                if (i == exp.Length - 1 && "∧∨→↔".Contains(actual)) return false;

                // ¬ no debe ir al final
                if (actual == '¬' && siguiente == null) return false;
            }

            return true;
        }


        // Extrae variables únicas en orden
        public static List<char> ExtraerVariables(string expresion)
        {
            return expresion
                .Where(char.IsLetter)
                .Distinct()
                .OrderBy(c => c)
                .ToList();
        }

        // Opcional: convertir a formato evaluable si usarán evaluador tipo C#
        public static string Convertir(string expresion)
        {
            // Primero convierte los operadores simples
            string exp = expresion
                .Replace("¬", "!")
                .Replace("∧", "&&")
                .Replace("∨", "||");

            // Convierte la implicación: A → B → !A || B
            // Busca patrón letra→letra o paréntesis→letra, etc.
            exp = Regex.Replace(exp, @"([A-Z\)])→([A-Z\(])", "!$1 || $2");

            // Convierte bicondicional: A ↔ B → (A && B) || (!A && !B)
            // Esto ya es más complejo, puedes usar este patrón básico:
            exp = Regex.Replace(exp, @"([A-Z])↔([A-Z])", "($1 && $2) || (!$1 && !$2)");

            return exp;
        }
    }
}

