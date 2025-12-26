using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Code_Helper.Language_packs.C__
{
	internal class Class
	{
		public string name { get; set; }
		public bool defaultConstructor { get; set; }
		public bool constructor { get; set; }

		readonly Dictionary<AccessModifier, List<Variable>> fields = new Dictionary<AccessModifier, List<Variable>>();
		readonly Dictionary<AccessModifier, List<Method>> methods = new Dictionary<AccessModifier, List<Method>>();

		public Class(string name = "")
		{
			this.name = name;
			this.defaultConstructor = false;
			this.constructor = false;
			foreach (AccessModifier access in Enum.GetValues(typeof(AccessModifier)))
			{
				fields[access] = new List<Variable>();
				methods[access] = new List<Method>();
			}
		}
		public void AddField(Variable variable)
		{
			fields[variable.modifier].Add(variable);
		}

		public void AddMethod(Method method)
		{
			methods[method.accessModifier].Add(method);
		}

		public override string ToString()
		{
			var sb = new StringBuilder();

			sb.AppendLine($"class {name}");
			sb.AppendLine("{");

			foreach (AccessModifier access in new[] { AccessModifier.Public, AccessModifier.Protected, AccessModifier.Private })
			{
				var fields_ = fields[access];
				var methods_ = methods[access];



				if (fields_.Count == 0 && methods_.Count == 0)
				{
					if (access == AccessModifier.Public &&
						(defaultConstructor || constructor) &&
						(fields[AccessModifier.Private].Count != 0 || fields[AccessModifier.Protected].Count != 0))
					{}
					else
						continue;
				}

				sb.AppendLine($"{access.ToString().ToLower()}:");

					if ( access == AccessModifier.Public && (defaultConstructor || constructor))
					{

						if (defaultConstructor)
							sb.AppendLine($"    {this.name}();");


						if (constructor)
						{
							sb.Append($"    {this.name}(");
							foreach (AccessModifier accessM in new[] { AccessModifier.Public, AccessModifier.Protected, AccessModifier.Private })
							{
								var fieldS = fields[accessM];
								foreach (var field in fieldS)
									sb.Append($"{field.ToStringWithoutAccesModifier('_')},");
							}

							sb.Remove(sb.Length - 1, 1);
							sb.Append(");\n");
						}
					}

				foreach (var field in fields_)
					sb.AppendLine($"    {field.ToStringWithoutAccesModifier()};");

				foreach (var method in methods_)
					sb.AppendLine($"    {method.ToStringWithoutAccesModifier()};");
			}

			sb.AppendLine("};");
			return sb.ToString();
		}

		public string ToString_cpp()
		{
			var sb = new StringBuilder();
			sb.AppendLine($"#include \"{this.name}.h\"");

			if(defaultConstructor)
			{
				sb.AppendLine();
				sb.AppendLine($"{this.name}::{this.name}() {{");
				sb.AppendLine();
				sb.AppendLine("}");
			}
			if (constructor)
			{
				sb.AppendLine();
				sb.Append($"{this.name}::{this.name}(");
				foreach (AccessModifier accessM in new[] { AccessModifier.Public, AccessModifier.Protected, AccessModifier.Private })
				{
					var fieldS = fields[accessM];
					foreach (var field in fieldS)
						sb.Append($"{field.ToStringWithoutAccesModifier('_')},");
				}
				sb.Remove(sb.Length - 1, 1);
				sb.Append($") {{");
				sb.AppendLine("");
				sb.AppendLine("}");
			}
			foreach (AccessModifier accessM in new[] { AccessModifier.Public, AccessModifier.Protected, AccessModifier.Private })
			{
				sb.AppendLine();
				var methods_ = methods[accessM];
				foreach (var method in methods_)
				{
			sb.AppendLine($"{method.typeData.ToString().ToLower()} {this.name}::{method.ToStringWithoutTypeData()} {{");
				sb.AppendLine("");
				sb.AppendLine("}");
				}
	
			}
			return sb.ToString();
		}
	}
}
