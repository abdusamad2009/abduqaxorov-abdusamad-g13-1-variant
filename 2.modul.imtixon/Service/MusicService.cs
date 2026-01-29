using _2.modul.imtixon.Dtos;
using _2.modul.imtixon.Repository;
using System.Text.Json;
using System.Threading.Channels;
using static _2.modul.imtixon.Program;

namespace _2.modul.imtixon.Service;

public class MusicService : IMusicService
{
   

    public MusicService(IMusicRepository musics)
    {
        musics = musics;
    }

    private static MusicDto MapToDto(MusicDto musics) => new()
    {
        Id = musics.Id,
        Name = musics.Name,
        MB = musics.MB,
        AuthorName = musics.AuthorName,
        QuantityLikes = musics.QuantityLikes
    };

    

}
