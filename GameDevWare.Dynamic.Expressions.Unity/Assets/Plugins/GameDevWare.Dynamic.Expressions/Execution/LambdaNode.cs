﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace GameDevWare.Dynamic.Expressions.Execution
{
	internal sealed class LambdaNode : ExecutionNode
	{
		private readonly LambdaExpression lambdaExpression;
		private readonly ParameterExpression[] parameterExpressions;
		private readonly MethodInfo prepareMethod;

		public LambdaNode(LambdaExpression lambdaExpression, ParameterExpression[] parameterExpressions)
		{
			if (lambdaExpression == null) throw new ArgumentNullException("lambdaExpression");
			if (parameterExpressions == null) throw new ArgumentNullException("parameterExpressions");

			this.lambdaExpression = lambdaExpression;
			this.parameterExpressions = parameterExpressions;

			if (lambdaExpression.Type.IsGenericType == false)
				throw new NotSupportedException(Properties.Resources.EXCEPTION_COMPIL_ONLYFUNCLAMBDASISSUPPORTED);

			var funcDefinition = lambdaExpression.Type.GetGenericTypeDefinition();
			if (funcDefinition != typeof(Func<>) && funcDefinition != typeof(Func<,>) && funcDefinition != typeof(Func<,,>) && funcDefinition != typeof(Func<,,,>) && funcDefinition != typeof(Func<,,,,>))
				throw new NotSupportedException(Properties.Resources.EXCEPTION_COMPIL_ONLYFUNCLAMBDASISSUPPORTED);

			var funcArguments = lambdaExpression.Type.GetGenericArguments();
			var prepareMethodDefinition = typeof(AotCompiler).GetMethods(BindingFlags.Public | BindingFlags.Static).Single(m => m.Name == Constants.EXECUTE_PREPARE_NAME && m.GetGenericArguments().Length == funcArguments.Length);
			this.prepareMethod = prepareMethodDefinition.MakeGenericMethod(funcArguments);
		}

		/// <inheritdoc />
		public override object Run(Closure closure)
		{
			var body = this.lambdaExpression.Body;
			var parameters = this.lambdaExpression.Parameters;

			// substitute captured parameters
			if (this.parameterExpressions.Length > 0)
			{
				var substitutions = new Dictionary<Expression, Expression>(this.parameterExpressions.Length);
				foreach (var parameterExpr in this.parameterExpressions)
				{
					var parameterValue = closure.Locals[LOCAL_FIRST_PARAMETER + Array.IndexOf(this.parameterExpressions, parameterExpr)];
					substitutions.Add(parameterExpr, Expression.Constant(parameterValue, parameterExpr.Type));
				}
				body = ExpressionSubstitutor.Visit(body, substitutions);
			}

			// prepare lambda
			return this.prepareMethod.Invoke(null, new object[] { body, parameters });
		}

		/// <inheritdoc />
		public override string ToString()
		{
			return this.lambdaExpression.ToString();
		}
	}
}
