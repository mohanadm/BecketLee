-- Saves any Event data and generates C# to seed the Events table with its content
select 
    'eventObj = new Event() { Title = ' + 
    case when charindex('"', title) > 0 then '' else '@' end + '"' + replace(title, '"', '\"') + '", ' +
    ' CreatedDate = Convert.ToDateTime("' + cast(createdDate as varchar) + '"), ' +
    ' StartDate = ' +
        case when startDate is null then 'null, '
        else
            case when 'Convert.ToDateTime( "' + cast(isnull(startDate, '''') as varchar) + '")' = '1900-01-01 00:00:00.0000000'
                then 'null '
                else 'Convert.ToDateTime( "' + cast(isnull(startDate, '''') as varchar) + '"), ' end
        end  +

    ' EndDate = ' +
        case when endDate is null then 'null, '
        else
            case when 'Convert.ToDateTime( "' + cast(isnull(endDate, '''') as varchar) + '")' = '1900-01-01 00:00:00.0000000'
                then 'null '
                else 'Convert.ToDateTime( "' + cast(isnull(endDate, '''') as varchar) + '"), ' end
        end  +
    ' EventTypeId = ' + cast( eventTypeId as varchar) + ', ' + 
    ' EventHtml = @"' + eventHtml + '"' + char(13) +
    ' }; context.Events.Add( eventObj );'  
from events 
order by eventTypeid, startDate desc