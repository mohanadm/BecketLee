namespace BecketLee.Models
{
    public class DeletionModel
    {
        /// <summary>
        /// The action to take when confirmed
        /// </summary>
        public string Action { get; set; }
        /// <summary>
        ///  The controller of the action
        /// </summary>
        public string Controller { get; set; }

        /// <summary>
        /// The name of the thing being deleted, Event, Bio, User, etc.
        /// </summary>
        public string Item { get; set; }

        /// <summary>
        /// The content at the top of the dialog
        /// </summary>
        public string Heading { get; set; }

        /// <summary>
        /// The id of the item being deleted
        /// </summary>
        public int DeleteId { get; set; }


        /// <summary>
        /// Required for the User and UserRoles where the ID values are strings.
        /// </summary>
        public string UserDeleteId { get; set; }
        public string RoleDeleteId { get; set; }


        /// <summary>
        /// The specific item, <EventTitle>, <PartnerName> , <UserName>
        /// </summary>
        public string Title { get; set; }

    }
}