using CreatePhoneNumber.BL;

namespace CreatePhoneNumber.Test
{
    public class UnitTest1
    {
        [Fact]
        public void CreatePhoneNumberTest()
        {
            //arrange
            IPhoneNumberCreator creator = new PhoneNumberCreator();

            int[] input = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            string expected = "(123) 456-7890";
            //act

            string actual = creator.CreatePhoneNumber(input);
            //assert

            Assert.Equal(expected, actual);
        }
    }
}