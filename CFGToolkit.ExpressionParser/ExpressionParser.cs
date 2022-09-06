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
                var result = Languages.C.ExpressionParser.expression.Value.Token().End().TryParse(expression);

                if (!result.IsSuccessful)
                {
                    throw new InvalidOperationException("Failed to parse");
                }
                if (result.Values.Count > 1)
                {
                    throw new InvalidOperationException("Problem with parsing");
                }

                return result.Values.FirstOrDefault()?.Value as SyntaxNode;
            }

            throw new InvalidOperationException("Unsupported language");
        }
    }
}
