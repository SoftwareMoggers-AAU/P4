﻿using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Dfa;
using Antlr4.Runtime.Tree;
using Antlr4.Runtime.Sharpen;
using P4.TinyCell;
using P4.TinyCell.Shared.Language.AbstractSyntaxTree;
using P4.TinyCell.Shared.Language.RegisterAllocation;
using P4.TinyCell.Shared.Language.Typechecking;
using P4.TinyCell.Shared.Language.CodeGen;
using P4.TinyCell.Shared.Utilities;
using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        //ProgramHelper helper = new();
        //helper.GenerateAntlr();

        string fileContent = File.ReadAllText("Test.tc");

        var antlrInputStream = new AntlrInputStream(fileContent);

        var lexer = new TinyCellLexer(antlrInputStream);

        var tokenStream = new CommonTokenStream(lexer);

        var parser = new TinyCellParser(tokenStream);

        // parser.AddErrorListener(new ParserHelper.NoErrorListener());

        var tree = parser.document();
        tokenStream.Fill();

        var tokens = tokenStream.GetTokens();


        // var list = listener.scopes;
        // var graphs = new Dictionary<string, Graph<string>>();
        // var graphGenerator = new LivenessGraphGenerator();
        // foreach (var scope in list)
        // {
        //     var graph = graphGenerator.generateGraph(scope.Value);
        //     graphs.Add(scope.Key, graph);
        // }
        // var allocatedScopes = new Dictionary<string, Dictionary<string, string>>();
        // var registerAllocator = new StaticRegisterAllocator();
        // foreach (var scope in graphs)
        // {
        //     var graph = scope.Value;
        //     var groupings = registerAllocator.AllocateRegisters(graph.adjacencyList, 3);
        //     allocatedScopes.Add(scope.Key, groupings);
        // }

        Console.WriteLine("\n=================================================\n");
        Console.WriteLine("Tokens:");

        foreach (var token in tokens)
        {
            int tokenType = token.Type - 1;
            string ruleName = tokenType >= 0 && tokenType < TinyCellLexer.ruleNames.Length ? TinyCellLexer.ruleNames[tokenType] : "Unknown";
            Console.WriteLine(token + " | " + ruleName + " | " + token.Text);
        }

        Console.WriteLine("\n=================================================\n");
        Console.WriteLine("Parse Tree:");

        ParserHelper.PrintTree(tree);

        AstBuilderVisitor astBuilderVisitor = new();
        AstNode abcd = astBuilderVisitor.Visit(tree);

        LivenessAnalysisVisitor livenessAnalysisVisitor = new();
        livenessAnalysisVisitor.Visit(abcd);
        var list = livenessAnalysisVisitor.Scopes;
        var graphs = new Dictionary<string, Graph<string>>();
        var graphGenerator = new LivenessGraphGenerator();
        foreach (var scope in list)
        {
            var graph = graphGenerator.generateGraph(scope.Value);
            graphs.Add(scope.Key, graph);
        }
        var allocatedScopes = new Dictionary<string, Dictionary<string, string>>();
        var registerAllocator = new StaticRegisterAllocator();
        foreach (var scope in graphs)
        {
            var graph = scope.Value;
            var groupings = registerAllocator.AllocateRegisters(graph.adjacencyList, 9);
            allocatedScopes.Add(scope.Key, groupings);
        }


        // Console.WriteLine(abcd.ToString());

        // var typeChecker = new TypeCheckerVisitor();
        // typeChecker.Visit(abcd);

        // TestAstVisitor test = new();
        // test.VisitRootNode((RootNode)abcd);


        CGeneratorVisitor codeGen = new CGeneratorVisitor();
        string code = codeGen.VisitRootNode((RootNode)abcd);
        Console.WriteLine(code);
    }
}
