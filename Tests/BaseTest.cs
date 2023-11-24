using Framework;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace Tests
{
    internal class BaseTest
    {
        [SetUp] 
        public void SetUp() 
        {
            Driver.InitializeDriver();  
        }

        [TearDown] 
        public void TearDown() 
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                string methodName = TestContext.CurrentContext.Test.MethodName;
                string filePath = Driver.TakeScreenshot(methodName);
                TestContext.AddTestAttachment(filePath);
            }
            Driver.QuitDriver();
        }
    }
}
