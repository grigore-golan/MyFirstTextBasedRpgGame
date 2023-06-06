namespace MyFirstTextBasedRpgGame.Dialogues.Interactive
{
    public class InitialDialogue
    {
        public Dialogue Dialogue { get; private set; }

        public InitialDialogue()
        {
            DialogueBuilder builder = new();

            Dialogue = builder
                .AddLine(new DialogueLine("Welcome, fellow adventurer.", "..."))
                .AddLine(new DialogueLine("I believe that you have the bravery required for the starting adventure.", "..."))
                .AddLine(new DialogueLine("It is sad to acknowledge you, but you are not from this world.", "..."))
                .AddLine(new DialogueLine("But there, you have a purpose.", "..."))
                .AddLine(new DialogueLine("As you are an alien, the one entity that brought you here gave you something.", "..."))
                .AddLine(new DialogueLine("But now you are not able to maintain and control that.", "..."))
                .AddLine(new DialogueLine("And I am not the one who is allowed to tell you.", "..."))
                .AddLine(new DialogueLine("But you will find it out soon.", "..."))
                //
                .AddLine(new DialogueLine("Can I go home?", Player.Pronoun))
                .AddLine(new DialogueLine("I'm afraid that you can not.", "..."))
                .AddLine(new DialogueLine("At least I do not know if that is possible.", "..."))
                .AddLine(new DialogueLine("Then tell me about this world. At least, I need to know what to do here", Player.Pronoun))
                //
                .AddLine(new DialogueLine("It will be my pleasure.", "..."))
                .AddLine(new DialogueLine("As you see, now, this wasteland does not look very friendly.", "..."))
                .AddLine(new DialogueLine("There is almost no life.", "..."))
                .AddLine(new DialogueLine("Not very often you can encounter an alive creature.", "..."))
                .AddLine(new DialogueLine("All that is left is a couple of towns, where live good folks.", "..."))
                .AddLine(new DialogueLine("And all around is gray. And as far as you go from these towns - the darker are souls of creatures wandering from place to place.", "..."))
                .AddLine(new DialogueLine("People call them \"The Dark ones\".", "..."))
                .AddLine(new DialogueLine("But I would say they are \"The Doomed ones\".", "..."))
                .AddLine(new DialogueLine("The Fortune did them dirty. Actually, they were people... normal people back then.", "..."))
                //
                .AddLine(new DialogueLine("What happened to them?", Player.Pronoun))
                .AddLine(new DialogueLine("They have fallen.", "..."))
                .AddLine(new DialogueLine("Fallen like angels who become demons?", Player.Pronoun))
                .AddLine(new DialogueLine("No, my friend. In this realm there are no demons or angels.", "..."))
                .AddLine(new DialogueLine("They've fallen to Plague.", "..."))
                //
                .AddLine(new DialogueLine("Some kind of a virus?", Player.Pronoun))
                .AddLine(new DialogueLine("Yes...", "..."))
                .AddLine(new DialogueLine("Is there a cure for that?", Player.Pronoun))
                .AddLine(new DialogueLine("As you can see... no. Or maybe not yet.", "..."))
                .AddLine(new DialogueLine("Let me guess, I am here to find that cure?", Player.Pronoun))
                .AddLine(new DialogueLine("It may be so, little one.", "..."))
                //
                .AddLine(new DialogueLine("But why they wander like wild animals. Don't they have a family, a home?", Player.Pronoun))
                .AddLine(new DialogueLine("No one knows. Many believe that the Doomed lost their minds.", "..."))
                .AddLine(new DialogueLine("But I think they are still alive. Not capable of controling their bodies...", "..."))
                .AddLine(new DialogueLine("But they see, feel and sadly understand their actions... and their condition.", "..."))
                //
                .AddLine(new DialogueLine("They kill, right?", Player.Pronoun))
                .AddLine(new DialogueLine("Unfortunately...", "..."))
                .AddLine(new DialogueLine("But they are not willing to.", "..."))
                .AddLine(new DialogueLine("That is sad. Can I help?", Player.Pronoun))
                .AddLine(new DialogueLine("Yes, but you have to find out how on your own.", "..."))
                //Poate asta sa fie punctul pentru continue, da restu segmentelor sa fie cu interogare (Continui? sau Dai skip?)
                .AddLine(new DialogueLine("It is first, but I hope not last time we've met, my friend.", "..."))
                .AddLine(new DialogueLine("Before I go, I need to tell you something.", "..."))
                .AddLine(new DialogueLine("Remember that. Bravery is not being able to take a life.", "..."))
                .AddLine(new DialogueLine("It is to save one.", "..."))
                .AddLine(new DialogueLine("Now head to the nearest town, there is someone who is waiting for you.", "..."))
                .AddLine(new DialogueLine("Farewell, little one. I hope to see you soon and in a good state.", "..."))
                .AddLine(new DialogueLine("So do I...", Player.Pronoun))
                .AddLine(new DialogueLine("*walks away*", "..."))
                .AddLine(new DialogueLine("I think I should have asked his name...", Player.Pronoun))
                .AddLine(new DialogueLine("Anyway, I think I need to go, before it goes dark outside.", Player.Pronoun))
                .Build();
        }
    }
}
