using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wroxx.Publishing.Domain;
using Wroxx.Publishing.Infrastructure;

namespace Wroxx.Publishing.Tests
{
    [TestClass]
    public class When_calling_GetWordCount
    {
        [TestMethod]
        public void Returns_Count_For_Valid_Content()
        {
            //Arrange
            IBook validBook = new MockBookManager() { Content = "This is a statement, and so is this." };
            var _author = new Author(validBook);

            //Act
            var repeatedWordInfo = _author.GetRepeatedWordInfo();
            //Assert
            Assert.AreEqual(6, repeatedWordInfo.Count());
        }


        [TestMethod]
        public void Returns_Zero_Count_For_InValid_Content()
        {
            //Arrange
            IBook validBook = new MockBookManager() { Content = "&*$*££." };
            var _author = new Author(validBook);

            //Act
            var repeatedWordInfo = _author.GetRepeatedWordInfo();
            //Assert
            Assert.AreEqual(0, repeatedWordInfo.Count());
        }

        [TestMethod]
        public void Returns_Count_Without_Any_Special_Characters()
        {
            //Arrange
            IBook validBook = new MockBookManager() { Content = "This is a &&&*^ simple Text" };
            var _author = new Author(validBook);

            //Act
            var repeatedWordInfo = _author.GetRepeatedWordInfo();
            //Assert
            Assert.AreEqual(5, repeatedWordInfo.Count());
        }

        [TestMethod]
        public void Returns_Exact_Count_Of_Words()
        {
            //Arrange
            IBook validBook = new MockBookManager() { Content = "This is a statement, and so is this." };
            var _author = new Author(validBook);

            //Act
            var repeatedWordInfo = _author.GetRepeatedWordCount();
            var word = repeatedWordInfo.Find(v => v.Item1 == "this");
            
            //Assert
            
            Assert.IsNotNull(word);
            Assert.AreEqual(2,word.Item2);

        }

        public void Returns_No_Items_when_Item_Not_Found()
        {
            //Arrange
            IBook validBook = new MockBookManager() { Content = "This is a statement, and so is this." };
            var _author = new Author(validBook);

            //Act
            var repeatedWordInfo = _author.GetRepeatedWordCount();
            var word = repeatedWordInfo.Find(v => v.Item1 == "Test");

            //Assert

            Assert.IsNull(word);

        }

    }
}
