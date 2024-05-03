﻿namespace P4.TinyCell.Shared.Language.AbstractSyntaxTree.PinExpr;
public abstract class PinExprNode : AstNode
{
    public AstNode From { get; set; }
    public AstNode To { get; set; }

    public PinExprNode(AstNode from, AstNode to)
    {
        From = from;
        To = to;

        AddChild(from);
        AddChild(to);
    }
}