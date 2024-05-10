using System;
using System.Windows.Forms;

using System.Text.RegularExpressions;

namespace NganHang_PhanTan.Util
{
    public class FormatValidator
    {
        public static bool isSTKInputValid(string input)
        {
            // Kiểm tra xem chuỗi có đúng 10 ký tự không
            if (input.Length == 0)
            {
                return false;
            }

            // Kiểm tra xem chuỗi chỉ chứa các chữ số không
            if (!Regex.IsMatch(input, @"^\d+$"))
            {
                return false;
            }

            return true;
        }
    }
}
