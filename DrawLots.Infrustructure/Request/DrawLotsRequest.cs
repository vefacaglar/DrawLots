using DrawLots.Infrustructure.Models;

namespace DrawLots.Infrustructure.Request;

public class DrawLotsRequest
{
    public DrawLotsRequest()
    {
        DrawLots = new List<DrawLotsItem>();
    }
    
    public List<DrawLotsItem> DrawLots { get; set; }
}