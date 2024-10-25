using WebAPIDemos.Models.Dto;

namespace WebAPIDemos.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO>() { 
             new VillaDTO{ Id=1, Name="Pool View", Sqft=500, Occupancy=5},
             new VillaDTO{ Id=2, Name="Beach View", Sqft = 600, Occupancy=6}
        };
    }
}
