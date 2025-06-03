using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

class Scripture
{
    string _completeVerse;
    string _nameOfVerse;
    string _contentsOfVerse;

    List<Word> allTheWords = new List<Word>();
    public Reference _reference;
    public Scripture()
    {
        var verses = new (string verseName, string verse)[] //var needs be in a method, it isn't totally recommendable but it will pick the type of the variable like string or a integer. 
       {
            ("1 Nephi 3:7", "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."),
            ("Mosiah 3:19", "For the natural man is an enemy to God, and has been from the fall of Adam, and will be, forever and ever, unless he yields to the enticings of the Holy Spirit, and putteth off the natural man and becometh a saint through the atonement of Christ the Lord, and becometh as a child, submissive, meek, humble, patient, full of love, willing to submit to all things which the Lord seeth fit to inflict upon him, even as a child doth submit to his father."),
            ("Alma 32:21", "And now, as I said concerning faith—faith is not to have a perfect knowledge of things; therefore if ye have faith ye hope for things which are not seen, which are true."),
            ("Helaman 5:12", "And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation; that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind, yea, when all his hail and his mighty storm shall beat upon you, it shall have no power over you to drag you down to the gulf of misery and endless woe, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fall."),
            ("3 Nephi 11:10-11", "Behold, I am Jesus Christ, whom the prophets testified should come into the world. And behold, I am the light and the life of the world; and I have drunk out of that bitter cup which the Father hath given me, and have glorified the Father in taking upon me the sins of the world, wherein I have suffered the will of the Father in all things from the beginning."),
            ("Moroni 10:4-5", "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost. And by the power of the Holy Ghost ye may know the truth of all things."),
            ("2 Nephi 2:25", "Adam fell that men might be; and men are, that they might have joy."),
            ("Alma 34:32", "For behold, this life is the time for men to prepare to meet God; yea, behold the day of this life is the day for men to perform their labors."),
            ("Ether 12:27", "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them."),
            ("Mosiah 2:17", "And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God.")

       };

        Random random = new Random();
        int verseIndex = random.Next(0, verses.Length); //next is a method that lets us pick a rand number range 
        _nameOfVerse = verses[verseIndex].verseName;
        _contentsOfVerse = verses[verseIndex].verse;

        _completeVerse = _nameOfVerse + _contentsOfVerse;



        _reference = new Reference(_nameOfVerse);

        breakUpVerse();
    }
    // split the versee into something i can use the for loop on rn it too big now i need to use split and then run it through for whatever the thing is in the array in the array do yur thing

    public void breakUpVerse()
    {

        allTheWords.Clear();

        foreach (string text in _contentsOfVerse.Split(" "))
        {
            Word word = new Word(text);
            allTheWords.Add(word);
        }
    }

    // foreach (var word in allTheWords)
    // {
    //     string verse = "";
    //     verse += word.Display();
    // }
    public string GetDisplayText()
    {
        string verseText = "";
        foreach (var word in allTheWords)
        {
            verseText += word.Display() + " ";
        }

        return $"{_reference.Display()}: {verseText.Trim()}"; //.Trim gets rid of whitespace which is kinda cool
    }

    public bool AllHiddenWords()
    {
        foreach (Word word in allTheWords)
        {
            if (word.GetSwitch() == false)
            {
                return false;

            }

        }
         return true;
    }

    public void HideRandWords(int count)
    {
        Random random = new Random();
        int HiddenWords = 0;

        while (HiddenWords < count)
        {
            int i = random.Next(0, allTheWords.Count);


            Word word = allTheWords[i];
            if (word.GetSwitch() == false)
            {
                word.Hider();
                HiddenWords++;

            }
            if (HiddenWords >= count)
            {
                break;
            }
             

        }


    }

    }
    

// Console.WriteLine($"{verses[0].verse}");

