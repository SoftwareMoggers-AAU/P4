﻿using P4.TinyCell.Language.AbstractSyntaxTree.ParameterNodes;
using P4.TinyCell.Language.AbstractSyntaxTree.Primitive;
using P4.TinyCell.Language.AbstractSyntaxTree.Statement;
using P4.TinyCell.Language.AbstractSyntaxTree.Types;

namespace P4.TinyCell.Language.AbstractSyntaxTree.Function;
public class FunctionDefinitionNode : AstNode
{
    public TypeNode Type { get; set; }
    public IdentifierNode Identifier { get; set; }
    public ParameterListNode ParameterList { get; set; }
    public StatementCollectionNode CompoundStatement { get; set; }
    public FunctionDefinitionNode(TypeNode type, IdentifierNode identifier, ParameterListNode parameterList, StatementCollectionNode compoundStatement)
    {
        Type = type;
        Identifier = identifier;
        ParameterList = parameterList;
        CompoundStatement = compoundStatement;

        AddChild(type);
        AddChild(identifier);
        AddChild(parameterList);
        AddChild(compoundStatement);
    }

    public override T Accept<T>(IAstVisitor<T> visitor)
    {
        return visitor.VisitFunctionDefinitionNode(this);
    }
}
