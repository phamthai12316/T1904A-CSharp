using System;
using System.ComponentModel.DataAnnotations;

namespace t1904a.Practical
{
    public class Phone
    {
        private string phoneName;
        private string phoneType;
        private float phonePrice;

        public Phone()
        {
        }

        public Phone(string phoneName, string phoneType, float phonePrice)
        {
            this.phoneName = phoneName;
            this.phoneType = phoneType;
            this.phonePrice = phonePrice;
        }
        
        public string PhoneName
        {
            get
            {
                return phoneName;
            }

            set
            {
                phoneName = value;
            }
        }

        public string PhoneType
        {
            get
            {
                return phoneType;
            }

            set
            {
                phoneType = value;
            }
        }

        public float PhonePrice
        {
            get
            {
                return phonePrice;
            }

            set
            {
                phonePrice = value;
            }
        }

        public void Display()
        {
            Console.WriteLine("Phone" +  phoneName + "type" + phoneType + "price" + phonePrice );
        }
    }
}