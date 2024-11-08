using AutoMapper;
using HotelProject.DtoLayer.Dtos.RoomDto;
using HotelProject.EntityLayer;

namespace HotelProject.WebApi.Mapping
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            //İki taraflı map oluşturmak gerekli
            CreateMap<RoomAddDto, Room>();
            CreateMap<Room,RoomAddDto>();

            //Reverse yapınca 2 taraflı oluyor.
            CreateMap<UpdateRoomDto, Room>().ReverseMap();
        }
    }
}
