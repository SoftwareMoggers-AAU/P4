//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from P4.TinyCell/Languages/TinyCell/TinyCell.g4 by ANTLR 4.13.1

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
public partial class TinyCellLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, T__15=16, T__16=17, 
		T__17=18, T__18=19, T__19=20, T__20=21, T__21=22, T__22=23, T__23=24, 
		T__24=25, T__25=26, T__26=27, T__27=28, T__28=29, T__29=30, T__30=31, 
		T__31=32, T__32=33, T__33=34, T__34=35, T__35=36, T__36=37, T__37=38, 
		T__38=39, T__39=40, T__40=41, T__41=42, T__42=43, T__43=44, T__44=45, 
		T__45=46, T__46=47, T__47=48, T__48=49, T__49=50, Identifier=51, String=52, 
		Numeral=53;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
		"T__9", "T__10", "T__11", "T__12", "T__13", "T__14", "T__15", "T__16", 
		"T__17", "T__18", "T__19", "T__20", "T__21", "T__22", "T__23", "T__24", 
		"T__25", "T__26", "T__27", "T__28", "T__29", "T__30", "T__31", "T__32", 
		"T__33", "T__34", "T__35", "T__36", "T__37", "T__38", "T__39", "T__40", 
		"T__41", "T__42", "T__43", "T__44", "T__45", "T__46", "T__47", "T__48", 
		"T__49", "Identifier", "String", "Numeral"
	};


	public TinyCellLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public TinyCellLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'setup'", "'update'", "'('", "')'", "'void'", "'char'", "'int'", 
		"'float'", "'bool'", "'pin'", "','", "'='", "'{'", "'}'", "'if'", "'else'", 
		"'while'", "'for'", "';'", "'continue'", "'break'", "'return'", "'?'", 
		"':'", "'||'", "'&&'", "'=='", "'!='", "'<'", "'>'", "'<='", "'>='", "'<<'", 
		"'>>'", "'+'", "'-'", "'*'", "'/'", "'%'", "'++'", "'--'", "'set'", "'to'", 
		"'*='", "'/='", "'%='", "'+='", "'-='", "'high'", "'low'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, "Identifier", "String", "Numeral"
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

	static TinyCellLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static int[] _serializedATN = {
		4,0,53,316,6,-1,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,
		6,2,7,7,7,2,8,7,8,2,9,7,9,2,10,7,10,2,11,7,11,2,12,7,12,2,13,7,13,2,14,
		7,14,2,15,7,15,2,16,7,16,2,17,7,17,2,18,7,18,2,19,7,19,2,20,7,20,2,21,
		7,21,2,22,7,22,2,23,7,23,2,24,7,24,2,25,7,25,2,26,7,26,2,27,7,27,2,28,
		7,28,2,29,7,29,2,30,7,30,2,31,7,31,2,32,7,32,2,33,7,33,2,34,7,34,2,35,
		7,35,2,36,7,36,2,37,7,37,2,38,7,38,2,39,7,39,2,40,7,40,2,41,7,41,2,42,
		7,42,2,43,7,43,2,44,7,44,2,45,7,45,2,46,7,46,2,47,7,47,2,48,7,48,2,49,
		7,49,2,50,7,50,2,51,7,51,2,52,7,52,1,0,1,0,1,0,1,0,1,0,1,0,1,1,1,1,1,1,
		1,1,1,1,1,1,1,1,1,2,1,2,1,3,1,3,1,4,1,4,1,4,1,4,1,4,1,5,1,5,1,5,1,5,1,
		5,1,6,1,6,1,6,1,6,1,7,1,7,1,7,1,7,1,7,1,7,1,8,1,8,1,8,1,8,1,8,1,9,1,9,
		1,9,1,9,1,10,1,10,1,11,1,11,1,12,1,12,1,13,1,13,1,14,1,14,1,14,1,15,1,
		15,1,15,1,15,1,15,1,16,1,16,1,16,1,16,1,16,1,16,1,17,1,17,1,17,1,17,1,
		18,1,18,1,19,1,19,1,19,1,19,1,19,1,19,1,19,1,19,1,19,1,20,1,20,1,20,1,
		20,1,20,1,20,1,21,1,21,1,21,1,21,1,21,1,21,1,21,1,22,1,22,1,23,1,23,1,
		24,1,24,1,24,1,25,1,25,1,25,1,26,1,26,1,26,1,27,1,27,1,27,1,28,1,28,1,
		29,1,29,1,30,1,30,1,30,1,31,1,31,1,31,1,32,1,32,1,32,1,33,1,33,1,33,1,
		34,1,34,1,35,1,35,1,36,1,36,1,37,1,37,1,38,1,38,1,39,1,39,1,39,1,40,1,
		40,1,40,1,41,1,41,1,41,1,41,1,42,1,42,1,42,1,43,1,43,1,43,1,44,1,44,1,
		44,1,45,1,45,1,45,1,46,1,46,1,46,1,47,1,47,1,47,1,48,1,48,1,48,1,48,1,
		48,1,49,1,49,1,49,1,49,1,50,1,50,5,50,285,8,50,10,50,12,50,288,9,50,1,
		51,1,51,5,51,292,8,51,10,51,12,51,295,9,51,1,51,1,51,1,52,3,52,300,8,52,
		1,52,1,52,5,52,304,8,52,10,52,12,52,307,9,52,1,52,1,52,4,52,311,8,52,11,
		52,12,52,312,3,52,315,8,52,0,0,53,1,1,3,2,5,3,7,4,9,5,11,6,13,7,15,8,17,
		9,19,10,21,11,23,12,25,13,27,14,29,15,31,16,33,17,35,18,37,19,39,20,41,
		21,43,22,45,23,47,24,49,25,51,26,53,27,55,28,57,29,59,30,61,31,63,32,65,
		33,67,34,69,35,71,36,73,37,75,38,77,39,79,40,81,41,83,42,85,43,87,44,89,
		45,91,46,93,47,95,48,97,49,99,50,101,51,103,52,105,53,1,0,6,3,0,65,90,
		95,95,97,122,4,0,48,57,65,90,95,95,97,122,1,0,34,34,1,0,45,45,1,0,49,57,
		1,0,48,57,321,0,1,1,0,0,0,0,3,1,0,0,0,0,5,1,0,0,0,0,7,1,0,0,0,0,9,1,0,
		0,0,0,11,1,0,0,0,0,13,1,0,0,0,0,15,1,0,0,0,0,17,1,0,0,0,0,19,1,0,0,0,0,
		21,1,0,0,0,0,23,1,0,0,0,0,25,1,0,0,0,0,27,1,0,0,0,0,29,1,0,0,0,0,31,1,
		0,0,0,0,33,1,0,0,0,0,35,1,0,0,0,0,37,1,0,0,0,0,39,1,0,0,0,0,41,1,0,0,0,
		0,43,1,0,0,0,0,45,1,0,0,0,0,47,1,0,0,0,0,49,1,0,0,0,0,51,1,0,0,0,0,53,
		1,0,0,0,0,55,1,0,0,0,0,57,1,0,0,0,0,59,1,0,0,0,0,61,1,0,0,0,0,63,1,0,0,
		0,0,65,1,0,0,0,0,67,1,0,0,0,0,69,1,0,0,0,0,71,1,0,0,0,0,73,1,0,0,0,0,75,
		1,0,0,0,0,77,1,0,0,0,0,79,1,0,0,0,0,81,1,0,0,0,0,83,1,0,0,0,0,85,1,0,0,
		0,0,87,1,0,0,0,0,89,1,0,0,0,0,91,1,0,0,0,0,93,1,0,0,0,0,95,1,0,0,0,0,97,
		1,0,0,0,0,99,1,0,0,0,0,101,1,0,0,0,0,103,1,0,0,0,0,105,1,0,0,0,1,107,1,
		0,0,0,3,113,1,0,0,0,5,120,1,0,0,0,7,122,1,0,0,0,9,124,1,0,0,0,11,129,1,
		0,0,0,13,134,1,0,0,0,15,138,1,0,0,0,17,144,1,0,0,0,19,149,1,0,0,0,21,153,
		1,0,0,0,23,155,1,0,0,0,25,157,1,0,0,0,27,159,1,0,0,0,29,161,1,0,0,0,31,
		164,1,0,0,0,33,169,1,0,0,0,35,175,1,0,0,0,37,179,1,0,0,0,39,181,1,0,0,
		0,41,190,1,0,0,0,43,196,1,0,0,0,45,203,1,0,0,0,47,205,1,0,0,0,49,207,1,
		0,0,0,51,210,1,0,0,0,53,213,1,0,0,0,55,216,1,0,0,0,57,219,1,0,0,0,59,221,
		1,0,0,0,61,223,1,0,0,0,63,226,1,0,0,0,65,229,1,0,0,0,67,232,1,0,0,0,69,
		235,1,0,0,0,71,237,1,0,0,0,73,239,1,0,0,0,75,241,1,0,0,0,77,243,1,0,0,
		0,79,245,1,0,0,0,81,248,1,0,0,0,83,251,1,0,0,0,85,255,1,0,0,0,87,258,1,
		0,0,0,89,261,1,0,0,0,91,264,1,0,0,0,93,267,1,0,0,0,95,270,1,0,0,0,97,273,
		1,0,0,0,99,278,1,0,0,0,101,282,1,0,0,0,103,289,1,0,0,0,105,299,1,0,0,0,
		107,108,5,115,0,0,108,109,5,101,0,0,109,110,5,116,0,0,110,111,5,117,0,
		0,111,112,5,112,0,0,112,2,1,0,0,0,113,114,5,117,0,0,114,115,5,112,0,0,
		115,116,5,100,0,0,116,117,5,97,0,0,117,118,5,116,0,0,118,119,5,101,0,0,
		119,4,1,0,0,0,120,121,5,40,0,0,121,6,1,0,0,0,122,123,5,41,0,0,123,8,1,
		0,0,0,124,125,5,118,0,0,125,126,5,111,0,0,126,127,5,105,0,0,127,128,5,
		100,0,0,128,10,1,0,0,0,129,130,5,99,0,0,130,131,5,104,0,0,131,132,5,97,
		0,0,132,133,5,114,0,0,133,12,1,0,0,0,134,135,5,105,0,0,135,136,5,110,0,
		0,136,137,5,116,0,0,137,14,1,0,0,0,138,139,5,102,0,0,139,140,5,108,0,0,
		140,141,5,111,0,0,141,142,5,97,0,0,142,143,5,116,0,0,143,16,1,0,0,0,144,
		145,5,98,0,0,145,146,5,111,0,0,146,147,5,111,0,0,147,148,5,108,0,0,148,
		18,1,0,0,0,149,150,5,112,0,0,150,151,5,105,0,0,151,152,5,110,0,0,152,20,
		1,0,0,0,153,154,5,44,0,0,154,22,1,0,0,0,155,156,5,61,0,0,156,24,1,0,0,
		0,157,158,5,123,0,0,158,26,1,0,0,0,159,160,5,125,0,0,160,28,1,0,0,0,161,
		162,5,105,0,0,162,163,5,102,0,0,163,30,1,0,0,0,164,165,5,101,0,0,165,166,
		5,108,0,0,166,167,5,115,0,0,167,168,5,101,0,0,168,32,1,0,0,0,169,170,5,
		119,0,0,170,171,5,104,0,0,171,172,5,105,0,0,172,173,5,108,0,0,173,174,
		5,101,0,0,174,34,1,0,0,0,175,176,5,102,0,0,176,177,5,111,0,0,177,178,5,
		114,0,0,178,36,1,0,0,0,179,180,5,59,0,0,180,38,1,0,0,0,181,182,5,99,0,
		0,182,183,5,111,0,0,183,184,5,110,0,0,184,185,5,116,0,0,185,186,5,105,
		0,0,186,187,5,110,0,0,187,188,5,117,0,0,188,189,5,101,0,0,189,40,1,0,0,
		0,190,191,5,98,0,0,191,192,5,114,0,0,192,193,5,101,0,0,193,194,5,97,0,
		0,194,195,5,107,0,0,195,42,1,0,0,0,196,197,5,114,0,0,197,198,5,101,0,0,
		198,199,5,116,0,0,199,200,5,117,0,0,200,201,5,114,0,0,201,202,5,110,0,
		0,202,44,1,0,0,0,203,204,5,63,0,0,204,46,1,0,0,0,205,206,5,58,0,0,206,
		48,1,0,0,0,207,208,5,124,0,0,208,209,5,124,0,0,209,50,1,0,0,0,210,211,
		5,38,0,0,211,212,5,38,0,0,212,52,1,0,0,0,213,214,5,61,0,0,214,215,5,61,
		0,0,215,54,1,0,0,0,216,217,5,33,0,0,217,218,5,61,0,0,218,56,1,0,0,0,219,
		220,5,60,0,0,220,58,1,0,0,0,221,222,5,62,0,0,222,60,1,0,0,0,223,224,5,
		60,0,0,224,225,5,61,0,0,225,62,1,0,0,0,226,227,5,62,0,0,227,228,5,61,0,
		0,228,64,1,0,0,0,229,230,5,60,0,0,230,231,5,60,0,0,231,66,1,0,0,0,232,
		233,5,62,0,0,233,234,5,62,0,0,234,68,1,0,0,0,235,236,5,43,0,0,236,70,1,
		0,0,0,237,238,5,45,0,0,238,72,1,0,0,0,239,240,5,42,0,0,240,74,1,0,0,0,
		241,242,5,47,0,0,242,76,1,0,0,0,243,244,5,37,0,0,244,78,1,0,0,0,245,246,
		5,43,0,0,246,247,5,43,0,0,247,80,1,0,0,0,248,249,5,45,0,0,249,250,5,45,
		0,0,250,82,1,0,0,0,251,252,5,115,0,0,252,253,5,101,0,0,253,254,5,116,0,
		0,254,84,1,0,0,0,255,256,5,116,0,0,256,257,5,111,0,0,257,86,1,0,0,0,258,
		259,5,42,0,0,259,260,5,61,0,0,260,88,1,0,0,0,261,262,5,47,0,0,262,263,
		5,61,0,0,263,90,1,0,0,0,264,265,5,37,0,0,265,266,5,61,0,0,266,92,1,0,0,
		0,267,268,5,43,0,0,268,269,5,61,0,0,269,94,1,0,0,0,270,271,5,45,0,0,271,
		272,5,61,0,0,272,96,1,0,0,0,273,274,5,104,0,0,274,275,5,105,0,0,275,276,
		5,103,0,0,276,277,5,104,0,0,277,98,1,0,0,0,278,279,5,108,0,0,279,280,5,
		111,0,0,280,281,5,119,0,0,281,100,1,0,0,0,282,286,7,0,0,0,283,285,7,1,
		0,0,284,283,1,0,0,0,285,288,1,0,0,0,286,284,1,0,0,0,286,287,1,0,0,0,287,
		102,1,0,0,0,288,286,1,0,0,0,289,293,5,34,0,0,290,292,8,2,0,0,291,290,1,
		0,0,0,292,295,1,0,0,0,293,291,1,0,0,0,293,294,1,0,0,0,294,296,1,0,0,0,
		295,293,1,0,0,0,296,297,5,34,0,0,297,104,1,0,0,0,298,300,7,3,0,0,299,298,
		1,0,0,0,299,300,1,0,0,0,300,301,1,0,0,0,301,305,7,4,0,0,302,304,7,5,0,
		0,303,302,1,0,0,0,304,307,1,0,0,0,305,303,1,0,0,0,305,306,1,0,0,0,306,
		314,1,0,0,0,307,305,1,0,0,0,308,310,9,0,0,0,309,311,7,5,0,0,310,309,1,
		0,0,0,311,312,1,0,0,0,312,310,1,0,0,0,312,313,1,0,0,0,313,315,1,0,0,0,
		314,308,1,0,0,0,314,315,1,0,0,0,315,106,1,0,0,0,7,0,286,293,299,305,312,
		314,0
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
