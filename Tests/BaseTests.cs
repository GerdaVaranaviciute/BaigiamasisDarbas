using Framework;
using NUnit.Framework;

namespace Tests
{
    internal class BaseTests
    {
        [SetUp] 
        public void SetUp() 
        {
            Driver.InitializeDriver();  
        }

        [TearDown] 
        public void TearDown() 
        {
            Driver.QuitDriver();
        }
    }
}
