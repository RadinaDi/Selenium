using System;
using Vivacom.Extensions;
using Vivacom.Model;

namespace Vivacom.Data
{
    public static class SmsData
    {
        private static Random random = new Random();

        public static Sms NewSms()
        {
            return new Sms()
            {
                Message = random.NextString(maxLength: 100),
            };
        }

        public static Sms WithFromNumber(this Sms sms, string fromNumber)
        {
            sms.FromNumber = fromNumber;
            return sms;
        }

        public static Sms WithToNumber(this Sms sms, string toNumber)
        {
            sms.ToNumber = toNumber;
            return sms;
        }
    }
}
