using System;
using System.Threading.Tasks;

using Microsoft.Bot.Builder.Azure;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;

// For more information about this template visit http://aka.ms/azurebots-csharp-luis
[Serializable]
public class BasicLuisDialog : LuisDialog<object>
{
    public BasicLuisDialog() : base(new LuisService(new LuisModelAttribute(Utils.GetAppSetting("LuisAppId"), Utils.GetAppSetting("LuisAPIKey"))))
    {
    }

    [LuisIntent("None")]
    public async Task NoneIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"You have reached the none intent. You said: {result.Query}"); //
        context.Wait(MessageReceived);
    }

    // Go to https://luis.ai and create a new intent, then train/publish your luis app.
    // Finally replace "MyIntent" with the name of your newly created intent in the following handler
    [LuisIntent("询问人物")]
    public async Task PeopleIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"You have reached the 询问人物 intent. You said: {result.Query}"); //
        context.Wait(MessageReceived);
    }
        
    [LuisIntent("询问地点")]
    public async Task LocationIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"You have reached the 询问地点 intent. You said: {result.Query}"); //
        context.Wait(MessageReceived);
    }
    
    [LuisIntent("询问定义")]
    public async Task DefinationIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"You have reached the 询问定义 intent. You said: {result.Query}"); //
        context.Wait(MessageReceived);
    }
    
    [LuisIntent("询问数量")]
    public async Task NumberIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"You have reached the 询问数量 intent. You said: {result.Query}"); //
        context.Wait(MessageReceived);
    }
}