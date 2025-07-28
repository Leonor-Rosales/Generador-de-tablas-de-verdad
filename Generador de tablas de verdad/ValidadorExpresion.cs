using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    }
}

