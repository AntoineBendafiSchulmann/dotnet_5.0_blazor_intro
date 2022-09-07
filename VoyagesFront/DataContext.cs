using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VoyagesFront
{
    public class DataContext: IDataContext
    {
        public IEnumerable<Voyage> Voyages { get; set; } = new Voyage[] {


            new Voyage("Bandung"  , "bandung.jpg"  , "nature"   , "Bandung,le paradis des montagnes", "en Indonésie"   , "Badung est un ville est réputée pour ses paysages montagneux et ses nombreux temples. Elle est également connue pour ses plantations de thé et de café. Bandung est une ville très animée."),
            new Voyage("Bali"   , "bali.jpeg"   , "voyage"  , "Bali, l'île des dieux"   , "en Indonésie"    ,"Bali est une île de l'archipel indonésien des îles de la Sonde. Elle est située entre Java et Lombok, célèbre pour ses plages de sable blanc, ses volcans, ses forêts tropicales."),
            new Voyage("santorini"   , "santorini.jpg"  , "visite"  , "les ruelles de Santorin"  ,"en Grèce"    , "Santorini est une île grecque de l'archipel des Cyclades, située au sud-est de la mer Égée. Elle est célèbre pour ses villages blancs perchés sur des falaises abruptes."),
            new Voyage("chili", "chili.jpg"  , "découverte"  , "le Chili"  ,"au Chili"    , "Le Chili est un pays d'Amérique du Sud, bordé à l'ouest par l'océan Pacifique et à l'est par l'océan Atlantique. Il est connu pour ses paysages grandioses, ses vignobles et ses villes coloniales."),
            new Voyage("New York"  , "newyork.jpg"  , "voyage"   , "New York, la ville qui ne dort jamais"   ,"aux États-Unis"    , "New York est une ville américaine située dans l'État de New York, au nord-est du pays. Elle est connue pour ses gratte-ciels, ses musées, ses parcs et ses rues animées."),
            new Voyage("Derbyshire"   , "derbyshire.jpg"  , "visite"   , "Derbyshire, le pays des lacs"    ,"au Royaume-Unis"    , "Derbyshire est un comté du Royaume-Uni, situé dans l'est de l'Angleterre. Il est connu pour ses lacs, ses forêts et ses villages pittoresques."),
            new Voyage("Taipei"    , "taipei.jpg"    , "découverte"    , "Taipei, la ville aux 101 tours"    ,"à Taïwan"    , "Taipei est la capitale de la République de Chine (Taïwan). Elle est connue pour ses gratte-ciels, ses temples bouddhistes et ses marchés nocturnes."),
            new Voyage("Hohenzollern"    , "hohenzollern.jpg"    , "nature"    , "Hohenzollern, le château des rois"    ,"en Allemagne"    , "Hohenzollern est un château allemand situé dans le sud de l'Allemagne, dans la région de Bade-Wurtemberg. Il est connu pour ses jardins et ses collections d'armes et d'armures."),
            new Voyage("Florence"    , "florence.jpg"    , "voyage"    , "Florence, la ville des arts"   ,"en Italie"    , "Florence est une ville italienne située dans la région de Toscane, au nord de Rome. Elle est connue pour ses musées, ses églises et ses rues animées."),
            new Voyage("Jusang"    , "jusang.jpg"   , "visite"   , "Jusang, le village des lacs"   , "en Corée du Sud"    ,"Jusang est un village coréen situé dans la province de Gangwon, au nord du pays. Il est connu pour ses lacs, ses montagnes et ses rizières."),
            new Voyage("Kenya"    , "kenya.jpg"    , "nature"   , "Kenya, le pays des animaux"   ,"au Kenya"    , "Le Kenya est un pays d'Afrique de l'Est, situé sur la côte de l'océan Indien. Il est connu pour ses paysages grandioses, ses parcs nationaux et ses safaris."),
            new Voyage("Kirkjufell"   , "kirkjufell.jpg"    , "nature", "Kirkjufell, le mont des trolls"   , "en Islande"    ,"Kirkjufell est un mont volcanique situé dans l'ouest de l'Islande. Il est connu pour sa forme pyramidale et pour son lac, qui reflète son sommet."),
            new Voyage("Los Angeles"    , "la.jpg"    , "voyage"    , "Los Angeles, la ville des stars"    ,"aux États-Unis"    , "Los Angeles est une ville américaine située dans l'État de Californie, au sud-ouest du pays. Elle est connue pour ses plages, ses parcs et ses gratte-ciels."),
            new Voyage("Istanbul"    , "Istanbul.jpg"    , "visite", "Istanbul, la ville des ponts"   ,"en Turquie"    ,  "Istanbul est une ville turque située sur la côte asiatique de la mer Noire. Elle est connue pour ses ponts, ses mosquées et ses bains turcs."),

        };


    }
}