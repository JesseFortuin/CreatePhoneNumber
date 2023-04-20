using System.Text;

namespace CreatePhoneNumber.BL
{
    public class PhoneNumberCreator : IPhoneNumberCreator
    {
        public string CreatePhoneNumber(int[] numbers)
        {
            string num = string.Join(", ", numbers);

            var sb = new StringBuilder(num);

            sb.Replace(", ", "");

            num = sb.ToString();

            num = "(" + num.Substring(0, 3) + ") " + num.Substring(3, 3) + "-" + num.Substring(6, 4);

            return num;
        }
    }
}