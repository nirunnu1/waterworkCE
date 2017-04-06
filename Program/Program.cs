using DevExpress.Office.Utils;
using System;
using System.Collections.Generic;
using waterwork.Models;

namespace Program
{
    public class list
    {
        public int key { get; set; }
        public int name { get; set; }
    } 
    class Program
    {
        static void Main(string[] args)
        {
            var Context = new waterwork.AssetDbContext();
            Console.WriteLine("Name >>  ");
            var data = new waterwork.Models.province()
            {
                Name = "เชียงราย"
            };
            Context.province.Add(data);
            Context.SaveChanges();

            List<amphur> amphur = new List<amphur>();
            amphur.Add(new amphur() { ID = 657, province_id = 1, Name = "เมืองเชียงราย   " });
            amphur.Add(new amphur() { ID = 658, province_id = 1, Name = "เวียงชัย   " });
            amphur.Add(new amphur() { ID = 659, province_id = 1, Name = "เชียงของ   " });
            amphur.Add(new amphur() { ID = 660, province_id = 1, Name = "เทิง   " });
            amphur.Add(new amphur() { ID = 661, province_id = 1, Name = "พาน   " });
            amphur.Add(new amphur() { ID = 662, province_id = 1, Name = "ป่าแดด   " });
            amphur.Add(new amphur() { ID = 663, province_id = 1, Name = "แม่จัน   " });
            amphur.Add(new amphur() { ID = 664, province_id = 1, Name = "เชียงแสน   " });
            amphur.Add(new amphur() { ID = 665, province_id = 1, Name = "แม่สาย   " });
            amphur.Add(new amphur() { ID = 666, province_id = 1, Name = "แม่สรวย   " });
            amphur.Add(new amphur() { ID = 667, province_id = 1, Name = "เวียงป่าเป้า   " });
            amphur.Add(new amphur() { ID = 668, province_id = 1, Name = "พญาเม็งราย   " });
            amphur.Add(new amphur() { ID = 669, province_id = 1, Name = "เวียงแก่น   " });
            amphur.Add(new amphur() { ID = 670, province_id = 1, Name = "ขุนตาล   " });
            amphur.Add(new amphur() { ID = 671, province_id = 1, Name = "แม่ฟ้าหลวง   " });
            amphur.Add(new amphur() { ID = 672, province_id = 1, Name = "แม่ลาว   " });
            amphur.Add(new amphur() { ID = 673, province_id = 1, Name = "เวียงเชียงรุ้ง   " });
            amphur.Add(new amphur() { ID = 674, province_id = 1, Name = "ดอยหลวง   " });
            foreach (var i in amphur)
            {
                Context.amphur.Add(i);
                Context.SaveChanges();
            }
            List<place> place = new List<place>();

        place.Add(new place() { amphur_id = 1, Name = " เวียง" });
            place.Add(new place() { amphur_id = 1, Name = " รอบเวียง" });
            place.Add(new place() { amphur_id = 1, Name = " บ้านดู่" });
            place.Add(new place() { amphur_id = 1, Name = " นางแล" });
            place.Add(new place() { amphur_id = 1, Name = " แม่ข้าวต้ม" });
            place.Add(new place() { amphur_id = 1, Name = " แม่ยาว" });
            place.Add(new place() { amphur_id = 1, Name = " สันทราย" });
            place.Add(new place() { amphur_id = 1, Name = " *บัวสลี" });
            place.Add(new place() { amphur_id = 1, Name = " *ดงมะดะ" });
            place.Add(new place() { amphur_id = 1, Name = " *ป่าก่อดำ" });
            place.Add(new place() { amphur_id = 1, Name = " แม่กรณ์" });
            place.Add(new place() { amphur_id = 1, Name = " ห้วยชมภู" });
            place.Add(new place() { amphur_id = 1, Name = " ห้วยสัก" });
            place.Add(new place() { amphur_id = 1, Name = " ริมกก" });
            place.Add(new place() { amphur_id = 1, Name = " ดอยลาน" });
            place.Add(new place() { amphur_id = 1, Name = " ป่าอ้อดอนชัย" });
            place.Add(new place() { amphur_id = 1, Name = " *จอมหมอกแก้ว" });
            place.Add(new place() { amphur_id = 1, Name = " ท่าสาย" });
            place.Add(new place() { amphur_id = 1, Name = " *โป่งแพร่" });
            place.Add(new place() { amphur_id = 1, Name = " ดอยฮาง" });
            place.Add(new place() { amphur_id = 1, Name = " ท่าสุด" });
            place.Add(new place() { amphur_id = 1, Name = " *ทุ่งก่อ" });
            place.Add(new place() { amphur_id = 1, Name = " *ป่าก่อดำ" });
            place.Add(new place() { amphur_id = 1, Name = " *ดงมะดะ" });
            place.Add(new place() { amphur_id = 1, Name = " *บัวสลี" });
            place.Add(new place() { amphur_id = 1, Name = " *เวียงเหนือ" });
            place.Add(new place() { amphur_id = 1, Name = " *ผางาม" });
            place.Add(new place() { amphur_id = 1, Name = " *เวียงชัย" });
            place.Add(new place() { amphur_id = 1, Name = " *ทุ่งก่อ" });
            place.Add(new place() { amphur_id = 2, Name = " *ทุ่งก่อ" });
            place.Add(new place() { amphur_id = 2, Name = " เวียงชัย" });
            place.Add(new place() { amphur_id = 2, Name = " ผางาม" });
            place.Add(new place() { amphur_id = 2, Name = " เวียงเหนือ" });
            place.Add(new place() { amphur_id = 2, Name = " *ป่าซาง" });
            place.Add(new place() { amphur_id = 2, Name = " ดอนศิลา" });
            place.Add(new place() { amphur_id = 2, Name = " *ดงมหาวัน" });
            place.Add(new place() { amphur_id = 2, Name = " เมืองชุม" });
            place.Add(new place() { amphur_id = 3, Name = " เวียง" });
            place.Add(new place() { amphur_id = 3, Name = " สถาน" });
            place.Add(new place() { amphur_id = 3, Name = " ครึ่ง" });
            place.Add(new place() { amphur_id = 3, Name = " บุญเรือง" });
            place.Add(new place() { amphur_id = 3, Name = " ห้วยซ้อ" });
            place.Add(new place() { amphur_id = 3, Name = " *ม่วงยาย" });
            place.Add(new place() { amphur_id = 3, Name = " *ปอ" });
            place.Add(new place() { amphur_id = 3, Name = " ศรีดอนชัย" });
            place.Add(new place() { amphur_id = 3, Name = " *หล่ายงาว" });
            place.Add(new place() { amphur_id = 3, Name = " ริมโขง" });
            place.Add(new place() { amphur_id = 3, Name = " *ปอ" });
            place.Add(new place() { amphur_id = 3, Name = " *ม่วงยาย" });
            place.Add(new place() { amphur_id = 4, Name = " เวียง" });
            place.Add(new place() { amphur_id = 4, Name = " งิ้ว" });
            place.Add(new place() { amphur_id = 4, Name = " ปล้อง" });
            place.Add(new place() { amphur_id = 4, Name = " แม่ลอย" });
            place.Add(new place() { amphur_id = 4, Name = " เชียงเคี่ยน" });
            place.Add(new place() { amphur_id = 4, Name = " *ตต้า" });
            place.Add(new place() { amphur_id = 4, Name = " *ปป่าตาล" });
            place.Add(new place() { amphur_id = 4, Name = " *ยยางฮอม" });
            place.Add(new place() { amphur_id = 4, Name = " ตับเต่า" });
            place.Add(new place() { amphur_id = 4, Name = " หงาว" });
            place.Add(new place() { amphur_id = 4, Name = " สันทรายงาม" });
            place.Add(new place() { amphur_id = 4, Name = " ศรีดอนไชย" });
            place.Add(new place() { amphur_id = 4, Name = " หนองแรด" });
            place.Add(new place() { amphur_id = 4, Name = " *แม่ลอย" });
            place.Add(new place() { amphur_id = 4, Name = " *ต้า" });
            place.Add(new place() { amphur_id = 4, Name = " ยางฮอม*" });
            place.Add(new place() { amphur_id = 4, Name = " *แม่เปา" });
            place.Add(new place() { amphur_id = 4, Name = " *ป่าตาล" });
            place.Add(new place() { amphur_id = 5, Name = " สันมะเค็ด" });
            place.Add(new place() { amphur_id = 5, Name = " แม่อ้อ" });
            place.Add(new place() { amphur_id = 5, Name = " ธารทอง" });
            place.Add(new place() { amphur_id = 5, Name = " สันติสุข" });
            place.Add(new place() { amphur_id = 5, Name = " ดอยงาม" });
            place.Add(new place() { amphur_id = 5, Name = " หัวง้ม" });
            place.Add(new place() { amphur_id = 5, Name = " เจริญเมือง" });
            place.Add(new place() { amphur_id = 5, Name = " ป่าหุ่ง" });
            place.Add(new place() { amphur_id = 5, Name = " ม่วงคำ" });
            place.Add(new place() { amphur_id = 5, Name = " ทรายขาว" });
            place.Add(new place() { amphur_id = 5, Name = " สันกลาง" });
            place.Add(new place() { amphur_id = 5, Name = " แม่เย็น" });
            place.Add(new place() { amphur_id = 5, Name = " เมืองพาน" });
            place.Add(new place() { amphur_id = 5, Name = " ทานตะวัน" });
            place.Add(new place() { amphur_id = 5, Name = " เวียงห้าว" });
            place.Add(new place() { amphur_id = 5, Name = " *ป่าแงะ" });
            place.Add(new place() { amphur_id = 5, Name = " *สันมะค่า" });
            place.Add(new place() { amphur_id = 5, Name = " *ป่าแดด" });
            place.Add(new place() { amphur_id = 6, Name = " ป่าแดด" });
            place.Add(new place() { amphur_id = 6, Name = " ป่าแงะ" });
            place.Add(new place() { amphur_id = 6, Name = " สันมะค่า" });
            place.Add(new place() { amphur_id = 6, Name = " โรงช้าง" });
            place.Add(new place() { amphur_id = 6, Name = " ศรีโพธิ์เงิน" });
            place.Add(new place() { amphur_id = 7, Name = " แม่จัน" });
            place.Add(new place() { amphur_id = 7, Name = " จันจว้า" });
            place.Add(new place() { amphur_id = 7, Name = " แม่คำ" });
            place.Add(new place() { amphur_id = 7, Name = " ป่าซาง" });
            place.Add(new place() { amphur_id = 7, Name = " สันทราย" });
            place.Add(new place() { amphur_id = 7, Name = " ท่าข้าวเปลือก" });
            place.Add(new place() { amphur_id = 7, Name = " ปงน้อย*" });
            place.Add(new place() { amphur_id = 7, Name = " ป่าตึง" });
            place.Add(new place() { amphur_id = 7, Name = " หนองป่าก่อ*" });
            place.Add(new place() { amphur_id = 7, Name = " แม่ไร่" });
            place.Add(new place() { amphur_id = 7, Name = " ศรีค้ำ" });
            place.Add(new place() { amphur_id = 7, Name = " จันจว้าใต้" });
            place.Add(new place() { amphur_id = 7, Name = " จอมสวรรค์" });
            place.Add(new place() { amphur_id = 7, Name = " *เเทอดไทย" });
            place.Add(new place() { amphur_id = 7, Name = " *แแม่สลองใน" });
            place.Add(new place() { amphur_id = 7, Name = " *แม่สลองนอก" });
            place.Add(new place() { amphur_id = 7, Name = " โชคชัย*" });
            place.Add(new place() { amphur_id = 8, Name = " เวียง" });
            place.Add(new place() { amphur_id = 8, Name = " ป่าสัก" });
            place.Add(new place() { amphur_id = 8, Name = " บ้านแซว" });
            place.Add(new place() { amphur_id = 8, Name = " ศรีดอนมูล" });
            place.Add(new place() { amphur_id = 8, Name = " แม่เงิน" });
            place.Add(new place() { amphur_id = 8, Name = " โยนก" });
            place.Add(new place() { amphur_id = 9, Name = " แม่สาย" });
            place.Add(new place() { amphur_id = 9, Name = " ห้วยไคร้" });
            place.Add(new place() { amphur_id = 9, Name = " เกาะช้าง" });
            place.Add(new place() { amphur_id = 9, Name = " โป่งผา" });
            place.Add(new place() { amphur_id = 9, Name = " ศรีเมืองชุม" });
            place.Add(new place() { amphur_id = 9, Name = " เวียงพางคำ" });
            place.Add(new place() { amphur_id = 9, Name = " บ้านด้าย" });
            place.Add(new place() { amphur_id = 9, Name = " โป่งงาม" });
            place.Add(new place() { amphur_id = 10, Name = " แม่สรวย" });
            place.Add(new place() { amphur_id = 10, Name = " ป่าแดด" });
            place.Add(new place() { amphur_id = 10, Name = " แม่พริก" });
            place.Add(new place() { amphur_id = 10, Name = " ศรีถ้อย" });
            place.Add(new place() { amphur_id = 10, Name = " ท่าก๊อ" });
            place.Add(new place() { amphur_id = 10, Name = " วาวี" });
            place.Add(new place() { amphur_id = 10, Name = " เจดีย์หลวง" });
            place.Add(new place() { amphur_id = 11, Name = " สันสลี" });
            place.Add(new place() { amphur_id = 11, Name = " เวียง" });
            place.Add(new place() { amphur_id = 11, Name = " บ้านโป่ง" });
            place.Add(new place() { amphur_id = 11, Name = " ป่างิ้ว" });
            place.Add(new place() { amphur_id = 11, Name = " เวียงกาหลง" });
            place.Add(new place() { amphur_id = 11, Name = " แม่เจดีย์" });
            place.Add(new place() { amphur_id = 11, Name = " แม่เจดีย์ใหม่" });
            place.Add(new place() { amphur_id = 11, Name = " เวียงกาหลง*" });
            place.Add(new place() { amphur_id = 12, Name = " แม่เปา" });
            place.Add(new place() { amphur_id = 12, Name = " แม่ต๋ำ" });
            place.Add(new place() { amphur_id = 12, Name = " ไม้ยา" });
            place.Add(new place() { amphur_id = 12, Name = " เม็งราย" });
            place.Add(new place() { amphur_id = 12, Name = " ตาดควัน" });
            place.Add(new place() { amphur_id = 13, Name = " ม่วงยาย" });
            place.Add(new place() { amphur_id = 13, Name = " ปอ" });
            place.Add(new place() { amphur_id = 13, Name = " หล่ายงาว" });
            place.Add(new place() { amphur_id = 13, Name = " ท่าข้าม" });
            place.Add(new place() { amphur_id = 14, Name = " ต้า" });
            place.Add(new place() { amphur_id = 14, Name = " ป่าตาล" });
            place.Add(new place() { amphur_id = 14, Name = " ยางฮอม" });
            place.Add(new place() { amphur_id = 15, Name = " เทอดไทย" });
            place.Add(new place() { amphur_id = 15, Name = " แม่สลองใน" });
            place.Add(new place() { amphur_id = 15, Name = " แม่สลองนอก" });
            place.Add(new place() { amphur_id = 15, Name = " แม่ฟ้าหลวง" });
            place.Add(new place() { amphur_id = 16, Name = " ดงมะดะ" });
            place.Add(new place() { amphur_id = 16, Name = " จอมหมอกแก้ว" });
            place.Add(new place() { amphur_id = 16, Name = " บัวสลี" });
            place.Add(new place() { amphur_id = 16, Name = " ป่าก่อดำ" });
            place.Add(new place() { amphur_id = 16, Name = " โป่งแพร่" });
            place.Add(new place() { amphur_id = 17, Name = " ทุ่งก่อ" });
            place.Add(new place() { amphur_id = 17, Name = " ดงมหาวัน" });
            place.Add(new place() { amphur_id = 17, Name = " ป่าซาง" });
            place.Add(new place() { amphur_id = 18, Name = " ปงน้อย" });
            place.Add(new place() { amphur_id = 18, Name = " โชคชัย" });
            place.Add(new place() { amphur_id = 18, Name = " หนองป่าก่อ" });




            foreach (var i in place)
            {
                Context.place.Add(i);
                Context.SaveChanges();
            }



        }

    }
}
