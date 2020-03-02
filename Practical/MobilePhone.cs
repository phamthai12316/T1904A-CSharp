namespace t1904a.Practical
{
    public class MobilePhone : Phone
    {
        public MobilePhone()
        {
        }

        public MobilePhone(string phoneName, string phoneType, float phonePrice) : base(phoneName, phoneType, phonePrice)
        {
            this.PhoneType = "Mobile";
        }
    }
}