using System;

namespace DatingApp.Api.Dtos
{
    public class PhotosForReturnDto
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public DateTime DataAdded { get; set; }
        public bool IsMain { get; set; }
        public string PublicId { get; set; }
    }
}