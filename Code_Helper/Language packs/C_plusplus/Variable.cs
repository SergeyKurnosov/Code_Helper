using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Code_Helper.Language_packs.C__
{
	public class Variable
	{
		public AccessModifier modifier { get; set; }
		public TypeData typeData { get; set; }
		public string name { get; set; }
		public string value { get; set; }
		public bool isArray { get; set; }
		public int arraySize { get; set; }

		public Variable(AccessModifier modifier = AccessModifier.None, TypeData typeData = TypeData.None, string name = "", string value = "", bool isArray = false, int arraySize = 0)
		{
			this.modifier = modifier;
			this.typeData = typeData;
			this.name = name;
			this.value = value;
			this.isArray = isArray;
			this.arraySize = isArray ? arraySize : 0;
		}

		public string ToStringWithoutAccesModifier()
		{
			string arrayInfo = isArray ? $"[{arraySize}]" : "";
			string result = "";
			name = ReplaceSpases(name);

			if (typeData != TypeData.None)
				result += $"{typeData.ToString().ToLower()} ";
			if (!string.IsNullOrEmpty(name))
				result += $"{name}";
			if (isArray)
			{
				result += $" {arrayInfo}";
				value = ValueArray();
			}
			if (!string.IsNullOrEmpty(value))
				result += $" = {value}";

			return result;
		}

		public string ToStringWithoutAccesModifier(char symbol)
		{
			string arrayInfo = isArray ? $"[{arraySize}]" : "";
			string result = "";
			name = ReplaceSpases(name);

			if (typeData != TypeData.None)
				result += $"{typeData.ToString().ToLower()} ";
			if (!string.IsNullOrEmpty(name))
				result += $"{name}{symbol}";
			if (isArray)
			{
				result += $" {arrayInfo}";
				value = ValueArray();
			}
			if (!string.IsNullOrEmpty(value))
				result += $" = {value}";

			return result;
		}

		public string ToStringWithAccesModifier()
		{
			string result = "";

			if (modifier != AccessModifier.None)
				result += $"{modifier.ToString().ToLower()} ";

			result += ToStringWithoutAccesModifier();

			return result;
		}

		public string ReplaceSpases(string str)
		{
			return str.Replace(" ", "");
		}

		public string ValueArray()
		{
			string result = value;
			if (isArray && !value.StartsWith("{") && !value.EndsWith("}") && !string.IsNullOrEmpty(value))
			{
				result = "";
				result += "{";
				string[] values = value.Split(' ');
				for (int i = 0; i < values.Length; i++)
				{
					if (i > 0)
						result += ", ";
					result += values[i].Trim();
				}
				result += "}";
			}
			return result;
		}
	}
}
