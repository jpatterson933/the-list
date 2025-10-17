using Microsoft.AspNetCore.Mvc;
using LaAdventuresList.Models;

namespace LaAdventuresList.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var adventureList = new AdventureList
        {
            Completed = new List<string>
            {
                "Beach Wine",
                "Alana's (coffee) & farmers market",
                "Oste",
                "Lacma",
                "Beach & Scopa",
                "Rock Climbing & Mogu Mogu Mazemen and Ramen",
                "Scopa and Capybaraaaa capybara-capybara-capybara-capybara",
                "Climbing, Boba, Garden and succulents",
                "Orange theory & butternut squash & spooky Netflix show",
                "Rock climbing & exploratory squats"
            },
            NewTodos = new List<string>
            {
                "Joshua Tree / Yosemite",
                "24th Danny's bday",
                "Cook together - new recipes 2.0",
                "Uniqlo shopping",
                "More sleepovers",
                "Guini snuggles",
                "Attend events together that awaken Jeff's passion for bettering the world"
            },
            Todos = new List<string>
            {
                "Rock climbing - THE ROPES edition v2",
                "Huntington gardens",
                "Read together? Book club?",
                "Get permitted (iykyk)",
                "Burn it all down"
            },
            ShowsAndEntertainment = new List<string>
            {
                "Plays - theatrical irl",
                "Parcels - Nov show",
                "Hollywood bowl - show of some kind",
                "Laker game",
                "Interstellar - movie",
                "Past Lives - movie #yearnersunite"
            },
            Food = new List<string>
            {
                "Girl and the goat",
                "Destroyer - breakfast",
                "Best chilaquiles in LA!?",
            },
            External = new List<string>
            {
                "Vineyard - Mexico"
            }
        };

        return View(adventureList);
    }
}
