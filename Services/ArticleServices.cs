using MeteorWebApp.Models;

namespace MeteorWebApp.Services;

public class ArticleService
{
    private readonly List<ArticleModel> _articles = new()
    {
        new ArticleModel
        {
            Id = 1,
            Date = new DateTime(2025, 6, 12),
            Title = "Tribulations of the Realm",
            Description = "Tribulations of the Realm is a PVEVP wave defense tabletop survival RPG with open barter mechanics. Designed for up to four players, it blends elemental combat, and evolving equipment into a high-fantasy setting where the god of chaos wants to destroy the world.",
            FirstImageUrl = "/imgs/Articles/TOTR/1.png",
            FirstSubtitle = null,
            ImageUrl = new []{
            "/imgs/Articles/TOTR/2.png",
            "/imgs/Articles/TOTR/3.png",
            "/imgs/Articles/TOTR/4.png",
            "/imgs/Articles/TOTR/5.png"
            },
            SectionTitles = new[] { "A world on the edge", "Interlocking systems","Built through iteration", },
            Content = new []{
            "Four continents, shattered by the influence of chaos. Four champions, each defending their homeland against the creatures sent by the god of chaos—a force determined to annihilate the world. Amid the ruins of lost civilizations, heroes unearth forgotten artifacts and reclaim the power needed to stand against the final threat.",
            "<p>Each session runs approximately two hours. Players choose a boss and face waves of enemies with elemental affinities, requiring tactical choices about which weapons to upgrade—equipment evolves into magical versions as it improves. Four distinct characters offer radically different playstyles.</p> <p>PvP is optional: players may attack each other or play effect cards to hinder a rival’s progress, turning every match into a fluid balance between alliance and self-interest. Multiple endgame bosses test collective strategy… and individual ambition.</p>",
            "One of the project’s strengths was its development flow. The entire team participated in internal playtests, contributing ideas and debating them in real time. No mechanic was off-limits; systems were overhauled when they didn’t serve the experience. That willingness to iterate quickly, without attachment to initial concepts, is what allowed Totr to achieve its current level of systemic depth."
            },
            StoreUrl = "https://play.google.com/store",
            
        },
       

    };

    public ArticleModel? GetById(int id)
        => _articles.FirstOrDefault(p => p.Id == id);
}