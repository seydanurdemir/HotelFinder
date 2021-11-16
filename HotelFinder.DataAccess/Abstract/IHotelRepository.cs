using HotelFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinder.DataAccess.Abstract
{
    public interface IHotelRepository
    {
        Task<List<Hotel>> GetAllHotels(); // Database Read (Select *) = Rest Http Get
        Task<Hotel> GetHotelById(int id); // Database Read (Select * Where Id=id) = Rest Http Get {id}
        Task<Hotel> CreateHotel(Hotel hotel); // Database (Write) Create (Insert) = Rest Http Post {json} // Need to save changes
        Task<Hotel> UpdateHotel(Hotel hotel); // Database (Write) Update (Update) = Rest Http Put {json} // Need to save changes
        Task DeleteHotel(int id); // Database (Write) Delete (Delete) = Rest Http Delete {id} // Need to save changes
    }
}
