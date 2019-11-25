﻿using System.Collections.Generic;
using NUnit.Framework.Interfaces;
using Xamarin.Forms.Controls.Tests;
using Xamarin.Forms.Xaml;

namespace Xamarin.Forms.Controls.GalleryPages.PlatformTestsGallery
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PlatformTestsConsole : ContentPage
	{
		const string FailedText = "FAILED";
		const string InconclusiveText = "Inconclusive";
		const string SuccessText = "SUCCESS";
		bool _runFailed;
		bool _runInconclusive;
		readonly Color _successColor = Color.Green;
		readonly Color _failColor = Color.Red;
		readonly Color _inconclusiveColor = Color.Goldenrod;

		public PlatformTestsConsole()
		{
			InitializeComponent();
			MessagingCenter.Subscribe<ITest>(this, "TestStarted", TestStarted);
			MessagingCenter.Subscribe<ITestResult>(this, "TestFinished", TestFinished);
		}

		protected override async void OnAppearing()
		{
			base.OnAppearing();

			var tests = new PlatformTestRunner();
			if (tests != null)
			{
				await tests.Run();
			}

			DisplayOverallResult();
		}

		void DisplayOverallResult()
		{
			Device.BeginInvokeOnMainThread(() =>
			{

				if (_runFailed)
				{
					Status.Text = FailedText;
					Status.TextColor = _failColor;
				}
				else if (_runInconclusive)
				{
					Status.Text = InconclusiveText;
					Status.TextColor = _inconclusiveColor;
				}
				else
				{
					Status.Text = SuccessText;
					Status.TextColor = _successColor;
				}

			});
		}

		void TestStarted(ITest test)
		{
			if (!test.IsSuite || IgnoreLevelForOutput(test))
			{
				return;
			}

			var name = ShortenTestName(test.FullName);

			var label = new Label { Text = $"{name} Started", LineBreakMode = LineBreakMode.HeadTruncation };

			Device.BeginInvokeOnMainThread(() =>
			{
				Results.Children.Add(label);
			});
		}

		void TestFinished(ITestResult result)
		{
			if (IgnoreLevelForOutput(result.Test))
			{
				return;
			}

			if (result.Test.IsSuite)
			{
				OutputSuiteResult(result);
			}
			else
			{
				OutputTestResult(result);
			}
		}

		void OutputTestResult(ITestResult result)
		{
			var name = ShortenTestName(result.FullName);

			var outcome = "Fail";

			if (result.PassCount > 0)
			{
				outcome = "Pass";
			}
			else if (result.InconclusiveCount > 0)
			{
				outcome = "Inconclusive";
			}

			var label = new Label { Text = $"{name}: {outcome}.", LineBreakMode = LineBreakMode.HeadTruncation };

			if (result.FailCount > 0)
			{
				label.TextColor = _failColor;
				_runFailed = true;
			}
			else if (result.InconclusiveCount > 0)
			{
				label.TextColor = _inconclusiveColor;
				_runInconclusive = true;
			}
			else
			{
				label.TextColor = _successColor;
			}

			var margin = new Thickness(15, 0, 0, 0);
			label.Margin = margin;

			var toAdd = new List<View> { label };

			foreach (var assertionResult in result.AssertionResults)
			{
				if (assertionResult.Status != AssertionStatus.Passed)
				{
					toAdd.Add(new Label { Text = assertionResult.Message });
					toAdd.Add(new Editor { Text = assertionResult.StackTrace, IsReadOnly = true });
				}
			}

			if (!string.IsNullOrEmpty(result.Output))
			{
				toAdd.Add(new Label { Text = result.Output, Margin = margin });
			}

			Device.BeginInvokeOnMainThread(() =>
			{
				foreach (var outputView in toAdd)
				{
					Results.Children.Add(outputView);
				}
				
			});
		}

		void OutputSuiteResult(ITestResult result)
		{
			var name = ShortenTestName(result.FullName);

			var label = new Label { Text = $"{name} Finished.", LineBreakMode = LineBreakMode.HeadTruncation };
			var counts = new Label { Text = $"Passed: {result.PassCount}; Failed: {result.FailCount}; Inconclusive: {result.InconclusiveCount}" };

			if (result.FailCount > 0)
			{
				label.TextColor = _failColor;
				_runFailed = true;
			}
			else if (result.InconclusiveCount > 0)
			{
				label.TextColor = _inconclusiveColor;
				_runInconclusive = true;
			}
			else
			{
				label.TextColor = _successColor;
			}

			counts.TextColor = label.TextColor;

			Device.BeginInvokeOnMainThread(() =>
			{
				Results.Children.Add(label);
				Results.Children.Add(counts);
			});
		}

		static readonly List<string> Trimmable = new List<string>
		{
				"Xamarin.Forms.ControlGallery.Android.",
				"Xamarin.Forms.ControlGallery.",
				"Xamarin.Forms.Controls.Tests.",
				"Xamarin.Forms.Controls.",
		};

		static readonly List<string> Ignorable = new List<string>
		{
				"Xamarin", "Xamarin.Forms",
				"Xamarin.Forms.ControlGallery",
				"Xamarin.Forms.ControlGallery.Android",
				"Xamarin.Forms.ControlGallery.iOS",
				"Xamarin.Forms.Controls", "Xamarin.Forms.Controls.Tests"
		};

		static string ShortenTestName(string name)
		{
			foreach (var str in Trimmable)
			{
				if (name.StartsWith(str))
				{
					return name.Substring(str.Length);
				}
			}

			return name;
		}

		static bool IgnoreLevelForOutput(ITest test)
		{
			if (test.FullName.EndsWith(".exe") || test.FullName.EndsWith(".dll"))
			{
				return true;
			}

			return Ignorable.Contains(test.FullName);
		}
	}
}