using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NganHang_PhanTan.Component;
namespace NganHang_PhanTan.Component
{
    class ActionDataControl
    {
        //Quy định max action có thể back lại là bn
        public readonly static int MAX_RECORD_STACK = 25;


        public static void ResolveStackStorage(LinkedList<ActionData> stack)
        {
            if (stack.Count == MAX_RECORD_STACK)
                stack.RemoveFirst();
        }
    }
}
