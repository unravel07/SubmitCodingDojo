using System;

namespace Homework11Lib
{
    public class Homework11 : IHomework11
    {
        public string GetReadWordOfNumber(int number)
        {
            var num = number.ToString();
            int length = num.Length;

            if (length == 0)
            {
                Console.WriteLine("empty string");
            }
            if (length > 4)
            {
                Console.WriteLine("Length more than 6 digit is not supported");
            }

            string[] one_digits = new string[] { "ศูนย์", "หนึ่ง", "สอง", "สาม", "สี่", "ห้า", "หก", "เจ็ด", "แปด", "เก้า" };
            string[] scale = new string[] {"สิบ","ร้อย","พัน","หมื่น","แสน","ล้าน"};
            
            // string[] two_digits = new string[] { "สิบ", "ยี่สิบ", "สามสิบ", "สี่สิบ", "ห้าสิบ", "หกสิบ", "เจ็บสิบ", "แปดสิบ", "เก้าสิบ" }; 
            // string[] three_digits = new string[] { "หนึ่งร้อย", "สองร้อย", "สามร้อย", "สี่ร้อย", "ห้าร้อย", "หกร้อย", "เจ็ดร้อย", "แปดร้อย", "เก้าร้อย" };
            // string[] four_digits = new string[] { "หนึ่งพัน", "สองพัน", "สามพัน", "สี่พัน", "ห้าพัน", "หกพัน", "เจ็ดพัน", "แปดพัน", "เก้าพัน" };
            // string[] five_digits = new string[] { "หนึ่งหมื่น", "สองหมื่น", "สามหมื่น", "สี่หมื่น", "ห้าหมื่น", "หกหมื่น", "เจ็ดหมื่น", "แปดหมื่น", "เก้าหมื่น" };
            // string[] six_digits = new string[] { "หนึ่งแสน", "สองแสน", "สามแสน", "สี่แสน", "ห้าแสน", "หกแสน", "เจ็ดแสน", "แปดแสน", "เก้าแสน" };
            // string[] seven_digits = new string[] { "หนึ่งล้าน", "สองล้าน", "สามล้าน", "สี่ล้าน", "ห้าล้าน", "หกล้าน", "เจ็ดล้าน", "แปดล้าน", "เก้าล้าน" };

            if (length < 1  )
            {

            }



            throw new NotImplementedException();
        }
    }
}

//ล้าน
//แสน
//หมื่น
//พัน
//ร้อย
//สิบ

