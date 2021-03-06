/*
Copyright (C) 2018-2019 de4dot@gmail.com

Permission is hereby granted, free of charge, to any person obtaining
a copy of this software and associated documentation files (the
"Software"), to deal in the Software without restriction, including
without limitation the rights to use, copy, modify, merge, publish,
distribute, sublicense, and/or sell copies of the Software, and to
permit persons to whom the Software is furnished to do so, subject to
the following conditions:

The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY
CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

#if !NO_GAS_FORMATTER && !NO_FORMATTER && !NO_ENCODER
using System.Collections.Generic;
using Iced.Intel;
using Iced.UnitTests.Intel.DecoderTests;
using Xunit;

namespace Iced.UnitTests.Intel.FormatterTests.Gas {
	public sealed class GasFormatterTest64_NonDec_NoSuffix_000 : FormatterTest {
		[Theory]
		[MemberData(nameof(Format_Data))]
		void Format(int index, Instruction info, string formattedString) => FormatBase(index, info, formattedString, GasFormatterFactory.Create_NoSuffix());
		public static IEnumerable<object[]> Format_Data => GetFormatData(NonDecodedInstructions.Infos64, formattedStrings);

		static readonly string[] formattedStrings = new string[NonDecodedInstructions.Infos64_Count] {
			"fstenv (%rax)",
			"fstenv %fs:(%rax)",
			"fstenv (%rax)",
			"fstenv %fs:(%rax)",
			"fstcw (%rax)",
			"fstcw %fs:(%rax)",
			"feni",
			"fdisi",
			"fclex",
			"finit",
			"fsetpm",
			"fsave (%rax)",
			"fsave %fs:(%rax)",
			"fsave (%rax)",
			"fsave %fs:(%rax)",
			"fstsw (%rax)",
			"fstsw %fs:(%rax)",
			"fstsw %ax",
			".byte 0x77",
			".byte 0x77,0xa9",
			".byte 0x77,0xa9,0xce",
			".byte 0x77,0xa9,0xce,0x9d",
			".byte 0x77,0xa9,0xce,0x9d,0x55",
			".byte 0x77,0xa9,0xce,0x9d,0x55,5",
			".byte 0x77,0xa9,0xce,0x9d,0x55,5,0x42",
			".byte 0x77,0xa9,0xce,0x9d,0x55,5,0x42,0x6c",
			".byte 0x77,0xa9,0xce,0x9d,0x55,5,0x42,0x6c,0x86",
			".byte 0x77,0xa9,0xce,0x9d,0x55,5,0x42,0x6c,0x86,0x32",
			".byte 0x77,0xa9,0xce,0x9d,0x55,5,0x42,0x6c,0x86,0x32,0xfe",
			".byte 0x77,0xa9,0xce,0x9d,0x55,5,0x42,0x6c,0x86,0x32,0xfe,0x4f",
			".byte 0x77,0xa9,0xce,0x9d,0x55,5,0x42,0x6c,0x86,0x32,0xfe,0x4f,0x34",
			".byte 0x77,0xa9,0xce,0x9d,0x55,5,0x42,0x6c,0x86,0x32,0xfe,0x4f,0x34,0x27",
			".byte 0x77,0xa9,0xce,0x9d,0x55,5,0x42,0x6c,0x86,0x32,0xfe,0x4f,0x34,0x27,0xaa",
			".byte 0x77,0xa9,0xce,0x9d,0x55,5,0x42,0x6c,0x86,0x32,0xfe,0x4f,0x34,0x27,0xaa,8",
			".word 0x77a9",
			".word 0x77a9,0xce9d",
			".word 0x77a9,0xce9d,0x5505",
			".word 0x77a9,0xce9d,0x5505,0x426c",
			".word 0x77a9,0xce9d,0x5505,0x426c,0x8632",
			".word 0x77a9,0xce9d,0x5505,0x426c,0x8632,0xfe4f",
			".word 0x77a9,0xce9d,0x5505,0x426c,0x8632,0xfe4f,0x3427",
			".word 0x77a9,0xce9d,0x5505,0x426c,0x8632,0xfe4f,0x3427,0xaa08",
			".int 0x77a9ce9d",
			".int 0x77a9ce9d,0x5505426c",
			".int 0x77a9ce9d,0x5505426c,0x8632fe4f",
			".int 0x77a9ce9d,0x5505426c,0x8632fe4f,0x3427aa08",
			".quad 0x77a9ce9d5505426c",
			".quad 0x77a9ce9d5505426c,0x8632fe4f3427aa08",
		};
	}
}
#endif
