using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NganHang_PhanTan.Component
{
        public class ActionData
        {
            public enum EventType
            {
                CANCEL_EDIT,
                INSERT,
                DELETE,
                UPDATE,
            }

            private EventType type;
            private object content;
            private int positionInGird;

            public EventType Type { get => type; set => type = value; }
            public object Content { get => content; set => content = value; }
            public int PositionInGird { get => positionInGird; set => positionInGird = value; }
            
            public ActionData(EventType type)
            {
                this.Type = type;
                this.Content = null;
                this.positionInGird = -1;
            }

            public ActionData(EventType type, object content, int gridPos)
            {
                this.Type = type;
                this.Content = content;
                this.positionInGird = gridPos;
            }

        }

}
