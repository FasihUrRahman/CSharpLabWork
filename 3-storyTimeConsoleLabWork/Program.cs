string tabSpace = "\t\t\t\t"; //For Tab Spaces
string newLine = "\n"; //For new Line
string tab = "\t"; //For single tab
string heading = "Short Story(The Student)"; //Heading Line
string contentParagraph1 = "AT first the weather was fine and still. The thrushes were calling, " +
    "and in the swamps close by something alive droned pitifully with a sound like blowing " +
    "into an empty bottle. A snipe flew by, and the shot aimed at it rang out with a gay, resounding " +
    "note in the spring air. But when it began to get dark in the forest a cold, penetrating wind blew " +
    "inappropriately from the east, and everything sank into silence. Needles of ice stretched across the " +
    "pools, and it felt cheerless, remote, and lonely in the forest. There was a whiff of winter." + newLine + tab +
    "Ivan Velikopolsky, the son of a sacristan, and a student of the clerical academy, returning home " +
    "from shooting, walked all the time by the path in the water-side meadow. His fingers were numb and " +
    "his face was burning with the wind. It seemed to him that the cold that had suddenly come on had " +
    "destroyed the order and harmony of things, that nature itself felt ill at ease, and that was why " +
    "the evening darkness was falling more rapidly than usual. All around it was deserted and peculiarly " +
    "gloomy. The only light was one gleaming in the widows' gardens near the river; the village, over " +
    "three miles away, and everything in the distance all round was plunged in the cold evening mist." +
    " The student remembered that, as he went out from the house, his mother was sitting barefoot on " +
    "the floor in the entry, cleaning the samovar, while his father lay on the stove coughing; as " +
    "it was Good Friday nothing had been cooked, and the student was terribly hungry. And now, " +
    "shrinking from the cold, he thought that just such a wind had blown in the days of Rurik " +
    "and in the time of Ivan the Terrible and Peter, and in their time there had been just the " +
    "same desperate poverty and hunger, the same thatched roofs with holes in them, ignorance, " +
    "misery, the same desolation around, the same darkness, the same feeling of oppression—all " +
    "these had existed, did exist, and would exist, and the lapse of a thousand years would make life " +
    "no better. And he did not want to go home."; //Main Paragraph
string contentParagraph2 = "The gardens were called the widows' because they were kept by two widows, " +
    "mother and daughter. A camp fire was burning brightly with a crackling sound, throwing out " +
    "light far around on the ploughed earth. The widow Vasilisa, a tall, fat old woman in a man's " +
    "coat, was standing by and looking thoughtfully into the fire; her daughter Lukerya, a little " +
    "pock-marked woman with a stupid-looking face, was sitting on the ground, washing a caldron and spoons." +
    " Apparently they had just had supper. There was a sound of men's voices; it was the " +
    "labourers watering their horses at the river."; //Ending Paragraph
string goodByeMessage = "Press Any Key to end..."; //End Line
Console.WriteLine(tabSpace + heading); //Calling Heading With Some Extra Tabs
Console.WriteLine(tab + contentParagraph1); //Calling Single Tab and Main Paragraph
Console.WriteLine(tab + contentParagraph2); //Calling Ending Paragraph with Single Tab
Console.Write(goodByeMessage);  //Calling End Line
Console.ReadKey();  //Waiting for input