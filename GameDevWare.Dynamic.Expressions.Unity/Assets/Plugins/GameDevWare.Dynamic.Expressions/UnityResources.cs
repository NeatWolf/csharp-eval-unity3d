﻿/*
	Copyright (c) 2016 Denis Zykov, GameDevWare.com

	This a part of "C# Eval()" Unity Asset - https://www.assetstore.unity3d.com/en/#!/content/56706

	THIS SOFTWARE IS DISTRIBUTED "AS-IS" WITHOUT ANY WARRANTIES, CONDITIONS AND
	REPRESENTATIONS WHETHER EXPRESS OR IMPLIED, INCLUDING WITHOUT LIMITATION THE
	IMPLIED WARRANTIES AND CONDITIONS OF MERCHANTABILITY, MERCHANTABLE QUALITY,
	FITNESS FOR A PARTICULAR PURPOSE, DURABILITY, NON-INFRINGEMENT, PERFORMANCE
	AND THOSE ARISING BY STATUTE OR FROM CUSTOM OR USAGE OF TRADE OR COURSE OF DEALING.

	This source code is distributed via Unity Asset Store,
	to use it in your project you should accept Terms of Service and EULA
	https://unity3d.com/ru/legal/as_terms
*/
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// ReSharper disable All

namespace GameDevWare.Dynamic.Expressions.Properties
{
	using System;
	using System.Collections.Generic;

	/// <summary>
	/// Localization resource for current assembly
	/// </summary>
	public static class Resources
	{
		private static readonly string[] supportedLanguages = new string[] { "en" };
		[ThreadStatic]
		private static int currentLanguageIdx;

		/// <summary>
		/// List of supported localization languages. <seealso cref="CurrentLanguage"/>.
		/// </summary>
		public static string[] SupportedLanguages { get { return (string[])supportedLanguages.Clone(); } }
		/// <summary>
		/// Current selected language of localization.
		/// </summary>
		public static string CurrentLanguage
		{
			get { return supportedLanguages[currentLanguageIdx]; }
			set
			{
				if (value == null) throw new ArgumentNullException("value");
				var langIndex = Array.IndexOf(supportedLanguages, value);
				if (langIndex < 0) throw new ArgumentException("Unsupported language '" + value + "'.", "value");

				currentLanguageIdx = langIndex;
			}
		}

		/// <summary>
		/// Return all localization strings by current <see cref="CurrentLanguage"/>.
		/// </summary>
		public static Dictionary<string, string> All
		{
			get
			{
				return new Dictionary<string, string>(60)
				{
					{ "EXCEPTION_PARSER_INVALIDCHILDCOUNTOFNODE", EXCEPTION_PARSER_INVALIDCHILDCOUNTOFNODE },
					{ "EXCEPTION_BIND_UNABLETOINVOKENONDELEG", EXCEPTION_BIND_UNABLETOINVOKENONDELEG },
					{ "EXCEPTION_COMPIL_NOCONVERTIONBETWEENTYPES", EXCEPTION_COMPIL_NOCONVERTIONBETWEENTYPES },
					{ "EXCEPTION_EXECUTION_INVALIDMEMBERFOREXPRESSION", EXCEPTION_EXECUTION_INVALIDMEMBERFOREXPRESSION },
					{ "EXCEPTION_BOUNDEXPR_CANTCONVERTARG", EXCEPTION_BOUNDEXPR_CANTCONVERTARG },
					{ "EXCEPTION_BIND_UNABLETORESOLVEMEMBERONTYPE", EXCEPTION_BIND_UNABLETORESOLVEMEMBERONTYPE },
					{ "EXCEPTION_COMPIL_NOBINARYOPONTYPE", EXCEPTION_COMPIL_NOBINARYOPONTYPE },
					{ "EXCEPTION_BIND_UNABLETORESOLVETYPE", EXCEPTION_BIND_UNABLETORESOLVETYPE },
					{ "EXCEPTION_BIND_TOOMANYARGUMENTS", EXCEPTION_BIND_TOOMANYARGUMENTS },
					{ "EXCEPTION_COMPIL_UNKNOWNEXPRTYPE", EXCEPTION_COMPIL_UNKNOWNEXPRTYPE },
					{ "EXCEPTION_PARSER_COLONISEXPRECTED", EXCEPTION_PARSER_COLONISEXPRECTED },
					{ "EXCEPTION_BIND_UNABLETOAPPLYNULLCONDITIONALOPERATORONTYPEREF", EXCEPTION_BIND_UNABLETOAPPLYNULLCONDITIONALOPERATORONTYPEREF },
					{ "EXCEPTION_BIND_UNABLETOBINDCONSTRUCTOR", EXCEPTION_BIND_UNABLETOBINDCONSTRUCTOR },
					{ "EXCEPTION_BIND_UNABLEREMAPPARAMETERSCOUNTMISMATCH", EXCEPTION_BIND_UNABLEREMAPPARAMETERSCOUNTMISMATCH },
					{ "EXCEPTION_PARSER_TERNARYOPREQOPERAND", EXCEPTION_PARSER_TERNARYOPREQOPERAND },
					{ "EXCEPTION_BIND_INVALIDLAMBDAARGUMENTS", EXCEPTION_BIND_INVALIDLAMBDAARGUMENTS },
					{ "EXCEPTION_BIND_CLOSEDDELEGATETYPEISEXPECTED", EXCEPTION_BIND_CLOSEDDELEGATETYPEISEXPECTED },
					{ "EXCEPTION_BIND_UNABLETORESOLVENAME", EXCEPTION_BIND_UNABLETORESOLVENAME },
					{ "EXCEPTION_BIND_VALIDDELEGATETYPEISEXPECTED", EXCEPTION_BIND_VALIDDELEGATETYPEISEXPECTED },
					{ "EXCEPTION_BOUNDEXPR_WRONGNUMPARAMS", EXCEPTION_BOUNDEXPR_WRONGNUMPARAMS },
					{ "EXCEPTION_PARSER_OPREQUIRESOPERAND", EXCEPTION_PARSER_OPREQUIRESOPERAND },
					{ "EXCEPTION_BIND_UNABLETOCREATEEXPRWITHPARAMS", EXCEPTION_BIND_UNABLETOCREATEEXPRWITHPARAMS },
					{ "EXCEPTION_PARSER_BINARYOPREQOPERAND", EXCEPTION_PARSER_BINARYOPREQOPERAND },
					{ "EXCEPTION_PARSER_UNARYOPREQOPERAND", EXCEPTION_PARSER_UNARYOPREQOPERAND },
					{ "EXCEPTION_STRINGUTILS_UNEXPECTEDESCAPESEQ", EXCEPTION_STRINGUTILS_UNEXPECTEDESCAPESEQ },
					{ "EXCEPTION_PARSER_UNEXPECTEDTOKENWHILEBUILDINGTREE", EXCEPTION_PARSER_UNEXPECTEDTOKENWHILEBUILDINGTREE },
					{ "EXCEPTION_COMPIL_UNKNOWNBINARYEXPRTYPE", EXCEPTION_COMPIL_UNKNOWNBINARYEXPRTYPE },
					{ "EXCEPTION_BIND_UNABLETOBINDDELEG", EXCEPTION_BIND_UNABLETOBINDDELEG },
					{ "EXCEPTION_PARSER_OPREQUIRESSECONDOPERAND", EXCEPTION_PARSER_OPREQUIRESSECONDOPERAND },
					{ "EXCEPTION_PARSER_TYPENAMEEXPECTED", EXCEPTION_PARSER_TYPENAMEEXPECTED },
					{ "EXCEPTION_EXECUTION_EXPRESSIONGIVESNULLRESULT", EXCEPTION_EXECUTION_EXPRESSIONGIVESNULLRESULT },
					{ "EXCEPTION_UNBOUNDEXPR_TYPESDOESNTMATCHNAMES", EXCEPTION_UNBOUNDEXPR_TYPESDOESNTMATCHNAMES },
					{ "EXCEPTION_PARSER_INVALIDCHILDTYPESOFNODE", EXCEPTION_PARSER_INVALIDCHILDTYPESOFNODE },
					{ "EXCEPTION_BIND_FAILEDTOBIND", EXCEPTION_BIND_FAILEDTOBIND },
					{ "EXCEPTION_COMPIL_ONLYFUNCLAMBDASISSUPPORTED", EXCEPTION_COMPIL_ONLYFUNCLAMBDASISSUPPORTED },
					{ "EXCEPTION_BIND_UNABLETORESOLVETYPEMULTIPLE", EXCEPTION_BIND_UNABLETORESOLVETYPEMULTIPLE },
					{ "EXCEPTION_COMPIL_UNKNOWNUNARYEXPRTYPE", EXCEPTION_COMPIL_UNKNOWNUNARYEXPRTYPE },
					{ "EXCEPTION_COMPIL_NOUNARYOPONTYPE", EXCEPTION_COMPIL_NOUNARYOPONTYPE },
					{ "EXCEPTION_BOUNDEXPR_BODYRESULTDOESNTMATCHRESULTTYPE", EXCEPTION_BOUNDEXPR_BODYRESULTDOESNTMATCHRESULTTYPE },
					{ "EXCEPTION_BIND_INVALIDCONSTANTEXPRESSION", EXCEPTION_BIND_INVALIDCONSTANTEXPRESSION },
					{ "EXCEPTION_UNBOUNDEXPR_DUPLICATEPARAMNAME", EXCEPTION_UNBOUNDEXPR_DUPLICATEPARAMNAME },
					{ "EXCEPTION_PARSER_UNEXPECTEDTOKEN", EXCEPTION_PARSER_UNEXPECTEDTOKEN },
					{ "EXCEPTION_UNBOUNDEXPR_INVALIDPARAMCOUNT", EXCEPTION_UNBOUNDEXPR_INVALIDPARAMCOUNT },
					{ "EXCEPTION_LIST_LISTISEMPTY", EXCEPTION_LIST_LISTISEMPTY },
					{ "EXCEPTION_BOUNDEXPR_WRONGPARAMETERTYPE", EXCEPTION_BOUNDEXPR_WRONGPARAMETERTYPE },
					{ "EXCEPTION_BIND_MISSINGATTRONNODE", EXCEPTION_BIND_MISSINGATTRONNODE },
					{ "EXCEPTION_BIND_UNKNOWNEXPRTYPE", EXCEPTION_BIND_UNKNOWNEXPRTYPE },
					{ "EXCEPTION_BIND_INVALIDCHARLITERAL", EXCEPTION_BIND_INVALIDCHARLITERAL },
					{ "EXCEPTION_PARSER_EXPRESSIONISEMPTY", EXCEPTION_PARSER_EXPRESSIONISEMPTY },
					{ "EXCEPTION_BIND_RENDERFAILED", EXCEPTION_BIND_RENDERFAILED },
					{ "EXCEPTION_BOUNDEXPR_ARGSDOESNTMATCHPARAMS", EXCEPTION_BOUNDEXPR_ARGSDOESNTMATCHPARAMS },
					{ "EXCEPTION_BIND_MISSINGORWRONGARGUMENT", EXCEPTION_BIND_MISSINGORWRONGARGUMENT },
					{ "EXCEPTION_BIND_UNABLETOBINDCALL", EXCEPTION_BIND_UNABLETOBINDCALL },
					{ "EXCEPTION_PARSER_UNEXPECTEDTOKENTYPE", EXCEPTION_PARSER_UNEXPECTEDTOKENTYPE },
					{ "EXCEPTION_BIND_FAILEDTOBINDGENERICARGUMENTSTOTYPE", EXCEPTION_BIND_FAILEDTOBINDGENERICARGUMENTSTOTYPE },
					{ "EXCEPTION_BIND_MISSINGMETHODPARAMETER", EXCEPTION_BIND_MISSINGMETHODPARAMETER },
					{ "EXCEPTION_BIND_UNABLETOBINDINDEXER", EXCEPTION_BIND_UNABLETOBINDINDEXER },
					{ "EXCEPTION_PARSER_UNEXPECTEDTOKENWHILEOTHEREXPECTED", EXCEPTION_PARSER_UNEXPECTEDTOKENWHILEOTHEREXPECTED },
					{ "EXCEPTION_TOKENIZER_INVALIDCHARLITERAL", EXCEPTION_TOKENIZER_INVALIDCHARLITERAL },
					{ "EXCEPTION_TOKENIZER_UNEXPECTEDSYMBOL", EXCEPTION_TOKENIZER_UNEXPECTEDSYMBOL },
				};
			}
		}

		/// <summary>
		/// Localization string with key EXCEPTION_PARSER_INVALIDCHILDCOUNTOFNODE
		/// </summary>
		public static string EXCEPTION_PARSER_INVALIDCHILDCOUNTOFNODE
		{
			get
			{
				switch (currentLanguageIdx)
				{
					case 0: return "An invalid children count '{1}' of node '{0}' while {2} is expected.";
					default: return "EXCEPTION_PARSER_INVALIDCHILDCOUNTOFNODE";
				}
			}
		}
		/// <summary>
		/// Localization string with key EXCEPTION_BIND_UNABLETOINVOKENONDELEG
		/// </summary>
		public static string EXCEPTION_BIND_UNABLETOINVOKENONDELEG
		{
			get
			{
				switch (currentLanguageIdx)
				{
					case 0: return "Unable to invoke non-delegate type '{0}'.";
					default: return "EXCEPTION_BIND_UNABLETOINVOKENONDELEG";
				}
			}
		}
		/// <summary>
		/// Localization string with key EXCEPTION_COMPIL_NOCONVERTIONBETWEENTYPES
		/// </summary>
		public static string EXCEPTION_COMPIL_NOCONVERTIONBETWEENTYPES
		{
			get
			{
				switch (currentLanguageIdx)
				{
					case 0: return "No conversion operation is defined from '{0}' to '{1}'.";
					default: return "EXCEPTION_COMPIL_NOCONVERTIONBETWEENTYPES";
				}
			}
		}
		/// <summary>
		/// Localization string with key EXCEPTION_EXECUTION_INVALIDMEMBERFOREXPRESSION
		/// </summary>
		public static string EXCEPTION_EXECUTION_INVALIDMEMBERFOREXPRESSION
		{
			get
			{
				switch (currentLanguageIdx)
				{
					case 0: return "Unknown member type '{0}' for MemberAccess expression.";
					default: return "EXCEPTION_EXECUTION_INVALIDMEMBERFOREXPRESSION";
				}
			}
		}
		/// <summary>
		/// Localization string with key EXCEPTION_BOUNDEXPR_CANTCONVERTARG
		/// </summary>
		public static string EXCEPTION_BOUNDEXPR_CANTCONVERTARG
		{
			get
			{
				switch (currentLanguageIdx)
				{
					case 0: return "Can't convert argument '{0}' ('{2}') to required type '{1}'.";
					default: return "EXCEPTION_BOUNDEXPR_CANTCONVERTARG";
				}
			}
		}
		/// <summary>
		/// Localization string with key EXCEPTION_BIND_UNABLETORESOLVEMEMBERONTYPE
		/// </summary>
		public static string EXCEPTION_BIND_UNABLETORESOLVEMEMBERONTYPE
		{
			get
			{
				switch (currentLanguageIdx)
				{
					case 0: return "Unable to find public member with name '{0}' on '{1}' type.";
					default: return "EXCEPTION_BIND_UNABLETORESOLVEMEMBERONTYPE";
				}
			}
		}
		/// <summary>
		/// Localization string with key EXCEPTION_COMPIL_NOBINARYOPONTYPE
		/// </summary>
		public static string EXCEPTION_COMPIL_NOBINARYOPONTYPE
		{
			get
			{
				switch (currentLanguageIdx)
				{
					case 0: return "No binary operation '{0}' is defined on type '{1}'.";
					default: return "EXCEPTION_COMPIL_NOBINARYOPONTYPE";
				}
			}
		}
		/// <summary>
		/// Localization string with key EXCEPTION_BIND_UNABLETORESOLVETYPE
		/// </summary>
		public static string EXCEPTION_BIND_UNABLETORESOLVETYPE
		{
			get
			{
				switch (currentLanguageIdx)
				{
					case 0: return "Unable to resolve type '{0}'.";
					default: return "EXCEPTION_BIND_UNABLETORESOLVETYPE";
				}
			}
		}
		/// <summary>
		/// Localization string with key EXCEPTION_BIND_TOOMANYARGUMENTS
		/// </summary>
		public static string EXCEPTION_BIND_TOOMANYARGUMENTS
		{
			get
			{
				switch (currentLanguageIdx)
				{
					case 0: return "Too many arguments. Maximum number of supported arguments '{0}'.";
					default: return "EXCEPTION_BIND_TOOMANYARGUMENTS";
				}
			}
		}
		/// <summary>
		/// Localization string with key EXCEPTION_COMPIL_UNKNOWNEXPRTYPE
		/// </summary>
		public static string EXCEPTION_COMPIL_UNKNOWNEXPRTYPE
		{
			get
			{
				switch (currentLanguageIdx)
				{
					case 0: return "Unknown expression type {0}.";
					default: return "EXCEPTION_COMPIL_UNKNOWNEXPRTYPE";
				}
			}
		}
		/// <summary>
		/// Localization string with key EXCEPTION_PARSER_COLONISEXPRECTED
		/// </summary>
		public static string EXCEPTION_PARSER_COLONISEXPRECTED
		{
			get
			{
				switch (currentLanguageIdx)
				{
					case 0: return "A colon ':' symbol is expected in conditional '?' expression.";
					default: return "EXCEPTION_PARSER_COLONISEXPRECTED";
				}
			}
		}
		/// <summary>
		/// Localization string with key EXCEPTION_BIND_UNABLETOAPPLYNULLCONDITIONALOPERATORONTYPEREF
		/// </summary>
		public static string EXCEPTION_BIND_UNABLETOAPPLYNULLCONDITIONALOPERATORONTYPEREF
		{
			get
			{
				switch (currentLanguageIdx)
				{
					case 0: return "Unable to apply null-conditional operator on type '{0}'.";
					default: return "EXCEPTION_BIND_UNABLETOAPPLYNULLCONDITIONALOPERATORONTYPEREF";
				}
			}
		}
		/// <summary>
		/// Localization string with key EXCEPTION_BIND_UNABLETOBINDCONSTRUCTOR
		/// </summary>
		public static string EXCEPTION_BIND_UNABLETOBINDCONSTRUCTOR
		{
			get
			{
				switch (currentLanguageIdx)
				{
					case 0: return "Unable to find constructor on type '{0}' accepting specified arguments.";
					default: return "EXCEPTION_BIND_UNABLETOBINDCONSTRUCTOR";
				}
			}
		}
		/// <summary>
		/// Localization string with key EXCEPTION_BIND_UNABLEREMAPPARAMETERSCOUNTMISMATCH
		/// </summary>
		public static string EXCEPTION_BIND_UNABLEREMAPPARAMETERSCOUNTMISMATCH
		{
			get
			{
				switch (currentLanguageIdx)
				{
					case 0: return "Unable to remap expression's parameters with lamda syntax. Parameters count mismatch.";
					default: return "EXCEPTION_BIND_UNABLEREMAPPARAMETERSCOUNTMISMATCH";
				}
			}
		}
		/// <summary>
		/// Localization string with key EXCEPTION_PARSER_TERNARYOPREQOPERAND
		/// </summary>
		public static string EXCEPTION_PARSER_TERNARYOPREQOPERAND
		{
			get
			{
				switch (currentLanguageIdx)
				{
					case 0: return "A ternary operation requires three parameters.";
					default: return "EXCEPTION_PARSER_TERNARYOPREQOPERAND";
				}
			}
		}
		/// <summary>
		/// Localization string with key EXCEPTION_BIND_INVALIDLAMBDAARGUMENTS
		/// </summary>
		public static string EXCEPTION_BIND_INVALIDLAMBDAARGUMENTS
		{
			get
			{
				switch (currentLanguageIdx)
				{
					case 0: return "Invalid argument types or count for lambda of type '{0}'.";
					default: return "EXCEPTION_BIND_INVALIDLAMBDAARGUMENTS";
				}
			}
		}
		/// <summary>
		/// Localization string with key EXCEPTION_BIND_CLOSEDDELEGATETYPEISEXPECTED
		/// </summary>
		public static string EXCEPTION_BIND_CLOSEDDELEGATETYPEISEXPECTED
		{
			get
			{
				switch (currentLanguageIdx)
				{
					case 0: return "Invalid lambda type '{0}'. A closed delegate type is expected in lambda type declaration.";
					default: return "EXCEPTION_BIND_CLOSEDDELEGATETYPEISEXPECTED";
				}
			}
		}
		/// <summary>
		/// Localization string with key EXCEPTION_BIND_UNABLETORESOLVENAME
		/// </summary>
		public static string EXCEPTION_BIND_UNABLETORESOLVENAME
		{
			get
			{
				switch (currentLanguageIdx)
				{
					case 0: return "Unable to resolve '{0}'. There is no formal parameter with this name.";
					default: return "EXCEPTION_BIND_UNABLETORESOLVENAME";
				}
			}
		}
		/// <summary>
		/// Localization string with key EXCEPTION_BIND_VALIDDELEGATETYPEISEXPECTED
		/// </summary>
		public static string EXCEPTION_BIND_VALIDDELEGATETYPEISEXPECTED
		{
			get
			{
				switch (currentLanguageIdx)
				{
					case 0: return "Invalid lambda type '{0}'. A valid delegate type should be specified in lambda type declaration.";
					default: return "EXCEPTION_BIND_VALIDDELEGATETYPEISEXPECTED";
				}
			}
		}
		/// <summary>
		/// Localization string with key EXCEPTION_BOUNDEXPR_WRONGNUMPARAMS
		/// </summary>
		public static string EXCEPTION_BOUNDEXPR_WRONGNUMPARAMS
		{
			get
			{
				switch (currentLanguageIdx)
				{
					case 0: return "Wrong number of parameters. Make sure parameter count matches expression's signature.";
					default: return "EXCEPTION_BOUNDEXPR_WRONGNUMPARAMS";
				}
			}
		}
		/// <summary>
		/// Localization string with key EXCEPTION_PARSER_OPREQUIRESOPERAND
		/// </summary>
		public static string EXCEPTION_PARSER_OPREQUIRESOPERAND
		{
			get
			{
				switch (currentLanguageIdx)
				{
					case 0: return "A '{0}' operator requires an operand.";
					default: return "EXCEPTION_PARSER_OPREQUIRESOPERAND";
				}
			}
		}
		/// <summary>
		/// Localization string with key EXCEPTION_BIND_UNABLETOCREATEEXPRWITHPARAMS
		/// </summary>
		public static string EXCEPTION_BIND_UNABLETOCREATEEXPRWITHPARAMS
		{
			get
			{
				switch (currentLanguageIdx)
				{
					case 0: return "Unable to create '{0}' expression with these '{1}' parameters.";
					default: return "EXCEPTION_BIND_UNABLETOCREATEEXPRWITHPARAMS";
				}
			}
		}
		/// <summary>
		/// Localization string with key EXCEPTION_PARSER_BINARYOPREQOPERAND
		/// </summary>
		public static string EXCEPTION_PARSER_BINARYOPREQOPERAND
		{
			get
			{
				switch (currentLanguageIdx)
				{
					case 0: return "A binary operation requires two parameters.";
					default: return "EXCEPTION_PARSER_BINARYOPREQOPERAND";
				}
			}
		}
		/// <summary>
		/// Localization string with key EXCEPTION_PARSER_UNARYOPREQOPERAND
		/// </summary>
		public static string EXCEPTION_PARSER_UNARYOPREQOPERAND
		{
			get
			{
				switch (currentLanguageIdx)
				{
					case 0: return "An unary operation requires one parameter.";
					default: return "EXCEPTION_PARSER_UNARYOPREQOPERAND";
				}
			}
		}
		/// <summary>
		/// Localization string with key EXCEPTION_STRINGUTILS_UNEXPECTEDESCAPESEQ
		/// </summary>
		public static string EXCEPTION_STRINGUTILS_UNEXPECTEDESCAPESEQ
		{
			get
			{
				switch (currentLanguageIdx)
				{
					case 0: return "Unknown escape sequence '{0}'.";
					default: return "EXCEPTION_STRINGUTILS_UNEXPECTEDESCAPESEQ";
				}
			}
		}
		/// <summary>
		/// Localization string with key EXCEPTION_PARSER_UNEXPECTEDTOKENWHILEBUILDINGTREE
		/// </summary>
		public static string EXCEPTION_PARSER_UNEXPECTEDTOKENWHILEBUILDINGTREE
		{
			get
			{
				switch (currentLanguageIdx)
				{
					case 0: return "Unexpected parser node met '{0}' while building expression tree.";
					default: return "EXCEPTION_PARSER_UNEXPECTEDTOKENWHILEBUILDINGTREE";
				}
			}
		}
		/// <summary>
		/// Localization string with key EXCEPTION_COMPIL_UNKNOWNBINARYEXPRTYPE
		/// </summary>
		public static string EXCEPTION_COMPIL_UNKNOWNBINARYEXPRTYPE
		{
			get
			{
				switch (currentLanguageIdx)
				{
					case 0: return "Unknown binary expression type '{0}'.";
					default: return "EXCEPTION_COMPIL_UNKNOWNBINARYEXPRTYPE";
				}
			}
		}
		/// <summary>
		/// Localization string with key EXCEPTION_BIND_UNABLETOBINDDELEG
		/// </summary>
		public static string EXCEPTION_BIND_UNABLETOBINDDELEG
		{
			get
			{
				switch (currentLanguageIdx)
				{
					case 0: return "Unable to invoke delegate {0}({1}) with specified arguments.";
					default: return "EXCEPTION_BIND_UNABLETOBINDDELEG";
				}
			}
		}
		/// <summary>
		/// Localization string with key EXCEPTION_PARSER_OPREQUIRESSECONDOPERAND
		/// </summary>
		public static string EXCEPTION_PARSER_OPREQUIRESSECONDOPERAND
		{
			get
			{
				switch (currentLanguageIdx)
				{
					case 0: return "A '{0}' operator requires a second operand.";
					default: return "EXCEPTION_PARSER_OPREQUIRESSECONDOPERAND";
				}
			}
		}
		/// <summary>
		/// Localization string with key EXCEPTION_PARSER_TYPENAMEEXPECTED
		/// </summary>
		public static string EXCEPTION_PARSER_TYPENAMEEXPECTED
		{
			get
			{
				switch (currentLanguageIdx)
				{
					case 0: return "A type name is expected.";
					default: return "EXCEPTION_PARSER_TYPENAMEEXPECTED";
				}
			}
		}
		/// <summary>
		/// Localization string with key EXCEPTION_EXECUTION_EXPRESSIONGIVESNULLRESULT
		/// </summary>
		public static string EXCEPTION_EXECUTION_EXPRESSIONGIVESNULLRESULT
		{
			get
			{
				switch (currentLanguageIdx)
				{
					case 0: return "Expression '{0}' gives null result.";
					default: return "EXCEPTION_EXECUTION_EXPRESSIONGIVESNULLRESULT";
				}
			}
		}
		/// <summary>
		/// Localization string with key EXCEPTION_UNBOUNDEXPR_TYPESDOESNTMATCHNAMES
		/// </summary>
		public static string EXCEPTION_UNBOUNDEXPR_TYPESDOESNTMATCHNAMES
		{
			get
			{
				switch (currentLanguageIdx)
				{
					case 0: return "Length of types array doesn't match length of names array.";
					default: return "EXCEPTION_UNBOUNDEXPR_TYPESDOESNTMATCHNAMES";
				}
			}
		}
		/// <summary>
		/// Localization string with key EXCEPTION_PARSER_INVALIDCHILDTYPESOFNODE
		/// </summary>
		public static string EXCEPTION_PARSER_INVALIDCHILDTYPESOFNODE
		{
			get
			{
				switch (currentLanguageIdx)
				{
					case 0: return "An invalid type of children nodes '{1}' of node '{0}' while '{2}' is expected.";
					default: return "EXCEPTION_PARSER_INVALIDCHILDTYPESOFNODE";
				}
			}
		}
		/// <summary>
		/// Localization string with key EXCEPTION_BIND_FAILEDTOBIND
		/// </summary>
		public static string EXCEPTION_BIND_FAILEDTOBIND
		{
			get
			{
				switch (currentLanguageIdx)
				{
					case 0: return "An error occured while trying to build '{0}' expression: {1}";
					default: return "EXCEPTION_BIND_FAILEDTOBIND";
				}
			}
		}
		/// <summary>
		/// Localization string with key EXCEPTION_COMPIL_ONLYFUNCLAMBDASISSUPPORTED
		/// </summary>
		public static string EXCEPTION_COMPIL_ONLYFUNCLAMBDASISSUPPORTED
		{
			get
			{
				switch (currentLanguageIdx)
				{
					case 0: return "Only System.Func<> lambda types are supported.";
					default: return "EXCEPTION_COMPIL_ONLYFUNCLAMBDASISSUPPORTED";
				}
			}
		}
		/// <summary>
		/// Localization string with key EXCEPTION_BIND_UNABLETORESOLVETYPEMULTIPLE
		/// </summary>
		public static string EXCEPTION_BIND_UNABLETORESOLVETYPEMULTIPLE
		{
			get
			{
				switch (currentLanguageIdx)
				{
					case 0: return "Unable to resolve type '{0}'. Can't choose from: '{1}'.";
					default: return "EXCEPTION_BIND_UNABLETORESOLVETYPEMULTIPLE";
				}
			}
		}
		/// <summary>
		/// Localization string with key EXCEPTION_COMPIL_UNKNOWNUNARYEXPRTYPE
		/// </summary>
		public static string EXCEPTION_COMPIL_UNKNOWNUNARYEXPRTYPE
		{
			get
			{
				switch (currentLanguageIdx)
				{
					case 0: return "Unknown unary expression type '{0}'.";
					default: return "EXCEPTION_COMPIL_UNKNOWNUNARYEXPRTYPE";
				}
			}
		}
		/// <summary>
		/// Localization string with key EXCEPTION_COMPIL_NOUNARYOPONTYPE
		/// </summary>
		public static string EXCEPTION_COMPIL_NOUNARYOPONTYPE
		{
			get
			{
				switch (currentLanguageIdx)
				{
					case 0: return "No unary operation '{0}' is defined on type '{1}'.";
					default: return "EXCEPTION_COMPIL_NOUNARYOPONTYPE";
				}
			}
		}
		/// <summary>
		/// Localization string with key EXCEPTION_BOUNDEXPR_BODYRESULTDOESNTMATCHRESULTTYPE
		/// </summary>
		public static string EXCEPTION_BOUNDEXPR_BODYRESULTDOESNTMATCHRESULTTYPE
		{
			get
			{
				switch (currentLanguageIdx)
				{
					case 0: return "Body's result type doesn't match expression's result type.";
					default: return "EXCEPTION_BOUNDEXPR_BODYRESULTDOESNTMATCHRESULTTYPE";
				}
			}
		}
		/// <summary>
		/// Localization string with key EXCEPTION_BIND_INVALIDCONSTANTEXPRESSION
		/// </summary>
		public static string EXCEPTION_BIND_INVALIDCONSTANTEXPRESSION
		{
			get
			{
				switch (currentLanguageIdx)
				{
					case 0: return "Can't convert constant of type '{0}' to literal representation.";
					default: return "EXCEPTION_BIND_INVALIDCONSTANTEXPRESSION";
				}
			}
		}
		/// <summary>
		/// Localization string with key EXCEPTION_UNBOUNDEXPR_DUPLICATEPARAMNAME
		/// </summary>
		public static string EXCEPTION_UNBOUNDEXPR_DUPLICATEPARAMNAME
		{
			get
			{
				switch (currentLanguageIdx)
				{
					case 0: return "Duplicate parameter name '{0}'.";
					default: return "EXCEPTION_UNBOUNDEXPR_DUPLICATEPARAMNAME";
				}
			}
		}
		/// <summary>
		/// Localization string with key EXCEPTION_PARSER_UNEXPECTEDTOKEN
		/// </summary>
		public static string EXCEPTION_PARSER_UNEXPECTEDTOKEN
		{
			get
			{
				switch (currentLanguageIdx)
				{
					case 0: return "Unexpected token '{0}' in current context.";
					default: return "EXCEPTION_PARSER_UNEXPECTEDTOKEN";
				}
			}
		}
		/// <summary>
		/// Localization string with key EXCEPTION_UNBOUNDEXPR_INVALIDPARAMCOUNT
		/// </summary>
		public static string EXCEPTION_UNBOUNDEXPR_INVALIDPARAMCOUNT
		{
			get
			{
				switch (currentLanguageIdx)
				{
					case 0: return "Invalid parameters count.";
					default: return "EXCEPTION_UNBOUNDEXPR_INVALIDPARAMCOUNT";
				}
			}
		}
		/// <summary>
		/// Localization string with key EXCEPTION_LIST_LISTISEMPTY
		/// </summary>
		public static string EXCEPTION_LIST_LISTISEMPTY
		{
			get
			{
				switch (currentLanguageIdx)
				{
					case 0: return "List is empty.";
					default: return "EXCEPTION_LIST_LISTISEMPTY";
				}
			}
		}
		/// <summary>
		/// Localization string with key EXCEPTION_BOUNDEXPR_WRONGPARAMETERTYPE
		/// </summary>
		public static string EXCEPTION_BOUNDEXPR_WRONGPARAMETERTYPE
		{
			get
			{
				switch (currentLanguageIdx)
				{
					case 0: return "One of parameters has invalid type. Make sure parameter types matches expression's signature.";
					default: return "EXCEPTION_BOUNDEXPR_WRONGPARAMETERTYPE";
				}
			}
		}
		/// <summary>
		/// Localization string with key EXCEPTION_BIND_MISSINGATTRONNODE
		/// </summary>
		public static string EXCEPTION_BIND_MISSINGATTRONNODE
		{
			get
			{
				switch (currentLanguageIdx)
				{
					case 0: return "Missing or wrong '{0}' attribute on one of expression nodes.";
					default: return "EXCEPTION_BIND_MISSINGATTRONNODE";
				}
			}
		}
		/// <summary>
		/// Localization string with key EXCEPTION_BIND_UNKNOWNEXPRTYPE
		/// </summary>
		public static string EXCEPTION_BIND_UNKNOWNEXPRTYPE
		{
			get
			{
				switch (currentLanguageIdx)
				{
					case 0: return "Unknown expression type '{0}'.";
					default: return "EXCEPTION_BIND_UNKNOWNEXPRTYPE";
				}
			}
		}
		/// <summary>
		/// Localization string with key EXCEPTION_BIND_INVALIDCHARLITERAL
		/// </summary>
		public static string EXCEPTION_BIND_INVALIDCHARLITERAL
		{
			get
			{
				switch (currentLanguageIdx)
				{
					case 0: return "Invalid char literal '{0}'. It should be one character length.";
					default: return "EXCEPTION_BIND_INVALIDCHARLITERAL";
				}
			}
		}
		/// <summary>
		/// Localization string with key EXCEPTION_PARSER_EXPRESSIONISEMPTY
		/// </summary>
		public static string EXCEPTION_PARSER_EXPRESSIONISEMPTY
		{
			get
			{
				switch (currentLanguageIdx)
				{
					case 0: return "Expression is empty";
					default: return "EXCEPTION_PARSER_EXPRESSIONISEMPTY";
				}
			}
		}
		/// <summary>
		/// Localization string with key EXCEPTION_BIND_RENDERFAILED
		/// </summary>
		public static string EXCEPTION_BIND_RENDERFAILED
		{
			get
			{
				switch (currentLanguageIdx)
				{
					case 0: return "An error occured while trying to render '{0}' expression: {1}";
					default: return "EXCEPTION_BIND_RENDERFAILED";
				}
			}
		}
		/// <summary>
		/// Localization string with key EXCEPTION_BOUNDEXPR_ARGSDOESNTMATCHPARAMS
		/// </summary>
		public static string EXCEPTION_BOUNDEXPR_ARGSDOESNTMATCHPARAMS
		{
			get
			{
				switch (currentLanguageIdx)
				{
					case 0: return "Count of passed arguments doesn't match parameters count.";
					default: return "EXCEPTION_BOUNDEXPR_ARGSDOESNTMATCHPARAMS";
				}
			}
		}
		/// <summary>
		/// Localization string with key EXCEPTION_BIND_MISSINGORWRONGARGUMENT
		/// </summary>
		public static string EXCEPTION_BIND_MISSINGORWRONGARGUMENT
		{
			get
			{
				switch (currentLanguageIdx)
				{
					case 0: return "Missing or wrong '{0}' argument.";
					default: return "EXCEPTION_BIND_MISSINGORWRONGARGUMENT";
				}
			}
		}
		/// <summary>
		/// Localization string with key EXCEPTION_BIND_UNABLETOBINDCALL
		/// </summary>
		public static string EXCEPTION_BIND_UNABLETOBINDCALL
		{
			get
			{
				switch (currentLanguageIdx)
				{
					case 0: return "Unable to find method '{0}' on type '{1}' accepting {2} arguments.";
					default: return "EXCEPTION_BIND_UNABLETOBINDCALL";
				}
			}
		}
		/// <summary>
		/// Localization string with key EXCEPTION_PARSER_UNEXPECTEDTOKENTYPE
		/// </summary>
		public static string EXCEPTION_PARSER_UNEXPECTEDTOKENTYPE
		{
			get
			{
				switch (currentLanguageIdx)
				{
					case 0: return "Unexpected token type '{0}'.";
					default: return "EXCEPTION_PARSER_UNEXPECTEDTOKENTYPE";
				}
			}
		}
		/// <summary>
		/// Localization string with key EXCEPTION_BIND_FAILEDTOBINDGENERICARGUMENTSTOTYPE
		/// </summary>
		public static string EXCEPTION_BIND_FAILEDTOBINDGENERICARGUMENTSTOTYPE
		{
			get
			{
				switch (currentLanguageIdx)
				{
					case 0: return "Failed to bind generic arguments '{0}' to type '{1}'.";
					default: return "EXCEPTION_BIND_FAILEDTOBINDGENERICARGUMENTSTOTYPE";
				}
			}
		}
		/// <summary>
		/// Localization string with key EXCEPTION_BIND_MISSINGMETHODPARAMETER
		/// </summary>
		public static string EXCEPTION_BIND_MISSINGMETHODPARAMETER
		{
			get
			{
				switch (currentLanguageIdx)
				{
					case 0: return "Missing required method/indexer '{0}' parameter.";
					default: return "EXCEPTION_BIND_MISSINGMETHODPARAMETER";
				}
			}
		}
		/// <summary>
		/// Localization string with key EXCEPTION_BIND_UNABLETOBINDINDEXER
		/// </summary>
		public static string EXCEPTION_BIND_UNABLETOBINDINDEXER
		{
			get
			{
				switch (currentLanguageIdx)
				{
					case 0: return "Unable to find indexing property on type '{0}' accepting specified arguments.";
					default: return "EXCEPTION_BIND_UNABLETOBINDINDEXER";
				}
			}
		}
		/// <summary>
		/// Localization string with key EXCEPTION_PARSER_UNEXPECTEDTOKENWHILEOTHEREXPECTED
		/// </summary>
		public static string EXCEPTION_PARSER_UNEXPECTEDTOKENWHILEOTHEREXPECTED
		{
			get
			{
				switch (currentLanguageIdx)
				{
					case 0: return "A one of these '{0}' tokens are expected.";
					default: return "EXCEPTION_PARSER_UNEXPECTEDTOKENWHILEOTHEREXPECTED";
				}
			}
		}
		/// <summary>
		/// Localization string with key EXCEPTION_TOKENIZER_INVALIDCHARLITERAL
		/// </summary>
		public static string EXCEPTION_TOKENIZER_INVALIDCHARLITERAL
		{
			get
			{
				switch (currentLanguageIdx)
				{
					case 0: return "Invalid char literal.";
					default: return "EXCEPTION_TOKENIZER_INVALIDCHARLITERAL";
				}
			}
		}
		/// <summary>
		/// Localization string with key EXCEPTION_TOKENIZER_UNEXPECTEDSYMBOL
		/// </summary>
		public static string EXCEPTION_TOKENIZER_UNEXPECTEDSYMBOL
		{
			get
			{
				switch (currentLanguageIdx)
				{
					case 0: return "Unexpected symbol '{0}'.";
					default: return "EXCEPTION_TOKENIZER_UNEXPECTEDSYMBOL";
				}
			}
		}
	}
}

