﻿namespace P4.TinyCell.AST;
public class DeclarationNode : AstNode
{
    public DeclarationNode(AstNode type, AstNode identifier)
    {
        AddChild(type);
        AddChild(identifier);
    }

    public DeclarationNode(AstNode type, AstNode identifier, AstNode action)
    {
        AddChild(type);
        AddChild(identifier);
        AddChild(action);
    }
}