using System.Buffers.Text;
using System.Runtime.CompilerServices;

namespace Algorithms
{
	public  class A
	{
		public int variable1 = 10;
		public int method1()
		{
			int variable2 = 9;
			return variable2;
		}

		public class childA
		{
			public int variable1 = 10;
			public int method1()
			{
				int variable2 = 9;
				return variable2;
			}
		}
	}

	public class B :A
	{
		public void method2()
		{
			method1();
		}
	}

	public class C
	{

		B tes = new B();
		public void method()
		{
			tes.method1();
		}
	}
	
}
