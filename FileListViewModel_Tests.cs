using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfXmlDemo.ViewModels;

namespace WpfXmlDemo.UnitTest
{
    [TestFixture]
    public class FileListViewModel_Tests
    {
        [Test]
        public void VMCanSave_Test()
        {
            FileListViewModel vm = new FileListViewModel("", "");
            Assert.DoesNotThrow(() => { bool test = vm.CanSave; });
        }

        [Test]
        public void VMSave_Test()
        {
            FileListViewModel vm = new FileListViewModel("", "");
            Assert.Throws<NotImplementedException>(() => { vm.Save(); });
        }
    }
}
