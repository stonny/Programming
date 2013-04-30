namespace CodeRefactoring
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class EventHolder
    {
        private MultiDictionary<string, Event> title = new MultiDictionary<string, Event>(true);
        private OrderedBag<Event> date = new OrderedBag<Event>();

        public void AddEvent(dateTime date, string title, string location)
        {
            Event newEvent = new Event(date, title, location);
            this.title.Add(title.ToLower(), newEvent);
            this.date.Add(newEvent);
            Messages.EventAdded();
        }

        public void DeleteEvents(string titleToDelete)
        {
            string titleToRemove = titleToDelete.ToLower();
            int removed = 0;
            foreach (var eventToRemove in this.title[titleToRemove])
            {
                removed++;
                this.bydate.Remove(eventToRemove);
            }

            this.title.Remove(titleToRemove);
            Messages.EventDeleted(removed);
        }

        public void ListEvents(dateTime date, int count)
        {
            OrderedBag<Event>.View eventsToShow =
                this.date.RangeFrom(new Event(date, string.Empty, string.Empty), true);
            int showed = 0;

            foreach (var eventToShow in eventsToShow)
            {
                if (showed == count)
                {
                    break;
                }

                Messages.PrintEvent(eventToShow);
                showed++;
            }

            if (showed == 0)
            {
                Messages.NoEventsFound();
            }
        }
    }
}
