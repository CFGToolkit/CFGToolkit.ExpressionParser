using CFGToolkit.AST;
using CFGToolkit.ParserCombinator;
using CFGToolkit.ParserCombinator.Input;
using CFGToolkit.ParserCombinator.Parsers;
using System.Threading;

namespace CFGToolkit.ExpressionParser.Languages.C
{
    public partial class ExpressionParser
    {
        public static Lazy<IParser<CharToken, SyntaxNode>> expression =
      new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.Or("expression", parallel: false, Parser.Sequence<CharToken, SyntaxNode>("expression#0", (args) => CreateSyntaxNode(false, true, nameof(expression), args), new Lazy<IParser<CharToken>>(() => conditional_expression.Value)).Tag("index", "0"),
       Parser.Sequence<CharToken, SyntaxNode>("expression#1", (args) => CreateSyntaxNode(false, true, nameof(expression), args), new Lazy<IParser<CharToken>>(() => expression_10.Value)).Tag("index", "1")).Tag("nt", NonTerminals.expression));

        public static Lazy<IParser<CharToken, SyntaxNode>> conditional_expression =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.Sequence<CharToken, SyntaxNode>("conditional_expression", (args) => CreateSyntaxNode(false, true, nameof(conditional_expression), args), new Lazy<IParser<CharToken>>(() => expression_10.Value), new Lazy<IParser<CharToken>>(() => _keyword_892025853_True.Value), new Lazy<IParser<CharToken>>(() => expression.Value), new Lazy<IParser<CharToken>>(() => _keyword_1032055229_True.Value), new Lazy<IParser<CharToken>>(() => expression.Value)).Tag("index", "0").Tag("First").Tag("First:0", "(").Tag("nt", NonTerminals.conditional_expression));

        public static Lazy<IParser<CharToken, SyntaxNode>> expression_10 =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.Sequence<CharToken, SyntaxNode>("expression_10", (args) => CreateSyntaxNode(false, true, nameof(expression_10), args), new Lazy<IParser<CharToken>>(() => expression_9.Value), new Lazy<IParser<CharToken>>(() => expression_10_many.Value.Many(greedy: true))).Tag("index", "0").Tag("First").Tag("First:0", "(").Tag("nt", NonTerminals.expression_10));

        public static Lazy<IParser<CharToken, SyntaxNode>> expression_10_many =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.Sequence<CharToken, SyntaxNode>("expression_10_many", (args) => CreateSyntaxNode(false, true, nameof(expression_10_many), args), new Lazy<IParser<CharToken>>(() => binary_operator_10.Value), new Lazy<IParser<CharToken>>(() => expression_9.Value)).Tag("index", "0").Tag("First").Tag("First:0", "||").Tag("nt", NonTerminals.expression_10_many));

        public static Lazy<IParser<CharToken, SyntaxNode>> expression_9 =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.Sequence<CharToken, SyntaxNode>("expression_9", (args) => CreateSyntaxNode(false, true, nameof(expression_9), args), new Lazy<IParser<CharToken>>(() => expression_8.Value), new Lazy<IParser<CharToken>>(() => expression_9_many.Value.Many(greedy: true))).Tag("index", "0").Tag("First").Tag("First:0", "(").Tag("nt", NonTerminals.expression_9));

        public static Lazy<IParser<CharToken, SyntaxNode>> expression_9_many =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.Sequence<CharToken, SyntaxNode>("expression_9_many", (args) => CreateSyntaxNode(false, true, nameof(expression_9_many), args), new Lazy<IParser<CharToken>>(() => binary_operator_9.Value), new Lazy<IParser<CharToken>>(() => expression_8.Value)).Tag("index", "0").Tag("First").Tag("First:0", "&&").Tag("nt", NonTerminals.expression_9_many));

        public static Lazy<IParser<CharToken, SyntaxNode>> expression_8 =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.Sequence<CharToken, SyntaxNode>("expression_8", (args) => CreateSyntaxNode(false, true, nameof(expression_8), args), new Lazy<IParser<CharToken>>(() => expression_7.Value), new Lazy<IParser<CharToken>>(() => expression_8_many.Value.Many(greedy: true))).Tag("index", "0").Tag("First").Tag("First:0", "(").Tag("nt", NonTerminals.expression_8));

        public static Lazy<IParser<CharToken, SyntaxNode>> expression_8_many =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.Sequence<CharToken, SyntaxNode>("expression_8_many", (args) => CreateSyntaxNode(false, true, nameof(expression_8_many), args), new Lazy<IParser<CharToken>>(() => binary_operator_8.Value), new Lazy<IParser<CharToken>>(() => expression_7.Value)).Tag("index", "0").Tag("First").Tag("First:0", "|").Tag("nt", NonTerminals.expression_8_many));

        public static Lazy<IParser<CharToken, SyntaxNode>> expression_7 =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.Sequence<CharToken, SyntaxNode>("expression_7", (args) => CreateSyntaxNode(false, true, nameof(expression_7), args), new Lazy<IParser<CharToken>>(() => expression_6.Value), new Lazy<IParser<CharToken>>(() => expression_7_many.Value.Many(greedy: true))).Tag("index", "0").Tag("First").Tag("First:0", "(").Tag("nt", NonTerminals.expression_7));

        public static Lazy<IParser<CharToken, SyntaxNode>> expression_7_many =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.Sequence<CharToken, SyntaxNode>("expression_7_many", (args) => CreateSyntaxNode(false, true, nameof(expression_7_many), args), new Lazy<IParser<CharToken>>(() => binary_operator_7.Value), new Lazy<IParser<CharToken>>(() => expression_6.Value)).Tag("index", "0").Tag("First").Tag("First:0", "^").Tag("nt", NonTerminals.expression_7_many));

        public static Lazy<IParser<CharToken, SyntaxNode>> expression_6 =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.Sequence<CharToken, SyntaxNode>("expression_6", (args) => CreateSyntaxNode(false, true, nameof(expression_6), args), new Lazy<IParser<CharToken>>(() => expression_5.Value), new Lazy<IParser<CharToken>>(() => expression_6_many.Value.Many(greedy: true))).Tag("index", "0").Tag("First").Tag("First:0", "(").Tag("nt", NonTerminals.expression_6));

        public static Lazy<IParser<CharToken, SyntaxNode>> expression_6_many =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.Sequence<CharToken, SyntaxNode>("expression_6_many", (args) => CreateSyntaxNode(false, true, nameof(expression_6_many), args), new Lazy<IParser<CharToken>>(() => binary_operator_6.Value), new Lazy<IParser<CharToken>>(() => expression_5.Value)).Tag("index", "0").Tag("First").Tag("First:0", "&").Tag("nt", NonTerminals.expression_6_many));

        public static Lazy<IParser<CharToken, SyntaxNode>> expression_5 =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.Sequence<CharToken, SyntaxNode>("expression_5", (args) => CreateSyntaxNode(false, true, nameof(expression_5), args), new Lazy<IParser<CharToken>>(() => expression_4.Value), new Lazy<IParser<CharToken>>(() => expression_5_many.Value.Many(greedy: true))).Tag("index", "0").Tag("First").Tag("First:0", "(").Tag("nt", NonTerminals.expression_5));

        public static Lazy<IParser<CharToken, SyntaxNode>> expression_5_many =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.Sequence<CharToken, SyntaxNode>("expression_5_many", (args) => CreateSyntaxNode(false, true, nameof(expression_5_many), args), new Lazy<IParser<CharToken>>(() => binary_operator_5.Value), new Lazy<IParser<CharToken>>(() => expression_4.Value)).Tag("index", "0").Tag("First").Tag("First:0", "!=").Tag("nt", NonTerminals.expression_5_many));

        public static Lazy<IParser<CharToken, SyntaxNode>> expression_4 =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.Sequence<CharToken, SyntaxNode>("expression_4", (args) => CreateSyntaxNode(false, true, nameof(expression_4), args), new Lazy<IParser<CharToken>>(() => expression_3.Value), new Lazy<IParser<CharToken>>(() => expression_4_many.Value.Many(greedy: true))).Tag("index", "0").Tag("First").Tag("First:0", "(").Tag("nt", NonTerminals.expression_4));

        public static Lazy<IParser<CharToken, SyntaxNode>> expression_4_many =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.Sequence<CharToken, SyntaxNode>("expression_4_many", (args) => CreateSyntaxNode(false, true, nameof(expression_4_many), args), new Lazy<IParser<CharToken>>(() => binary_operator_4.Value), new Lazy<IParser<CharToken>>(() => expression_3.Value)).Tag("index", "0").Tag("First").Tag("First:0", "<=").Tag("nt", NonTerminals.expression_4_many));

        public static Lazy<IParser<CharToken, SyntaxNode>> expression_3 =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.Sequence<CharToken, SyntaxNode>("expression_3", (args) => CreateSyntaxNode(false, true, nameof(expression_3), args), new Lazy<IParser<CharToken>>(() => expression_2.Value), new Lazy<IParser<CharToken>>(() => expression_3_many.Value.Many(greedy: true))).Tag("index", "0").Tag("First").Tag("First:0", "(").Tag("nt", NonTerminals.expression_3));

        public static Lazy<IParser<CharToken, SyntaxNode>> expression_3_many =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.Sequence<CharToken, SyntaxNode>("expression_3_many", (args) => CreateSyntaxNode(false, true, nameof(expression_3_many), args), new Lazy<IParser<CharToken>>(() => binary_operator_3.Value), new Lazy<IParser<CharToken>>(() => expression_2.Value)).Tag("index", "0").Tag("First").Tag("First:0", "<<").Tag("nt", NonTerminals.expression_3_many));

        public static Lazy<IParser<CharToken, SyntaxNode>> expression_2 =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.Sequence<CharToken, SyntaxNode>("expression_2", (args) => CreateSyntaxNode(false, true, nameof(expression_2), args), new Lazy<IParser<CharToken>>(() => expression_1.Value), new Lazy<IParser<CharToken>>(() => expression_2_many.Value.Many(greedy: true))).Tag("index", "0").Tag("First").Tag("First:0", "(").Tag("nt", NonTerminals.expression_2));

        public static Lazy<IParser<CharToken, SyntaxNode>> expression_2_many =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.Sequence<CharToken, SyntaxNode>("expression_2_many", (args) => CreateSyntaxNode(false, true, nameof(expression_2_many), args), new Lazy<IParser<CharToken>>(() => binary_operator_2.Value), new Lazy<IParser<CharToken>>(() => expression_1.Value)).Tag("index", "0").Tag("First").Tag("First:0", "+").Tag("nt", NonTerminals.expression_2_many));

        public static Lazy<IParser<CharToken, SyntaxNode>> expression_1 =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.Sequence<CharToken, SyntaxNode>("expression_1", (args) => CreateSyntaxNode(false, true, nameof(expression_1), args), new Lazy<IParser<CharToken>>(() => expression_primary.Value), new Lazy<IParser<CharToken>>(() => expression_1_many.Value.Many(greedy: true))).Tag("index", "0").Tag("First").Tag("First:0", "(").Tag("nt", NonTerminals.expression_1));

        public static Lazy<IParser<CharToken, SyntaxNode>> expression_1_many =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.Sequence<CharToken, SyntaxNode>("expression_1_many", (args) => CreateSyntaxNode(false, true, nameof(expression_1_many), args), new Lazy<IParser<CharToken>>(() => binary_operator_1.Value), new Lazy<IParser<CharToken>>(() => expression_primary.Value)).Tag("index", "0").Tag("First").Tag("First:0", "*").Tag("nt", NonTerminals.expression_1_many));

        public static Lazy<IParser<CharToken, SyntaxNode>> binary_operator_1 =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.XOr("binary_operator_1", first: true, parallelMode: XOrParallelMode.None, Parser.Sequence<CharToken, SyntaxNode>("binary_operator_1#0", (args) => CreateSyntaxNode(false, true, nameof(binary_operator_1), args), new Lazy<IParser<CharToken>>(() => _keyword_310035264_True.Value)).Tag("index", "0"),
           Parser.Sequence<CharToken, SyntaxNode>("binary_operator_1#1", (args) => CreateSyntaxNode(false, true, nameof(binary_operator_1), args), new Lazy<IParser<CharToken>>(() => _keyword_1742231173_True.Value)).Tag("index", "1"),
           Parser.Sequence<CharToken, SyntaxNode>("binary_operator_1#2", (args) => CreateSyntaxNode(false, true, nameof(binary_operator_1), args), new Lazy<IParser<CharToken>>(() => _keyword_24331476_True.Value)).Tag("index", "2")).Tag("xor").Tag("priority", "1").Tag("operator").Tag("First").Tag("First:0", "*").Tag("First:1", "/").Tag("First:2", "%").Tag("nt", NonTerminals.binary_operator_1));

        public static Lazy<IParser<CharToken, SyntaxNode>> binary_operator_2 =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.XOr("binary_operator_2", first: true, parallelMode: XOrParallelMode.None, Parser.Sequence<CharToken, SyntaxNode>("binary_operator_2#0", (args) => CreateSyntaxNode(false, true, nameof(binary_operator_2), args), new Lazy<IParser<CharToken>>(() => _keyword_1558930534_True.Value)).Tag("index", "0"),
           Parser.Sequence<CharToken, SyntaxNode>("binary_operator_2#1", (args) => CreateSyntaxNode(false, true, nameof(binary_operator_2), args), new Lazy<IParser<CharToken>>(() => _keyword_740029763_True.Value)).Tag("index", "1")).Tag("xor").Tag("priority", "2").Tag("operator").Tag("First").Tag("First:0", "+").Tag("First:1", "-").Tag("nt", NonTerminals.binary_operator_2));

        public static Lazy<IParser<CharToken, SyntaxNode>> binary_operator_3 =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.XOr("binary_operator_3", first: true, parallelMode: XOrParallelMode.None, Parser.Sequence<CharToken, SyntaxNode>("binary_operator_3#0", (args) => CreateSyntaxNode(false, true, nameof(binary_operator_3), args), new Lazy<IParser<CharToken>>(() => _keyword_1309527343_True.Value)).Tag("index", "0"),
           Parser.Sequence<CharToken, SyntaxNode>("binary_operator_3#1", (args) => CreateSyntaxNode(false, true, nameof(binary_operator_3), args), new Lazy<IParser<CharToken>>(() => _keyword_816786937_True.Value)).Tag("index", "1")).Tag("xor").Tag("priority", "3").Tag("operator").Tag("First").Tag("First:0", "<<").Tag("First:1", ">>").Tag("nt", NonTerminals.binary_operator_3));

        public static Lazy<IParser<CharToken, SyntaxNode>> binary_operator_4 =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.XOr("binary_operator_4", first: true, parallelMode: XOrParallelMode.None, Parser.Sequence<CharToken, SyntaxNode>("binary_operator_4#0", (args) => CreateSyntaxNode(false, true, nameof(binary_operator_4), args), new Lazy<IParser<CharToken>>(() => _keyword_829326556_True.Value)).Tag("index", "0"),
           Parser.Sequence<CharToken, SyntaxNode>("binary_operator_4#1", (args) => CreateSyntaxNode(false, true, nameof(binary_operator_4), args), new Lazy<IParser<CharToken>>(() => _keyword_1300857847_True.Value)).Tag("index", "1"),
           Parser.Sequence<CharToken, SyntaxNode>("binary_operator_4#2", (args) => CreateSyntaxNode(false, true, nameof(binary_operator_4), args), new Lazy<IParser<CharToken>>(() => _keyword_939787975_True.Value)).Tag("index", "2"),
           Parser.Sequence<CharToken, SyntaxNode>("binary_operator_4#3", (args) => CreateSyntaxNode(false, true, nameof(binary_operator_4), args), new Lazy<IParser<CharToken>>(() => _keyword_2076602465_True.Value)).Tag("index", "3")).Tag("xor").Tag("priority", "4").Tag("operator").Tag("First").Tag("First:0", "<=").Tag("First:1", ">=").Tag("First:2", "<").Tag("First:3", ">").Tag("nt", NonTerminals.binary_operator_4));

        public static Lazy<IParser<CharToken, SyntaxNode>> binary_operator_5 =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.XOr("binary_operator_5", first: true, parallelMode: XOrParallelMode.None, Parser.Sequence<CharToken, SyntaxNode>("binary_operator_5#0", (args) => CreateSyntaxNode(false, true, nameof(binary_operator_5), args), new Lazy<IParser<CharToken>>(() => _keyword_648759161_True.Value)).Tag("index", "0"),
           Parser.Sequence<CharToken, SyntaxNode>("binary_operator_5#1", (args) => CreateSyntaxNode(false, true, nameof(binary_operator_5), args), new Lazy<IParser<CharToken>>(() => _keyword_234840654_True.Value)).Tag("index", "1")).Tag("xor").Tag("priority", "5").Tag("operator").Tag("First").Tag("First:0", "!=").Tag("First:1", "==").Tag("nt", NonTerminals.binary_operator_5));

        public static Lazy<IParser<CharToken, SyntaxNode>> binary_operator_6 =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.Sequence<CharToken, SyntaxNode>("binary_operator_6", (args) => CreateSyntaxNode(false, true, nameof(binary_operator_6), args), new Lazy<IParser<CharToken>>(() => _keyword_282216391_True.Value)).Tag("index", "0").Tag("priority", "6").Tag("operator").Tag("First").Tag("First:0", "&").Tag("nt", NonTerminals.binary_operator_6));

        public static Lazy<IParser<CharToken, SyntaxNode>> binary_operator_7 =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.Sequence<CharToken, SyntaxNode>("binary_operator_7", (args) => CreateSyntaxNode(false, true, nameof(binary_operator_7), args), new Lazy<IParser<CharToken>>(() => _keyword_1167493674_True.Value)).Tag("index", "0").Tag("priority", "7").Tag("operator").Tag("First").Tag("First:0", "^").Tag("nt", NonTerminals.binary_operator_7));

        public static Lazy<IParser<CharToken, SyntaxNode>> binary_operator_8 =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.Sequence<CharToken, SyntaxNode>("binary_operator_8", (args) => CreateSyntaxNode(false, true, nameof(binary_operator_8), args), new Lazy<IParser<CharToken>>(() => _keyword_492696045_True.Value)).Tag("index", "0").Tag("priority", "8").Tag("operator").Tag("First").Tag("First:0", "|").Tag("nt", NonTerminals.binary_operator_8));

        public static Lazy<IParser<CharToken, SyntaxNode>> binary_operator_9 =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.Sequence<CharToken, SyntaxNode>("binary_operator_9", (args) => CreateSyntaxNode(false, true, nameof(binary_operator_9), args), new Lazy<IParser<CharToken>>(() => _keyword_2023765867_True.Value)).Tag("index", "0").Tag("priority", "9").Tag("operator").Tag("First").Tag("First:0", "&&").Tag("nt", NonTerminals.binary_operator_9));

        public static Lazy<IParser<CharToken, SyntaxNode>> binary_operator_10 =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.Sequence<CharToken, SyntaxNode>("binary_operator_10", (args) => CreateSyntaxNode(false, true, nameof(binary_operator_10), args), new Lazy<IParser<CharToken>>(() => _keyword_1465882374_True.Value)).Tag("index", "0").Tag("priority", "10").Tag("operator").Tag("First").Tag("First:0", "||").Tag("nt", NonTerminals.binary_operator_10));

        public static Lazy<IParser<CharToken, SyntaxNode>> expression_primary =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.Sequence<CharToken, SyntaxNode>("expression_primary", (args) => CreateSyntaxNode(false, true, nameof(expression_primary), args), new Lazy<IParser<CharToken>>(() => cast_expression.Value)).Tag("index", "0").Tag("First").Tag("First:0", "(").Tag("nt", NonTerminals.expression_primary));

        public static Lazy<IParser<CharToken, SyntaxNode>> cast_expression =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.XOr("cast_expression", first: false, parallelMode: XOrParallelMode.None, Parser.Sequence<CharToken, SyntaxNode>("cast_expression#0", (args) => CreateSyntaxNode(false, true, nameof(cast_expression), args), new Lazy<IParser<CharToken>>(() => _keyword_1371525173_True.Value), new Lazy<IParser<CharToken>>(() => types.Value), new Lazy<IParser<CharToken>>(() => _keyword_1870961584_True.Value), new Lazy<IParser<CharToken>>(() => cast_expression.Value)).Tag("index", "0"),
           Parser.Sequence<CharToken, SyntaxNode>("cast_expression#1", (args) => CreateSyntaxNode(false, true, nameof(cast_expression), args), new Lazy<IParser<CharToken>>(() => unary_expression.Value)).Tag("index", "1")).Tag("xor").Tag("nt", NonTerminals.cast_expression));

        public static Lazy<IParser<CharToken, SyntaxNode>> unary_expression =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.XOr("unary_expression", first: false, parallelMode: XOrParallelMode.None, Parser.Sequence<CharToken, SyntaxNode>("unary_expression#0", (args) => CreateSyntaxNode(false, true, nameof(unary_expression), args), new Lazy<IParser<CharToken>>(() => postfix.Value)).Tag("index", "0"),
           Parser.Sequence<CharToken, SyntaxNode>("unary_expression#1", (args) => CreateSyntaxNode(false, true, nameof(unary_expression), args), new Lazy<IParser<CharToken>>(() => prefix.Value)).Tag("index", "1"),
           Parser.Sequence<CharToken, SyntaxNode>("unary_expression#2", (args) => CreateSyntaxNode(false, true, nameof(unary_expression), args), new Lazy<IParser<CharToken>>(() => primary.Value)).Tag("index", "2")).Tag("xor").Tag("nt", NonTerminals.unary_expression));

        public static Lazy<IParser<CharToken, SyntaxNode>> primary =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.XOr("primary", first: false, parallelMode: XOrParallelMode.None, Parser.Sequence<CharToken, SyntaxNode>("primary#0", (args) => CreateSyntaxNode(false, true, nameof(primary), args), new Lazy<IParser<CharToken>>(() => number.Value)).Tag("index", "0"),
           Parser.Sequence<CharToken, SyntaxNode>("primary#1", (args) => CreateSyntaxNode(false, true, nameof(primary), args), new Lazy<IParser<CharToken>>(() => variable.Value)).Tag("index", "1"),
           Parser.Sequence<CharToken, SyntaxNode>("primary#2", (args) => CreateSyntaxNode(false, true, nameof(primary), args), new Lazy<IParser<CharToken>>(() => @string.Value)).Tag("index", "2"),
           Parser.Sequence<CharToken, SyntaxNode>("primary#3", (args) => CreateSyntaxNode(false, true, nameof(primary), args), new Lazy<IParser<CharToken>>(() => _keyword_1371525173_True.Value), new Lazy<IParser<CharToken>>(() => expression.Value), new Lazy<IParser<CharToken>>(() => _keyword_1870961584_True.Value)).Tag("index", "3")).Tag("xor").Tag("nt", NonTerminals.primary));

        public static Lazy<IParser<CharToken, SyntaxNode>> arguments =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.Sequence<CharToken, SyntaxNode>("arguments", (args) => CreateSyntaxNode(false, true, nameof(arguments), args), new Lazy<IParser<CharToken>>(() => arguments_prefix.Value), new Lazy<IParser<CharToken>>(() => arguments_rest.Value)).Tag("index", "0").Tag("xor").Tag("nt", NonTerminals.arguments));

        public static Lazy<IParser<CharToken, SyntaxNode>> postfix =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.Sequence<CharToken, SyntaxNode>("postfix", (args) => CreateSyntaxNode(false, true, nameof(postfix), args), new Lazy<IParser<CharToken>>(() => postfix_prefix.Value), new Lazy<IParser<CharToken>>(() => postfix_rest.Value)).Tag("index", "0").Tag("xor").Tag("nt", NonTerminals.postfix));

        public static Lazy<IParser<CharToken, SyntaxNode>> prefix =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.Sequence<CharToken, SyntaxNode>("prefix", (args) => CreateSyntaxNode(false, true, nameof(prefix), args), new Lazy<IParser<CharToken>>(() => unary_prefix_operator.Value), new Lazy<IParser<CharToken>>(() => primary.Value)).Tag("index", "0").Tag("xor").Tag("First").Tag("First:0", "++").Tag("nt", NonTerminals.prefix));

        public static Lazy<IParser<CharToken, SyntaxNode>> types =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.Sequence<CharToken, SyntaxNode>("types", (args) => CreateSyntaxNode(false, true, nameof(types), args), new Lazy<IParser<CharToken>>(() => types_prefix.Value), new Lazy<IParser<CharToken>>(() => types_rest.Value)).Tag("index", "0").Tag("xor").Tag("First").Tag("First:0", "char").Tag("nt", NonTerminals.types));

        public static Lazy<IParser<CharToken, SyntaxNode>> type =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.XOr("type", first: true, parallelMode: XOrParallelMode.None, Parser.Sequence<CharToken, SyntaxNode>("type#0", (args) => CreateSyntaxNode(false, true, nameof(type), args), new Lazy<IParser<CharToken>>(() => _keyword_267266730_True.Value)).Tag("index", "0"),
           Parser.Sequence<CharToken, SyntaxNode>("type#1", (args) => CreateSyntaxNode(false, true, nameof(type), args), new Lazy<IParser<CharToken>>(() => _keyword_198818345_True.Value)).Tag("index", "1"),
           Parser.Sequence<CharToken, SyntaxNode>("type#2", (args) => CreateSyntaxNode(false, true, nameof(type), args), new Lazy<IParser<CharToken>>(() => _keyword_1989785454_True.Value)).Tag("index", "2"),
           Parser.Sequence<CharToken, SyntaxNode>("type#3", (args) => CreateSyntaxNode(false, true, nameof(type), args), new Lazy<IParser<CharToken>>(() => _keyword_2141776151_True.Value)).Tag("index", "3"),
           Parser.Sequence<CharToken, SyntaxNode>("type#4", (args) => CreateSyntaxNode(false, true, nameof(type), args), new Lazy<IParser<CharToken>>(() => _keyword_1839863353_True.Value)).Tag("index", "4"),
           Parser.Sequence<CharToken, SyntaxNode>("type#5", (args) => CreateSyntaxNode(false, true, nameof(type), args), new Lazy<IParser<CharToken>>(() => _keyword_1445956107_True.Value)).Tag("index", "5"),
           Parser.Sequence<CharToken, SyntaxNode>("type#6", (args) => CreateSyntaxNode(false, true, nameof(type), args), new Lazy<IParser<CharToken>>(() => _keyword_1612036129_True.Value)).Tag("index", "6"),
           Parser.Sequence<CharToken, SyntaxNode>("type#7", (args) => CreateSyntaxNode(false, true, nameof(type), args), new Lazy<IParser<CharToken>>(() => _keyword_2100566772_True.Value)).Tag("index", "7")).Tag("xor").Tag("First").Tag("First:0", "char").Tag("First:1", "short").Tag("First:2", "int").Tag("First:3", "long").Tag("First:4", "float").Tag("First:5", "double").Tag("First:6", "signed").Tag("First:7", "unsigned").Tag("nt", NonTerminals.type));

        public static Lazy<IParser<CharToken, SyntaxNode>> unary_prefix_operator =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.XOr("unary_prefix_operator", first: true, parallelMode: XOrParallelMode.None, Parser.Sequence<CharToken, SyntaxNode>("unary_prefix_operator#0", (args) => CreateSyntaxNode(false, true, nameof(unary_prefix_operator), args), new Lazy<IParser<CharToken>>(() => _keyword_341812014_True.Value)).Tag("index", "0"),
           Parser.Sequence<CharToken, SyntaxNode>("unary_prefix_operator#1", (args) => CreateSyntaxNode(false, true, nameof(unary_prefix_operator), args), new Lazy<IParser<CharToken>>(() => _keyword_887370889_True.Value)).Tag("index", "1"),
           Parser.Sequence<CharToken, SyntaxNode>("unary_prefix_operator#2", (args) => CreateSyntaxNode(false, true, nameof(unary_prefix_operator), args), new Lazy<IParser<CharToken>>(() => _keyword_1558930534_True.Value)).Tag("index", "2"),
           Parser.Sequence<CharToken, SyntaxNode>("unary_prefix_operator#3", (args) => CreateSyntaxNode(false, true, nameof(unary_prefix_operator), args), new Lazy<IParser<CharToken>>(() => _keyword_740029763_True.Value)).Tag("index", "3"),
           Parser.Sequence<CharToken, SyntaxNode>("unary_prefix_operator#4", (args) => CreateSyntaxNode(false, true, nameof(unary_prefix_operator), args), new Lazy<IParser<CharToken>>(() => _keyword_844767463_True.Value)).Tag("index", "4"),
           Parser.Sequence<CharToken, SyntaxNode>("unary_prefix_operator#5", (args) => CreateSyntaxNode(false, true, nameof(unary_prefix_operator), args), new Lazy<IParser<CharToken>>(() => _keyword_1028553605_True.Value)).Tag("index", "5"),
           Parser.Sequence<CharToken, SyntaxNode>("unary_prefix_operator#6", (args) => CreateSyntaxNode(false, true, nameof(unary_prefix_operator), args), new Lazy<IParser<CharToken>>(() => _keyword_282216391_True.Value)).Tag("index", "6")).Tag("xor").Tag("operator").Tag("First").Tag("First:0", "++").Tag("First:1", "--").Tag("First:2", "+").Tag("First:3", "-").Tag("First:4", "!").Tag("First:5", "~").Tag("First:6", "&").Tag("nt", NonTerminals.unary_prefix_operator));

        public static Lazy<IParser<CharToken, SyntaxNode>> unary_postfix_operator =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.XOr("unary_postfix_operator", first: true, parallelMode: XOrParallelMode.None, Parser.Sequence<CharToken, SyntaxNode>("unary_postfix_operator#0", (args) => CreateSyntaxNode(false, true, nameof(unary_postfix_operator), args), new Lazy<IParser<CharToken>>(() => _keyword_341812014_True.Value)).Tag("index", "0"),
           Parser.Sequence<CharToken, SyntaxNode>("unary_postfix_operator#1", (args) => CreateSyntaxNode(false, true, nameof(unary_postfix_operator), args), new Lazy<IParser<CharToken>>(() => _keyword_887370889_True.Value)).Tag("index", "1")).Tag("xor").Tag("operator").Tag("First").Tag("First:0", "++").Tag("First:1", "--").Tag("nt", NonTerminals.unary_postfix_operator));

        public static Lazy<IParser<CharToken, SyntaxNode>> variable =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.Sequence<CharToken, SyntaxNode>("variable", (args) => CreateSyntaxNode(false, true, nameof(variable), args), new Lazy<IParser<CharToken>>(() => _keyword_630856201_True.Value)).Tag("index", "0").Tag("pattern").Tag("nt", NonTerminals.variable));

        public static Lazy<IParser<CharToken, SyntaxNode>> number =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.Sequence<CharToken, SyntaxNode>("number", (args) => CreateSyntaxNode(false, true, nameof(number), args), new Lazy<IParser<CharToken>>(() => _keyword_702627102_True.Value)).Tag("index", "0").Tag("pattern").Tag("nt", NonTerminals.number));

        public static Lazy<IParser<CharToken, SyntaxNode>> @string =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.Sequence<CharToken, SyntaxNode>("@string", (args) => CreateSyntaxNode(false, true, nameof(@string), args), new Lazy<IParser<CharToken>>(() => _keyword_1786360725_True.Value)).Tag("index", "0").Tag("pattern").Tag("nt", NonTerminals.@string));

        public static Lazy<IParser<CharToken, SyntaxNode>> arguments_prefix =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.Sequence<CharToken, SyntaxNode>("arguments_prefix", (args) => CreateSyntaxNode(false, true, nameof(arguments_prefix), args), new Lazy<IParser<CharToken>>(() => primary.Value)).Tag("index", "0").Tag("xor").Tag("nt", NonTerminals.arguments_prefix));

        public static Lazy<IParser<CharToken, SyntaxNode>> arguments_rest =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.XOr("arguments_rest", first: false, parallelMode: XOrParallelMode.None, Parser.Sequence<CharToken, SyntaxNode>("arguments_rest#0", (args) => CreateSyntaxNode(false, true, nameof(arguments_rest), args), new Lazy<IParser<CharToken>>(() => _keyword_96864103_True.Value), new Lazy<IParser<CharToken>>(() => arguments.Value)).Tag("index", "0"),
           Parser.Sequence<CharToken, SyntaxNode>("arguments_rest#1", (args) => CreateSyntaxNode(false, true, nameof(arguments_rest), args), new Lazy<IParser<CharToken>>(() => Parser.Return(string.Empty))).Tag("index", "1")).Tag("xor").Tag("nt", NonTerminals.arguments_rest));

        public static Lazy<IParser<CharToken, SyntaxNode>> postfix_prefix =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.Sequence<CharToken, SyntaxNode>("postfix_prefix", (args) => CreateSyntaxNode(false, true, nameof(postfix_prefix), args), new Lazy<IParser<CharToken>>(() => primary.Value)).Tag("index", "0").Tag("xor").Tag("nt", NonTerminals.postfix_prefix));

        public static Lazy<IParser<CharToken, SyntaxNode>> postfix_rest =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.XOr("postfix_rest", first: false, parallelMode: XOrParallelMode.None, Parser.Sequence<CharToken, SyntaxNode>("postfix_rest#0", (args) => CreateSyntaxNode(false, true, nameof(postfix_rest), args), new Lazy<IParser<CharToken>>(() => _keyword_1832448525_True.Value), new Lazy<IParser<CharToken>>(() => expression.Value), new Lazy<IParser<CharToken>>(() => _keyword_846556041_True.Value)).Tag("index", "0"),
           Parser.Sequence<CharToken, SyntaxNode>("postfix_rest#1", (args) => CreateSyntaxNode(false, true, nameof(postfix_rest), args), new Lazy<IParser<CharToken>>(() => _keyword_1371525173_True.Value), new Lazy<IParser<CharToken>>(() => _keyword_1870961584_True.Value)).Tag("index", "1"),
           Parser.Sequence<CharToken, SyntaxNode>("postfix_rest#2", (args) => CreateSyntaxNode(false, true, nameof(postfix_rest), args), new Lazy<IParser<CharToken>>(() => _keyword_1371525173_True.Value), new Lazy<IParser<CharToken>>(() => arguments.Value), new Lazy<IParser<CharToken>>(() => _keyword_1870961584_True.Value)).Tag("index", "2"),
           Parser.Sequence<CharToken, SyntaxNode>("postfix_rest#3", (args) => CreateSyntaxNode(false, true, nameof(postfix_rest), args), new Lazy<IParser<CharToken>>(() => unary_postfix_operator.Value)).Tag("index", "3")).Tag("xor").Tag("nt", NonTerminals.postfix_rest));

        public static Lazy<IParser<CharToken, SyntaxNode>> types_prefix =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.Sequence<CharToken, SyntaxNode>("types_prefix", (args) => CreateSyntaxNode(false, true, nameof(types_prefix), args), new Lazy<IParser<CharToken>>(() => type.Value)).Tag("index", "0").Tag("xor").Tag("First").Tag("First:0", "char").Tag("nt", NonTerminals.types_prefix));

        public static Lazy<IParser<CharToken, SyntaxNode>> types_rest =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.XOr("types_rest", first: false, parallelMode: XOrParallelMode.None, Parser.Sequence<CharToken, SyntaxNode>("types_rest#0", (args) => CreateSyntaxNode(false, true, nameof(types_rest), args), new Lazy<IParser<CharToken>>(() => types.Value)).Tag("index", "0"),
           Parser.Sequence<CharToken, SyntaxNode>("types_rest#1", (args) => CreateSyntaxNode(false, true, nameof(types_rest), args), new Lazy<IParser<CharToken>>(() => Parser.Return(string.Empty))).Tag("index", "1")).Tag("xor").Tag("nt", NonTerminals.types_rest));

        public static Lazy<IParser<CharToken, string>> _keyword_1309527343_True =
          new Lazy<IParser<CharToken, string>>(() => Parser.String("<<", true).Tag("keyword"));

        public static Lazy<IParser<CharToken, string>> _keyword_816786937_True =
          new Lazy<IParser<CharToken, string>>(() => Parser.String(">>", true).Tag("keyword"));

        public static Lazy<IParser<CharToken, string>> _keyword_829326556_True =
          new Lazy<IParser<CharToken, string>>(() => Parser.String("<=", true).Tag("keyword"));

        public static Lazy<IParser<CharToken, string>> _keyword_1300857847_True =
          new Lazy<IParser<CharToken, string>>(() => Parser.String(">=", true).Tag("keyword"));

        public static Lazy<IParser<CharToken, string>> _keyword_648759161_True =
          new Lazy<IParser<CharToken, string>>(() => Parser.String("!=", true).Tag("keyword"));

        public static Lazy<IParser<CharToken, string>> _keyword_234840654_True =
          new Lazy<IParser<CharToken, string>>(() => Parser.String("==", true).Tag("keyword"));

        public static Lazy<IParser<CharToken, string>> _keyword_2023765867_True =
          new Lazy<IParser<CharToken, string>>(() => Parser.String("&&", true).Tag("keyword"));

        public static Lazy<IParser<CharToken, string>> _keyword_1465882374_True =
          new Lazy<IParser<CharToken, string>>(() => Parser.String("||", true).Tag("keyword"));

        public static Lazy<IParser<CharToken, string>> _keyword_267266730_True =
          new Lazy<IParser<CharToken, string>>(() => Parser.String("char", true).Tag("keyword"));

        public static Lazy<IParser<CharToken, string>> _keyword_198818345_True =
          new Lazy<IParser<CharToken, string>>(() => Parser.String("short", true).Tag("keyword"));

        public static Lazy<IParser<CharToken, string>> _keyword_1989785454_True =
          new Lazy<IParser<CharToken, string>>(() => Parser.String("int", true).Tag("keyword"));

        public static Lazy<IParser<CharToken, string>> _keyword_2141776151_True =
          new Lazy<IParser<CharToken, string>>(() => Parser.String("long", true).Tag("keyword"));

        public static Lazy<IParser<CharToken, string>> _keyword_1839863353_True =
          new Lazy<IParser<CharToken, string>>(() => Parser.String("float", true).Tag("keyword"));

        public static Lazy<IParser<CharToken, string>> _keyword_1445956107_True =
          new Lazy<IParser<CharToken, string>>(() => Parser.String("double", true).Tag("keyword"));

        public static Lazy<IParser<CharToken, string>> _keyword_1612036129_True =
          new Lazy<IParser<CharToken, string>>(() => Parser.String("signed", true).Tag("keyword"));

        public static Lazy<IParser<CharToken, string>> _keyword_2100566772_True =
          new Lazy<IParser<CharToken, string>>(() => Parser.String("unsigned", true).Tag("keyword"));

        public static Lazy<IParser<CharToken, string>> _keyword_341812014_True =
          new Lazy<IParser<CharToken, string>>(() => Parser.String("++", true).Tag("keyword"));

        public static Lazy<IParser<CharToken, string>> _keyword_887370889_True =
          new Lazy<IParser<CharToken, string>>(() => Parser.String("--", true).Tag("keyword"));

        public static Lazy<IParser<CharToken, char>> _keyword_892025853_True =
          new Lazy<IParser<CharToken, char>>(() => Parser.Char('?', true).Tag("keyword"));

        public static Lazy<IParser<CharToken, char>> _keyword_1032055229_True =
          new Lazy<IParser<CharToken, char>>(() => Parser.Char(':', true).Tag("keyword"));

        public static Lazy<IParser<CharToken, char>> _keyword_310035264_True =
          new Lazy<IParser<CharToken, char>>(() => Parser.Char('*', true).Tag("keyword"));

        public static Lazy<IParser<CharToken, char>> _keyword_1742231173_True =
          new Lazy<IParser<CharToken, char>>(() => Parser.Char('/', true).Tag("keyword"));

        public static Lazy<IParser<CharToken, char>> _keyword_24331476_True =
          new Lazy<IParser<CharToken, char>>(() => Parser.Char('%', true).Tag("keyword"));

        public static Lazy<IParser<CharToken, char>> _keyword_1558930534_True =
          new Lazy<IParser<CharToken, char>>(() => Parser.Char('+', true).Tag("keyword"));

        public static Lazy<IParser<CharToken, char>> _keyword_740029763_True =
          new Lazy<IParser<CharToken, char>>(() => Parser.Char('-', true).Tag("keyword"));

        public static Lazy<IParser<CharToken, char>> _keyword_939787975_True =
          new Lazy<IParser<CharToken, char>>(() => Parser.Char('<', true).Tag("keyword"));

        public static Lazy<IParser<CharToken, char>> _keyword_2076602465_True =
          new Lazy<IParser<CharToken, char>>(() => Parser.Char('>', true).Tag("keyword"));

        public static Lazy<IParser<CharToken, char>> _keyword_282216391_True =
          new Lazy<IParser<CharToken, char>>(() => Parser.Char('&', true).Tag("keyword"));

        public static Lazy<IParser<CharToken, char>> _keyword_1167493674_True =
          new Lazy<IParser<CharToken, char>>(() => Parser.Char('^', true).Tag("keyword"));

        public static Lazy<IParser<CharToken, char>> _keyword_492696045_True =
          new Lazy<IParser<CharToken, char>>(() => Parser.Char('|', true).Tag("keyword"));

        public static Lazy<IParser<CharToken, char>> _keyword_1371525173_True =
          new Lazy<IParser<CharToken, char>>(() => Parser.Char('(', true).Tag("keyword"));

        public static Lazy<IParser<CharToken, char>> _keyword_1870961584_True =
          new Lazy<IParser<CharToken, char>>(() => Parser.Char(')', true).Tag("keyword"));

        public static Lazy<IParser<CharToken, char>> _keyword_844767463_True =
          new Lazy<IParser<CharToken, char>>(() => Parser.Char('!', true).Tag("keyword"));

        public static Lazy<IParser<CharToken, char>> _keyword_1028553605_True =
          new Lazy<IParser<CharToken, char>>(() => Parser.Char('~', true).Tag("keyword"));

        public static Lazy<IParser<CharToken, char>> _keyword_96864103_True =
          new Lazy<IParser<CharToken, char>>(() => Parser.Char(',', true).Tag("keyword"));

        public static Lazy<IParser<CharToken, char>> _keyword_1832448525_True =
          new Lazy<IParser<CharToken, char>>(() => Parser.Char('[', true).Tag("keyword"));

        public static Lazy<IParser<CharToken, char>> _keyword_846556041_True =
          new Lazy<IParser<CharToken, char>>(() => Parser.Char(']', true).Tag("keyword"));

        public static Lazy<IParser<CharToken, string>> _keyword_630856201_True =
          new Lazy<IParser<CharToken, string>>(() => Parser.Regex("[a-zA-Z_][a-zA-Z0-9_\\$]*", true).Cached(630856201).Tag("keyword"));

        public static Lazy<IParser<CharToken, string>> _keyword_702627102_True =
          new Lazy<IParser<CharToken, string>>(() => Parser.Regex("([0-9]*[.])?[0-9]+", true).Cached(702627102).Tag("keyword"));

        public static Lazy<IParser<CharToken, string>> _keyword_1786360725_True =
          new Lazy<IParser<CharToken, string>>(() => Parser.Regex("\"((?:\\\\.|[^\\\"])*)\"", true).Cached(1786360725).Tag("keyword"));



        public class NonTerminals
        {
            public const string expression = "expression";
            public const string conditional_expression = "conditional_expression";
            public const string expression_10 = "expression_10";
            public const string expression_10_many = "expression_10_many";
            public const string expression_9 = "expression_9";
            public const string expression_9_many = "expression_9_many";
            public const string expression_8 = "expression_8";
            public const string expression_8_many = "expression_8_many";
            public const string expression_7 = "expression_7";
            public const string expression_7_many = "expression_7_many";
            public const string expression_6 = "expression_6";
            public const string expression_6_many = "expression_6_many";
            public const string expression_5 = "expression_5";
            public const string expression_5_many = "expression_5_many";
            public const string expression_4 = "expression_4";
            public const string expression_4_many = "expression_4_many";
            public const string expression_3 = "expression_3";
            public const string expression_3_many = "expression_3_many";
            public const string expression_2 = "expression_2";
            public const string expression_2_many = "expression_2_many";
            public const string expression_1 = "expression_1";
            public const string expression_1_many = "expression_1_many";
            public const string binary_operator_1 = "binary_operator_1";
            public const string binary_operator_2 = "binary_operator_2";
            public const string binary_operator_3 = "binary_operator_3";
            public const string binary_operator_4 = "binary_operator_4";
            public const string binary_operator_5 = "binary_operator_5";
            public const string binary_operator_6 = "binary_operator_6";
            public const string binary_operator_7 = "binary_operator_7";
            public const string binary_operator_8 = "binary_operator_8";
            public const string binary_operator_9 = "binary_operator_9";
            public const string binary_operator_10 = "binary_operator_10";
            public const string expression_primary = "expression_primary";
            public const string cast_expression = "cast_expression";
            public const string unary_expression = "unary_expression";
            public const string primary = "primary";
            public const string arguments = "arguments";
            public const string postfix = "postfix";
            public const string prefix = "prefix";
            public const string types = "types";
            public const string type = "type";
            public const string unary_prefix_operator = "unary_prefix_operator";
            public const string unary_postfix_operator = "unary_postfix_operator";
            public const string variable = "variable";
            public const string number = "number";
            public const string @string = "string";
            public const string arguments_prefix = "arguments_prefix";
            public const string arguments_rest = "arguments_rest";
            public const string postfix_prefix = "postfix_prefix";
            public const string postfix_rest = "postfix_rest";
            public const string types_prefix = "types_prefix";
            public const string types_rest = "types_rest";

        }

    }
}