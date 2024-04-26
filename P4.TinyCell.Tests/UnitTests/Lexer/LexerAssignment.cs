﻿using static P4.TinyCell.Tests.Utility;
using System.ComponentModel;

namespace P4.TinyCell.Tests;

public class LexerAssignment
{
    // Can handle a numeral assignment.
    [Fact]
    [Description("Can handle a numeral assignment")]
    public void LexerNumeralAssignment()
    {
        var input = "x = 5";
        var tokenTypes = GetTokenTypesFromInput(input);

        var expectedTokenTypes = new List<int>
        {
            TinyCellLexer.Identifier,
            TinyCellLexer.Whitespace,
            TinyCellLexer.ASSIGN,
            TinyCellLexer.Whitespace,
            TinyCellLexer.Numeral,
            TinyCellLexer.Eof
        };

        Assert.Equal(expectedTokenTypes, tokenTypes);
    }

    // Can handle a string assignment.
    [Fact]
    [Description("Can handle a string assignment")]
    public void LexerStringAssignment()
    {
        var input = "x = \"hello\"";
        var tokenTypes = GetTokenTypesFromInput(input);

        var expectedTokenTypes = new List<int>
        {
            TinyCellLexer.Identifier,
            TinyCellLexer.Whitespace,
            TinyCellLexer.ASSIGN,
            TinyCellLexer.Whitespace,
            TinyCellLexer.String,
            TinyCellLexer.Eof
        };

        Assert.Equal(expectedTokenTypes, tokenTypes);
    }

    // Can handle a boolean assignment.
    [Fact]
    [Description("Can handle a boolean assignment")]
    public void LexerBooleanAssignment()
    {
        var input = "x = true";
        var tokenTypes = GetTokenTypesFromInput(input);

        var expectedTokenTypes = new List<int>
        {
            TinyCellLexer.Identifier,
            TinyCellLexer.Whitespace,
            TinyCellLexer.ASSIGN,
            TinyCellLexer.Whitespace,
            TinyCellLexer.Bool,
            TinyCellLexer.Eof
        };

        Assert.Equal(expectedTokenTypes, tokenTypes);
    }

    // Can handle a function assignment.
    [Fact]
    [Description("Can handle a function assignment")]
    public void LexerFunctionAssignment()
    {
        var input = "x = func()";
        var tokenTypes = GetTokenTypesFromInput(input);

        var expectedTokenTypes = new List<int>
        {
            TinyCellLexer.Identifier,
            TinyCellLexer.Whitespace,
            TinyCellLexer.ASSIGN,
            TinyCellLexer.Whitespace,
            TinyCellLexer.Identifier,
            TinyCellLexer.LPAR,
            TinyCellLexer.RPAR,
            TinyCellLexer.Eof
        };

        Assert.Equal(expectedTokenTypes, tokenTypes);
    }

    // Can handle an expression assignment.
    [Fact]
    [Description("Can handle an expression assignment")]
    public void LexerExpressionAssignment()
    {
        var input = "x = 5 + 5";
        var tokenTypes = GetTokenTypesFromInput(input);

        var expectedTokenTypes = new List<int>
        {
            TinyCellLexer.Identifier,
            TinyCellLexer.Whitespace,
            TinyCellLexer.ASSIGN,
            TinyCellLexer.Whitespace,
            TinyCellLexer.Numeral,
            TinyCellLexer.Whitespace,
            TinyCellLexer.PLUS,
            TinyCellLexer.Whitespace,
            TinyCellLexer.Numeral,
            TinyCellLexer.Eof
        };

        Assert.Equal(expectedTokenTypes, tokenTypes);
    }

    // Can handle a unary expression assignment.
    [Fact]
    [Description("Can handle a unary expression assignment")]
    public void LexerUnaryExpressionAssignment()
    {
        var input = "x = -5";
        var tokenTypes = GetTokenTypesFromInput(input);

        var expectedTokenTypes = new List<int>
        {
            TinyCellLexer.Identifier,
            TinyCellLexer.Whitespace,
            TinyCellLexer.ASSIGN,
            TinyCellLexer.Whitespace,
            TinyCellLexer.Numeral,
            TinyCellLexer.Eof
        };

        Assert.Equal(expectedTokenTypes, tokenTypes);
    }

    // Can handle a multiplicative expression assignment.
    [Fact]
    [Description("Can handle a multiplicative expression assignment")]
    public void LexerMultiplicativeExpressionAssignment()
    {
        var input = "x = 5 * 5";
        var tokenTypes = GetTokenTypesFromInput(input);

        var expectedTokenTypes = new List<int>
        {
            TinyCellLexer.Identifier,
            TinyCellLexer.Whitespace,
            TinyCellLexer.ASSIGN,
            TinyCellLexer.Whitespace,
            TinyCellLexer.Numeral,
            TinyCellLexer.Whitespace,
            TinyCellLexer.MULT,
            TinyCellLexer.Whitespace,
            TinyCellLexer.Numeral,
            TinyCellLexer.Eof
        };

        Assert.Equal(expectedTokenTypes, tokenTypes);
    }

    // Can handle additive expression assignment.
    [Fact]
    [Description("Can handle additive expression assignment")]
    public void LexerAdditiveExpressionAssignment()
    {
        var input = "x = 5 + 5";
        var tokenTypes = GetTokenTypesFromInput(input);

        var expectedTokenTypes = new List<int>
        {
            TinyCellLexer.Identifier,
            TinyCellLexer.Whitespace,
            TinyCellLexer.ASSIGN,
            TinyCellLexer.Whitespace,
            TinyCellLexer.Numeral,
            TinyCellLexer.Whitespace,
            TinyCellLexer.PLUS,
            TinyCellLexer.Whitespace,
            TinyCellLexer.Numeral,
            TinyCellLexer.Eof
        };

        Assert.Equal(expectedTokenTypes, tokenTypes);
    }

    // Can handle bitshift expression assignment.
    [Fact]
    [Description("Can handle bitshift expression assignment")]
    public void LexerBitshiftExpressionAssignment()
    {
        var input = "x = 5 << 5";
        var tokenTypes = GetTokenTypesFromInput(input);

        var expectedTokenTypes = new List<int>
        {
            TinyCellLexer.Identifier,
            TinyCellLexer.Whitespace,
            TinyCellLexer.ASSIGN,
            TinyCellLexer.Whitespace,
            TinyCellLexer.Numeral,
            TinyCellLexer.Whitespace,
            TinyCellLexer.BITSHIFTL,
            TinyCellLexer.Whitespace,
            TinyCellLexer.Numeral,
            TinyCellLexer.Eof
        };

        Assert.Equal(expectedTokenTypes, tokenTypes);
    }
}
