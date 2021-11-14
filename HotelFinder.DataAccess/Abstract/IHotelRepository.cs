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
        List<Hotel> GetAllHotels(); // Database Read (Select *) = Rest Http Get
        Hotel GetHotelById(int id); // Database Read (Select * Where Id=id) = Rest Http Get {id}
        Hotel CreateHotel(Hotel hotel); // Database (Write) Create (Insert) = Rest Http Post {json} // Need to save changes
        Hotel UpdateHotel(Hotel hotel); // Database (Write) Update (Update) = Rest Http Put {json} // Need to save changes
        void DeleteHotel(int id); // Database (Write) Delete (Delete) = Rest Http Delete {id} // Need to save changes
    }
}
