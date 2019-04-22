using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_6.MultipleInheritance
{
    public class TextBox : UIControl, IDraggable, IDroppable
    {
        public void Drag()
        {
            throw new NotImplementedException();
        }

        public void Drop()
        {
            throw new NotImplementedException();
        }
    }
    public class UIControl
    {
        public string Id { get; set; }
        public Size Size { get; set; }
        public Position TopLeft { get; set; }

        public virtual void Draw()
        {

        }

        public void Fokus()
        {
            Console.WriteLine("Received fokus.");
        }
    }
}
