using Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce_MVC.Interfaces
{
    public interface IAnnouncementRepository
    {
        Task<List<Announcement>> GetAnnouncements();
        Task<Announcement> GetAnnouncementAsync(Guid? announcID);
        Announcement GetAnnouncement(Guid? announcID);
        void AddAnnouncement(Announcement announcement);
        Task AddAnnouncementAsync(Announcement announcement);
        void UpdateAnnouncement(Announcement announcement);
        void DeleteAnnouncement(Announcement announcement);
        bool Save();
        Task<bool> SaveAsync();
    }
}
