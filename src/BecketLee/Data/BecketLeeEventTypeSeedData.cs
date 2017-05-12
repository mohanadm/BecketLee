using System.Threading.Tasks;
using System.Linq;
using BecketLee.Models;

namespace BecketLee.Data
{
    public class BecketLeeEventTypeSeedData 
    {
        public static async Task EnsureEventTypeData( BecketLeeContext context )
        {
            if (!context.EventTypes.Any() || context.EventTypes.Count() < 3)
            {
                // delete
                foreach (var eventType in context.EventTypes)
                    context.Remove( eventType );
                if (context.ChangeTracker.HasChanges())
                    await context.SaveChangesAsync();

                var eventTypeObject = new EventType() { EventTypeDescription = "News" };
                context.EventTypes.Add( eventTypeObject );
                eventTypeObject = new EventType() { EventTypeDescription = "Events" };
                context.EventTypes.Add( eventTypeObject );
                eventTypeObject = new EventType() { EventTypeDescription = "Pubs" };
                context.EventTypes.Add( eventTypeObject );

                await context.SaveChangesAsync();

            }
        }
    }
}