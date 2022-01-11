using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryPool : MonoBehaviour
{

    public static StoryPool Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    public string GetPressStatsText(int pressCharisma)
    {
        if (pressCharisma >= 1 & pressCharisma <= 3)
        {
            return "Hates talking to media. Gets nervous and says stuff that will later regret.";
        } else if (pressCharisma >= 4 & pressCharisma <= 6)
        {
            return "Really likes to watch others in the media getting hammered. Doesn’t really have much experience with media but would like to have a go.";
        } else if (pressCharisma >= 7)
        {
            return "Is well trained and an agile media personality. Can really turn the tide when speaking to the media.";
        }
        return "";
    }

    public string GetLobbyStatsText(int lobbySkill)
    {
        if (lobbySkill >= 1 & lobbySkill <= 3)
        {
            return "New to politics. Doesn’t really trust politicians and doesn’t really know that being a president means to actively engage in politics.";
        }
        else if (lobbySkill >= 4 & lobbySkill <= 6)
        {
            return "Can sometimes pull off swift moves when talking to fellow politicians but lacks the experience to be consistent and fully trustworthy. ";
        }
        else if (lobbySkill >= 7)
        {
            return "Really turns the heads of politicians when talking to them. Just knows perfectly well what to say even to the fiercest rivals to win them over.";
        }
        return "";
    }

    public string GetFamiliyStatsText(int familyModel)
    {
        if (familyModel >= 1 & familyModel <= 3)
        {
            return "Has had several partners and even more kids but doesn’t really know their names or the exact number (of partners and kids).";
        }
        else if (familyModel >= 4 & familyModel <= 6)
        {
            return "Has one lover somewhere but other then that really loves the kids.";
        }
        else if (familyModel >= 7)
        {
            return "Has been happily married for several years and has several kids who all would also like to be a president one day.";
        }
        return "";
    }

    public string GetConfidenceText(int confidence)
    {
        if (confidence >= 1 & confidence <= 3)
        {
            return "Is constantly nervous about everything and has severe anxiety issues.";
        }
        else if (confidence >= 4 & confidence <= 6)
        {
            return "Plays it cool but is actually not that sure about stuff.";
        }
        else if (confidence >= 7)
        {
            return "Gets lifted by stressful situations and can get sad when there is nobody to dominate over.";
        }
        return "";
    }

    public string GetPoliticalLeftRigh(int leftright)
    {
        if (leftright >= 1 & leftright <= 3)
        {
            return "Would rather take from the rich and give it to the poor.";
        }
        else if (leftright >= 4 & leftright <= 7)
        {
            return "Tries to appeal to everyone, to rich and to poor and to the middle class.";
        }
        else if (leftright >= 8)
        {
            return "Doesn't care about the people in need. Because everyone should have an equal opportunity to make it or break it!";
        }
        return "";
    }

    public string GetPoliticalConLib(int conlib)
    {
        if (conlib >= 1 & conlib <= 3)
        {
            return "Doesn’t like new stuff because he doesn’t know how to deal with it. Only likes white people.";
        }
        else if (conlib >= 4 & conlib <= 7)
        {
            return "Has made some accidental racial insults but then again has a partner who is black. ";
        }
        else if (conlib >= 8)
        {
            return "Loves gays and all other LGBT+ community members. Would let you merry anyone!";
        }
        return "";
    }

}
