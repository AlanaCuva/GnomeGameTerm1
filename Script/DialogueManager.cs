using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public struct TextBlock
//{
//    public string[] texts;
//};
public class DialogueManager : MonoBehaviour
{

    string[] AllDialoguesEnlish = new string[]{
        "halt!",
        "State your business to Guard Gnome… I am Guard Gnome, I Guard Puddletown",
        "An outsider... you must be the inspector",
        "Well I'm afraid you're too late. The Mayor was found shattered last night by the docks.",
        "Gnone too soon. This would have been his 231st Winter, such a shame",
        "Where was I last night? Wait, I'm a suspect?! How dare you! I wish nothing more than to uphold peace in this shithole",
        "I was here last night. Guarding. Like i always am... Everyday for the past 84 Winters",
        "Maybe now the Mayor is gone I will finally get paid for all the work I do. I'm retiring soon, I need a pension. I Have gneeds you know...",
        "Now go and interrogate those other gnomes, I'm innocent I swear",
        "Start with Baker Gnome, he's just past the wall.",
        "Well hello there, please come in!",
        "Why yes I'm Baker Gnome, why do you ask? A murder? By the docks? Are you sure?",
        "Well this is the first I'm hearing of it. I think...",
        "I've been too busy baking all this bread. After the Mayor's flour tax went away last night I got a little excited and baked too much bread",
        "Would you like a seeded loaf? Or perhaps a jam tart... they are to die for!",
        "I can take you round the back and show you my stock, and my tools... No? Oh well another time I suppose",
        "If you ask me it was that pesky Holy Gnome",
        "I heard him potterring around early this morning down by the docks when I was going to pick up my flour from the town square",
        "Hello young one, it’s lovely to see another gnome choosing to bring himself into the light of the shroom",
        "… No? You’re not here to give yourself over to the one true mushroom? Well, why are you here?",
        "A murder? And you dare accuse me? I, a gnome of the shroom would never commit such a heinous act, why it would be preposterous!",
        "Yes the mayor didn’t always see eye to eye with my methods, and we were in competition for the puddletown elections...",
        "But a shattering is too far, too far indeed.",
        "Although, I must say, it does leave just me in the running for the mayor now, maybe I can take this village into a different, more holy direction.",
        "Maybe his shatter was a good thing?...  I'm joking! I may be a holy gnome, but I can still joke can’t I? Ha ha… ha. Ha.",
        "My first decree is to get rid of that strange gnome outside of the village walls.",
        "He’s been standing there claiming it's his sworn duty to guard the wall for over 80 winters now, it’s just sad… so sad.",
        "If you’re looking for a culprit, it’s most likely the gnome who found the shattered body at the docks, the fisher gnome.",
        "Ahoy! How are you on this fine day? I’m doing great!",
        "Oh, you’re here about the shattering aren’t you. It's a sad thing when life is taken away, but sometimes it can be good.",
        "Think about these fish, we take life to make everyone else's better, and that's okay…",
        "Obviously I’m not talking about the mayor, what a sad, sad situation.",
        "Don’t get me wrong, the pond has been a lot cleaner since he passed.",
        "The sewage from his jacuzzi isn’t poisoning the pond anymore, which has made my job a lot easier I must say.",
        "Everyone in the village seems a lot happier now, right? So does it really matter that we killed him… FUCK",
        "I mean.. Uhhhhh… Of course… It’s a tragic thing… But do you really need to call in the authorities on this one?",
        "I’d say it’s an open and shut case. The mayor made the village worse, now he’s gone, and everyone is happier.",
        "Anyways I have fish to catch, can't talk, I bid you farewell.",

 };

    
    enum StringIDs
    {
        HALT,
        STATE_YOUR_BUSINESS,
        AN_OUTSIDER,
        WELL_IM_AFRAID,
        GNONE_TOO_SOON,
        WHERE_WAS_I,
        I_WAS_HERE,
        MAYBE_NOW,
        NOW_GO,
        START_WITH,
        WELL_HELLO,
        WHY_YES,
        WELL_THIS_IS,
        IVE_BEEN_TOO_BUSY,
        WOULD_YOU_LIKE,
        I_CAN_TAKE,
        IF_YOU_ASK_ME,
        I_HEARD_HIM,
        HELLO_YOUNG_ONE,
        NO_YOURE_NOT_HERE,
        A_MURDER,
        YES_THE_MAYOR,
        BUT_A_SHATTERING,
        ALTHOUGH,
        MAYBE_HIS_SHATTER,
        MY_FIRST_DECREE,
        HES_BEEN_STANDING,
        IF_YOURE_LOOKING,
        AHOY,
        OH_YOURE_HERE,
        THINK_ABOUT,
        OBVIOUSLY,
        DONT_GET_ME_WRONG,
        THE_SEWAGE,
        EVERYONE,
        I_MEAN,
        ID_SAY,
        ANYWAYS,

    };


    struct CharacterDialogue
    {
        public CharacterDialogue(StringIDs[] ids)
        {
            StringIDList = ids;
        }
        public StringIDs[] StringIDList;
    }



    public enum CharacterDialogueIDs
    {
        GuardGnome,
        BakerGnome,
        HolyGnome,
        FisherGnome,
    };


    CharacterDialogue[] AllCharacterDialogue =
    {
        //GuardGnome
        new CharacterDialogue
            (
                new StringIDs[]
                {
                    StringIDs.HALT, StringIDs.STATE_YOUR_BUSINESS, StringIDs.AN_OUTSIDER, StringIDs.WELL_IM_AFRAID, StringIDs.GNONE_TOO_SOON, StringIDs.WHERE_WAS_I, StringIDs.I_WAS_HERE, StringIDs.MAYBE_NOW, StringIDs.NOW_GO, StringIDs.START_WITH
                }
            ),
        //BakerGnome
        new CharacterDialogue
            (
                new StringIDs[]
                {
                    StringIDs.WELL_HELLO, StringIDs.WHY_YES, StringIDs.WELL_THIS_IS, StringIDs.IVE_BEEN_TOO_BUSY, StringIDs.WOULD_YOU_LIKE, StringIDs.I_CAN_TAKE, StringIDs.IF_YOU_ASK_ME, StringIDs.I_HEARD_HIM
                }
            ),
        //HolyGnome
            new CharacterDialogue
            (
                new StringIDs[]
                {
                    StringIDs.HELLO_YOUNG_ONE, StringIDs.NO_YOURE_NOT_HERE, StringIDs.A_MURDER, StringIDs.YES_THE_MAYOR, StringIDs.BUT_A_SHATTERING, StringIDs.ALTHOUGH, StringIDs.MAYBE_HIS_SHATTER, StringIDs.MY_FIRST_DECREE, StringIDs.HES_BEEN_STANDING, StringIDs.IF_YOURE_LOOKING 
                }
            ),
        //FisherGnome
            new CharacterDialogue
            (
                new StringIDs[]
                {
                    StringIDs.AHOY, StringIDs.OH_YOURE_HERE, StringIDs.THINK_ABOUT, StringIDs.OBVIOUSLY, StringIDs.DONT_GET_ME_WRONG, StringIDs.THE_SEWAGE, StringIDs.EVERYONE, StringIDs.I_MEAN, StringIDs.ID_SAY, StringIDs.ANYWAYS 
                }

             )
               


    };
        



    public TMPro.TMP_Text _textPanel;
    public Transform BasePanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetText(string myText)
    {
        _textPanel.text = myText;
    }
    public void ContinuePressed()
    {
        // _textPanel.text = "";
        currentSentence++;
        if (currentSentence < AllCharacterDialogue[(int)_CurrentCharID].StringIDList.Length)
        {
            _textPanel.text = AllDialoguesEnlish[(int)(AllCharacterDialogue[(int)_CurrentCharID].StringIDList[currentSentence])];
        }
        else
        {
            HideDialogue();
        }
        //HideDialogue();
    }
    public void HideDialogue()
    {
        BasePanel.gameObject.SetActive(false);
    }
    public void ShowDialogue(CharacterDialogueIDs charID)
    {
        BasePanel.gameObject.SetActive(true);
        currentSentence = 0;
        _CurrentCharID = charID;
        _textPanel.text = AllDialoguesEnlish[(int)(AllCharacterDialogue[(int)charID].StringIDList[currentSentence])];
    }
    int currentSentence=0;
    CharacterDialogueIDs _CurrentCharID;
}
