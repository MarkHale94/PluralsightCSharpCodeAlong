using System;
using Xunit;

namespace GradeBook.Tests {
    public delegate string WriteLogDelegate (string logMessage);
    public class TypeTests {
        int count = 0;
        [Fact]
        public void WriteLogDelegateCanPointToMethod () {
            //Delegates are useful because you can take a variable and treat it like a method
            //Delegates can invoke one or more methods, as long as the return type and the parameters match
            WriteLogDelegate log = ReturnMessage;
            log += ReturnMessage;
            log += IncrementCount;
            var result = log ("Hello");
            Assert.Equal ("Hello", result);
        }
        string ReturnMessage (string message) {
            count++;
            return message;
        }
        string IncrementCount (string message) {
            count++;
            return message.ToLower ();
        }

        [Fact]
        public void StringsBehaveLikeValueTypes () {
            string name = "Mark";
            var upper = MakeUppercase (name);
            Assert.Equal ("Mark", name);
            Assert.Equal ("MARK", upper);
        }

        private string MakeUppercase (string parameter) {
            return parameter = parameter.ToUpper ();
        }

        [Fact]
        public void CSharpCanPassByRef () {
            //arrange
            var book1 = GetBook ("Book 1");
            GetBookSetName (ref book1, "New Name");
            //act

            //assert
            Assert.Equal ("New Name", book1.Name);
        }
        private void GetBookSetName (ref Book book, string name) {
            book = new Book (name);
            book.Name = name;
        }

        [Fact]
        public void CSharpIsPassByValue () {
            //arrange
            var book1 = GetBook ("Book 1");
            GetBookSetName (book1, "New Name");
            //act

            //assert
            Assert.NotEqual ("New Name", book1.Name);
        }

        private void GetBookSetName (Book book, string name) {
            book = new Book (name);
            book.Name = name;
        }

        [Fact]
        public void CanSetNameFromReference () {
            //arrange
            var book1 = GetBook ("Book 1");
            SetName (book1, "New Name");
            //act

            //assert
            Assert.NotEqual ("Book 1", book1.Name);
        }

        private void SetName (Book book, string name) {
            book.Name = name;
        }

        [Fact]
        public void GetBookReturnsDifferentObjects () {
            //arrange
            var book1 = GetBook ("Book 1");
            var book2 = GetBook ("Book 2");
            //act

            //assert
            Assert.Equal ("Book 1", book1.Name);
            Assert.Equal ("Book 2", book2.Name);
            Assert.NotSame (book1, book2);
        }

        [Fact]
        public void GetBookReturnsSameObject () {
            //arrange
            var book1 = GetBook ("Book 1");
            var book2 = book1;
            //act

            //assert
            Assert.Same (book2, book1);
        }

        Book GetBook (string name) {
            return new Book (name);
        }
    }
}