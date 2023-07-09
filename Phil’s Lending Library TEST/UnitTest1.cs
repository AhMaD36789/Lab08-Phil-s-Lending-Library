using Lab08_Phil_s_Lending_Library.Classes;

namespace Phil_s_Lending_Library_TEST
{
    public class UnitTest1
    {
        [Fact]
        public void AddingBookTOLibrary()
        {
            Library library = new Library();
            library.Add("bokokkaav1", "ahmad", "saleh", 300);

            int result = library.Count();

            Assert.Equal(1, result);

        }

        [Fact]
        public void BorrowingBookFromLibrary()
        {
            Library library = new Library();
            library.Add("bokokkaav1", "ahmad", "saleh", 300);
            library.Borrow("bokokkaav1");
            int result = library.Count();

            Assert.Equal(0, result);

        }

        [Fact]
        public void BorrowingMissingBookFromLibrary()
        {
            Library library = new Library();
            library.Add("bokokkaav1", "ahmad", "saleh", 300);

            var result = library.Borrow("bokokkaav");

            Assert.Equal(null, result);

        }

        [Fact]
        public void ReturningBookToLibrary()
        {
            Library library = new Library();
            library.Add("bokokkaav1", "ahmad", "saleh", 300);
            library.Borrow("bokokkaav1");
            library.Return(new Book("bokokkaav1", "ahmad", "saleh", 300));
            int result = library.Count();

            Assert.Equal(1, result);

        }

        [Fact]
        public void PackingBackPack()
        {
            Backpack<string> backpack = new Backpack<string>();
            string result = ("this is my hourse. my hourse is amazing");
            backpack.Pack(result);
            Assert.Contains(result, backpack);
        }
        [Fact]
        public void UnPackingBackPack()
        {
            Backpack<string> backpack = new Backpack<string>();
            string result = ("this is my hourse. my hourse is amazing");
            backpack.Pack(result);
            string result2 = ("MY NAME IS VECTOR REZNOV AND I WILL HAVE MY REVENGE");
            backpack.Pack(result2);
            backpack.Unpack(0);
            Assert.DoesNotContain(result, backpack);
        }
    }
}