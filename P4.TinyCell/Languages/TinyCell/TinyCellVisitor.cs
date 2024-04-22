//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from /home/rasmus/Documents/GitHub/P4/P4.TinyCell/Languages/TinyCell/TinyCell.g4 by ANTLR 4.13.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="TinyCellParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.1")]
[System.CLSCompliant(false)]
public interface ITinyCellVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="TinyCellParser.document"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDocument([NotNull] TinyCellParser.DocumentContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="TinyCellParser.generalDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGeneralDeclaration([NotNull] TinyCellParser.GeneralDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="TinyCellParser.setupDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSetupDefinition([NotNull] TinyCellParser.SetupDefinitionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="TinyCellParser.updateDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUpdateDefinition([NotNull] TinyCellParser.UpdateDefinitionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="TinyCellParser.functionDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionDefinition([NotNull] TinyCellParser.FunctionDefinitionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="TinyCellParser.type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitType([NotNull] TinyCellParser.TypeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="TinyCellParser.parameterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParameterList([NotNull] TinyCellParser.ParameterListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="TinyCellParser.parameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParameter([NotNull] TinyCellParser.ParameterContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="TinyCellParser.declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDeclaration([NotNull] TinyCellParser.DeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="TinyCellParser.initialDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInitialDeclaration([NotNull] TinyCellParser.InitialDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="TinyCellParser.compoundStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCompoundStatement([NotNull] TinyCellParser.CompoundStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="TinyCellParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStatement([NotNull] TinyCellParser.StatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="TinyCellParser.ifStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIfStatement([NotNull] TinyCellParser.IfStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="TinyCellParser.loopStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLoopStatement([NotNull] TinyCellParser.LoopStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="TinyCellParser.jumpStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitJumpStatement([NotNull] TinyCellParser.JumpStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="TinyCellParser.assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAssignment([NotNull] TinyCellParser.AssignmentContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="TinyCellParser.functionCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionCall([NotNull] TinyCellParser.FunctionCallContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="TinyCellParser.primitiveExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPrimitiveExpression([NotNull] TinyCellParser.PrimitiveExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="TinyCellParser.unaryExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUnaryExpression([NotNull] TinyCellParser.UnaryExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="TinyCellParser.multiplicativeExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMultiplicativeExpression([NotNull] TinyCellParser.MultiplicativeExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="TinyCellParser.additiveExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAdditiveExpression([NotNull] TinyCellParser.AdditiveExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="TinyCellParser.bitshiftExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBitshiftExpression([NotNull] TinyCellParser.BitshiftExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="TinyCellParser.comparisonExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitComparisonExpression([NotNull] TinyCellParser.ComparisonExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="TinyCellParser.equalityExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEqualityExpression([NotNull] TinyCellParser.EqualityExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="TinyCellParser.andExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAndExpression([NotNull] TinyCellParser.AndExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="TinyCellParser.orExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOrExpression([NotNull] TinyCellParser.OrExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="TinyCellParser.ternaryExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTernaryExpression([NotNull] TinyCellParser.TernaryExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="TinyCellParser.pinExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPinExpression([NotNull] TinyCellParser.PinExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="TinyCellParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpression([NotNull] TinyCellParser.ExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="TinyCellParser.identifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIdentifier([NotNull] TinyCellParser.IdentifierContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="TinyCellParser.assignmentOperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAssignmentOperator([NotNull] TinyCellParser.AssignmentOperatorContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="TinyCellParser.pinVoltage"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPinVoltage([NotNull] TinyCellParser.PinVoltageContext context);
}
