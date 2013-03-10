using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeviceModel;

namespace MobilePhone
{
    class GMSTest
    {
        static void Main()
        {
            GSM[] mobilePhones = new GSM[3];

            GSM nokia = new GSM("3310", "Nokia");

            nokia.AddHistory(DateTime.Now, 0998080907, 1.08);
            nokia.AddHistory(DateTime.Now, 0998080907, 2132331.08);
            nokia.DeleteHistory(1);

            Battery sonyBattery5511 = new Battery("77ds7", 220, 10, BatteryType.NiMH);
            Display sonyDisplay5511 = new Display(23, 128);
            GSM sony = new GSM("5511", "Sony", 100.77m, "Pesho", sonyBattery5511, sonyDisplay5511);

            GSM samsung = new GSM("4433", "samsung", 50.22m, "Gosho");

            mobilePhones[0] = nokia;
            mobilePhones[1] = sony;
            mobilePhones[2] = samsung;

            //Console.WriteLine(nokia.CalcPriceHistory(2.2m));
            for (int i = 0; i < mobilePhones.Length; i++)
            {
                Console.WriteLine(mobilePhones[i]);
            }
            
        }
    }
}
