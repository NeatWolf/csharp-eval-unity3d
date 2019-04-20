using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace GameDevWare.Dynamic.Expressions.Packing
{
	internal static class NewPacker
	{
		public static Dictionary<string, object> Pack(NewExpression expression)
		{
			if (expression == null) throw new ArgumentNullException("expression");

			var arguments = expression.Arguments.ToArray();
			var argumentNames = ArrayUtils.ConvertAll(expression.Constructor.GetParameters(), p => p.Name);

			return new Dictionary<string, object>(3) {
				{Constants.EXPRESSION_TYPE_ATTRIBUTE, Constants.EXPRESSION_TYPE_NEW},
				{Constants.METHOD_ATTRIBUTE, AnyPacker.Pack(expression.Constructor)},
				{Constants.ARGUMENTS_ATTRIBUTE, AnyPacker.Pack(arguments, argumentNames)},
			};
		}
	}
}
