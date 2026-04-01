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
            SecondDescription = null,
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
        new ArticleModel
        {
            Id = 2,
            Date = new DateTime(2025, 6, 12),
            Title = "Mateaventuras",
            Description = "Mateaventuras is a math exercise book where learning happens through adventure. Published by Letra Impresa and adopted by private schools in Buenos Aires as part of their mathematics curriculum, it transforms foundational math practice into a journey guided by charismatic characters and a richly illustrated world.",
            FirstImageUrl = "/imgs/Articles/MateAventuras/1.png",
            FirstSubtitle = "Press start",
            SecondDescription = "The series invites students to press “start” and begin the adventure of learning math through play. Readers explore worlds, unlock levels, and solve mathematical challenges as if playing their favorite game. Each book also includes a Digital Education Project designed to introduce computational thinking and basic programming concepts.",
            ImageUrl = new []{
            "/imgs/Articles/MateAventuras/2.png",
            "/imgs/Articles/MateAventuras/3.png",
            },
            SectionTitles = new[] { "A world built through illustration", "Our role"},
            Content = new []{
            "<p>What sets Mateaventuras apart is its narrative structure. Rather than a collection of isolated problems, the exercises are woven into a cohesive adventure. Two protagonists—an adventurous boy and a tender young witch—guide students through increasingly complex challenges, creating emotional engagement alongside skill development.</p> <p>The visual world is crafted with care: environments, characters, and progression systems work together to make abstract concepts feel tangible and rewarding.</p>",
            "<p>Meteor Craftwork was responsible for all visual development of Mateaventuras—from character design and conceptual art to final illustrations. Working with publisher Letra Impresa, we interpreted their educational vision into a cohesive aesthetic that appeals to young readers while maintaining clarity and warmth.</p> <p>The book has been adopted by private schools across Buenos Aires with around 200 units per school distributed.</p>",
            },
            StoreUrl = "https://play.google.com/store",
            
        },

    };

    public ArticleModel? GetById(int id) => _articles.FirstOrDefault(p => p.Id == id);

    public IEnumerable<ArticleModel> GetAll() => _articles;
}