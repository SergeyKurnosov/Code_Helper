using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Helper.Language_packs.C__
{
	public enum TypeData
	{
		None,
		Int,
		Unsigned_int,
		_int8,
		Unsigned__int8,
		_int16,
		Unsigned__int16,
		_int32,
		Unsigned__int32,
		_int64,
		Unsigned__int64,
		Bool,
		Char,
		Signed_char,
		Unsigned_char,
		Short,
		Unsigned_short,
		Long,
		Unsigned_long,
		Long_long,
		Unsigned_long_long,
		Enum,
		Float,
		Double,
		Long_double,
		Wchar_t,
		Void
	}

	public enum AccessModifier
	{
		None,
		Public,
		Private,
		Protected,
		Internal,
		ProtectedInternal,
		PrivateProtected
	}

	[Flags]
	public enum MethodModifiers
	{
		None = 0,
		Static = 1,
		Virtual = 2,
		Const = 4,
		Override = 8,
		Final = 16
	}
}
