// Opening Dialog
"I thought... maybe I could fix this."
"They said it was impossible, but what if I could gather everything<br>that made you... you?"
"Fourteen pieces. That’s all it would take."
"Then maybe... maybe I could see you again." 
"I have to try." 
-> exploration_start

// Exploration Phase
=== exploration_start ===
You feel the weight of what you're about to do, but there's no<br>turning back now. (Use arrow/wasd to move and collect objects)
-> object_collection

// Object Collection
=== object_collection ===
+ [You find a Pressed Flower.]
    "Forget-me-nots... Your favorite. You always told me memories <br>fade, but I never thought I’d forget your voice." 
-> object_collection

+ [You find a Map.]
    "All the places you wanted to go. Paris, Cairo, Rio..." <br>"We never made it past the front porch, did we?" 
-> object_collection

+ [You find a Wedding Photo.]
    "The happiest day of our lives… Was it really that long ago?" <br>"It feels like yesterday." 
-> object_collection

+ [You find a Worn Notebook.]
    "Your handwriting… so messy, so alive." <br>"Every page filled with your thoughts, your plans. Why didn’t I listen more?" 
-> object_collection

+ [You find a Broken Pocket Watch.]
    "You always said you didn’t have enough time." <br>"I never realized how true that was until now." 
-> object_collection

+ [You find a Music Box.]
    "That melody… It always made you smile." <br>"I can almost hear you humming along." 
-> object_collection

+ [You find a Phone.]
    "I used to call you just to hear your voice." <br>"If I called now, would you answer?" 
-> object_collection

+ [You find a Ring.]
    "You promised we’d grow old together..."<br>"This wasn’t old enough!" 
-> object_collection

+ [You find a Broken Mirror.]
    "I remember when you smashed this." <br>"You were so angry, but it wasn’t at me. It was never at me." 
-> object_collection

+ [You find a Torn Letter.]
    "What did you want to say?" <br>"I thought you would tell me everything..." 
-> object_collection

+ [You find an Old Briefcase.]
    "You carried this everywhere." <br>"You said it was for us, for our future, but I wonder...<br>was it worth it?" 
-> object_collection

+ [You find Art Supplies.]
    "The brushes are dry, the paints cracked." <br>"You stopped creating... and I never asked why." 
-> object_collection

+ [You find a Picture of Yourself.]
    "You kept this? Even after all the fights, all the silence... <br>you still held onto me." 
-> object_collection

+ [You find a Doll.]
    "It’s just a shell. A hollow reminder that no matter what I do... <br>you’re not here." 
-> object_collection

+ [All Items Collected]
-> attempt_revival

// Attempting the Revival
=== attempt_revival ===
You’ve gathered everything. Every piece... <br>every memory, every dream, every regret."<br>"You brought them all back. 
"Please... please come back." 
...
......
"Why isn’t it working? I did everything right! I just want you back!" 
"...It’s over. You’re really gone." 
"You were never just pieces." <br>"You were whole, and I can’t bring that back." 
-> closing_dialog

// Closing Dialog
=== closing_dialog ===
The space around you feels lighter, brighter somehow. <br>The weight on your shoulders begins to lift.
"I’ll carry you with me, though. In every memory, every dream." <br>"I won’t forget you." 
"Goodbye." 
-> END