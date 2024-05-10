using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NganHang_PhanTan.Util
{
    class NameFormatter
    {
        public static string CapitalizeFirstLetter(string input)
        {
            // Kiểm tra xem chuỗi đầu vào có null hoặc rỗng không
            if (string.IsNullOrEmpty(input))
                return input;

            // Chuyển đổi ký tự đầu tiên thành chữ in hoa
            return char.ToUpper(input[0]) + input.Substring(1);
        }

        public static string RemoveDuplicateSpace(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            StringBuilder sb = new StringBuilder();
            bool lastWasSpace = false;

            foreach (char c in input)
            {
                if (char.IsWhiteSpace(c))
                {
                    if (!lastWasSpace)
                    {
                        sb.Append(c);
                        lastWasSpace = true;
                    }
                }
                else
                {
                    sb.Append(c);
                    lastWasSpace = false;
                }
            }

            return sb.ToString();
        }
    }
}
