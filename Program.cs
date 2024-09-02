using WebChat.DataService;
using WebChat.Hubs;

var builder = WebApplication.CreateBuilder(args);

//problema de CORS
builder.Services.AddCors(opt =>{
    opt.AddPolicy("reactApp",builder =>{
        builder.WithOrigins("http://localhost:3000")
        .AllowAnyHeader()
        .AllowAnyMethod()
        .AllowCredentials();
    
    });
});


builder.Services.AddSingleton<InMemoryDb>();

//SignalR suporte
builder.Services.AddSignalR();


var app = builder.Build();


app.UseHttpsRedirection();

app.MapHub<ChatHub>("/Chat");

app.UseCors("reactApp");

app.Run();

