using System;

namespace SimpleAdsReactJWT.Data
{
    public class Ad
    {
            public int Id { get; set; }
            public string Name { get; set; }
            public DateTime DatePosted { get; set; }
            public string PhoneNumber { get; set; }
            public string Details { get; set; }
            public int UserId { get; set; }
            public bool BelongsToUser { get; set; }      
    }
}
