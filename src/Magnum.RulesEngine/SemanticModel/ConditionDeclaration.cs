// Copyright 2007-2008 The Apache Software Foundation.
//  
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use 
// this file except in compliance with the License. You may obtain a copy of the 
// License at 
// 
//     http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software distributed 
// under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, either express or implied. See the License for the 
// specific language governing permissions and limitations under the License.
namespace Magnum.RulesEngine.SemanticModel
{
	using System;
	using System.Linq.Expressions;

	public class ConditionDeclaration :
		Declaration
	{
		public ConditionDeclaration(Type matchType, Expression expression)
			: base(DeclarationType.Condition)
		{
			MatchType = matchType;
			Expression = expression;
		}

		/// <summary>
		/// The type to match for this condition
		/// </summary>
		public Type MatchType { get; private set; }

		/// <summary>
		/// The expression that is evaluated to determine if this condition is satisfied
		/// </summary>
		public Expression Expression { get; private set; }
	}
}