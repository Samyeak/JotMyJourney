using System;

namespace JotMyJourney
{
    public abstract class BaseModel
    {
        public int Id { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
