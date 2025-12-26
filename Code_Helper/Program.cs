using Code_Helper.Language_packs.C__;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_Helper
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			//Class class_ = new Class("MyClass");

			//class_.AddField(new Variable(AccessModifier.Private, TypeData.Int, "myInt"));
			//class_.AddField(new Variable(AccessModifier.Public, TypeData.Bool, "vvv"));

			//class_.AddMethod(new Method(
			//	AccessModifier.Public,
			//	TypeData.Void,
			//	"SetMyInt",
			//	new List<Variable> { new Variable(AccessModifier.Public, TypeData.Int, "newInt") }
			//	));

			//class_.AddMethod(new Method(
			//	AccessModifier.Public,
			//	TypeData.Int,
			//	"GetMyInt",
			//	modifiers: MethodModifiers.Const
			//	));
			//Console.WriteLine(class_.ToString());
			Console.WriteLine("//////////////////////////////////////////////////////");
			//Variable variable = new Variable();
			//Console.WriteLine(variable.ToStringWithAccesModifier());
		

			//////////////////////////////////////////////////////////////////////
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
			//////////////////////////////////////////////////////////////////////
			


		}
	}
}
