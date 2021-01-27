using System;
using System.Collections.Generic;
using System.Text;

/*
 * This is a comment of a Class
 */
namespace InherentComplexityScore
{
    public class CyclomaticComplexitySoftwareScience
    {
        static void Main(string[] args)
        {
        }

        /*
         * Cyclomatic Complexity = 1
         * 
         * Operands: +9
         *  public  +1
         *  void    +1
         *  (       +2
         *  {       +1
         *  .       +2
         *  ;       +1
         *  }       +1
         *  
         * Operators: 0
         * 
         * IdentifierToken: TestMethod, System, Console, WriteLine
         * StringLiteralToken: Holi
         */
        public void TestMethod1()
        {
            System.Console.WriteLine("Holi");
        }

        /*
         * Cyclomatic Complexity = 2
         * - normal flow:   +1
         * - foreach:       +1
         * 
         * Operands: +17
         *  public  +1
         *  void    +1
         *  (       +4
         *  {       +2
         *  .       +2
         *  ;       +2
         *  }       +2
         *  new     +1
         *  string  +1
         *  in      +1
         *  
         * Operators: 0
         *
         * IdentifierToken: TestMethod2, var, paises, List, pais, System, Console, WriteLine       
         *
         */
        public void TestMethod2()
        {
            var paises = new List<string>();
            foreach (var pais in paises)
            {
                System.Console.WriteLine(pais);
            }
        }

        /*
         * Cyclomatic Complexity = 3
         * 
         * Operands: +16
         *  public  +1
         *  void    +1
         *  (       +3
         *  {       +4
         *  ;       +1
         *  }       +4
         *  else    +2
         *  
         * Operators: 0
         *
         * IdentifierToken: TestMethod3, var, indice
         * NumericLiteralToken: 0, 1
         */
        public void TestMethod3()
        {
            var indice = 0;
            if (indice == 0)
            {
            }
            else if (indice == 1)
            {
            }
            else
            {
            }
        }

        /*
         * Cyclomatic Complexity = 3
         * - normal flow:    +1
         * - case 0:         +1
         * - case 1:         +1
         * 
         * Operands: +15
         *  public  +1
         *  void    +1
         *  (       +2
         *  {       +2
         *  ;       +4
         *  :       +3
         *  }       +2
         *  
         * Operators: +3
         *  break    +3
         *
         * IdentifierToken: TestMethod4, var, indice
         * NumericLiteralToken: 0, 1
         * SwitchKeyword: switch
         * CaseKeyword: case
         * 
         */
        public void TestMethod4()
        {
            var indice = 0;
            switch (indice)
            {
                case 0:
                    break;
                case 1:
                    break;
                default:
                    break;
            }
        }

        /*
         * Cyclomatic Complexity = 5
         * - we start with 1 for the routine    +1
         * - add 1 for the while loop           +1
         * - add 1 for the if                   +1
         * - add 1 for each &&                  +2
         * 
         * Operands: +23
         *  public  +1
         *  void    +1
         *  (       +6
         *  {       +3
         *  }       +3
         *  ,       +4
         *  int     +3
         *  true    +2
         *  
         * Operators: +3
         *  break    +3
         *
         * IdentifierToken: TestMethod5, Boolean, nextPage, lineCount, linesPerPage, status, morePages
         * NumericLiteralToken: 0, 1
         * WhileKeyword: while
         * ExclamationEqualsToken: !=
         * LessThanEqualsToken: <=
         * AmpersandAmpersandToken: &&
         * NumericLiteralToken: 0
         * 
         */
        public void TestMethod5(Boolean nextPage, int lineCount, int linesPerPage, int status, Boolean morePages)
        {
            while (nextPage != true)
            {
                if ((lineCount <= linesPerPage) && (status != 0) && (morePages == true))
                {
                    //....
                }
            }
        }

        /*
         * Cyclomatic Complexity = 12
         * - normal flow:                                       +1
         * - case 0 if (a <= 0 || b <= 0 || c <= 0):            +3
         * - case 1 if((a > b + c || b > a + c || c > a + b)):  +3
         * - case 2 if(a == b && b == c)                        +2
         * - case 3 if(a == b || b == c || a == c)              +3
         * 
         * Operands: +51
         *  public  +1
         *  void    +1
         *  (       +13
         *  {       +6
         *  }       +6
         *  ,       +2
         *  int     +3
         *  new     +1
         *  string  +1
         *  in      +1
         *  .       +10
         *  ;       +6
         *  
         * Operators: +3
         *  +       +3         
         *
         * IdentifierToken: TestMethod6, a, b, c, var, paises, List, pais, System, Console, WriteLine
         * ForEachKeyword: foreach
         * IfKeyword: if
         * NumericLiteralToken: 0         
         * 
         */
        public void TestMethod6(int a, int b, int c)
        {
            var paises = new List<string>();
            foreach (var pais in paises)
            {
                if (a <= 0 || b <= 0 || c <= 0)
                {
                    System.Console.WriteLine(pais);
                }

                if ((a > b + c || b > a + c || c > a + b))
                {
                    System.Console.WriteLine(pais);
                }

                if (a == b && b == c)
                {
                    System.Console.WriteLine(pais);
                }

                if (a == b || b == c || a == c)
                {
                    System.Console.WriteLine(pais);
                }

                System.Console.WriteLine(pais);
            }
        }
    }
}
