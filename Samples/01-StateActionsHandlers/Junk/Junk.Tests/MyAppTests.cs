using Microsoft.Playwright;
using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace YourNamespace
{
    [TestFixture]
    public class MyAppTests
    {
        [Test]
        public async Task TestHomePage()
        {
            using var playwright = await Playwright.CreateAsync();
            await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false // Set to true for headless mode
            });

            var page = await browser.NewPageAsync();
            await page.GotoAsync("http://localhost:5080/");

            // Add your test logic here
            // Click on the "Counter" link
            await page.ClickAsync("text=Counter");

            // Wait for 3 seconds
            await Task.Delay(3000); // 3000 milliseconds = 3 seconds

            // Click on the button with the text "Click me"
            await page.ClickAsync("button:text('Click me')");

            // Wait for 9 seconds
            await Task.Delay(9000); // 3000 milliseconds = 3 seconds


            // Wait for user input
            // Console.WriteLine("Do you wish to end the test? (yes/no)");
            // string userInput = Console.ReadLine();

            // if (userInput?.ToLower() == "yes")
            // {
            //     // Add any clean up logic if necessary
            //     Console.WriteLine("Test ending.");
            // }
            // else
            // {
            //     Console.WriteLine("Test will continue running.");
            //     // Add additional logic to continue running the test
            // }

            // Assert.IsTrue(/* condition for your test */);
        }
    }
}


