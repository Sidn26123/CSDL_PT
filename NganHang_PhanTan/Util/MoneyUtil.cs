using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NganHang_PhanTan.Util
{
    class MoneyUtil
    {
        public static string ToStringMoney(double m, string s)
        {
            // Chuyển đổi số double thành chuỗi có định dạng tiền tệ
            string moneyString = m.ToString("N");

            // Nếu có dấu phân cách được chỉ định, thêm dấu phân cách giữa 3 số
            if (!string.IsNullOrEmpty(s))
            {
                // Thay thế dấu phân cách mặc định bằng dấu phân cách được chỉ định
                moneyString = moneyString.Replace(",", s);
            }

            return moneyString;
        }

        public static string formatMoneyStr(string input, string sep)
        {
            System.Text.StringBuilder result = new System.Text.StringBuilder();

            // Lặp qua từng ký tự trong chuỗi đầu vào, bắt đầu từ cuối chuỗi
            for (int i = input.Length - 1; i >= 0; i--)
            {
                // Thêm ký tự từ chuỗi đầu vào vào đầu chuỗi kết quả
                result.Insert(0, input[i]);

                // Nếu đây là ký tự thứ 3 từ phía sau, thêm ký tự vào giữa
                if ((input.Length - i) % 3 == 0 && i != 0) // Kiểm tra i != 0 để tránh thêm ký tự vào đầu chuỗi kết quả
                {
                    result.Insert(0, sep);
                }
            }

            // Trả về chuỗi mới đã được xây dựng
            return result.ToString();
        }
    }
}
