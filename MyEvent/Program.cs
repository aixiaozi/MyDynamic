using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestEvents
{
    using MyCollections;

    class EventListener
    {
        private ListWithChangedEvent List;

        public EventListener(ListWithChangedEvent list)
        {
            List = list;
            // Add "ListChanged" to the Changed event on "List":
            List.Changed += new EventHandler(ListChanged);
        }

        // This will be called whenever the list changes:
        private void ListChanged(object sender, EventArgs e)
        {
            Console.WriteLine("This is called when the event fires.");
        }

        public void Detach()
        {
            // Detach the event and delete the list:
            List.Changed -= new EventHandler(ListChanged);
            List = null;
        }
    }

    class Test
    {
        // Test the ListWithChangedEvent class:
        public static void Main()
        {
            // Create a new list:
            ListWithChangedEvent list = new ListWithChangedEvent();

            // Create a class that listens to the list's change event:
            EventListener listener = new EventListener(list);

            // Add and remove items from the list:
            list.Add("item 1");
            list.Clear();
            listener.Detach();
        }
    }
}
