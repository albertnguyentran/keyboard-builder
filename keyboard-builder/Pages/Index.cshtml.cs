using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using keyboard_builder.Models;

namespace keyboard_builder.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public List<KeyboardsModel> fakeKeyboardDb = new List<KeyboardsModel>()
    {
        new KeyboardsModel(){
            ImageTitle="LeopoldFC900R",
            KeyboardName="LeopoldFC900R",
            BasePrice=100,
            Keycaps=true,
            Switches=true,
            FinalPrice=150
        },
        new KeyboardsModel(){
            ImageTitle="DuckyOne3",
            KeyboardName="DuckyOne3",
            BasePrice=110,
            Keycaps=true,
            Switches=true,
            FinalPrice=160
        },
        new KeyboardsModel(){
            ImageTitle="ObinslabAnne",
            KeyboardName="ObinslabAnne",
            BasePrice=120,
            Keycaps=true,
            Switches=true,
            FinalPrice=170
        },
        new KeyboardsModel(){
            ImageTitle="VarmilloVA87M",
            KeyboardName="VarmilloVA87M",
            BasePrice=130,
            Keycaps=true,
            Switches=true,
            FinalPrice=180
        },
        new KeyboardsModel(){
            ImageTitle="VortexCore",
            KeyboardName="VortexCore",
            BasePrice=140,
            Keycaps=true,
            Switches=true,
            FinalPrice=190
        },
        new KeyboardsModel(){
            ImageTitle="LeopoldFC660C",
            KeyboardName="LeopoldFC660",
            BasePrice=150,
            Keycaps=true,
            Switches=true,
            FinalPrice=200
        },
        new KeyboardsModel(){
            ImageTitle="VortexRace3",
            KeyboardName="VortexRace3",
            BasePrice=160,
            Keycaps=true,
            Switches=true,
            FinalPrice=210
        },

    };

    public void OnGet()
    {

    }
}

