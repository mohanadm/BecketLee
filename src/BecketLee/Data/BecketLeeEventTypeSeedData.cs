using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using BecketLee.Models;
using Microsoft.EntityFrameworkCore;

namespace BecketLee.Data
{
    public class BecketLeeEventTypeSeedData 
    {
        public static async Task EnsureEventTypeData(BecketLeeContext context)
        {
//            if (!context.EventTypes.Any() || context.EventTypes.Count() != 4)
//            {
            var list = new List<EventType>()
            {
                new EventType() {EventTypeId = 1, EventTypeDescription = "News"},
                new EventType() {EventTypeId = 2, EventTypeDescription = "Events"},
                new EventType() {EventTypeId = 3, EventTypeDescription = "Pubs"},
                new EventType() {EventTypeId = 4, EventTypeDescription = "Cases"}
            };

            foreach (EventType eventType in list)
            {
                var et = await context.EventTypes.FindAsync(eventType.EventTypeId);
                if (et != null)
                {
                    et.EventTypeDescription = eventType.EventTypeDescription;
                    context.EventTypes.Update(et);
                }
                else
                {
                    context.EventTypes.Add(eventType);
                }
            }

            try
            {
                context.Database.OpenConnection();
                context.Database.ExecuteSqlCommand( "set identity_insert dbo.EventTypes on" );
                context.SaveChanges();
                context.Database.ExecuteSqlCommand( "set identity_insert dbo.EventTypes off" );
            }
            catch (DbUpdateException exception)
            {
                var x = exception.ToString();
            }
            finally
            {
                context.Database.CloseConnection();
            }

        }
    }
}