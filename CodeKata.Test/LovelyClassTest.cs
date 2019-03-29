using CodeKata.Con;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeKata.Test {
	[TestClass]
	public class LovelyClassTest {

		/// <summary>
		/// Wird vor der Ausführung jedes Tests aufgerufen.
		/// </summary>
		[TestInitialize]
		public void InitializeTest() {

		}

		/// <summary>
		/// Bereinigt einen Test
		/// </summary>
		[TestCleanup]
		public void Cleanup() {



		}

		[TestMethod]
		public void TestMyLovelyClass() {

			LovelyMathClass lovelyMathClass = new LovelyMathClass();
			int result = lovelyMathClass.Add(5, 10);

			Assert.AreEqual(15, result);
		}
	}
}
