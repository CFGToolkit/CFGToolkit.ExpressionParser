using CFGToolkit.AST;
using CFGToolkit.ParserCombinator;
using CFGToolkit.ParserCombinator.Input;
using CFGToolkit.ParserCombinator.Values;
using CFGToolkit.ParserCombinator.Parsers;
using System;
using System.Collections.Generic;
using System.Threading;

namespace CFGToolkit.ExpressionParser.Languages.C
{
    public partial class ExpressionParser
    {
        public static Lazy<IParser<CharToken, SyntaxNode>> expression =
                  new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.Or("expression", parallel: false, Parser.Sequence<CharToken, SyntaxNode>("expression#0", (args) => CreateSyntaxNode(false, true, nameof(expression), args), new Lazy<IParser<CharToken>>(() => conditional_expression.Value)).Tag("index", "0"),
                   Parser.Sequence<CharToken, SyntaxNode>("expression#1", (args) => CreateSyntaxNode(false, true, nameof(expression), args), new Lazy<IParser<CharToken>>(() => expression_10.Value)).Tag("index", "1")).Tag("nt", NonTerminals.expression));

        public static Lazy<IParser<CharToken, SyntaxNode>> conditional_expression =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.Sequence<CharToken, SyntaxNode>("conditional_expression", (args) => CreateSyntaxNode(false, true, nameof(conditional_expression), args), new Lazy<IParser<CharToken>>(() => expression_10.Value), new Lazy<IParser<CharToken>>(() => _keyword_453364295_True.Value), new Lazy<IParser<CharToken>>(() => expression.Value), new Lazy<IParser<CharToken>>(() => _keyword_890725761_True.Value), new Lazy<IParser<CharToken>>(() => expression.Value)).Tag("index", "0").Tag("nt", NonTerminals.conditional_expression));

        public static Lazy<IParser<CharToken, SyntaxNode>> expression_10 =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.Sequence<CharToken, SyntaxNode>("expression_10", (args) => CreateSyntaxNode(false, true, nameof(expression_10), args), new Lazy<IParser<CharToken>>(() => expression_9.Value), new Lazy<IParser<CharToken>>(() => expression_10_many.Value.Many(greedy: true))).Tag("index", "0").Tag("nt", NonTerminals.expression_10));

        public static Lazy<IParser<CharToken, SyntaxNode>> expression_10_many =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.Sequence<CharToken, SyntaxNode>("expression_10_many", (args) => CreateSyntaxNode(false, true, nameof(expression_10_many), args), new Lazy<IParser<CharToken>>(() => binary_operator_10.Value), new Lazy<IParser<CharToken>>(() => expression_9.Value)).Tag("index", "0").Tag("First").Tag("First:0", "||").Tag("nt", NonTerminals.expression_10_many));

        public static Lazy<IParser<CharToken, SyntaxNode>> expression_9 =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.Sequence<CharToken, SyntaxNode>("expression_9", (args) => CreateSyntaxNode(false, true, nameof(expression_9), args), new Lazy<IParser<CharToken>>(() => expression_8.Value), new Lazy<IParser<CharToken>>(() => expression_9_many.Value.Many(greedy: true))).Tag("index", "0").Tag("nt", NonTerminals.expression_9));

        public static Lazy<IParser<CharToken, SyntaxNode>> expression_9_many =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.Sequence<CharToken, SyntaxNode>("expression_9_many", (args) => CreateSyntaxNode(false, true, nameof(expression_9_many), args), new Lazy<IParser<CharToken>>(() => binary_operator_9.Value), new Lazy<IParser<CharToken>>(() => expression_8.Value)).Tag("index", "0").Tag("First").Tag("First:0", "&&").Tag("nt", NonTerminals.expression_9_many));

        public static Lazy<IParser<CharToken, SyntaxNode>> expression_8 =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.Sequence<CharToken, SyntaxNode>("expression_8", (args) => CreateSyntaxNode(false, true, nameof(expression_8), args), new Lazy<IParser<CharToken>>(() => expression_7.Value), new Lazy<IParser<CharToken>>(() => expression_8_many.Value.Many(greedy: true))).Tag("index", "0").Tag("nt", NonTerminals.expression_8));

        public static Lazy<IParser<CharToken, SyntaxNode>> expression_8_many =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.Sequence<CharToken, SyntaxNode>("expression_8_many", (args) => CreateSyntaxNode(false, true, nameof(expression_8_many), args), new Lazy<IParser<CharToken>>(() => binary_operator_8.Value), new Lazy<IParser<CharToken>>(() => expression_7.Value)).Tag("index", "0").Tag("First").Tag("First:0", "|").Tag("nt", NonTerminals.expression_8_many));

        public static Lazy<IParser<CharToken, SyntaxNode>> expression_7 =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.Sequence<CharToken, SyntaxNode>("expression_7", (args) => CreateSyntaxNode(false, true, nameof(expression_7), args), new Lazy<IParser<CharToken>>(() => expression_6.Value), new Lazy<IParser<CharToken>>(() => expression_7_many.Value.Many(greedy: true))).Tag("index", "0").Tag("nt", NonTerminals.expression_7));

        public static Lazy<IParser<CharToken, SyntaxNode>> expression_7_many =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.Sequence<CharToken, SyntaxNode>("expression_7_many", (args) => CreateSyntaxNode(false, true, nameof(expression_7_many), args), new Lazy<IParser<CharToken>>(() => binary_operator_7.Value), new Lazy<IParser<CharToken>>(() => expression_6.Value)).Tag("index", "0").Tag("First").Tag("First:0", "^").Tag("nt", NonTerminals.expression_7_many));

        public static Lazy<IParser<CharToken, SyntaxNode>> expression_6 =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.Sequence<CharToken, SyntaxNode>("expression_6", (args) => CreateSyntaxNode(false, true, nameof(expression_6), args), new Lazy<IParser<CharToken>>(() => expression_5.Value), new Lazy<IParser<CharToken>>(() => expression_6_many.Value.Many(greedy: true))).Tag("index", "0").Tag("nt", NonTerminals.expression_6));

        public static Lazy<IParser<CharToken, SyntaxNode>> expression_6_many =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.Sequence<CharToken, SyntaxNode>("expression_6_many", (args) => CreateSyntaxNode(false, true, nameof(expression_6_many), args), new Lazy<IParser<CharToken>>(() => binary_operator_6.Value), new Lazy<IParser<CharToken>>(() => expression_5.Value)).Tag("index", "0").Tag("First").Tag("First:0", "&").Tag("nt", NonTerminals.expression_6_many));

        public static Lazy<IParser<CharToken, SyntaxNode>> expression_5 =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.Sequence<CharToken, SyntaxNode>("expression_5", (args) => CreateSyntaxNode(false, true, nameof(expression_5), args), new Lazy<IParser<CharToken>>(() => expression_4.Value), new Lazy<IParser<CharToken>>(() => expression_5_many.Value.Many(greedy: true))).Tag("index", "0").Tag("nt", NonTerminals.expression_5));

        public static Lazy<IParser<CharToken, SyntaxNode>> expression_5_many =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.Sequence<CharToken, SyntaxNode>("expression_5_many", (args) => CreateSyntaxNode(false, true, nameof(expression_5_many), args), new Lazy<IParser<CharToken>>(() => binary_operator_5.Value), new Lazy<IParser<CharToken>>(() => expression_4.Value)).Tag("index", "0").Tag("First").Tag("First:0", "!=").Tag("nt", NonTerminals.expression_5_many));

        public static Lazy<IParser<CharToken, SyntaxNode>> expression_4 =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.Sequence<CharToken, SyntaxNode>("expression_4", (args) => CreateSyntaxNode(false, true, nameof(expression_4), args), new Lazy<IParser<CharToken>>(() => expression_3.Value), new Lazy<IParser<CharToken>>(() => expression_4_many.Value.Many(greedy: true))).Tag("index", "0").Tag("nt", NonTerminals.expression_4));

        public static Lazy<IParser<CharToken, SyntaxNode>> expression_4_many =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.Sequence<CharToken, SyntaxNode>("expression_4_many", (args) => CreateSyntaxNode(false, true, nameof(expression_4_many), args), new Lazy<IParser<CharToken>>(() => binary_operator_4.Value), new Lazy<IParser<CharToken>>(() => expression_3.Value)).Tag("index", "0").Tag("First").Tag("First:0", "<=").Tag("nt", NonTerminals.expression_4_many));

        public static Lazy<IParser<CharToken, SyntaxNode>> expression_3 =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.Sequence<CharToken, SyntaxNode>("expression_3", (args) => CreateSyntaxNode(false, true, nameof(expression_3), args), new Lazy<IParser<CharToken>>(() => expression_2.Value), new Lazy<IParser<CharToken>>(() => expression_3_many.Value.Many(greedy: true))).Tag("index", "0").Tag("nt", NonTerminals.expression_3));

        public static Lazy<IParser<CharToken, SyntaxNode>> expression_3_many =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.Sequence<CharToken, SyntaxNode>("expression_3_many", (args) => CreateSyntaxNode(false, true, nameof(expression_3_many), args), new Lazy<IParser<CharToken>>(() => binary_operator_3.Value), new Lazy<IParser<CharToken>>(() => expression_2.Value)).Tag("index", "0").Tag("First").Tag("First:0", "<<").Tag("nt", NonTerminals.expression_3_many));

        public static Lazy<IParser<CharToken, SyntaxNode>> expression_2 =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.Sequence<CharToken, SyntaxNode>("expression_2", (args) => CreateSyntaxNode(false, true, nameof(expression_2), args), new Lazy<IParser<CharToken>>(() => expression_1.Value), new Lazy<IParser<CharToken>>(() => expression_2_many.Value.Many(greedy: true))).Tag("index", "0").Tag("nt", NonTerminals.expression_2));

        public static Lazy<IParser<CharToken, SyntaxNode>> expression_2_many =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.Sequence<CharToken, SyntaxNode>("expression_2_many", (args) => CreateSyntaxNode(false, true, nameof(expression_2_many), args), new Lazy<IParser<CharToken>>(() => binary_operator_2.Value), new Lazy<IParser<CharToken>>(() => expression_1.Value)).Tag("index", "0").Tag("First").Tag("First:0", "+").Tag("nt", NonTerminals.expression_2_many));

        public static Lazy<IParser<CharToken, SyntaxNode>> expression_1 =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.Sequence<CharToken, SyntaxNode>("expression_1", (args) => CreateSyntaxNode(false, true, nameof(expression_1), args), new Lazy<IParser<CharToken>>(() => expression_primary.Value), new Lazy<IParser<CharToken>>(() => expression_1_many.Value.Many(greedy: true))).Tag("index", "0").Tag("nt", NonTerminals.expression_1));

        public static Lazy<IParser<CharToken, SyntaxNode>> expression_1_many =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.Sequence<CharToken, SyntaxNode>("expression_1_many", (args) => CreateSyntaxNode(false, true, nameof(expression_1_many), args), new Lazy<IParser<CharToken>>(() => binary_operator_1.Value), new Lazy<IParser<CharToken>>(() => expression_primary.Value)).Tag("index", "0").Tag("First").Tag("First:0", "*").Tag("nt", NonTerminals.expression_1_many));

        public static Lazy<IParser<CharToken, SyntaxNode>> binary_operator_1 =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.XOr("binary_operator_1", first: true, parallelMode: XOrParallelMode.None, Parser.Sequence<CharToken, SyntaxNode>("binary_operator_1#0", (args) => CreateSyntaxNode(false, true, nameof(binary_operator_1), args), new Lazy<IParser<CharToken>>(() => _keyword_1201781781_True.Value)).Tag("index", "0"),
           Parser.Sequence<CharToken, SyntaxNode>("binary_operator_1#1", (args) => CreateSyntaxNode(false, true, nameof(binary_operator_1), args), new Lazy<IParser<CharToken>>(() => _keyword_1381577406_True.Value)).Tag("index", "1"),
           Parser.Sequence<CharToken, SyntaxNode>("binary_operator_1#2", (args) => CreateSyntaxNode(false, true, nameof(binary_operator_1), args), new Lazy<IParser<CharToken>>(() => _keyword_1981836147_True.Value)).Tag("index", "2")).Tag("xor").Tag("priority", "1").Tag("operator").Tag("First").Tag("First:0", "*").Tag("First:1", "/").Tag("First:2", "%").Tag("nt", NonTerminals.binary_operator_1));

        public static Lazy<IParser<CharToken, SyntaxNode>> binary_operator_2 =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.XOr("binary_operator_2", first: true, parallelMode: XOrParallelMode.None, Parser.Sequence<CharToken, SyntaxNode>("binary_operator_2#0", (args) => CreateSyntaxNode(false, true, nameof(binary_operator_2), args), new Lazy<IParser<CharToken>>(() => _keyword_1219070517_True.Value)).Tag("index", "0"),
           Parser.Sequence<CharToken, SyntaxNode>("binary_operator_2#1", (args) => CreateSyntaxNode(false, true, nameof(binary_operator_2), args), new Lazy<IParser<CharToken>>(() => _keyword_2002820254_True.Value)).Tag("index", "1")).Tag("xor").Tag("priority", "2").Tag("operator").Tag("First").Tag("First:0", "+").Tag("First:1", "-").Tag("nt", NonTerminals.binary_operator_2));

        public static Lazy<IParser<CharToken, SyntaxNode>> binary_operator_3 =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.XOr("binary_operator_3", first: true, parallelMode: XOrParallelMode.None, Parser.Sequence<CharToken, SyntaxNode>("binary_operator_3#0", (args) => CreateSyntaxNode(false, true, nameof(binary_operator_3), args), new Lazy<IParser<CharToken>>(() => _keyword_1350007203_True.Value)).Tag("index", "0"),
           Parser.Sequence<CharToken, SyntaxNode>("binary_operator_3#1", (args) => CreateSyntaxNode(false, true, nameof(binary_operator_3), args), new Lazy<IParser<CharToken>>(() => _keyword_1947704720_True.Value)).Tag("index", "1")).Tag("xor").Tag("priority", "3").Tag("operator").Tag("First").Tag("First:0", "<<").Tag("First:1", ">>").Tag("nt", NonTerminals.binary_operator_3));

        public static Lazy<IParser<CharToken, SyntaxNode>> binary_operator_4 =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.XOr("binary_operator_4", first: true, parallelMode: XOrParallelMode.None, Parser.Sequence<CharToken, SyntaxNode>("binary_operator_4#0", (args) => CreateSyntaxNode(false, true, nameof(binary_operator_4), args), new Lazy<IParser<CharToken>>(() => _keyword_1365569967_True.Value)).Tag("index", "0"),
           Parser.Sequence<CharToken, SyntaxNode>("binary_operator_4#1", (args) => CreateSyntaxNode(false, true, nameof(binary_operator_4), args), new Lazy<IParser<CharToken>>(() => _keyword_809761583_True.Value)).Tag("index", "1"),
           Parser.Sequence<CharToken, SyntaxNode>("binary_operator_4#2", (args) => CreateSyntaxNode(false, true, nameof(binary_operator_4), args), new Lazy<IParser<CharToken>>(() => _keyword_222898273_True.Value)).Tag("index", "2"),
           Parser.Sequence<CharToken, SyntaxNode>("binary_operator_4#3", (args) => CreateSyntaxNode(false, true, nameof(binary_operator_4), args), new Lazy<IParser<CharToken>>(() => _keyword_701867068_True.Value)).Tag("index", "3")).Tag("xor").Tag("priority", "4").Tag("operator").Tag("First").Tag("First:0", "<=").Tag("First:1", ">=").Tag("First:2", "<").Tag("First:3", ">").Tag("nt", NonTerminals.binary_operator_4));

        public static Lazy<IParser<CharToken, SyntaxNode>> binary_operator_5 =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.XOr("binary_operator_5", first: true, parallelMode: XOrParallelMode.None, Parser.Sequence<CharToken, SyntaxNode>("binary_operator_5#0", (args) => CreateSyntaxNode(false, true, nameof(binary_operator_5), args), new Lazy<IParser<CharToken>>(() => _keyword_290000757_True.Value)).Tag("index", "0"),
           Parser.Sequence<CharToken, SyntaxNode>("binary_operator_5#1", (args) => CreateSyntaxNode(false, true, nameof(binary_operator_5), args), new Lazy<IParser<CharToken>>(() => _keyword_49424749_True.Value)).Tag("index", "1")).Tag("xor").Tag("priority", "5").Tag("operator").Tag("First").Tag("First:0", "!=").Tag("First:1", "==").Tag("nt", NonTerminals.binary_operator_5));

        public static Lazy<IParser<CharToken, SyntaxNode>> binary_operator_6 =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.Sequence<CharToken, SyntaxNode>("binary_operator_6", (args) => CreateSyntaxNode(false, true, nameof(binary_operator_6), args), new Lazy<IParser<CharToken>>(() => _keyword_395310680_True.Value)).Tag("index", "0").Tag("priority", "6").Tag("operator").Tag("First").Tag("First:0", "&").Tag("nt", NonTerminals.binary_operator_6));

        public static Lazy<IParser<CharToken, SyntaxNode>> binary_operator_7 =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.Sequence<CharToken, SyntaxNode>("binary_operator_7", (args) => CreateSyntaxNode(false, true, nameof(binary_operator_7), args), new Lazy<IParser<CharToken>>(() => _keyword_1782216587_True.Value)).Tag("index", "0").Tag("priority", "7").Tag("operator").Tag("First").Tag("First:0", "^").Tag("nt", NonTerminals.binary_operator_7));

        public static Lazy<IParser<CharToken, SyntaxNode>> binary_operator_8 =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.Sequence<CharToken, SyntaxNode>("binary_operator_8", (args) => CreateSyntaxNode(false, true, nameof(binary_operator_8), args), new Lazy<IParser<CharToken>>(() => _keyword_247263457_True.Value)).Tag("index", "0").Tag("priority", "8").Tag("operator").Tag("First").Tag("First:0", "|").Tag("nt", NonTerminals.binary_operator_8));

        public static Lazy<IParser<CharToken, SyntaxNode>> binary_operator_9 =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.Sequence<CharToken, SyntaxNode>("binary_operator_9", (args) => CreateSyntaxNode(false, true, nameof(binary_operator_9), args), new Lazy<IParser<CharToken>>(() => _keyword_883163864_True.Value)).Tag("index", "0").Tag("priority", "9").Tag("operator").Tag("First").Tag("First:0", "&&").Tag("nt", NonTerminals.binary_operator_9));

        public static Lazy<IParser<CharToken, SyntaxNode>> binary_operator_10 =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.Sequence<CharToken, SyntaxNode>("binary_operator_10", (args) => CreateSyntaxNode(false, true, nameof(binary_operator_10), args), new Lazy<IParser<CharToken>>(() => _keyword_640633024_True.Value)).Tag("index", "0").Tag("primary", "10").Tag("operator").Tag("First").Tag("First:0", "||").Tag("nt", NonTerminals.binary_operator_10));

        public static Lazy<IParser<CharToken, SyntaxNode>> expression_primary =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.XOr("expression_primary", first: false, parallelMode: XOrParallelMode.None, Parser.Sequence<CharToken, SyntaxNode>("expression_primary#0", (args) => CreateSyntaxNode(false, true, nameof(expression_primary), args), new Lazy<IParser<CharToken>>(() => primary.Value), new Lazy<IParser<CharToken>>(() => unary_postfix_operator.Value)).Tag("index", "0"),
           Parser.Sequence<CharToken, SyntaxNode>("expression_primary#1", (args) => CreateSyntaxNode(false, true, nameof(expression_primary), args), new Lazy<IParser<CharToken>>(() => primary.Value)).Tag("index", "1"),
           Parser.Sequence<CharToken, SyntaxNode>("expression_primary#2", (args) => CreateSyntaxNode(false, true, nameof(expression_primary), args), new Lazy<IParser<CharToken>>(() => unary_prefix_operator.Value), new Lazy<IParser<CharToken>>(() => primary.Value)).Tag("index", "2")).Tag("xor").Tag("nt", NonTerminals.expression_primary));

        public static Lazy<IParser<CharToken, SyntaxNode>> primary =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.XOr("primary", first: false, parallelMode: XOrParallelMode.None, Parser.Sequence<CharToken, SyntaxNode>("primary#0", (args) => CreateSyntaxNode(false, true, nameof(primary), args), new Lazy<IParser<CharToken>>(() => number.Value)).Tag("index", "0"),
           Parser.Sequence<CharToken, SyntaxNode>("primary#1", (args) => CreateSyntaxNode(false, true, nameof(primary), args), new Lazy<IParser<CharToken>>(() => variable.Value), new Lazy<IParser<CharToken>>(() => _keyword_1377182076_True.Value), new Lazy<IParser<CharToken>>(() => expression.Value), new Lazy<IParser<CharToken>>(() => _keyword_1845180290_True.Value)).Tag("index", "1"),
           Parser.Sequence<CharToken, SyntaxNode>("primary#2", (args) => CreateSyntaxNode(false, true, nameof(primary), args), new Lazy<IParser<CharToken>>(() => variable.Value)).Tag("index", "2"),
           Parser.Sequence<CharToken, SyntaxNode>("primary#3", (args) => CreateSyntaxNode(false, true, nameof(primary), args), new Lazy<IParser<CharToken>>(() => _keyword_1544281697_True.Value), new Lazy<IParser<CharToken>>(() => typename.Value), new Lazy<IParser<CharToken>>(() => _keyword_1555796783_True.Value), new Lazy<IParser<CharToken>>(() => primary.Value)).Tag("index", "3"),
           Parser.Sequence<CharToken, SyntaxNode>("primary#4", (args) => CreateSyntaxNode(false, true, nameof(primary), args), new Lazy<IParser<CharToken>>(() => _keyword_1544281697_True.Value), new Lazy<IParser<CharToken>>(() => expression.Value), new Lazy<IParser<CharToken>>(() => _keyword_1555796783_True.Value)).Tag("index", "4")).Tag("xor").Tag("nt", NonTerminals.primary));

        public static Lazy<IParser<CharToken, SyntaxNode>> typename =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.XOr("typename", first: true, parallelMode: XOrParallelMode.None, Parser.Sequence<CharToken, SyntaxNode>("typename#0", (args) => CreateSyntaxNode(false, true, nameof(typename), args), new Lazy<IParser<CharToken>>(() => _keyword_932670183_True.Value)).Tag("index", "0"),
           Parser.Sequence<CharToken, SyntaxNode>("typename#1", (args) => CreateSyntaxNode(false, true, nameof(typename), args), new Lazy<IParser<CharToken>>(() => _keyword_2049219608_True.Value)).Tag("index", "1"),
           Parser.Sequence<CharToken, SyntaxNode>("typename#2", (args) => CreateSyntaxNode(false, true, nameof(typename), args), new Lazy<IParser<CharToken>>(() => _keyword_419510180_True.Value)).Tag("index", "2"),
           Parser.Sequence<CharToken, SyntaxNode>("typename#3", (args) => CreateSyntaxNode(false, true, nameof(typename), args), new Lazy<IParser<CharToken>>(() => _keyword_691105691_True.Value)).Tag("index", "3"),
           Parser.Sequence<CharToken, SyntaxNode>("typename#4", (args) => CreateSyntaxNode(false, true, nameof(typename), args), new Lazy<IParser<CharToken>>(() => _keyword_1474072660_True.Value)).Tag("index", "4"),
           Parser.Sequence<CharToken, SyntaxNode>("typename#5", (args) => CreateSyntaxNode(false, true, nameof(typename), args), new Lazy<IParser<CharToken>>(() => _keyword_536339479_True.Value)).Tag("index", "5")).Tag("xor").Tag("First").Tag("First:0", "char").Tag("First:1", "short").Tag("First:2", "int").Tag("First:3", "long").Tag("First:4", "float").Tag("First:5", "double").Tag("nt", NonTerminals.typename));

        public static Lazy<IParser<CharToken, SyntaxNode>> unary_prefix_operator =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.XOr("unary_prefix_operator", first: true, parallelMode: XOrParallelMode.None, Parser.Sequence<CharToken, SyntaxNode>("unary_prefix_operator#0", (args) => CreateSyntaxNode(false, true, nameof(unary_prefix_operator), args), new Lazy<IParser<CharToken>>(() => _keyword_2130620168_True.Value)).Tag("index", "0"),
           Parser.Sequence<CharToken, SyntaxNode>("unary_prefix_operator#1", (args) => CreateSyntaxNode(false, true, nameof(unary_prefix_operator), args), new Lazy<IParser<CharToken>>(() => _keyword_393655817_True.Value)).Tag("index", "1"),
           Parser.Sequence<CharToken, SyntaxNode>("unary_prefix_operator#2", (args) => CreateSyntaxNode(false, true, nameof(unary_prefix_operator), args), new Lazy<IParser<CharToken>>(() => _keyword_1219070517_True.Value)).Tag("index", "2"),
           Parser.Sequence<CharToken, SyntaxNode>("unary_prefix_operator#3", (args) => CreateSyntaxNode(false, true, nameof(unary_prefix_operator), args), new Lazy<IParser<CharToken>>(() => _keyword_2002820254_True.Value)).Tag("index", "3"),
           Parser.Sequence<CharToken, SyntaxNode>("unary_prefix_operator#4", (args) => CreateSyntaxNode(false, true, nameof(unary_prefix_operator), args), new Lazy<IParser<CharToken>>(() => _keyword_1624898732_True.Value)).Tag("index", "4"),
           Parser.Sequence<CharToken, SyntaxNode>("unary_prefix_operator#5", (args) => CreateSyntaxNode(false, true, nameof(unary_prefix_operator), args), new Lazy<IParser<CharToken>>(() => _keyword_369351100_True.Value)).Tag("index", "5")).Tag("xor").Tag("operator").Tag("First").Tag("First:0", "++").Tag("First:1", "--").Tag("First:2", "+").Tag("First:3", "-").Tag("First:4", "!").Tag("First:5", "~").Tag("nt", NonTerminals.unary_prefix_operator));

        public static Lazy<IParser<CharToken, SyntaxNode>> unary_postfix_operator =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.XOr("unary_postfix_operator", first: true, parallelMode: XOrParallelMode.None, Parser.Sequence<CharToken, SyntaxNode>("unary_postfix_operator#0", (args) => CreateSyntaxNode(false, true, nameof(unary_postfix_operator), args), new Lazy<IParser<CharToken>>(() => _keyword_2130620168_True.Value)).Tag("index", "0"),
           Parser.Sequence<CharToken, SyntaxNode>("unary_postfix_operator#1", (args) => CreateSyntaxNode(false, true, nameof(unary_postfix_operator), args), new Lazy<IParser<CharToken>>(() => _keyword_393655817_True.Value)).Tag("index", "1")).Tag("xor").Tag("operator").Tag("First").Tag("First:0", "++").Tag("First:1", "--").Tag("nt", NonTerminals.unary_postfix_operator));

        public static Lazy<IParser<CharToken, SyntaxNode>> variable =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.Sequence<CharToken, SyntaxNode>("variable", (args) => CreateSyntaxNode(false, true, nameof(variable), args), new Lazy<IParser<CharToken>>(() => _keyword_157442893_True.Value)).Tag("index", "0").Tag("pattern").Tag("nt", NonTerminals.variable));

        public static Lazy<IParser<CharToken, SyntaxNode>> number =
          new Lazy<IParser<CharToken, SyntaxNode>>(() => Parser.Sequence<CharToken, SyntaxNode>("number", (args) => CreateSyntaxNode(false, true, nameof(number), args), new Lazy<IParser<CharToken>>(() => _keyword_608521323_True.Value)).Tag("index", "0").Tag("pattern").Tag("nt", NonTerminals.number));

        public static Lazy<IParser<CharToken, string>> _keyword_1350007203_True =
          new Lazy<IParser<CharToken, string>>(() => Parser.String("<<", true).Tag("keyword"));

        public static Lazy<IParser<CharToken, string>> _keyword_1947704720_True =
          new Lazy<IParser<CharToken, string>>(() => Parser.String(">>", true).Tag("keyword"));

        public static Lazy<IParser<CharToken, string>> _keyword_1365569967_True =
          new Lazy<IParser<CharToken, string>>(() => Parser.String("<=", true).Tag("keyword"));

        public static Lazy<IParser<CharToken, string>> _keyword_809761583_True =
          new Lazy<IParser<CharToken, string>>(() => Parser.String(">=", true).Tag("keyword"));

        public static Lazy<IParser<CharToken, string>> _keyword_290000757_True =
          new Lazy<IParser<CharToken, string>>(() => Parser.String("!=", true).Tag("keyword"));

        public static Lazy<IParser<CharToken, string>> _keyword_49424749_True =
          new Lazy<IParser<CharToken, string>>(() => Parser.String("==", true).Tag("keyword"));

        public static Lazy<IParser<CharToken, string>> _keyword_883163864_True =
          new Lazy<IParser<CharToken, string>>(() => Parser.String("&&", true).Tag("keyword"));

        public static Lazy<IParser<CharToken, string>> _keyword_640633024_True =
          new Lazy<IParser<CharToken, string>>(() => Parser.String("||", true).Tag("keyword"));

        public static Lazy<IParser<CharToken, string>> _keyword_932670183_True =
          new Lazy<IParser<CharToken, string>>(() => Parser.String("char", true).Tag("keyword"));

        public static Lazy<IParser<CharToken, string>> _keyword_2049219608_True =
          new Lazy<IParser<CharToken, string>>(() => Parser.String("short", true).Tag("keyword"));

        public static Lazy<IParser<CharToken, string>> _keyword_419510180_True =
          new Lazy<IParser<CharToken, string>>(() => Parser.String("int", true).Tag("keyword"));

        public static Lazy<IParser<CharToken, string>> _keyword_691105691_True =
          new Lazy<IParser<CharToken, string>>(() => Parser.String("long", true).Tag("keyword"));

        public static Lazy<IParser<CharToken, string>> _keyword_1474072660_True =
          new Lazy<IParser<CharToken, string>>(() => Parser.String("float", true).Tag("keyword"));

        public static Lazy<IParser<CharToken, string>> _keyword_536339479_True =
          new Lazy<IParser<CharToken, string>>(() => Parser.String("double", true).Tag("keyword"));

        public static Lazy<IParser<CharToken, string>> _keyword_2130620168_True =
          new Lazy<IParser<CharToken, string>>(() => Parser.String("++", true).Tag("keyword"));

        public static Lazy<IParser<CharToken, string>> _keyword_393655817_True =
          new Lazy<IParser<CharToken, string>>(() => Parser.String("--", true).Tag("keyword"));

        public static Lazy<IParser<CharToken, char>> _keyword_453364295_True =
          new Lazy<IParser<CharToken, char>>(() => Parser.Char('?', true).Tag("keyword"));

        public static Lazy<IParser<CharToken, char>> _keyword_890725761_True =
          new Lazy<IParser<CharToken, char>>(() => Parser.Char(':', true).Tag("keyword"));

        public static Lazy<IParser<CharToken, char>> _keyword_1201781781_True =
          new Lazy<IParser<CharToken, char>>(() => Parser.Char('*', true).Tag("keyword"));

        public static Lazy<IParser<CharToken, char>> _keyword_1381577406_True =
          new Lazy<IParser<CharToken, char>>(() => Parser.Char('/', true).Tag("keyword"));

        public static Lazy<IParser<CharToken, char>> _keyword_1981836147_True =
          new Lazy<IParser<CharToken, char>>(() => Parser.Char('%', true).Tag("keyword"));

        public static Lazy<IParser<CharToken, char>> _keyword_1219070517_True =
          new Lazy<IParser<CharToken, char>>(() => Parser.Char('+', true).Tag("keyword"));

        public static Lazy<IParser<CharToken, char>> _keyword_2002820254_True =
          new Lazy<IParser<CharToken, char>>(() => Parser.Char('-', true).Tag("keyword"));

        public static Lazy<IParser<CharToken, char>> _keyword_222898273_True =
          new Lazy<IParser<CharToken, char>>(() => Parser.Char('<', true).Tag("keyword"));

        public static Lazy<IParser<CharToken, char>> _keyword_701867068_True =
          new Lazy<IParser<CharToken, char>>(() => Parser.Char('>', true).Tag("keyword"));

        public static Lazy<IParser<CharToken, char>> _keyword_395310680_True =
          new Lazy<IParser<CharToken, char>>(() => Parser.Char('&', true).Tag("keyword"));

        public static Lazy<IParser<CharToken, char>> _keyword_1782216587_True =
          new Lazy<IParser<CharToken, char>>(() => Parser.Char('^', true).Tag("keyword"));

        public static Lazy<IParser<CharToken, char>> _keyword_247263457_True =
          new Lazy<IParser<CharToken, char>>(() => Parser.Char('|', true).Tag("keyword"));

        public static Lazy<IParser<CharToken, char>> _keyword_1377182076_True =
          new Lazy<IParser<CharToken, char>>(() => Parser.Char('[', true).Tag("keyword"));

        public static Lazy<IParser<CharToken, char>> _keyword_1845180290_True =
          new Lazy<IParser<CharToken, char>>(() => Parser.Char(']', true).Tag("keyword"));

        public static Lazy<IParser<CharToken, char>> _keyword_1544281697_True =
          new Lazy<IParser<CharToken, char>>(() => Parser.Char('(', true).Tag("keyword"));

        public static Lazy<IParser<CharToken, char>> _keyword_1555796783_True =
          new Lazy<IParser<CharToken, char>>(() => Parser.Char(')', true).Tag("keyword"));

        public static Lazy<IParser<CharToken, char>> _keyword_1624898732_True =
          new Lazy<IParser<CharToken, char>>(() => Parser.Char('!', true).Tag("keyword"));

        public static Lazy<IParser<CharToken, char>> _keyword_369351100_True =
          new Lazy<IParser<CharToken, char>>(() => Parser.Char('~', true).Tag("keyword"));

        public static Lazy<IParser<CharToken, string>> _keyword_157442893_True =
          new Lazy<IParser<CharToken, string>>(() => Parser.Regex("[a-zA-Z_][a-zA-Z0-9_\\$]*", true).Cached(157442893).Tag("keyword"));

        public static Lazy<IParser<CharToken, string>> _keyword_608521323_True =
          new Lazy<IParser<CharToken, string>>(() => Parser.Regex("([0-9]*[.])?[0-9]+", true).Cached(608521323).Tag("keyword"));



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
            public const string primary = "primary";
            public const string typename = "typename";
            public const string unary_prefix_operator = "unary_prefix_operator";
            public const string unary_postfix_operator = "unary_postfix_operator";
            public const string variable = "variable";
            public const string number = "number";

        }
    }
}