using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Code_Helper.Language_packs.C__
{
	public class Method
	{
		public AccessModifier accessModifier { get; set; }
		public TypeData typeData;
		public string name { get; set; }
		public List<Variable> parameters;
		public MethodModifiers modifiers;

		public Method(AccessModifier accessModifier = AccessModifier.None, TypeData typeData = TypeData.None, string name = "", List<Variable> parameters = null, MethodModifiers modifiers = MethodModifiers.None)
		{
			this.accessModifier = accessModifier;
			this.typeData = typeData;
			this.name = name;
			this.parameters = parameters ?? new List<Variable>();
			this.modifiers = modifiers;
		}

		private string ModifiersToString()
		{
			var allModifiers = new MethodModifiers[]
			{
		MethodModifiers.Static,
		MethodModifiers.Virtual,
		MethodModifiers.Const,
		MethodModifiers.Override,
		MethodModifiers.Final
			};

			var activeMods = new List<string>();

			foreach (var mod in allModifiers)
			{
				if (modifiers.HasFlag(mod))
					activeMods.Add(mod.ToString().ToLower());
			}

			return activeMods.Count > 0 ? string.Join(" ", activeMods) + " " : "";
		}

		public string ToStringWithoutAccesModifier()
		{
			string modsStr = ModifiersToString();
			if (!string.IsNullOrEmpty(modsStr))
				modsStr += " ";

			string paramsStr = string.Join(", ", parameters.ConvertAll(p => p.ToStringWithoutAccesModifier()));

			return $"{typeData.ToString().ToLower()} {name}({paramsStr}) {modsStr}";
		}

		public string ToStringWithoutTypeData()
		{
			string modsStr = ModifiersToString();
			if (!string.IsNullOrEmpty(modsStr))
				modsStr += " ";

			string paramsStr = string.Join(", ", parameters.ConvertAll(p => p.ToStringWithoutAccesModifier()));

			return $"{name}({paramsStr}) {modsStr}";
		}

		public string ToStringWithAccesModifier()
		{

			return $"{accessModifier.ToString().ToLower()} {ToStringWithoutAccesModifier()}";
		}
	}
}
