﻿namespace P4.TinyCell.Language.AbstractSyntaxTree.NumExpr;

public class SubExprNode(AstNode left, AstNode right) : BinExprNode(left, right)
{
    public override T Accept<T>(IAstVisitor<T> visitor)
    {
        return visitor.VisitSubExprNode(this);
    }
}
