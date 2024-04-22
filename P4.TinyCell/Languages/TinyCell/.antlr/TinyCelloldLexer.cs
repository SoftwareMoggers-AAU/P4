//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from /Users/emilpriv/Desktop/Git-Clones/P4/P4.TinyCell/Languages/TinyCell/TinyCell.g4 by ANTLR 4.13.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.1")]
[System.CLSCompliant(false)]
public partial class TinyCelloldLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		VOLHIGH=1, VOLLOW=2, PIN=3, INT=4, FLOAT=5, STRING=6, BOOL=7, VOID=8, 
		CHAR=9, UPDATE=10, SETUP=11, SET=12, TO=13, IF=14, ELSE=15, WHILE=16, 
		FOR=17, CONTINUE=18, BREAK=19, RETURN=20, QUESTION=21, LPAR=22, RPAR=23, 
		LCURLY=24, RCURLY=25, LBRACKET=26, RBRACKET=27, SEMI=28, DOT=29, COMMA=30, 
		COLON=31, NEWLINE=32, ASSIGN=33, PLUSASSIGN=34, MULTASSIGN=35, DIVASSIGN=36, 
		MODASSIGN=37, MINUSASSIGN=38, QUOTE=39, MULT=40, DIV=41, PLUS=42, MINUS=43, 
		MOD=44, AND=45, OR=46, EQ=47, NEQ=48, GT=49, LT=50, GTE=51, LTE=52, NOT=53, 
		BITSHIFTL=54, BITSHIFTR=55, UNARYPLUS=56, UNARYMINUS=57, Identifier=58, 
		String=59, Numeral=60, Whitespace=61, Newline=62;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"VOLHIGH", "VOLLOW", "PIN", "INT", "FLOAT", "STRING", "BOOL", "VOID", 
		"CHAR", "UPDATE", "SETUP", "SET", "TO", "IF", "ELSE", "WHILE", "FOR", 
		"CONTINUE", "BREAK", "RETURN", "QUESTION", "LPAR", "RPAR", "LCURLY", "RCURLY", 
		"LBRACKET", "RBRACKET", "SEMI", "DOT", "COMMA", "COLON", "NEWLINE", "ASSIGN", 
		"PLUSASSIGN", "MULTASSIGN", "DIVASSIGN", "MODASSIGN", "MINUSASSIGN", "QUOTE", 
		"MULT", "DIV", "PLUS", "MINUS", "MOD", "AND", "OR", "EQ", "NEQ", "GT", 
		"LT", "GTE", "LTE", "NOT", "BITSHIFTL", "BITSHIFTR", "UNARYPLUS", "UNARYMINUS", 
		"Identifier", "String", "Numeral", "Whitespace", "Newline"
	};


	public TinyCelloldLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public TinyCelloldLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'high'", "'low'", "'pin'", "'int'", "'float'", "'string'", "'bool'", 
		"'void'", "'char'", "'update'", "'setup'", "'set'", "'to'", "'if'", "'else'", 
		"'while'", "'for'", "'continue'", "'break'", "'return'", "'?'", "'('", 
		"')'", "'{'", "'}'", "'['", "']'", "';'", "'.'", "','", "':'", "'\\n'", 
		"'='", "'+='", "'*='", "'/='", "'%='", "'-='", "'\"'", "'*'", "'/'", "'+'", 
		"'-'", "'%'", "'&&'", "'||'", "'=='", "'!='", "'>'", "'<'", "'>='", "'<='", 
		"'!'", "'<<'", "'>>'", "'++'", "'--'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "VOLHIGH", "VOLLOW", "PIN", "INT", "FLOAT", "STRING", "BOOL", "VOID", 
		"CHAR", "UPDATE", "SETUP", "SET", "TO", "IF", "ELSE", "WHILE", "FOR", 
		"CONTINUE", "BREAK", "RETURN", "QUESTION", "LPAR", "RPAR", "LCURLY", "RCURLY", 
		"LBRACKET", "RBRACKET", "SEMI", "DOT", "COMMA", "COLON", "NEWLINE", "ASSIGN", 
		"PLUSASSIGN", "MULTASSIGN", "DIVASSIGN", "MODASSIGN", "MINUSASSIGN", "QUOTE", 
		"MULT", "DIV", "PLUS", "MINUS", "MOD", "AND", "OR", "EQ", "NEQ", "GT", 
		"LT", "GTE", "LTE", "NOT", "BITSHIFTL", "BITSHIFTR", "UNARYPLUS", "UNARYMINUS", 
		"Identifier", "String", "Numeral", "Whitespace", "Newline"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "TinyCell.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static TinyCelloldLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static int[] _serializedATN = {
		4,0,62,371,6,-1,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,
		6,2,7,7,7,2,8,7,8,2,9,7,9,2,10,7,10,2,11,7,11,2,12,7,12,2,13,7,13,2,14,
		7,14,2,15,7,15,2,16,7,16,2,17,7,17,2,18,7,18,2,19,7,19,2,20,7,20,2,21,
		7,21,2,22,7,22,2,23,7,23,2,24,7,24,2,25,7,25,2,26,7,26,2,27,7,27,2,28,
		7,28,2,29,7,29,2,30,7,30,2,31,7,31,2,32,7,32,2,33,7,33,2,34,7,34,2,35,
		7,35,2,36,7,36,2,37,7,37,2,38,7,38,2,39,7,39,2,40,7,40,2,41,7,41,2,42,
		7,42,2,43,7,43,2,44,7,44,2,45,7,45,2,46,7,46,2,47,7,47,2,48,7,48,2,49,
		7,49,2,50,7,50,2,51,7,51,2,52,7,52,2,53,7,53,2,54,7,54,2,55,7,55,2,56,
		7,56,2,57,7,57,2,58,7,58,2,59,7,59,2,60,7,60,2,61,7,61,1,0,1,0,1,0,1,0,
		1,0,1,1,1,1,1,1,1,1,1,2,1,2,1,2,1,2,1,3,1,3,1,3,1,3,1,4,1,4,1,4,1,4,1,
		4,1,4,1,5,1,5,1,5,1,5,1,5,1,5,1,5,1,6,1,6,1,6,1,6,1,6,1,7,1,7,1,7,1,7,
		1,7,1,8,1,8,1,8,1,8,1,8,1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,10,1,10,1,10,1,10,
		1,10,1,10,1,11,1,11,1,11,1,11,1,12,1,12,1,12,1,13,1,13,1,13,1,14,1,14,
		1,14,1,14,1,14,1,15,1,15,1,15,1,15,1,15,1,15,1,16,1,16,1,16,1,16,1,17,
		1,17,1,17,1,17,1,17,1,17,1,17,1,17,1,17,1,18,1,18,1,18,1,18,1,18,1,18,
		1,19,1,19,1,19,1,19,1,19,1,19,1,19,1,20,1,20,1,21,1,21,1,22,1,22,1,23,
		1,23,1,24,1,24,1,25,1,25,1,26,1,26,1,27,1,27,1,28,1,28,1,29,1,29,1,30,
		1,30,1,31,1,31,1,32,1,32,1,33,1,33,1,33,1,34,1,34,1,34,1,35,1,35,1,35,
		1,36,1,36,1,36,1,37,1,37,1,37,1,38,1,38,1,39,1,39,1,40,1,40,1,41,1,41,
		1,42,1,42,1,43,1,43,1,44,1,44,1,44,1,45,1,45,1,45,1,46,1,46,1,46,1,47,
		1,47,1,47,1,48,1,48,1,49,1,49,1,50,1,50,1,50,1,51,1,51,1,51,1,52,1,52,
		1,53,1,53,1,53,1,54,1,54,1,54,1,55,1,55,1,55,1,56,1,56,1,56,1,57,1,57,
		5,57,322,8,57,10,57,12,57,325,9,57,1,58,1,58,5,58,329,8,58,10,58,12,58,
		332,9,58,1,58,1,58,1,59,3,59,337,8,59,1,59,3,59,340,8,59,1,59,5,59,343,
		8,59,10,59,12,59,346,9,59,1,59,1,59,4,59,350,8,59,11,59,12,59,351,3,59,
		354,8,59,1,60,4,60,357,8,60,11,60,12,60,358,1,60,1,60,1,61,1,61,3,61,365,
		8,61,1,61,3,61,368,8,61,1,61,1,61,0,0,62,1,1,3,2,5,3,7,4,9,5,11,6,13,7,
		15,8,17,9,19,10,21,11,23,12,25,13,27,14,29,15,31,16,33,17,35,18,37,19,
		39,20,41,21,43,22,45,23,47,24,49,25,51,26,53,27,55,28,57,29,59,30,61,31,
		63,32,65,33,67,34,69,35,71,36,73,37,75,38,77,39,79,40,81,41,83,42,85,43,
		87,44,89,45,91,46,93,47,95,48,97,49,99,50,101,51,103,52,105,53,107,54,
		109,55,111,56,113,57,115,58,117,59,119,60,121,61,123,62,1,0,7,3,0,65,90,
		95,95,97,122,4,0,48,57,65,90,95,95,97,122,6,0,33,33,35,41,44,44,46,90,
		94,122,126,126,1,0,45,45,1,0,48,57,1,0,46,46,2,0,9,9,32,32,379,0,1,1,0,
		0,0,0,3,1,0,0,0,0,5,1,0,0,0,0,7,1,0,0,0,0,9,1,0,0,0,0,11,1,0,0,0,0,13,
		1,0,0,0,0,15,1,0,0,0,0,17,1,0,0,0,0,19,1,0,0,0,0,21,1,0,0,0,0,23,1,0,0,
		0,0,25,1,0,0,0,0,27,1,0,0,0,0,29,1,0,0,0,0,31,1,0,0,0,0,33,1,0,0,0,0,35,
		1,0,0,0,0,37,1,0,0,0,0,39,1,0,0,0,0,41,1,0,0,0,0,43,1,0,0,0,0,45,1,0,0,
		0,0,47,1,0,0,0,0,49,1,0,0,0,0,51,1,0,0,0,0,53,1,0,0,0,0,55,1,0,0,0,0,57,
		1,0,0,0,0,59,1,0,0,0,0,61,1,0,0,0,0,63,1,0,0,0,0,65,1,0,0,0,0,67,1,0,0,
		0,0,69,1,0,0,0,0,71,1,0,0,0,0,73,1,0,0,0,0,75,1,0,0,0,0,77,1,0,0,0,0,79,
		1,0,0,0,0,81,1,0,0,0,0,83,1,0,0,0,0,85,1,0,0,0,0,87,1,0,0,0,0,89,1,0,0,
		0,0,91,1,0,0,0,0,93,1,0,0,0,0,95,1,0,0,0,0,97,1,0,0,0,0,99,1,0,0,0,0,101,
		1,0,0,0,0,103,1,0,0,0,0,105,1,0,0,0,0,107,1,0,0,0,0,109,1,0,0,0,0,111,
		1,0,0,0,0,113,1,0,0,0,0,115,1,0,0,0,0,117,1,0,0,0,0,119,1,0,0,0,0,121,
		1,0,0,0,0,123,1,0,0,0,1,125,1,0,0,0,3,130,1,0,0,0,5,134,1,0,0,0,7,138,
		1,0,0,0,9,142,1,0,0,0,11,148,1,0,0,0,13,155,1,0,0,0,15,160,1,0,0,0,17,
		165,1,0,0,0,19,170,1,0,0,0,21,177,1,0,0,0,23,183,1,0,0,0,25,187,1,0,0,
		0,27,190,1,0,0,0,29,193,1,0,0,0,31,198,1,0,0,0,33,204,1,0,0,0,35,208,1,
		0,0,0,37,217,1,0,0,0,39,223,1,0,0,0,41,230,1,0,0,0,43,232,1,0,0,0,45,234,
		1,0,0,0,47,236,1,0,0,0,49,238,1,0,0,0,51,240,1,0,0,0,53,242,1,0,0,0,55,
		244,1,0,0,0,57,246,1,0,0,0,59,248,1,0,0,0,61,250,1,0,0,0,63,252,1,0,0,
		0,65,254,1,0,0,0,67,256,1,0,0,0,69,259,1,0,0,0,71,262,1,0,0,0,73,265,1,
		0,0,0,75,268,1,0,0,0,77,271,1,0,0,0,79,273,1,0,0,0,81,275,1,0,0,0,83,277,
		1,0,0,0,85,279,1,0,0,0,87,281,1,0,0,0,89,283,1,0,0,0,91,286,1,0,0,0,93,
		289,1,0,0,0,95,292,1,0,0,0,97,295,1,0,0,0,99,297,1,0,0,0,101,299,1,0,0,
		0,103,302,1,0,0,0,105,305,1,0,0,0,107,307,1,0,0,0,109,310,1,0,0,0,111,
		313,1,0,0,0,113,316,1,0,0,0,115,319,1,0,0,0,117,326,1,0,0,0,119,336,1,
		0,0,0,121,356,1,0,0,0,123,367,1,0,0,0,125,126,5,104,0,0,126,127,5,105,
		0,0,127,128,5,103,0,0,128,129,5,104,0,0,129,2,1,0,0,0,130,131,5,108,0,
		0,131,132,5,111,0,0,132,133,5,119,0,0,133,4,1,0,0,0,134,135,5,112,0,0,
		135,136,5,105,0,0,136,137,5,110,0,0,137,6,1,0,0,0,138,139,5,105,0,0,139,
		140,5,110,0,0,140,141,5,116,0,0,141,8,1,0,0,0,142,143,5,102,0,0,143,144,
		5,108,0,0,144,145,5,111,0,0,145,146,5,97,0,0,146,147,5,116,0,0,147,10,
		1,0,0,0,148,149,5,115,0,0,149,150,5,116,0,0,150,151,5,114,0,0,151,152,
		5,105,0,0,152,153,5,110,0,0,153,154,5,103,0,0,154,12,1,0,0,0,155,156,5,
		98,0,0,156,157,5,111,0,0,157,158,5,111,0,0,158,159,5,108,0,0,159,14,1,
		0,0,0,160,161,5,118,0,0,161,162,5,111,0,0,162,163,5,105,0,0,163,164,5,
		100,0,0,164,16,1,0,0,0,165,166,5,99,0,0,166,167,5,104,0,0,167,168,5,97,
		0,0,168,169,5,114,0,0,169,18,1,0,0,0,170,171,5,117,0,0,171,172,5,112,0,
		0,172,173,5,100,0,0,173,174,5,97,0,0,174,175,5,116,0,0,175,176,5,101,0,
		0,176,20,1,0,0,0,177,178,5,115,0,0,178,179,5,101,0,0,179,180,5,116,0,0,
		180,181,5,117,0,0,181,182,5,112,0,0,182,22,1,0,0,0,183,184,5,115,0,0,184,
		185,5,101,0,0,185,186,5,116,0,0,186,24,1,0,0,0,187,188,5,116,0,0,188,189,
		5,111,0,0,189,26,1,0,0,0,190,191,5,105,0,0,191,192,5,102,0,0,192,28,1,
		0,0,0,193,194,5,101,0,0,194,195,5,108,0,0,195,196,5,115,0,0,196,197,5,
		101,0,0,197,30,1,0,0,0,198,199,5,119,0,0,199,200,5,104,0,0,200,201,5,105,
		0,0,201,202,5,108,0,0,202,203,5,101,0,0,203,32,1,0,0,0,204,205,5,102,0,
		0,205,206,5,111,0,0,206,207,5,114,0,0,207,34,1,0,0,0,208,209,5,99,0,0,
		209,210,5,111,0,0,210,211,5,110,0,0,211,212,5,116,0,0,212,213,5,105,0,
		0,213,214,5,110,0,0,214,215,5,117,0,0,215,216,5,101,0,0,216,36,1,0,0,0,
		217,218,5,98,0,0,218,219,5,114,0,0,219,220,5,101,0,0,220,221,5,97,0,0,
		221,222,5,107,0,0,222,38,1,0,0,0,223,224,5,114,0,0,224,225,5,101,0,0,225,
		226,5,116,0,0,226,227,5,117,0,0,227,228,5,114,0,0,228,229,5,110,0,0,229,
		40,1,0,0,0,230,231,5,63,0,0,231,42,1,0,0,0,232,233,5,40,0,0,233,44,1,0,
		0,0,234,235,5,41,0,0,235,46,1,0,0,0,236,237,5,123,0,0,237,48,1,0,0,0,238,
		239,5,125,0,0,239,50,1,0,0,0,240,241,5,91,0,0,241,52,1,0,0,0,242,243,5,
		93,0,0,243,54,1,0,0,0,244,245,5,59,0,0,245,56,1,0,0,0,246,247,5,46,0,0,
		247,58,1,0,0,0,248,249,5,44,0,0,249,60,1,0,0,0,250,251,5,58,0,0,251,62,
		1,0,0,0,252,253,5,10,0,0,253,64,1,0,0,0,254,255,5,61,0,0,255,66,1,0,0,
		0,256,257,5,43,0,0,257,258,5,61,0,0,258,68,1,0,0,0,259,260,5,42,0,0,260,
		261,5,61,0,0,261,70,1,0,0,0,262,263,5,47,0,0,263,264,5,61,0,0,264,72,1,
		0,0,0,265,266,5,37,0,0,266,267,5,61,0,0,267,74,1,0,0,0,268,269,5,45,0,
		0,269,270,5,61,0,0,270,76,1,0,0,0,271,272,5,34,0,0,272,78,1,0,0,0,273,
		274,5,42,0,0,274,80,1,0,0,0,275,276,5,47,0,0,276,82,1,0,0,0,277,278,5,
		43,0,0,278,84,1,0,0,0,279,280,5,45,0,0,280,86,1,0,0,0,281,282,5,37,0,0,
		282,88,1,0,0,0,283,284,5,38,0,0,284,285,5,38,0,0,285,90,1,0,0,0,286,287,
		5,124,0,0,287,288,5,124,0,0,288,92,1,0,0,0,289,290,5,61,0,0,290,291,5,
		61,0,0,291,94,1,0,0,0,292,293,5,33,0,0,293,294,5,61,0,0,294,96,1,0,0,0,
		295,296,5,62,0,0,296,98,1,0,0,0,297,298,5,60,0,0,298,100,1,0,0,0,299,300,
		5,62,0,0,300,301,5,61,0,0,301,102,1,0,0,0,302,303,5,60,0,0,303,304,5,61,
		0,0,304,104,1,0,0,0,305,306,5,33,0,0,306,106,1,0,0,0,307,308,5,60,0,0,
		308,309,5,60,0,0,309,108,1,0,0,0,310,311,5,62,0,0,311,312,5,62,0,0,312,
		110,1,0,0,0,313,314,5,43,0,0,314,315,5,43,0,0,315,112,1,0,0,0,316,317,
		5,45,0,0,317,318,5,45,0,0,318,114,1,0,0,0,319,323,7,0,0,0,320,322,7,1,
		0,0,321,320,1,0,0,0,322,325,1,0,0,0,323,321,1,0,0,0,323,324,1,0,0,0,324,
		116,1,0,0,0,325,323,1,0,0,0,326,330,3,77,38,0,327,329,7,2,0,0,328,327,
		1,0,0,0,329,332,1,0,0,0,330,328,1,0,0,0,330,331,1,0,0,0,331,333,1,0,0,
		0,332,330,1,0,0,0,333,334,3,77,38,0,334,118,1,0,0,0,335,337,7,3,0,0,336,
		335,1,0,0,0,336,337,1,0,0,0,337,339,1,0,0,0,338,340,2,48,57,0,339,338,
		1,0,0,0,340,344,1,0,0,0,341,343,7,4,0,0,342,341,1,0,0,0,343,346,1,0,0,
		0,344,342,1,0,0,0,344,345,1,0,0,0,345,353,1,0,0,0,346,344,1,0,0,0,347,
		349,7,5,0,0,348,350,7,4,0,0,349,348,1,0,0,0,350,351,1,0,0,0,351,349,1,
		0,0,0,351,352,1,0,0,0,352,354,1,0,0,0,353,347,1,0,0,0,353,354,1,0,0,0,
		354,120,1,0,0,0,355,357,7,6,0,0,356,355,1,0,0,0,357,358,1,0,0,0,358,356,
		1,0,0,0,358,359,1,0,0,0,359,360,1,0,0,0,360,361,6,60,0,0,361,122,1,0,0,
		0,362,364,5,13,0,0,363,365,5,10,0,0,364,363,1,0,0,0,364,365,1,0,0,0,365,
		368,1,0,0,0,366,368,5,10,0,0,367,362,1,0,0,0,367,366,1,0,0,0,368,369,1,
		0,0,0,369,370,6,61,0,0,370,124,1,0,0,0,11,0,323,330,336,339,344,351,353,
		358,364,367,1,0,1,0
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}