using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ThesisBackendAPI;

public class InformationForNoArchitecture
{
    public static readonly string storyOutline = 
        "The character starts in the Ancient Forest, a great and old forest, filled with magic and mystery, Here, on a small clearing, the character see two people: a small green Goblin with a red hair and tuft of hair and which wears a worn-out leather armor, his name is Golgi, and a young girl with scholar robes and a wizard hat, with dark skin and curly hair, her name is Irina. Moreover, here the protagonist sees an axe lodged on tree, that could be removed with enough strenght. If the protagonist move further into the forest, he arrives to the Ruined Castle, his destination. Here they enter on the throne hall. In the throne hall the see a girl in shining armor, wielding an halberd, with orange hair arranged in two braids, her name is Miriam. In the same room there is a locked chest, with a golden lock. It will be very difficult to break it open or open it by sheer force, a little easier to use a spell to open it and not too difficult to pick the lock, but this action would be easier to do with the right key. If opened, the chest reveals to contain the Sword of Ruin and a Spell Scroll. If the protagonist proceeds deeper inside the dungeon, they will find themselves in a great crumbled hall. In this Hall there is a big knight in a black armor, wielding a big heavy shield and a greatsword, named Alken. He will attack the protagonist relentlessly, without spelling a single word. At first he can be talked to, or some tricks can be used, but in the end he must be defeated either by fighting him or using a spell on him. He can be defeated, and in this case his Black Iron Shield and a golden Magical Key that he was carrying can be taken. This key can open the chest seen before. Behind Alken there is a gigantic door. If the protagonist open it and go inside, they will find themselves in deeper part of the castle. Here they will face an obstacle which depends on their goal. \n\n1. If they were searching for the Mystical Crown, they will encounter the Fallen King, an ancient immortal King who has now fallen into sorrow and despair. He is found in a collapsed room which overlooks a ravine. At the center of the room there is a grave, surrounded by flowers. He is sitting on the verge of a ravine, in a collapsed room, staring at the void. He as the crown, and can be convinced to give it up by talking, fighting or spellcasting. He will be unbothered by the attacks or the spells of the protagonist, but he will admire their determination. After giving up the crown, he will sit again at the verge of the ravine, and will be unresponsive.\n\n2. If the protagonist is looking for the Treasure of the Fallen King, they will face the fearsome Dragon of Ruin, which guard the treasure. The treasure is inside a Ravine which is full of riches. When the protagonist enters the ravine, the mighty Dragon will land in front of him. Here the dragon can be faced with magic or fighting skills, but also with some clever tricks, elaborated traps or some talking. After the first interaction, the dragon will throw flame at the protagonist, which can be resisted, dodged or defended against with magic. Finally, the dragon bust be defeated either physically or with magic. If defeated the dragon will retreat, leaving the treasure to be taken. \n\n3. If the protagonist wants to defeat the Shadowmancer, they will face the powerful wizard, which will summon shadow monsters to fight them. After defeating the army, the protagonist faces the Shadowmancer himself. It can be defeated using magic or by fighting him, but also clever tricks or elaborated traps.\n\n At the end the protagonist achieve their goal.";
    public static string storySoFar = "";
}

public struct NoArchitectureRequest
{
    [JsonInclude]
    [JsonPropertyName("content")]
    public string content;
    [JsonInclude]
    [JsonPropertyName("maxScenes")]
    public int maxScenes;
    [JsonInclude]
    [JsonPropertyName("currentScene")]
    public int currentScene;
}