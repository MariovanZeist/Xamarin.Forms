using System.Diagnostics;
using NUnit.Framework.Interfaces;
using Xamarin.Forms;
using Xamarin.Forms.ControlGallery.Android;

namespace Xamarin.Forms.ControlGallery.Android
{
	//public class ControlGalleryTestListener : ITestListener
	//{
	//	public void SendMessage(TestMessage message)
	//	{
	//		Debug.WriteLine(message);
	//	}

	//	public void TestFinished(ITestResult result)
	//	{
	//		Debug.WriteLine($"{result.Name} finished");
	//		MessagingCenter.Send(result, "TestFinished");
	//	}

	//	public void TestOutput(TestOutput output)
	//	{
	//		Debug.WriteLine(output);
	//	}

	//	public void TestStarted(ITest test)
	//	{
	//		Debug.WriteLine($"{test.Name} started");
	//		MessagingCenter.Send(test, "TestStarted");
	//	}

	//	void PrintResults(ITestResult result)
	//	{
	//		Debug.WriteLine($">>>>>> name {result.FullName}");
	//		Debug.WriteLine($">>>>>> Passcount {result.PassCount}");
	//		Debug.WriteLine($">>>>>> Failcount {result.FailCount}");

	//		Debug.WriteLine($">>>>>> StackTrace: {result.StackTrace}");
	//		Debug.WriteLine($">>>>>> RunState: {result.Test.RunState}");

	//		Debug.WriteLine($">>>>>> Properties: {result.Test.Properties}");

	//		Debug.WriteLine($">>>>>> Inconclusive: {result.InconclusiveCount}");

	//		Debug.WriteLine($">>>>>> Output: {result.Output}");


	//		if (result.HasChildren)
	//		{
	//			foreach (var r in result.Children)
	//			{
	//				PrintResults(r);
	//			}
	//		}
	//	}
	//}
}