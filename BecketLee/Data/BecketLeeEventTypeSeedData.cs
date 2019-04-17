using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using BecketLee.Models;
using Microsoft.EntityFrameworkCore;

namespace BecketLee.Data
{
    public class BecketLeeEventTypeSeedData 
    {
        public static async Task EnsureEventTypeData(BecketLeeDbContext context)
        {
            if( !context.EventTypes.Any() || context.EventTypes.Count() != 2 )
            {
                foreach (var eventType in context.EventTypes)
                    context.Remove(eventType);
                if (context.ChangeTracker.HasChanges())
                    await context.SaveChangesAsync();

                var list = new List<EventType>()
                {
                    new EventType() {EventTypeId = 1, EventTypeDescription = "News"},
                    new EventType() {EventTypeId = 2, EventTypeDescription = "Events"},
//                    new EventType() {EventTypeId = 3, EventTypeDescription = "Pubs"},
//                    new EventType() {EventTypeId = 4, EventTypeDescription = "Cases"}
                };

                foreach (EventType eventType in list)
                {
                    var et = await context.EventTypes.FindAsync( eventType.EventTypeId );
                    if( et != null )
                    {
                        et.EventTypeDescription = eventType.EventTypeDescription;
                        context.EventTypes.Update( et );
                    }
                    else
                    {
                        context.EventTypes.Add( eventType );
                    }
                }

                try
                {
                    context.Database.OpenConnection();
                    context.Database.ExecuteSqlCommand( "set identity_insert dbo.EventTypes on" );
                    context.SaveChanges();
                    context.Database.ExecuteSqlCommand( "set identity_insert dbo.EventTypes off" );
                }
                finally
                {
                    context.Database.CloseConnection();
                }
            }
        }
    }
}