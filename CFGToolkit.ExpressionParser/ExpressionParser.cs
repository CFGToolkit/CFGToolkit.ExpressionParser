using CFGToolkit.AST;
using CFGToolkit.ParserCombinator;

namespace CFGToolkit.ExpressionParser
{
    public class ExpressionParser
    {
        public static SyntaxNode Parse(string expression, ExpressionLanguage language)
        {
            if (language == ExpressionLanguage.C)
            {
                return Languages.C.ExpressionParser.expression.Value.End().Parse(expression).SingleOrDefault();
            }

            throw new InvalidOperationException("Unsupported language");
        }
    }
}
