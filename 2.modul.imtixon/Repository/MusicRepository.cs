using static _2.modul.imtixon.Program;
using _2.modul.imtixon.Dtos;
using _2.modul.imtixon.Class;

namespace _2.modul.imtixon.Repository;

public class MusicRepository : IMusicRepository
{
    private readonly List<MusicDto> musics = new();



    public void Create(MusicDto musics)
    {
        musics.Add(musics);
    }

    public void Update(Music musics)
    {
        var old = GetById(musics.Id);
        if (old == null)
        {
            return;
        }

      
    }

    private  GetById(Guid id)
    {
       
    }

    public void Delete(Guid id)
    {
        var musics = GetById(id);
        if (musics != null)
        {
            musics.Remove(musics);
        }
    }

    

}
